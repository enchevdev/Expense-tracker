namespace ExpenseTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            
       


            List<Expense> expenses = new List<Expense>();


            

            while (true)
            {
                decimal bedrag = 0;
                Expense expense = new Expense();
                

                Console.WriteLine("Enter description:");
                expense.Description = Console.ReadLine();

                Console.WriteLine("Enter amount:");
                expense.Amount = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter category:");
                expense.Category = Console.ReadLine();
                expenses.Add(expense);
                foreach (Expense item in expenses)
                {
                    Console.WriteLine($"Description: {item.Description}, Amount: {item.Amount}$, Category: {item.Category}");

                    bedrag += item.Amount;
                }
                Console.WriteLine($"Total expenses: {bedrag}$");
            }
        }
    }
}