using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCodeExercise
{
    public class StringCollectionEqualityComparer : EqualityComparer<IEnumerable<string>>
    {
        public override bool Equals(IEnumerable<string> x, IEnumerable<string> y)
        {
            if (object.Equals(x, y))
                return true;
            var orderedEnumerable = x.OrderBy(value => value, StringComparer.OrdinalIgnoreCase).ToList();
            var orderBy = y.OrderBy(value => value, StringComparer.OrdinalIgnoreCase).ToList();
            
            var equal = orderedEnumerable.SequenceEqual(orderBy, StringComparer.OrdinalIgnoreCase);
            return equal;
        }

        public override int GetHashCode(IEnumerable<string> obj)
        {
            return obj.OrderBy(value => value, StringComparer.OrdinalIgnoreCase)
                .Aggregate(0, (hashCode, value) => hashCode ^ value?.GetHashCode() + 33 ?? hashCode);
        }
    }
}