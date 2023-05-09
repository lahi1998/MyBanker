using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    internal class Visa_CreditCard : Cards, ICredit, IExpiration_Date
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
        public int Credit_Month { get; set; }
        public string ExpirationDate { get; set; }

        public Visa_CreditCard(string Name, string CardNumber, string AcountNumber, int Age)
        {
            NAME = Name;
            CARDNUMBER = CardNumber;
            ACOUNTNUMBER = AcountNumber;
            AGE = Age;
            ExpirationDate = "";
        }

        internal override string GenerateCardNumber()
        {
            string Prefix = "4";

            for (int i = 0; i < 15; i++)
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

            if (Age >= 18)
            {
                AcountNumber = GenerateAcountNumber();
                CardNumber = GenerateCardNumber();
                Credit_Month = 20000;
                DateTime now = DateTime.Now;
                DateTime ExpirationDate = now.AddYears(5);

                // placing a x where i want the return string to be split to a new write line so i looks nice.
                CardInfo = string.Concat("Visa/dankort *Name : ", Name, "*Card number : ", CardNumber, "*Acount number : ", AcountNumber, "*Expiration Date : ", ExpirationDate, "*Total credit : ", Credit_Month, "*Monthly withdraw limit : 25000 *Going over credit limit is allowed.");
            }
            else { CardInfo = "You are to young come back when your 18."; }
            return CardInfo;
        }

    }
}
