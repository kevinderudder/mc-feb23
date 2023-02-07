using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Models
{

   


    public class Person
    {
        public string Fullname { get; set; }
        public string City { get; set; }
        public int Age { get; set; }

        public Gender Gender { get; set; }


        public static IList<Person> All { get {
                return new List<Person>() {
                    new Person(){ Fullname = "Johnny Depp", Age = 58, Gender = Gender.MALE, City = "LA" },
                    new Person(){ Fullname = "Kevin DeRudder", Age = 41, Gender = Gender.MALE, City = "Gent" },
                    new Person(){ Fullname = "Elon Musk", Age = 46, Gender = Gender.X, City = "Kaapstad" },
                    new Person(){ Fullname = "Will Smith", Age = 50, Gender = Gender.MALE, City = "LA" },
                    new Person(){ Fullname = "Lebron James", Age = 38, Gender = Gender.MALE, City = "LA" },
                    new Person(){ Fullname = "Adam Sandler", Age = 56, Gender = Gender.MALE, City = "LA"},
                    new Person(){ Fullname = "Steven Geens", Age = 38, Gender = Gender.FEMALE, City = "Mechelen" },
                    new Person(){ Fullname = "Wout Van Aert", Age = 30, Gender = Gender.MALE, City = "Mol" },
                    new Person(){ Fullname = "Margot Robbie", Age = 41, Gender = Gender.FEMALE, City = "Gent" }
                };
            } }
    }

    public enum Gender { 
        FEMALE,
        MALE,
        X
    }
}
