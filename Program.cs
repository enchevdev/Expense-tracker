namespace ExpenseTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            
       


            List<Expense> expenses = new List<Expense>();


            

            while (true)
            {
                int choice = 0;

                Console.WriteLine("1. Add expense");

                Console.WriteLine("2. View expenses");

                Console.WriteLine("3. View total");

                Console.WriteLine("4. Exit");

                decimal bedrag = 0;

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Expense expense = new Expense();

                        

                        Console.WriteLine("Enter description:");
                        expense.Description = Console.ReadLine();

                        Console.WriteLine("Enter amount:");
                        expense.Amount = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Enter category:");
                        expense.Category = Console.ReadLine();
                        expenses.Add(expense);

                      

                        break;

                    case 2:
                        foreach (Expense item in expenses)
                        {
                            Console.WriteLine($"Description: {item.Description}, Amount: {item.Amount}$, Category: {item.Category}");

                            
                        }
                        

                        break;

                    case 3:
                        bedrag = 0;

                        foreach (Expense item in expenses)
                        {
                            bedrag += item.Amount;
                            
                        }
                        Console.WriteLine($"Total expenses: {bedrag}$");

                        break;

                    case 4:   
                        
                     return;
                }
            }
        }
    }
}