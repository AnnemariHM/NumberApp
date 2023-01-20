namespace Testi
{
    using System;
    public class UserInterface
    {
        NumberApp numbers;
        
        public UserInterface(NumberApp numbers)
        {
            this.numbers = numbers;
        }

        public void Start()//Reads numbers from the user.
        {
            int userInput = 0;
            Console.WriteLine("Anna numero, -1 lopettaa.");
            while(true)
            {//Reads the input from the user.
                userInput = Convert.ToInt32(Console.ReadLine());
                //Breaks if user gives -1.
                if(userInput == -1)
                {
                    break;
                }
                //Otherwise adds numbers to the list.
                numbers.AddToList(userInput);
            }//Prints the statistics of the numbers.
                Console.WriteLine("\nAnnoit numerot:");
                numbers.PrintList();
                Console.WriteLine("\nNumeroiden summa: " + numbers.Sum());
                Console.WriteLine("Numeroiden keskiarvo: " + numbers.Average());
        }
    }
}