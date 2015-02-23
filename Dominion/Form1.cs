/* Header
 * Program name:
 *      Dominion Card Generator
 * Description:
 *      DCG randomly chooses cards for Dominion players to play with.
 *      The users can stay with the default of 10 cards, or choose to generate a larger amount and then 'ban' cards.
 *      If the user wishes to view all cards, that is an option as well.
 *      When a card is selected, the card's information (Name, Cost, Type, Set, and Description) are displayed.)
 *      When cards are generated, whatever cards are to also be played with are shown as well. (e.g. When a Witch is in play, a curse should also be played with as well (Witch description: (Each other player gains a Curse card.)))
 *      Not all users own all Promotional cards. Because of this, users can select which promotional cards they do own.
 *      
 * Author: Justin "The" Fern
 * 
 * ===============================================================================================================
 *  Very special thanks to: Brandon Olson for help with maintaining the code and making the code dynamic.
 *  Very special thanks to: Philip Wolfe for help with finding bugs and coming up with ideas for future features.
 * ===============================================================================================================
 * 
 * Card Information retrieved from http://dominionstrategy.com/
 * 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Dominion
{
    public partial class DominionGenerator : Form
    {
        public List<Card> allCards = new List<Card>();              //All cards that exist in the game
        public List<Card> potentialCards = new List<Card>();        //Cards that, based on the users' checkboxes, have the potential to be displayed in the listbox
        public List<Card> listOfCardsOnField = new List<Card>();    //Cards that are going to be displayed in the listbox
        public List<Card> promoCards = new List<Card>();            //The list of promo cards that the user owns and can play with.
        public Dictionary<CheckBox, List<Card>> setDictionary = new Dictionary<CheckBox, List<Card>>();
        public Dictionary<Card, List<Card>> additionalCardsDict = new Dictionary<Card, List<Card>>();
        public List<Card> additionalCardsList = new List<Card>();

        #region Utilities

        public DominionGenerator()
        {InitializeComponent();}
        
        private void Form1_Load(object sender, EventArgs e)         // Everthing that happens when the Program begins
        {
            loadAllCardsXML();          // Add all of the cards from the XML file to a list of cards
            loadAdditionalCardsXML();   // Add all of the cards information about the additional cards information

            setDictionary.Add(BaseCheck, allCards.FindAll(delegate (Card card) {return card.Set == "Base";}));                  //Adding cards to the list of all cards based on their set
            setDictionary.Add(IntrigueCheck, allCards.FindAll(delegate(Card card) { return card.Set == "Intrigue"; }));
            setDictionary.Add(SeasideCheck, allCards.FindAll(delegate(Card card) { return card.Set == "Seaside"; }));
            setDictionary.Add(ProsperityCheck, allCards.FindAll(delegate(Card card) { return card.Set == "Prosperity"; }));
            setDictionary.Add(HinterlandsCheck, allCards.FindAll(delegate(Card card) { return card.Set == "Hinterlands"; }));
            setDictionary.Add(DarkAgesCheck, allCards.FindAll(delegate(Card card) { return card.Set == "Dark Ages"; }));
            setDictionary.Add(AlchemyCheck, allCards.FindAll(delegate(Card card) { return card.Set == "Alchemy"; }));
            setDictionary.Add(CornucopiaCheck, allCards.FindAll(delegate(Card card) { return card.Set == "Cornucopia"; }));
            setDictionary.Add(GuildsCheck, allCards.FindAll(delegate(Card card) { return card.Set == "Guilds"; }));
            AddListings.Select();
        }

        private void loadAllCardsXML()                              // Reading from the XML file and placing them in the list of allCards
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(Dominion.Properties.Resources.Cards);
            XmlElement xelRoot = xmlDoc.DocumentElement;
            XmlNodeList xnlNodes = xelRoot.SelectNodes("/Cards/Card");

            foreach (XmlNode xndNode in xnlNodes)
            {
                string name = xndNode["Name"].InnerText;                        // Setting the Name of each card
                int cost = Convert.ToInt32(xndNode["Cost"].InnerText);          // Setting the Cost of each card
                string type = xndNode["Type"].InnerText;                        // Setting the Type of each card
                string description = xndNode["Description"].InnerText;          // Setting the Description of each card
                string set = xndNode["Set"].InnerText;                          // Setting the Set of each card
                Card newCard = new Card(name, cost, type, description, set);    // Creating a new card object based on the information gathered above
                allCards.Add(newCard);                                          // Add it to the list of allCards
            }
        }

        private void loadAdditionalCardsXML()                       // Reading from the XML file and placing them into the list of additionalCards
        {
            XmlDocument xmlDox = new XmlDocument();
            xmlDox.LoadXml(Dominion.Properties.Resources.additionalCards);
            XmlElement additionalRoot = xmlDox.DocumentElement;
            XmlNodeList additionalNodes = additionalRoot.SelectNodes("/Cards/Card");

            foreach (XmlNode additionalNode in additionalNodes)
            {
                string name = additionalNode["Name"].InnerText;         // Setting the Name value of each card
                string gained = additionalNode["Gained"].InnerText;     // Setting the Gained value of each card

                string[] gainedCardList = gained.Split(',');            // Since the gained value occasionally has two card names, we must split the gained value and throw those values into a list to be sifted through later

                Card card = getCardOfName(name, allCards);              // Make a card object based off of the name of the node
                List<Card> valueCards = new List<Card>();               // Making a new list of Cards. This list will hold all of the 'additional cards' that are paired with the first card.
                foreach (string gainedCard in gainedCardList)           // For every card.name in gainedCardList. . .
                    valueCards.Add(getCardOfName(gainedCard, allCards));// Add that card associated with the name to the other list.

                additionalCardsDict.Add(card, valueCards);              // Add the card and its additional cards to the additionalCardsDict dictionary
            }
        }

        private Card getCardOfName(string name, List<Card> cardList)// Accessing the card of a specified name
        {
            foreach (Card card in cardList)
                if (card.Name == name)
                    return card;

            return null;
        }

        private int GetRandom(int range)                            // Creates a random number between a range of numbers passed in
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());
            return r.Next(0, range);
        }

        private void AddCard()                                      // Adding cards from the list of potential cards to the listOfCardsOnField
        {
            if (listOfCardsOnField.Count() == potentialCards.Count())   // if the amount of displayed is equal to the amount of cards that can be displayed. . 
            { MessageBox.Show("No more cards!"); return; }              // There are no more cards to be shown. Return, dawg

            int random = GetRandom(potentialCards.Count());             // Running our GetRandom function to recieve a random int

            if (listOfCardsOnField.Contains(potentialCards[random]))    // if the list of displayed cards already has this card. . .
                AddCard();                                              // recursiveness

            if (!listOfCardsOnField.Contains(potentialCards[random]))   // if the list of displayed cards does not already have this card. . .
                listOfCardsOnField.Add(potentialCards[random]);         // throw it in
        }

        private void Sort()                                         // Sort through the listOfCardsOnField
        {
            List<Card> SortedList = listOfCardsOnField.OrderBy(o => o.Set).ToList();    // Sorting the list by property 'set'
            listOfCardsOnField = SortedList;                                            // setting listOfCardsOnField equal to the new sorted list
        }

        #endregion

        #region listeners
        //regions are great

        private void AddListings_Click(object sender, EventArgs e)                      // Clicking the 'Do the Thing' button. Adds n random cards to the list box. n = number in Integer Incrementer (by default: 10, user can change it to a max of 100)
        {
            listOfCardsOnField.Clear(); // Empty logical list
            cardsOnField.Items.Clear(); // Empty list box
            UpdatePotentialCards();     // Add all possible cards to the potentials cards list
            GetListOfCardsOnField();    // Add given number of random cards to the logical list 
            UpdateCardsOnFieldBox();    // Update the list box
            GetAdditionalCards();       // Add all additional cards to the additional cards list
            UpdateAdditionalCardsBox(); // Update the additionalCards list box
        }

        private void RemoveItem_Click(object sender, EventArgs e)                       // For removing the selected item in the listbox
        {
            if (cardsOnField.SelectedIndex != -1)
            {
                listOfCardsOnField.RemoveAt(cardsOnField.SelectedIndex);    // Remove the item from our logical list
                cardsOnField.Items.Clear();                                 // Clear the list box
                UpdateCardsOnFieldBox();                                    // Add all of the items from the logical list to list box
                GetAdditionalCards();                                       // Make changes to the Additional Cards list if necessary
                UpdateAdditionalCardsBox();                                 // Show the changes
            }
        }

        private void Replace_Click(object sender, EventArgs e)                          // Removes selected cards and adds a new card
        {
            if (cardsOnField.SelectedIndex != -1)   // As long as the selected index isn't -1
            {
                RemoveItem_Click(sender, e);        // Removes selected card
                AddCardButton_Click(sender, e);     // Adds a new card
            }
        }

        private void AddCardButton_Click(object sender, EventArgs e)                    // Based on which checkboxes are selected, cards are added to appropriate lists and then, in turn, to the proper listboxes
        {
            AddCard();                  // Adding cards from the list of potential cards to the listOfCardsOnField
            cardsOnField.Items.Clear(); // Clear all items from the listbox
            UpdateCardsOnFieldBox();    // Display this change
            Sort();                     // Sort through the listOfCardsOnField
            GetAdditionalCards();       // If any of the cards in play require other cards to be played with (e.g. Witch requires Curses to be in the supply as well)
            UpdateAdditionalCardsBox(); // Display the cards in the AdditionalCards list in the AdditionalCards listbox
        }

        private void AddPromoCardButton_Click(object sender, EventArgs e)               // Opens promoCard dialog box
        { addPromoCardsToolStripMenuItem_Click(sender, e); }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)            // File --> Exit
        { Application.Exit(); } // Close the program

        private void addPromoCardsToolStripMenuItem_Click(object sender, EventArgs e)   // File --> Add Promo Cards. Used to specify which Promotional Cards the user has
        {
            AddPromoCards AddPromoCards = new AddPromoCards(allCards, promoCards);
            AddPromoCards.ShowDialog();
        }

        private void viewAllCardsToolStripMenuItem_Click(object sender, EventArgs e)    // User can see every card in existence
        {
            listOfCardsOnField.Clear();         // Remove all cards from the listOfCardsOnField
            cardsOnField.Items.Clear();         // Clear everything from the listbox, too
            additionalCards.Items.Clear();      // Remove everything from the additional cards listbox
            foreach (Card card in allCards)     // for every single existing card (whether it belongs in a set or not). . .
                listOfCardsOnField.Add(card);   // Put it in the listOfCardsOnField
            UpdateCardsOnFieldBox();            // For every card in listOfCardsOnField, put that card in the listbox
            cardsOnField.Update();              // Display these changes (WindowsForms are dumb)
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)         // Show the credits dialog box
        {
            Credits credits = new Credits();
            credits.ShowDialog();
        }

        private void cardsOnField_SelectedIndexChanged(object sender, EventArgs e)      // When the slected item in the listbox changes
        {
            int index = cardsOnField.SelectedIndex;                         // Only one listbox should be selected at a time. . .
            additionalCards.SelectedIndex = -1;                             // This is to ensure confusion (about which card's information being displayed) is nonexistent
            cardsOnField.SelectedIndex = index;

            if (cardsOnField.SelectedIndex != -1)                           // As long as the new index isn't -1. . 
                UpdateSelectedCardInfo(cardsOnField, listOfCardsOnField);   // Display the selected card's information
        }

        private void additionalCards_SelectedIndexChanged(object sender, EventArgs e)   // Displays card information, based on what card is selected
        {
            int index = additionalCards.SelectedIndex;                          // Only one listbox should be selected at a time. . .
            cardsOnField.SelectedIndex = -1;                                    // This is to ensure confusion (about which card's information being displayed) is nonexistent
            additionalCards.SelectedIndex = index;

            if (additionalCards.SelectedIndex != -1)                            // As long as the new index isn't -1. . .
                UpdateSelectedCardInfo(additionalCards, additionalCardsList);   // Display the selected card's information
        }

        private void PromoCheck_CheckedChanged(object sender, EventArgs e)              // Checkbox for PromoCards checkbox changes
        {
            if (PromoCheck.Checked)                                     // If the box is now checked. . 
                if (!promoCards.Any())                                  // If the list of cards, promoCards doesn't contain any cards. . .
                    addPromoCardsToolStripMenuItem_Click(sender, e);    // open the promoCards dialog box
                                                                        // There's no sense in checking the box if nothin is to be added
        }

        private void CheckChange_CheckedChanged(object sender, EventArgs e)             // Change the state of all other checkboxes
        {
            if (CheckChange.Checked)                        // If the checkbox is checked. . .
            {
                IntrigueCheck.Checked = SeasideCheck.Checked = ProsperityCheck.Checked = HinterlandsCheck.Checked = DarkAgesCheck.Checked = AlchemyCheck.Checked = CornucopiaCheck.Checked = GuildsCheck.Checked = PromoCheck.Checked = BaseCheck.Checked = false;
                CheckChange.Text = "Check All";             // ^^each other checkbox should be unchecked^^     Change the text appropriately
                CheckChange.Location = new Point(194, 370); // Move the checkbox (since the text makes the checkbox smaller), to make it seem like it never moved :P
            }
            else                                            // If the checkbox is unchecked
            {
                IntrigueCheck.Checked = SeasideCheck.Checked = ProsperityCheck.Checked = HinterlandsCheck.Checked = DarkAgesCheck.Checked = AlchemyCheck.Checked = CornucopiaCheck.Checked = GuildsCheck.Checked = PromoCheck.Checked = BaseCheck.Checked = true;
                CheckChange.Text = "UnCheck All";           // ^^each other checkbox should be checked^^        Change the text appropriately
                CheckChange.Location = new Point(180, 370); // Move the checkbox (since the text makes the checkbox bigger), to make it seem like it never moved :P
            }
        }

        private void numOfCardsInc_ValueChanged(object sender, EventArgs e)             // When the user changes how many cards he wants displayed
        {
            AddListings.Text = "Generate " + numOfCardsInc.Value + " Cards";            // Change the text in the 'Do The Thing' button
        }

        #endregion

        #region logicUpdates
        private void UpdateSelectedCardInfo(ListBox listbox, List<Card> cardList)   // When the selected index in the list box changes, the Card's information needs to update on the right-hand side of the GUI
        {
            if (cardList.Any())                                                     // As long as there are cards in the list of cards in the field
            {
                Card currentlySelectedCard = cardList[listbox.SelectedIndex];       // Making a new card identical to the Card Name displayed in the listbox
                CardNameBox.Text = currentlySelectedCard.Name;                      // Updating the Textbox with the Card's name
                CardCostBox.Text = Convert.ToString(currentlySelectedCard.Cost);    // Updating the Textbox with the Card's cost
                CardTypeBox.Text = currentlySelectedCard.Type;                      // Updating the Textbox with the Card's type
                CardSetBox.Text = currentlySelectedCard.Set;                        // Updating the Textbox with the Card's Set
                CardDescriptionBox.Text = currentlySelectedCard.Description;        // Updating the Textbox with the Card's Description
            }
        }

        //Good
        private void UpdatePotentialCards()                                         // When a new checkbox has been either selected or deselected, the Cards that will be displayed need to be changed
        {
            potentialCards.Clear();                                     // Remove all cards in the cards that 'can' be displayed
            foreach (CheckBox checkbox in setDictionary.Keys)           // Looking at all of the checkboxes on the GUI
                if (checkbox.Checked)                                   // If the checkbox is not checked, it has not been filtered out
                    potentialCards.AddRange(setDictionary[checkbox]);   // Add everything in correlation with the checkbox (e.g. if Base is not checked, all cards with set "Base" get added to potentialCards)

            if (PromoCheck.Checked)                                     // Promotional Cards is a special set. It must be dealt with specially
                potentialCards.AddRange(promoCards);
        }

        private void GetListOfCardsOnField()                                        // Determining which cards are going to be played with
        {
            List<int> sorted = new List<int>();                         //Creating a list to ensure when cards are displayed, they are sorted by their set
            int i = 0;
            if (numOfCardsInc.Value > potentialCards.Count)             //if Integer Incrementer has a greater value than the amount of cards in the list
                MessageBox.Show("You don't have enough cards!");        //yell at the user
            if (numOfCardsInc.Value <= potentialCards.Count())          //if Integer Incrementer has an equal or lesser value than the amount in the list
            {
                while (i < numOfCardsInc.Value)                         //While i is less than the value of the Integer Incrementer
                {
                    int j = GetRandom(potentialCards.Count());          //j is going to be our random index number to determine which card should be displayed on the field
                    if (!sorted.Contains(j))                            //as long as the index isn't already in sorted
                    {
                        sorted.Add(j);
                        i++;                                            //Increment that nonsense
                    }
                }
            }
            sorted.Sort();
            foreach (int num in sorted)                                 //incrementing through sorted
                listOfCardsOnField.Add(potentialCards[num]);            //add the random card
        }

        private void UpdateCardsOnFieldBox()                                        // When changes are made in the cardsOnField list, the listbox needs to reflect that change
        {
            foreach (Card card in listOfCardsOnField)   // Look at each card in the list of cards on the field
            { cardsOnField.Items.Add(card.Name); }      // Display what that card is
            cardsOnField.Update();                      // Update the listbox to display the correct information
        }

        private void GetAdditionalCards()                                           // Based on the cards in listOfCardsOnField, put the other cards that should also be in play into the additionalCards list
        {
            additionalCardsList.Clear();                                            // Clear the additionalCardsList

            if (cardsOnField.Items.Count > 0)                                       // As long as the amount of cards in cardsOnField listbox
            {
                foreach (Card card in listOfCardsOnField)                           // For every card in the list listOfCardsOnField. . .
                    if (additionalCardsDict.ContainsKey(card))                      // If the dicitionary additionalCardsDict contains the card as a key
                        foreach (Card additionalCard in additionalCardsDict[card])  // For every card in the dictionary additionalCardsDict. . .
                            if (!additionalCardsList.Contains(additionalCard) && !listOfCardsOnField.Contains(additionalCard))  // If additionalCardsList does not already contain the card and if the listOfCardsOnField does not contain the card. . .
                                additionalCardsList.Add(additionalCard);            // Add the card to additionalCardsList
                if (DetermineToPlayWith("Prosperity"))                              // If the function DetermineToPlayWith returns true when "Prosperity" is passed. . .
                {
                    additionalCardsList.Add(getCardOfName("Colony", allCards));     // Add the card (that has the name "Colony") from the list allCards to the additionalCardsList
                    additionalCardsList.Add(getCardOfName("Platinum", allCards));   // Do the same but with the card named "Platinum"
                }
                if (DetermineToPlayWith("Dark Ages"))                               // If the function DetermineToPlayWith returns true when "Dark Ages" is passed. . .
                    additionalCardsList.Add(getCardOfName("Shelter", allCards));    // Add the card (that has the name "Shelter") from the list allCards to the additionalCardsList
            }
        }

        private void UpdateAdditionalCardsBox()                                     // Make changes in the listbox according to what is in the list additionalCardsList
        {
            additionalCards.Items.Clear();                      // Clear all items in the additionalCards listbox

            if (additionalCardsList.Any())                      // If additionalCardsList contains any cards. . .
                foreach (Card card in additionalCardsList)      // For every card in additionalCardsList. . .
                    if (card != null)                           // As long as the card is not null. . .
                        additionalCards.Items.Add(card.Name);   // Add the card name to the additionalCards listbox

            additionalCards.Update();                           // Display the changes in the list additionalCardsList
        }

        private bool DetermineToPlayWith(string set)                                // If a certain card is in the listOfCardsOnField, display the cards associated with the former card
        {
            int num = -1;                                   // Set the num to -1 for the if check later
            int random;                                     // Declaring an integer variable
            foreach (Card card in listOfCardsOnField)       // For every card in listOfCardsOnField. . .
                if (card.Set == set)                        // If the card's set name is equal to the set name that was passed in. . 
                    num++;                                  // plus plus num

            random = GetRandom(listOfCardsOnField.Count);   // Get a new random value
            if (random <= num)                              // If random is less than or equal to num. . . 
                return true;                                // return true
            else                                            // If random is greater than num. . .
                return false;                               // return false
        }
        #endregion
    }
}