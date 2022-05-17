using System;

namespace ATMSavingsExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            
            person.FirstName = "What is your first name: ".RequestString();


            person.LastName = "What is your first name: ".RequestString();

           
            person.Deposits = "How much do you want to deposit: ".RequestDecimal(true);


            Console.WriteLine();
        }
    }



}
