using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominion
{
    public partial class AddPromoCards : Form
    {
        List<Card> allCards = new List<Card>();
        List<Card> PromoCards = new List<Card>();

        public AddPromoCards(List<Card>aCards, List<Card>pCards)            //Runs when the dialog box is created
        {
            InitializeComponent();
            allCards = aCards;      //Set the new allCards equal to the passed-in allCards, so that referencing it will be appropriate
            PromoCards = pCards;    //set the new PromoCards equal to the passed-in PromoCards, so that referencing it will be approptiate

            int index = allCards.FindIndex(f => f.Name == "Black Market");  //Sets 'index' to the index of where the card is located in allCards
            if (PromoCards.Contains(allCards[index]))                       //if PromoCards contains the card
                BlackMarketPromoCheck.Checked = true;                       //Check the associated checkbox

            index = allCards.FindIndex(f => f.Name == "Envoy");
            if (PromoCards.Contains(allCards[index]))
                EnvoyPromoCheck.Checked = true;

            index = allCards.FindIndex(f => f.Name == "Walled Village");
            if (PromoCards.Contains(allCards[index]))
                WalledVillagePromoCheck.Checked = true;

            index = allCards.FindIndex(f => f.Name == "Governor");
            if (PromoCards.Contains(allCards[index]))
                GovernorPromoCheck.Checked = true;

            index = allCards.FindIndex(f => f.Name == "Stash");
            if (PromoCards.Contains(allCards[index]))
                StashPromoCheck.Checked = true;

            index = allCards.FindIndex(f => f.Name == "Prince");
            if (PromoCards.Contains(allCards[index]))
                PrincePromoCheck.Checked = true;

            if (BlackMarketPromoCheck.Checked && EnvoyPromoCheck.Checked && WalledVillagePromoCheck.Checked && GovernorPromoCheck.Checked && StashPromoCheck.Checked && PrincePromoCheck.Checked)
            {
                CheckChange.Checked = true;
                CheckChange.Text = "UnCheck All";
            }
        }

        private void PromoCardDialogClose_Click(object sender, EventArgs e) //Runs when the dialog box is to be closed
        {
            if (BlackMarketPromoCheck.Checked)                                  //If the checkbox is checked
            {
                int index = allCards.FindIndex(f => f.Name == "Black Market");  //Set the index to where this card exists
                if (!PromoCards.Contains(allCards[index]))                      //If PromoCards does not contain the card
                    PromoCards.Add(allCards[index]);                            //Add the card
            }

            if (EnvoyPromoCheck.Checked)
            {
                int index = allCards.FindIndex(f => f.Name == "Envoy");
                if (!PromoCards.Contains(allCards[index]))
                    PromoCards.Add(allCards[index]);
            }

            if (WalledVillagePromoCheck.Checked)
            {
                int index = allCards.FindIndex(f => f.Name == "Walled Village");
                if (!PromoCards.Contains(allCards[index]))
                    PromoCards.Add(allCards[index]);
            }

            if (GovernorPromoCheck.Checked)
            {
                int index = allCards.FindIndex(f => f.Name == "Governor");
                if (!PromoCards.Contains(allCards[index]))
                    PromoCards.Add(allCards[index]);
            }

            if (StashPromoCheck.Checked)
            {
                int index = allCards.FindIndex(f => f.Name == "Stash");
                if (!PromoCards.Contains(allCards[index]))
                    PromoCards.Add(allCards[index]);
            }

            if (PrincePromoCheck.Checked)
            {
                int index = allCards.FindIndex(f => f.Name == "Prince");
                if (!PromoCards.Contains(allCards[index]))
                    PromoCards.Add(allCards[index]);
            }

            this.Close(); 
        }

        private void CheckChange_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckChange.Checked)
            {
                BlackMarketPromoCheck.Checked = EnvoyPromoCheck.Checked = WalledVillagePromoCheck.Checked = GovernorPromoCheck.Checked = StashPromoCheck.Checked = PrincePromoCheck.Checked = true;
                CheckChange.Text = "UnCheck All";
                CheckChange.Location = new Point(66, 220);
            }
            else
            {
                BlackMarketPromoCheck.Checked = EnvoyPromoCheck.Checked = WalledVillagePromoCheck.Checked = GovernorPromoCheck.Checked = StashPromoCheck.Checked = PrincePromoCheck.Checked = false;
                CheckChange.Text = "Check All";
                CheckChange.Location = new Point(80, 220);
            }
        }
    }
}
