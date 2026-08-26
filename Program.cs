namespace ExpenseTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Expense expense = new Expense();
            Expense expense1 = new Expense();
            Expense expense2 = new Expense();


            List<Expense> expenses = new List<Expense>();




            expense.Description = "Pizza";
            expense.Amount = 15.00m;
            expense.Category = "Food";

            expense1.Description = "Cola";
            expense1.Amount = 3.00m;
            expense1.Category = "Food";

            
            expense2.Description = "Train ticket";
            expense2.Amount = 12.00m;
            expense2.Category = "Transportation";

            expenses.Add(expense);
            expenses.Add(expense1);
            expenses.Add(expense2);


            foreach ( Expense item in expenses)
            {
                Console.WriteLine($"Description: {item.Description}, Amount: {item.Amount}, Category: {item.Category}");
            }
        }
    }
}