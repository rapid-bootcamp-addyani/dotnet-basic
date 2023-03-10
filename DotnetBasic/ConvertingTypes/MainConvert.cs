using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertingTypes
{
    public class MainDataType
    {
        public static void Main()
        {
            //PatternMatching();
            //PrecedingSample();
            PatternMatchingAnimal();
        }

        #region pattern matching 
        public static void PatternMatching()
        {
            var g = new Giraffe();
            var a = new Animal();
            FeedMammals(g);
            FeedMammals(a);
            // Output:
            // Eating.
            // Animal is not a Mammal

            SuperNova sn = new SuperNova();
            TestForMammals(g);
            TestForMammals(sn);

            static void FeedMammals(Animal a)
            {
                if (a is Mammal m)
                {
                    m.Eat();
                }
                else
                {
                    // variable 'm' is not in scope here, and can't be used.
                    Console.WriteLine($"{a.GetType().Name} is not a Mammal");
                }
            }

            static void TestForMammals(object o)
            {
                // You also can use the as operator and test for null
                // before referencing the variable.
                var m = o as Mammal;
                if (m != null)
                {
                    Console.WriteLine(m.ToString());
                }
                else
                {
                    Console.WriteLine($"{o.GetType().Name} is not a Mammal");
                }
            }
            // Output:
            // I am an animal.
            // SuperNova is not a Mammal
        }
        #endregion

        #region preceding sample 
        public static void PrecedingSample()
        {
            int i = 5;
            PatternMatchingNullable(i);

            int? j = null;
            PatternMatchingNullable(j);

            double d = 9.78654;
            PatternMatchingNullable(d);

            PatternMatchingSwitch(i);
            PatternMatchingSwitch(j);
            PatternMatchingSwitch(d);

            static void PatternMatchingNullable(ValueType? val)
            {
                if (val is int j) // Nullable types are not allowed in patterns
                {
                    Console.WriteLine(j);
                }
                else if (val is null) // If val is a nullable type with no value, this expression is true
                {
                    Console.WriteLine("val is a nullable type with the null value");
                }
                else
                {
                    Console.WriteLine("Could not convert " + val.ToString());
                }
            }

            static void PatternMatchingSwitch(ValueType? val)
            {
                switch (val)
                {
                    case int number:
                        Console.WriteLine(number);
                        break;
                    case long number:
                        Console.WriteLine(number);
                        break;
                    case decimal number:
                        Console.WriteLine(number);
                        break;
                    case float number:
                        Console.WriteLine(number);
                        break;
                    case double number:
                        Console.WriteLine(number);
                        break;
                    case null:
                        Console.WriteLine("val is a nullable type with the null value");
                        break;
                    default:
                        Console.WriteLine("Could not convert " + val.ToString());
                        break;
                }
            }
        }
        #endregion

        #region pattern matching animal
        public static void PatternMatchingAnimal()
        {
            // Use the is operator to verify the type.
            // before performing a cast.
            Giraffe g = new();
            UseIsOperator(g);

            // Use the as operator and test for null
            // before referencing the variable.
            UseAsOperator(g);

            // Use pattern matching to test for null
            // before referencing the variable
            UsePatternMatchingIs(g);

            // Use the as operator to test
            // an incompatible type.
            SuperNova sn = new();
            UseAsOperator(sn);

            // Use the as operator with a value type.
            // Note the implicit conversion to int? in
            // the method body.
            int i = 5;
            UseAsWithNullable(i);

            double d = 9.78654;
            UseAsWithNullable(d);

            static void UseIsOperator(Animal a)
            {
                if (a is Mammal)
                {
                    Mammal m = (Mammal)a;
                    m.Eat();
                }
            }

            static void UsePatternMatchingIs(Animal a)
            {
                if (a is Mammal m)
                {
                    m.Eat();
                }
            }

            static void UseAsOperator(object o)
            {
                Mammal? m = o as Mammal;
                if (m is not null)
                {
                    Console.WriteLine(m.ToString());
                }
                else
                {
                    Console.WriteLine($"{o.GetType().Name} is not a Mammal");
                }
            }

            static void UseAsWithNullable(System.ValueType val)
            {
                int? j = val as int?;
                if (j is not null)
                {
                    Console.WriteLine(j);
                }
                else
                {
                    Console.WriteLine("Could not convert " + val.ToString());
                }
            }
        }
        #endregion
    }
}
