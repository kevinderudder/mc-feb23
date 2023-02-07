using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //Demo1();
        //DemoBoxing();
        DemoNullables();
    }

    private static void DemoNullables()
    {
        string boek = "Thus spoke Zaratustra";
        string groep = "Queens of the Stone Age";

        //MGroup m = new MGroup();
        //Console.WriteLine(m.Title.IndexOf("Queens"));

    }

    

    private static void DemoBoxing()
    {
        ArrayList a = new ArrayList();
        List<int> ints = new List<int>();
        ints.Add(1);
        ints.Add(2);
        ints.Add(3);
        ints.Add(1);
        ints.Add(1);
        ints.Add(1);
        //ints.Add("Nicolas Cage");
        int l = ints.Count;
        for (int i = 0; i < l ; i+=2 ) {
            Console.WriteLine(ints[i]);
            Console.WriteLine(ints[i+1]);
        }

        
    }

    private static void Demo1()
    {

        int x = 10;
        PrintInt(x);

        Person p = new Person();
        p.FirstName = "Kevin";
        p.LastName = "DeRudder";

        PrintPerson(p);
        PrintPerson(p);

    }

    private static void PrintPerson(Person p)
    {
        p.LastName = "Cage";
        Console.WriteLine($"{p.FirstName} {p.LastName}");
    }

    private static void PrintInt(int x)
    {

        Console.WriteLine(x);

    }

   
}

class Person {

    public string FirstName { get; set; }
    public string LastName { get; set; }

}

class MGroup {

    public string? Title { get; set; }
    public MGroup()
    {

    }



}