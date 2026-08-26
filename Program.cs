namespace ExpenseTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Expense expense = new Expense();

            List<Expense> expenses = new List<Expense>();

            expense.Description = "Pizza";
            expense.Amount = 15.00m;
            expense.Category = "Food";

            expenses.Add(expense);

            Console.WriteLine(expense.Description + " - $" + expense.Amount + " - " + expense.Category);

        }
    }
}