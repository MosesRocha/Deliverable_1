namespace Deliverable_1
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int input = 0;
                string series = "";

                while (true)
                {
                    try
                    {
                        // Beginning question for user
                        Console.Write("Enter an integer number between 1 and 100: ");
                        input = int.Parse(Console.ReadLine());

                        if (input >= 1 && input <= 100)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter an integer number between 1 and 100.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Please use an integer number");
                        Console.ReadKey(true);
                    }
                }

                while (true)
                {
                    // Second question for user
                    Console.Write("Specify the series type: Even or Odd: ");
                    series = Console.ReadLine();

                    // User can use any variation of 'odd'
                    if (series == "odd" || series == "Odd" || series == "ODD")
                    {
                        try
                        {
                            Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are:");
                            int i = 1;
                            while (i <= input)
                            {
                                Console.WriteLine(i);
                                i = i + 2;
                            }
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Please specify the series type: Even or Odd: ");
                        }
                    }

                    // User can use any variation of 'even'
                    else if (series == "even" || series == "Even" || series == "EVEN")
                    {
                        try
                        {
                            Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are:");
                            int i = 0;
                            while (i <= input)
                            {
                                Console.WriteLine(i);
                                i = i + 2;
                            }
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Please specify the series type: Even or Odd: ");
                        }
                    }
                }
            }
        }
    }
