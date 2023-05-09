using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    internal class Maestro : Cards, IExpiration_Date
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

        public Maestro(string Name, string CardNumber, string AcountNumber, int Age)
        {
            NAME = Name;
            CARDNUMBER = CardNumber;
            ACOUNTNUMBER = AcountNumber;
            AGE = Age;
            ExpirationDate = "";
        }

        internal override string GenerateCardNumber()
        {
            var list = new List<string> { "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763" };
            Random random = new Random();
            int index = random.Next(list.Count);
            string Prefix = list[index];

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

                DateTime now = DateTime.Now;
                DateTime ExpirationDate = now.AddYears(5).AddMonths(8);

                // placing a x where i want the return string to be split to a new write line so i looks nice.
                CardInfo = string.Concat("Maestro *Name : ", Name, "*Card number : ", CardNumber, "*Acount number : ", AcountNumber, "*Expiration Date : ", ExpirationDate, "*Can be used for both online and international purchases");
            }
            else { CardInfo = "You are to young come back when your 18."; }
            return CardInfo;
        }
    }
}
