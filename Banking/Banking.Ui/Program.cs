using Banking.Models;
using System.Diagnostics;
using System.Linq;
internal class Program
{
    private static void Print(IEnumerable<Person> people) { 
    
        foreach(Person p in people)
        {
            Console.WriteLine($"> {p.Fullname} - {p.Age}");
        }
    
    }

    private static void Main(string[] args)
    {

        var q = from p in Person.All
                where p.GetLastname().StartsWith("d", StringComparison.CurrentCultureIgnoreCase)
                orderby p.Age ascending, p.Fullname descending
                select new { 
                    LastName = p.GetLastname(),
                    Leeftijd = p.Age
                
                };


        var r = Person.All.Where(p => p.GetLastname()
                          .StartsWith("d", StringComparison.CurrentCultureIgnoreCase))
                          .OrderBy(p => p.Age)
                          .SingleOrDefault();

     
        //Print(q);


        //using (GosselinContext gc = GosselinContext.CreateContext()) { 

        //}

        //GosselinContext gc2 = GosselinContext.CreateContext();



        RevolutBankAccount ba = new RevolutBankAccount("REV-1234", "REV-9876");
        //ba.BuyStock("hkjhkj");
        //// polymorphism
        // poly  --> meerdere
        // morph --> vormen

        //using (BankAccount ba1 = new RevolutBankAccount("REV-1234", "REV-9876")) {
        //    Console.WriteLine(ba1);
        //}


        //List<BankAccount> accounts = new List<BankAccount>();

        //BankAccount bacopy = new RevolutBankAccount("REV-1234", "REV-9876");
        //bacopy.Type = BankAccountType.DEPOSIT;

        //BankAccount ba2 = new KbcBankAccount("KBC-134", "KBC-9876");


        //Console.WriteLine(ba);

        
        //string name = "glenn";
        //Console.WriteLine(name.ToJason(name));

        //// {name:'glenn'}   name.toJason();
        //ba.Encrypt("hsa", "dat maakt niet uit");
      
        //double f = Temp.ToFahrenheit(20);
        //Console.WriteLine(f);



    }


    
}

internal static class Extensions {

    public static string GetLastname(this Person p) {
        string[] bobTheStringSplitter = p.Fullname.Split(' ');
        if (bobTheStringSplitter.Length > 0) {
            return bobTheStringSplitter[1];
        }
        return "";
    }

}

internal class Temp {

    public static double ToFahrenheit(double c) {
        return c * 9 / 5 + 32;
      
    }

}