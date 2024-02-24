namespace InterestCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Interest Calculator");

            string YorN = "y";

            YorN = YorN.ToUpper();

            while (YorN.Equals("Y"))
            {
                Console.WriteLine("Enter Loan Amount");
                string loanamount = Console.ReadLine();
                Double LoanAmount = Convert.ToDouble(loanamount);

                Console.WriteLine("Enter Interest Rate");
                string interestrate = Console.ReadLine();
                Double InterestRate = Convert.ToDouble(interestrate);

                Console.WriteLine("Loan Amount : $"+LoanAmount);
                Console.WriteLine("Interest Rate : "+InterestRate+"%");
                Double Interest = LoanAmount * InterestRate;
                string inter = Interest.ToString("N2");
                Console.WriteLine("Interest : "+"$"+inter);
               
                Console.WriteLine("Continue y/n?");

                string choice = Console.ReadLine();
                choice = choice.ToUpper();
                Boolean success = false;
                while (!success)
                {
                    if (choice.Equals("Y"))
                    {
                        success = true;
                        YorN = choice;
                    }
                    else if (choice.Equals("N"))
                    {
                        success = true;
                        YorN = choice;
                    }
                    else
                    {
                        Console.WriteLine("Please enter Y or N");
                        choice = Console.ReadLine();
                        choice = choice.ToUpper();
                    }
                }
               
               
            }
            Console.WriteLine("Bye");
        }
    }
}