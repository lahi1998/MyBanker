using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyBanker
{
    internal class Mastercard : Cards, ICredit, IExpiration_Date
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

        public int Credit_Month { get; set; }
        public string ExpirationDate { get; set; }


        public Mastercard(string Name, string CardNumber, string AcountNumber) 
        {
            NAME = Name;
            CARDNUMBER = CardNumber;
            ACOUNTNUMBER = AcountNumber;
            ExpirationDate = "";
        }

        internal override string GenerateCardNumber()
        {
            var list = new List<string> { "51", "52", "53", "54", "55" };
            Random random = new Random();
            int index = random.Next(list.Count);
            string Prefix = list[index];

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

            AcountNumber = GenerateAcountNumber();
            CardNumber = GenerateCardNumber();
            Credit_Month = 40000;
            DateTime now = DateTime.Now;
            DateTime ExpirationDate = now.AddYears(5);

            // placing a * where i want the return string to be split to a new write line so i looks nice.
            CardInfo = string.Concat("Mastercard *Name : ", Name, "*Card number : ", CardNumber, "*Acount number : ", AcountNumber, "*Expiration Date : ", ExpirationDate, "*Total credit : ", Credit_Month, "*Monthly withdraw limit : 30000 *Daily Widraw limit : 5000");
            return CardInfo;
        }




    }
}
