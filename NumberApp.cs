namespace Testi
{
    using System;
    public class NumberApp
    {
        List<int> numberList;
        public NumberApp()
        {
            this.numberList = new List<int>();
        }
        public void AddToList(int number)//Adds numbers to the list.
        {
            numberList.Add(number);
        }
        
        public void PrintList()//Prints the list.
        {
            foreach(int numbers in numberList)
            {
                Console.WriteLine(numbers);
            }

        }
        public int Sum()//Counts and returns the sum of the numbers in the list.
        {
            if(numberList == null)
            {
                return 0;
            }
            int sum = 0;
            foreach(int numbers in numberList)
            {
                sum += numbers;
            }
            return sum;
        }
        public double Average()//Counts and returns the average of the numbers in the list.
        {
            if(numberList == null)
            {
                return 0.0;
            }
            else
            {
                return Math.Round((double)this.Sum()/numberList.Count, 2);
            }
        }
    }
}