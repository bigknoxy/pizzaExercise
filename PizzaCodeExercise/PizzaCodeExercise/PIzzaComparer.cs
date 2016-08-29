using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCodeExercise
{
    public class PIzzaComparer : IEqualityComparer<Pizza>
    {
        public bool Equals(Pizza x, Pizza y)
        {
            var list1 = x.Toppings.OrderBy(o => o.Length);
            var list2 = y.Toppings.OrderBy(o => o.Length);
            var isEqual =  list1.SequenceEqual(list2);

            return isEqual;
        }

        public int GetHashCode(Pizza obj)
        {
            string listOftoppings = string.Empty;

            foreach (var topping in obj.Toppings)
            {
                listOftoppings = listOftoppings+topping;
            }
            return listOftoppings.GetHashCode();
        }
    }
}
