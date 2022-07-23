using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thembelihle
{
   public class Card
    {
        int id;
        private string holderName;
        private string number;
        private string expireyDate;
        private int cvv;
        public Card(int id, string holderName, string number, string expireyDate,int cvv)
        {
            this.number = number;
            this.id = id;
            this.holderName = holderName;
            this.expireyDate = expireyDate;
            this.cvv = cvv;
        }
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int CVV
        {
            get { return this.cvv; }
            set { this.cvv = value; }
        }
        public string HolderName
        {
            get { return this.holderName;}
            set { this.holderName = value; }
        }
        public string Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
        public string ExpireyDate
        {
            get { return this.expireyDate; }
            set { this.expireyDate = value; }
        }

    }
}
