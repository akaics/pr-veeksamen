using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prøveeksamen
{
    public class Expense
    {

        //instansfelter

        private int _id;
        private string _description;
        private double _amount;

        //properties

        public int ID { get;}
        public string Description { get;}
        public double Amount
        {
            get { return _amount; }
            set
            {
                if (value >= 1)
                {
                    _amount = value;
                }
                else
                {
                    throw new ArgumentException("Expense cannot have a negative amount.");
                }
            }




        }

        // Constructor

        public Expense(int id, string description, double amount)
        {
            ID = id;
            Description = description;
            Amount = amount;
        }

        // ToString() method 

        public override string ToString()
        {
            return $"ID: {ID}, Description: {Description}, Amount: {Amount}";
        }
    }
}
