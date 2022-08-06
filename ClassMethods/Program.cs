using System;

namespace ClassMethods {

    class Program {

        static void Main(string[] args) { 
        School school = new School();
            school.name = "Jhon";
            school.direction = "Villahermosa, Tab";
            school.dateFundation = DateTime.Now;
            Console.WriteLine(school.name);
            Console.WriteLine("Stamping ....");
            school.Stamp();

        }
    }

    class School {

       public string name;
       public string direction;
       public DateTime dateFundation;

        public void Stamp() { 
            //all
            Console.Beep(10000,3000);
        }
    
    }
}