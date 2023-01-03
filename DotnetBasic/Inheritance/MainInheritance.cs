using Inheritance.OOP;
using Inheritance.OOP.InheritanceShape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class MainDataType
    {
        public static void Main()
        {
            SimpleClassExample();
            ClassNameExample();
            Example();
            TestClasses();
            ShapeMain();
        }

        #region Implicit inheritance
        public class SimpleClass
        { }

        public static void SimpleClassExample()
        {
            Type t = typeof(SimpleClass);
            BindingFlags flags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public |
                                 BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;
            MemberInfo[] members = t.GetMembers(flags);
            Console.WriteLine($"Type {t.Name} has {members.Length} members: ");
            foreach (MemberInfo member in members)
            {
                string access = "";
                string stat = "";
                var method = member as MethodBase;
                if (method != null)
                {
                    if (method.IsPublic)
                        access = " Public";
                    else if (method.IsPrivate)
                        access = " Private";
                    else if (method.IsFamily)
                        access = " Protected";
                    else if (method.IsAssembly)
                        access = " Internal";
                    else if (method.IsFamilyOrAssembly)
                        access = " Protected Internal ";
                    if (method.IsStatic)
                        stat = " Static";
                }
                string output = $"{member.Name} ({member.MemberType}): {access}{stat}, Declared by {member.DeclaringType}";
                Console.WriteLine(output);
            }
        }
        #endregion

        #region Implicit inheritance EmptyClass
        public class EmptyClass
        { }

        public static void ClassNameExample()
        {
            EmptyClass sc = new();
            Console.WriteLine(sc.ToString());
        }
        #endregion

        #region Inheritance and an "is a" relationship
        public static void Example()
        {
            var packard = new Automobile("Packard", "Custom Eight", 1948);
            Console.WriteLine(packard);
        }
        #endregion

        #region Designing the base class and derived classes
        public static void TestClasses()
        {
            var book = new Book("The Tempest", "0971655819", "Shakespeare, William",
                                "Public Domain Press");
            ShowPublicationInfo(book);
            book.Publish(new DateTime(2016, 8, 18));
            ShowPublicationInfo(book);

            var book2 = new Book("The Tempest", "Classic Works Press", "Shakespeare, William");
            Console.Write($"{book.Title} and {book2.Title} are the same publication: " +
                  $"{((Publication)book).Equals(book2)}");
        }

        public static void ShowPublicationInfo(Publication pub)
        {
            string pubDate = pub.GetPublicationDate();
            Console.WriteLine($"{pub.Title}, " +
                      $"{(pubDate == "NYP" ? "Not Yet Published" : "published on " + pubDate):d} by {pub.Publisher}");
        }
        #endregion

        #region Designing abstract base classes and their derived classes
        public static void ShapeMain()
        {
            Shape[] shapes = { new Rectangle(10, 12), new Square(5),
                    new Circle(3) };
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape}: area, {Shape.GetArea(shape)}; " +
                                  $"perimeter, {Shape.GetPerimeter(shape)}");
                if (shape is Rectangle rect)
                {
                    Console.WriteLine($"   Is Square: {rect.IsSquare()}, Diagonal: {rect.Diagonal}");
                    continue;
                }
                if (shape is Square sq)
                {
                    Console.WriteLine($"   Diagonal: {sq.Diagonal}");
                    continue;
                }
            }
        }
        #endregion
    }
}
