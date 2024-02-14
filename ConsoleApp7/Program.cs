namespace ConsoleApp7
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] operators = { "+", "-", "*", "/" };

            Random random = new Random();
            float numberOfItems = random.Next(5, 15);
            double answer;
            double correctAns;
            float totalScore = 0;

            Console.WriteLine("Total Number of items: " + numberOfItems);

            for (int i = 1; i <= numberOfItems; i++)
            {
                //generates random operators
                string randomOperator;

                //for random numbers to solved for each item
                int leftNum = random.Next(5, 15);
                int rightNum = random.Next(5, 15);
                int operatorNum = random.Next(1, 4);

                //solve to get correct answer
                if (operatorNum == 1)
                {
                    randomOperator = "+";
                    correctAns = leftNum + rightNum;
                }
                else if (operatorNum == 2)
                {
                    randomOperator = "-";
                    correctAns = leftNum - rightNum;
                }
                else if (operatorNum == 3)
                {
                    randomOperator = "*";
                    correctAns = leftNum * rightNum;
                }
                else
                {
                    randomOperator = "/";
                    correctAns = leftNum / rightNum;
                }

                while (true)
                {
                    Console.WriteLine("Question " + i + ": " + leftNum + " " + randomOperator + " " + rightNum);
                    answer = Convert.ToDouble(Console.ReadLine());

                    if (correctAns == answer)
                    {
                        totalScore++;
                        Console.WriteLine("Correct!\n");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! Correct answer: " + correctAns +"\n");
                    }
                    //if user enters an input proceed to next item
                    if (answer != null)
                    {
                        break;
                    }
                }

            }
            //Print user's score after the for loop is done
            
            float percentage = (totalScore /numberOfItems) * 100;

            Console.WriteLine("Your Total Score: " + totalScore);
            Console.WriteLine("Percentage of Correct Answers: " + percentage + "%");

        }


    }


}
