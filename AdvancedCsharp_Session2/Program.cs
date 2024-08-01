using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
            //List<int> list = new List<int>();
            //Console.WriteLine($"Count Of arrayList = {list.Count}, Capacity Of arrayList = {list.Capacity}");
            //list.Add(1);
            //Console.WriteLine($"Count Of arrayList = {list.Count}, Capacity Of arrayList = {list.Capacity}");

            //list.AddRange(new int[] { 2, 3, 4 });

            //list.Add(5);
            //Console.WriteLine($"Count Of arrayList = {list.Count}, Capacity Of arrayList = {list.Capacity}");

            //// 8 - 5 = 3 * 4 [int] = 12 bytes [Unused bytes]

            //list.TrimExcess(); // Delete Unused bytes
            //Console.WriteLine("Ater Trim");
            //Console.WriteLine($"Count Of arrayList = {list.Count}, Capacity Of arrayList = {list.Capacity}");

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5 };
            //// Adding an element to the list
            //Numbers.Add(6);
            //Console.WriteLine("After Adding 6");
            //Numbers[3] = 400;
            //PrintList(Numbers); // Sets the element at index 3 to 400

            //Console.WriteLine("Using Indexer to Get Values:");
            //for (int i = 0; i < Numbers.Count; i++)
            //{
            //    Console.WriteLine($"Element at index {i}: {Numbers[i]}");
            //}


            // Numbers[8] = 800; Invalid : ArgumentOutOfRangeException
            // PrintList(Numbers); 

            #endregion

            #region List Method
            //List<int> Numbers2 = new List<int> { 1, 2, 3, 4, 5 };
            //Displaying count and capacity of the list
            //Console.WriteLine($"Count Of List = {Numbers2.Count}, Capacity Of List = {Numbers2.Capacity}");

            //Adding a single element to the list

            //Numbers2.Add(100);
            //Adding a range of elements to the list
            //Numbers2.AddRange(new int[] { 200, 700 });
            //Console.WriteLine($"Count Of List = {Numbers2.Count}, Capacity Of List = {Numbers2.Capacity}");
            //Iterating over the list and printing each element
            //foreach (int Num in Numbers2)
            //{
            //    Console.Write($" {Num} ");
            //}
            //Console.WriteLine();

            //Inserting an element at a specific index

            //Numbers2.Insert(3, 7000);

            //Console.WriteLine("\n========================");
            //foreach (int Num in Numbers2)
            //{
            //    Console.Write($" {Num} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine(Numbers2.IndexOf(4));
            //Performing a binary search for an element in the list

            // Console.WriteLine(Numbers2.BinarySearch(3));
            /* 
             Binary Search:
            Numbers.BinarySearch(3); performs a binary search for the element 3 in the list. 
            If the element is found, the method returns the index of the element. 
            If the element is not found, the method returns a negative number indicating the bitwise complement of the index of the next element that is larger than the target value,
            or if there is no larger element, the bitwise complement of Count.
             */


            // Removing all elements from the list
            //Numbers.Clear(); 
            // Checking if the list contains a specific element
            //Console.WriteLine(Numbers2.Contains(100));

            //Console.WriteLine();
            //List<int> Numbers3 = new List<int> { 10, 30, 50, 29 , 10};
            //int[] array = new int[10];


            // Copy all elements from the list to the array starting at array[0]
            // Numbers3.CopyTo( array ); // Array  :  10  30  50  29  0  0  0  0  0  0
            //foreach (int Num in array)
            //{ Console.Write($" {Num} "); }

            // Copy all elements from the list to the array starting at array[2]
            //Numbers3.CopyTo(array, 2);

            //Console.WriteLine();
            //foreach (int Num in array)
            //{ Console.Write($" {Num} "); }

            //Console.WriteLine( $"Count of Number List = {Numbers3.Count} , Capactity of the list = {Numbers3.Capacity}");

            //Numbers3.CopyTo(0, array, 0, 4); 

            //foreach (int Num in array)
            //{ Console.Write($" {Num} "); }

            /*The CopyTo method is useful for transferring data from a list to an array, especially when you need to work with fixed-size collections or need to interface with APIs that require arrays. 
             * It provides a flexible way to control how and where elements are copied within the array.*/


            // Ensuring the capacity of the list is at least 19

            //Numbers3.EnsureCapacity(19);
            //Console.WriteLine($"Count of Number List = {Numbers3.Count} , Capactity of the list = {Numbers3.Capacity}");
            /*
             The EnsureCapacity method is particularly useful in scenarios where you know in advance that a large number of elements will be added to a list. By setting the capacity in advance, 
            you can minimize the number of times the internal array needs to be resized, thus optimizing performance and reducing memory overhead.
             
             */


            // Finding the last index of the value 3 in the list
            //Console.WriteLine($"Last index of 10 = {Numbers3.LastIndexOf(10)}");

            // Reversing the order of the list
            // Numbers2.Reverse();


            #endregion

            #region Linked List
            //// Initializing a LinkedList of integers
            //LinkedList<int> Linkedlist = new LinkedList<int>();
            //Console.WriteLine($"LinkedList Count = {Linkedlist.Count}");

            //// Adding elements to the beginning and end of
            //// the LinkedList
            //Linkedlist.AddFirst(1);
            //Console.WriteLine($"LinkedList Count = {Linkedlist.Count}"); //LinkedList Count = 1
            //Linkedlist.AddLast(2);

            //foreach (int i in Linkedlist)
            //{
            //    Console.Write($" {i} ");
            //}
            //LinkedListNode<int> AfterNode=  Linkedlist.Find(1);

            //Console.WriteLine();
            //Linkedlist.AddAfter(AfterNode, 5);

            //foreach (int i in Linkedlist)
            //{
            //    Console.Write($" {i} ");
            //}

            //Console.WriteLine();
            //Linkedlist.AddBefore(Linkedlist.Find(5), 500);
            //foreach (int i in Linkedlist)
            //{
            //    Console.Write($" {i} ");
            //}



            #endregion

            #region STACK

            Stack<int> stack = new Stack<int>();
            // Pushing elements onto the stack
            stack.Push(1); //Push adds an element to the stack.
            stack.Push(2);
            stack.Push(3);

            // Display the top element without removing it
            //Console.WriteLine(stack.Peek()); //Peek returns the top element without removing it.
            //Console.WriteLine(stack.Pop()); //Pop removes and returns the top element
            foreach (int i in stack) 
                Console.Write($" {i} ");
            Console.WriteLine();
            bool result =stack.TryPop(out int element);
            Console.WriteLine($"Result : {result} , element : {element}");

            #endregion






        }

    }
}
