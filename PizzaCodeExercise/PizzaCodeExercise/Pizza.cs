using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCodeExercise
{
    public class Pizza //: IEquatable<Pizza>
    {
        public IEnumerable<string> Toppings { get; set; }

        //public override bool Equals(object obj)
        //{
        //    var pizzaObj = obj as Pizza;
        //    if (pizzaObj == null) return false;


        //    var list1 = pizzaObj.Toppings.OrderBy(o => o.Length);
        //    var list2 = y.Toppings.OrderBy(o => o.Length);
        //    return list1.SequenceEqual(list2);

        //    new HashSet<string>(pizzaObj.Toppings).SetEquals(B)
        //    foreach (var topping in pizzaObj.Toppings)
        //    {

        //    }
        //    pizzaObj.Toppings

        //    return (Pizza == pizzaObj.Toppings && Longitude == pizzaObj.Longitude);
        //}

        //public bool Equals(Pizza other)
        //{
        //    var item = other as Pizza;

        //    if (item == null)
        //    {
        //        return false;
        //    }
        //    PIzzaComparer comparer = new PIzzaComparer();

        //    var isEqual = comparer.Equals(this, item);

        //    return isEqual;
        //}

        //public override bool Equals(object obj)
        //{
        //    var item = obj as Pizza;

        //    if (item == null)
        //    {
        //        return false;
        //    }
        //    PIzzaComparer comparer = new PIzzaComparer();

        //     var isEqual =  comparer.Equals(this, item);

        //    return isEqual;
        //    //return this.Toppings.Equals(item.Toppings);
        //}

        //public override int GetHashCode()
        //{
        //    string listOftoppings = string.Empty;

        //    foreach (var topping in this.Toppings.OrderByDescending(x => x).ToList())
        //    {
        //        listOftoppings = listOftoppings + topping;
        //    }
        //    return listOftoppings.Trim().GetHashCode();
        //    //return this.Toppings.GetHashCode();
        //    //return Toppings.OrderByDescending(x => x).ToList().GetHashCode();
        //}

        //bool IEquatable<Pizza>.Equals(Pizza other)
        //{
        //    return this.Equals(other);
        //}

        
    }


    
}
