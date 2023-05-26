using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading data from list data.");
            List<Product> products = new List<Product>();
        }
        public void SaveData()
        {
            Console.WriteLine("I am saving to a list database.");
        }
        
    }
}
