using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prøveeksamen
{
    public class Expensetracker
    {

        //instansfelter
        private int _id;
        private Dictionary<int, Expense> Expenses;


        //properties
        public int ID { get; }

        
        // constructor + Dictionary 
        public Expensetracker(int id)
        {
            ID = id;

            Expenses = new Dictionary<int, Expense>();

        }
        // Create method
        public void AddExpense(Expense expense)
        {
            Expenses.Add(expense.ID, expense);

            // vi prøvede, at lægge if statement til argument exception ind i method, but it didnt work :/
        }

        // Delete method

        public void DeleteExpensive(int id)
        {
            Expenses.Remove(id);
        }

        // GetTotalExpenses() method (kom tilbage)

        public int GetTotalExpenses(int id)
        {
            return Expenses.Count;
        }

        //ToString() method

        public override string ToString()
        {
            return $"ID: {ID}";
        }
    }
}
