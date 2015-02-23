using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Dominion
{
    public class Card
    {
        string name;        // Each card has a name
        int cost;           // Each card costs money in order to purchase (even if it is free)
        string type;        // Each card has a different type (e.g. Copper and Silver are 'Treasure' cards. Cellar, however, is an action card.)
        string description;
        //bool additional;  // Some cards require additional cards to work properly. (e.g. 'The Witch' states: "each other player gains a Curse card.")
        string set;         // Cards belong to different sets

        public Card(string name, int cost, string type, string description, string set)
        {
            this.name = name;
            this.cost = cost;
            this.type = type;
            this.description = description;
            this.set = set;
        }

        public Card(Card newCard)
        {
            this.name = newCard.name;
            this.cost = newCard.cost;
            this.type = newCard.type;
            this.description = newCard.description;
            this.set = newCard.set;
        }

        public Card()
        {
            this.name = "N/A";
            this.cost = -1;
            this.set = "Base";
            this.type = "N/A";
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Set
        {
            get { return set; }
            set { set = value; }
        }


    }
}