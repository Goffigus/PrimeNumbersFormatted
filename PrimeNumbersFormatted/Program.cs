using static System.Console;

namespace PrimeNumbersFormatted
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            int countCol = 0;

            for (int i = 2; i < 100; i++)
            {

                for (int x = 2; x < i; x++) //loop that looks to see if there are any factors
                {

                    if (i % x == 0)
                    {

                        isPrime = false;
                        x = i;//exits loop once number is proven not to be prime

                    }

                }


                if (isPrime) //only print if number did not fail tests  
                {

                    Write(i);
                    Write("\t");
                    countCol++;
                    if (countCol >= 6)
                    {
                        Write("\n");
                        countCol = 0;
                    }
                }
                isPrime = true;



            }

        }
    }
}
