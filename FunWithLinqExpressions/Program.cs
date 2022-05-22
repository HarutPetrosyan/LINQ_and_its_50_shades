using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLinqExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProdactInfo[] infos = new[]{
            new ProdactInfo{ Name = "Mac's Coffee", Description = "Coffee with TEETH",
            NumberInStock = 24},
            new ProdactInfo{ Name = "Milk Maid Milk", Description = "Milk cow's love",
            NumberInStock = 100},
            new ProdactInfo{ Name = "Pure Silk Tofu", Description = "Bland as Possible",
            NumberInStock = 120},
            new ProdactInfo{ Name = "Crunchy Pops", Description = "Cheezy, peppery goodness",
            NumberInStock = 2},
            new ProdactInfo{ Name = "RipOff Water", Description = "From the tap to your wallet",
            NumberInStock = 100},
            new ProdactInfo{ Name = "Classic Valpo Pizza", Description = "Everyone lovespizza!",
            NumberInStock = 73}
            };
            //SelectEverything(infos);
            //ListProductName(infos);
            //GetOverStock(infos,15);
            //GetNameAndDeccriptions(infos);
            //Array array = GetprojectSubset(infos);
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //GetCountFromQuery();
            //Revercemethode(infos);
            //DisplayDeff();
            //DisplayInteraction();
            //DisplayConcat();

            AggregateOps();
            Console.ReadLine(); 
        }
        static void SelectEverything(ProdactInfo[] prodacts)
        {
            var myprod=from i in prodacts select i;
            foreach (var item in myprod)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static void ListProductName(ProdactInfo[] prodacts)
        {
            var myprod=from i in prodacts select i;
            foreach (var item in myprod)
            {
                Console.WriteLine($"Name: {item.Name}");
            }
        }
        static void GetOverStock(ProdactInfo[] prodacts, int a )
        {
            var myprod=from i in prodacts where i.NumberInStock>a select i;
            foreach (var item in myprod)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static void GetNameAndDeccriptions(ProdactInfo[] prodacts )
        {
            var myprod= from i in prodacts select new {i.Name, i.Description};
            foreach (var item in myprod)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static Array GetprojectSubset(ProdactInfo[] prodacts)
        {
            var myprod= from i in prodacts select new { i.Name, i.Description };
            return myprod.ToArray();
        }
        static void GetCountFromQuery()
        {
            string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter",
"System Shock 2"};
            int Countt=(from i in currentVideoGames where i.Length>6 select i).Count();
            Console.WriteLine($"{Countt} itam honor the Linq Query");
        }
        static void Revercemethode(ProdactInfo[] prodacts)
        {
            var myprod=(from i in prodacts select i).Reverse();
            foreach (var item in myprod)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static void AlphabetisProductNames(ProdactInfo[] prodacts)
        {
            var myprod=from i in prodacts orderby i.Name select i;
            foreach (var item in myprod)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static void DisplayDeff()
        {
            List<string> mycar = new List<string> { "BMW", "Paggani", "Mercedec" };
            List<string> yourcar = new List<string> { "Rolls Royce", "Mercedec", "BMW" };
            var cars = (from i in mycar select i).Except(from c in yourcar select c);
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
        }
        static void DisplayInteraction()
        {
            List<string> mycar = new List<string> { "BMW", "Paggani", "Mercedec" };
            List<string> yourcar = new List<string> { "Rolls Royce", "Mercedec", "BMW" };
            var cars = (from i in mycar select i).Intersect(from c in yourcar select c);
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
        }
        static void DisplayUnion()
        {
            List<string> mycar = new List<string> { "BMW", "Paggani", "Mercedec" };
            List<string> yourcar = new List<string> { "Rolls Royce", "Mercedec", "BMW" };
            var cars = (from i in mycar select i).Union(from c in yourcar select c);
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
        }
        static void DisplayConcat()
        {
            List<string> mycar = new List<string> { "BMW", "Paggani", "Mercedec" };
            List<string> yourcar = new List<string> { "Rolls Royce", "Mercedec", "BMW" };
            var cars = (from i in mycar select i).Concat(from c in yourcar select c);
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
        }
        static void DisplayConcatNodups()
        {
            List<string> mycar = new List<string> { "BMW", "Paggani", "Mercedec" };
            List<string> yourcar = new List<string> { "Rolls Royce", "Mercedec", "BMW" };
            var cars = (from i in mycar select i).Concat(from c in yourcar select c);
            foreach (var item in cars.Distinct())
            {
                Console.WriteLine(item);
            }
        }
        static void AggregateOps()
        {
            double[] winterTemps = { 2.0, -21.3, 8, -4, 0, 8.2 };
            // Various aggregation examples.
            Console.WriteLine("Max temp: {0}", (from t in winterTemps select t).Max());        
            Console.WriteLine("Min temp: {0}", (from t in winterTemps select t).Min());
            Console.WriteLine("Average temp: {0}", (from t in winterTemps select t).Average());
            Console.WriteLine("Sum of all temps: {0}", (from t in winterTemps select t).Sum());
        }
    }
}
