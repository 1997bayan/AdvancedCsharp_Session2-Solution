using System.Collections;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace AdvancedCsharp_Session2
{

    
    internal class Program
    
    {

        static void PrintList(List<int> list)
        {
            Console.WriteLine("List elements: " + string.Join(", ", list)); //The string.Join method is used to concatenate the elements of a collection, in this case, a List<int>, into a single string.
        }
        public static int SumArrayList(ArrayList arraylist)
        {
            int sum = 0;

            if (arraylist != null)
            {
                for (int i = 0; i < arraylist.Count; i++)
                {

                    sum = sum + (int)arraylist[i]; //// Unboxing and casting

                }
                return sum;

            }
            return 0;

        }
        static void Main(string[] args)
        {
            #region ArrayList -Non Generecis
            // ArrayList arrayList = new ArrayList();
            // // Initial size of ArrayList
            // Console.WriteLine($"Count Of arrayList = {arrayList.Count}, Capacity Of arrayList = {arrayList.Capacity}");

            // arrayList.Add(1);
            // Console.WriteLine("After Adding First Element");
            // Console.WriteLine($"Count Of arrayList = {arrayList.Count}, Capacity Of arrayList = {arrayList.Capacity}");
            // // Capacity increases to 4

            // arrayList.Add(2);
            // arrayList.AddRange(new int[] { 3, 4 });
            // Console.WriteLine($"Count Of arrayList = {arrayList.Count}, Capacity Of arrayList = {arrayList.Capacity}");

            // arrayList.Add(5);

            // // Create new Array at the Heap with Double size of old Array - [8].
            // //Take old elements and adding new elements to new Array with Capacity 8.
            // // Capacity doubles to 8
            // Console.WriteLine($"\nCount Of arrayList = {arrayList.Count}, Capacity Of arrayList = {arrayList.Capacity}");


            // Console.WriteLine("================");

            // ArrayList arrayList2 = new ArrayList(5) { 1, 2, 3, 4, 5 };
            // Console.WriteLine($"Count Of arrayList2 = {arrayList2.Count}, Capacity Of arrayList2 = {arrayList2.Capacity}");
            // arrayList2.Add(6);
            // Console.WriteLine("================");

            // Console.WriteLine("After Adding 6th Element");
            // Console.WriteLine($"Count Of arrayList2 = {arrayList2.Count}, Capacity Of arrayList2 = {arrayList2.Capacity}");
            // arrayList2.TrimToSize();
            // // Capacity trimmed to match Count
            // Console.WriteLine("After Trim");
            // Console.WriteLine($"Count Of arrayList2 = {arrayList2.Count}, Capacity Of arrayList2 = {arrayList2.Capacity}");
            // // Key Points:
            // //Dynamic Sizing:

            // //ArrayList dynamically resizes itself. Initially, it has no capacity.
            // //Adding elements increases its capacity.The first addition sets the capacity to 4.
            // //Once the capacity is reached, adding more elements doubles the capacity.
            // //TrimToSize Method:

            // //TrimToSize reduces the capacity of the ArrayList to match its count, freeing up unused memory.
            // arrayList2.Add("Bayan");
            // foreach (int item in arrayList2)
            // {
            //     Console.WriteLine(item); // System.InvalidCastException:
            // } 


            //int result= SumArrayList(arrayList2);
            // Console.WriteLine($"Sum = {result}");
            #endregion



            #region List <T> Genercis
            List<int> list = new List<int>();
            Console.WriteLine($"Count Of arrayList = {list.Count}, Capacity Of arrayList = {list.Capacity}");
            list.Add(1);
            Console.WriteLine($"Count Of arrayList = {list.Count}, Capacity Of arrayList = {list.Capacity}");

            list.AddRange(new int[] { 2, 3, 4 });

            list.Add(5);
            Console.WriteLine($"Count Of arrayList = {list.Count}, Capacity Of arrayList = {list.Capacity}");

            // 8 - 5 = 3 * 4 [int] = 12 bytes [Unused bytes]

            list.TrimExcess(); // Delete Unused bytes
            Console.WriteLine("Ater Trim");
            Console.WriteLine($"Count Of arrayList = {list.Count}, Capacity Of arrayList = {list.Capacity}");

            List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5 };
            // Adding an element to the list
            Numbers.Add(6);
            Console.WriteLine("After Adding 6");
            Numbers[3] = 400;
            PrintList(Numbers); // Sets the element at index 3 to 400

            Console.WriteLine("Using Indexer to Get Values:");
            for (int i = 0; i < Numbers.Count; i++)
            {
                Console.WriteLine($"Element at index {i}: {Numbers[i]}");
            }


            // Numbers[8] = 800; Invalid : ArgumentOutOfRangeException
            // PrintList(Numbers); 

            #endregion







        }

    }
}
