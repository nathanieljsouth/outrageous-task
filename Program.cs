using System;

/*
Create a class User with two fields, int field Age and string field Name, 
and one method with name GetName() that takes no arguments and returns a field Name.

*/

namespace time
{

    class User {

        //member variable/fields
        int Age;
        string Name;

        public string GetName() {
            return Name;

        }

    }

    /*
    Create a class Car with two fields: a double field Weight and a string field Color. 
    Then, add two methods to class Car: PrintWeight(), which prints the value of the field Weight; 
    and PrintColor(), which prints the value of the field Color to the console. Both methods take no parameters.

    */
    class Car {
        public double Weight;
        public string Color;

        public void PrintWeight() {

            Console.WriteLine(Weight.ToString());
        }
        public void PrintColor() {
            Console.WriteLine(Color);

        }
    }//end Car

    class Program
    {     
        
        public static void Main(string[] args)
        {
            //to use class User
            //must create an object for it
            User myObject = new User();

            Console.WriteLine(myObject.GetName());


            //to access information from my Car blueprint
            //create an object for my Car
            Car myCar = new Car();
            myCar.Color = "red";
            myCar.Weight = 100.2;
            myCar.PrintWeight();
            myCar.PrintColor();


        }//end Main
    }//end Program
}//end namespace