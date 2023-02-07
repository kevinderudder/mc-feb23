using Banking.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        //RevolutBankAccount ba = new RevolutBankAccount("REV-1234", "REV-9876");
        //ba.BuyStock("hkjhkj");
        //// polymorphism
        // poly  --> meerdere
        // morph --> vormen

        BankAccount ba1 = new RevolutBankAccount("REV-1234", "REV-9876");
        //BankAccount ba2 = new KbcBankAccount("KBC-134", "KBC-9876");


        //Console.WriteLine(ba);
    }
}