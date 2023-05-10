using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    internal class Debit_Card : Cards
    {
        public string? NAME
        {
            get { return Name; }
            set { Name = value; }
        }

        public string? CARDNUMBER
        {
            get { return CardNumber; }
            set { CardNumber = value; }
        }

        public string? ACOUNTNUMBER
        {
            get { return AcountNumber; }
            set { AcountNumber = value; }
        }

        public int AGE
        {
            get { return Age; }
            set { Age = value; }
        }

        public Debit_Card(string Name, string CardNumber, string AcountNumber, int Age)
        {
            NAME = Name;
            CARDNUMBER = CardNumber;
            ACOUNTNUMBER = AcountNumber;
            AGE = Age;
        }

        internal override string GenerateCardNumber()
        {
            string Prefix = "2400";

            for (int i = 0; i < 14; i++)
            {
                Random rnd = new Random();
                int number = rnd.Next(1, 10);
                number.ToString();
                Prefix = Prefix + number;
            }

            return Prefix;
        }

        internal override string GenerateAcountNumber()
        {
            string Prefix = "3520";

            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                int number = rnd.Next(1, 10);
                number.ToString();
                Prefix = Prefix + number;
            }
            return Prefix;
        }

        internal override string Generatecard()
        {
            string CardInfo;

            if (Age < 18)
            {
                AcountNumber = GenerateAcountNumber();
                CardNumber = GenerateCardNumber();

                // placing a * where i want the return string to be split to a new write line so i looks nice.
                CardInfo = string.Concat("Debit card *Name : ", Name, "*Card number : ", CardNumber, "*Acount number : ", AcountNumber, "*This car has no credit all money spend i withdraw right away.");
            }
            else { CardInfo = "You are to old you should be under 18."; }
            return CardInfo;
        }
    }
}
