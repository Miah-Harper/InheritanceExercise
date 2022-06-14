using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)

        {
            var canary = new Bird();
            canary.Wings = true;
            canary.Beaks = true;
            canary.Colorful = true;
            canary.Nests = true;




            var copperHead = new Reptile();
            
                copperHead.ColdBlooded = true;
                copperHead.HasScales = true;
                copperHead.HasVenom = true;
                copperHead.TwoLegs = false;

            var myAnimals = new Animal [] { canary, copperHead }; 

            foreach(var animal in myAnimals)
            {
                Console.WriteLine($"Does this animal have 4 legs? {animal.FourLegs}");
                Console.WriteLine($"This animal has two eyes: {animal.TwoEyes}");
                Console.WriteLine($"This animal is adorable! {animal.Adorable}");
                Console.WriteLine($"Is this animal furry? {animal.Furry}");
                Console.WriteLine("");
            }


            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             * 

           

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }

        

    }
}
