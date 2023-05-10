using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    internal class Visa_Electron : Cards, IExpiration_Date
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
        public string ExpirationDate { get; set; }

        public Visa_Electron(string Name, string CardNumber, string AcountNumber, int Age)
        {
            NAME = Name;
            CARDNUMBER = CardNumber;
            ACOUNTNUMBER = AcountNumber;
            AGE = Age;
            ExpirationDate = "";
        }

        internal override string GenerateCardNumber()
        {
            var list = new List<string> { "4026", "417500", "4508", "4844", "4913", "4917" };
            Random random = new Random();
            int index = random.Next(list.Count);
            string Prefix = list[index];

            int needamount = 16 - Prefix.Length;

            for (int i = 0; i < needamount; i++)
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

            if (Age >= 15)
            {
                AcountNumber = GenerateAcountNumber();
                CardNumber = GenerateCardNumber();
                DateTime now = DateTime.Now;
                DateTime ExpirationDate = now.AddYears(5);

                // placing a * where i want the return string to be split to a new write line so i looks nice.
                CardInfo = string.Concat("Visa Electron *Name : ", Name, "*Card number : ", CardNumber, "*Acount number : ", AcountNumber, "*Expiration Date : ", ExpirationDate, "*Max amount to spend is 10000 a month.");
            }
            else { CardInfo = "You are to young come back when your 15."; }
            return CardInfo;
        }

    }
}
