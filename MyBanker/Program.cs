//Hævekort: no expiry date, cifre(16) under 18 år, ingen overtræk, ikke bruges internationalt/nettet..

//Maestro : expiry 5 år 8 måneder, cifre(19) minimum 18 år.

//VISA Elecron : expiry max 5 år, cifre(16) minimum 15 år, max forbrug 10k om månded

//Visa/Dankort : expiry max 5 år, cifre(16) minimum 18 år, max forbrug 20k om månded dog overtræk til 25k

//Mastercard  : expiry max 5 år, cifre(16) ingen minimums alder, max forbrug 40k om månded saldo opgøres en gang om måndeden.
//	            Hæve max 5k om dagen og op til 30 om månded.

//Prfix er del af de 16/19 cifre  exempel 51 + 14 cifre.

//Kontoer er 14 cifre første 4 cifre (id nummer) exempel 3520

//alle kort : Navn, Kortnummer, Udløbsdato, alder og KontoNummer

using MyBanker;

Mastercard mastercard1 = new Mastercard("Lars", "", "");
string cardInfo1 = mastercard1.Generatecard();
string[] result1 = cardInfo1.Split('*');

foreach (string s in result1)
{
    Console.WriteLine(s);
}

Console.WriteLine();

Visa_CreditCard visa_credit = new Visa_CreditCard("Lars", "", "", 18);
string cardInfo2 = visa_credit.Generatecard();
string[] result2 = cardInfo2.Split('*');

foreach (string s in result2)
{
    Console.WriteLine(s);
}

Console.WriteLine();

Visa_Electron visa_electron = new Visa_Electron("Lars", "", "", 15);
string cardInfo3 = visa_electron.Generatecard();
string[] result3 = cardInfo3.Split('*');

foreach (string s in result3)
{
    Console.WriteLine(s);
}

Console.WriteLine();

Maestro maestro = new Maestro("Lars", "", "", 18);
string cardInfo4 = maestro.Generatecard();
string[] result4 = cardInfo4.Split('*');

foreach (string s in result4)
{
    Console.WriteLine(s);
}

Console.WriteLine();

Debit_Card debit = new Debit_Card("Lars", "", "", 16);
string cardInfo5 = debit.Generatecard();
string[] result5 = cardInfo5.Split('*');

foreach (string s in result5)
{
    Console.WriteLine(s);
}
