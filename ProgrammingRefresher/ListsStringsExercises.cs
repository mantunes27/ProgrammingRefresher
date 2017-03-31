using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProgrammingRefresher
{
    class ListsStringsExercises
    {
        public void sortAndPrintList(List<int> a)
        {
            //a.Sort();
            foreach (int i in a)
            {
                Console.Write(i + " ");
                Console.Write(" ");
            }

        }
        public void rotateList(List<int> a,int steps)
        {
            sortAndPrintList(a);
            for(int i = 1; i <= steps; i++ )
            {
                int last = a.Count()-1 ;
                a.Add(a[0]);
                a.Insert(0, a[last]);

                last = a.Count() - 1;

                a.RemoveAt(last - 1);
                a.RemoveAt(last - 1);
            }
            Console.WriteLine("after rotating");
            sortAndPrintList(a);
        }
        static void Main(string[] args)
        {
            
            


            //1 Write a function that returns the largest element in a list.
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);

            List<string> listString = new List<string>();
            listString.Add("A");
            listString.Add("B");
            listString.Add("C");
            listString.Add("D");
            listString.Add("E");
            listString.Add("F");

            //  int big = 0;
            //
            //  foreach (int x in list)
            //  {
            //      if (x > big)
            //      {
            //          big = x;
            //      }
            //  }
            //  Console.WriteLine($"The biggest number is {big}");
            //  Console.ReadLine();

            // 2 Write function that reverses a list, preferably in place.

            //  List<int> reversedList = new List<int>();
            //
            //  for(int i = list.Count; i < 1;i--)
            //  {
            //      reversedList.Add(list[i]);
            //      Console.WriteLine(i);
            //  }
            //
            //  Console.ReadLine();

            // 3 Write a function that checks whether an element occurs in a list.
            //
            //  bool found = false;
            //  int ele = 29;
            //
            //  foreach (int i in list)
            //  {
            //      if(ele == i)
            //      {
            //          found = true;
            //      }
            //  }
            //  Console.WriteLine($"The number exists in the list: {found}");
            //  Console.ReadLine();

            // 4 Write a function that returns the elements on odd positions in a list
            //  for(int i = 0; i < list.Count();i++)
            //  {
            //      if(i % 2 != 0)
            //      {
            //          Console.WriteLine(list[i]);
            //      }
            //  }

            //5 Write a function that computes the running total of a list
            // int count = 0;
            //
            // foreach(int i in list)
            // {
            //     count += i;
            // }
            // Console.WriteLine(count);

            //6 Write a function that tests whether a string is a palindrome

            //     string test = "Hueuh";
            //     test = test.ToLower();
            //
            //     
            //     
            //
            //     int count = 0;
            //     bool poly = true;
            //     for(int i = test.Count()-1; 0 < i ;i--)
            //     {
            //         if(test[i] != test[count] )
            //         {
            //             poly = false;
            //         }
            //         count += 1;
            //     }
            //     Console.WriteLine(poly);

            //7  Write three functions that compute the sum of the numbers in a list: using a for-loop,
            //a while-loop and recursion. (Subject to availability of these constructs in your language of choice.)
            //for loop
            //    int count = 0;
            //    for (int i = 0; i < list.Count(); i++)
            //    {
            //        count += list[i];
            //    }
            //
            //    //while loop
            //    int countWhile = 0;
            //    int counter = 0;
            //    while(counter <= list.Count()-1)
            //        {
            //        countWhile += list[counter];
            //        counter += 1;
            //    }
            //
            //    Console.WriteLine(count);
            //    Console.WriteLine(countWhile);

            //8
            //Write a function on_all that applies a function to every element of a list. Use it to print the first twenty perfect squares (a natural number nn is a perfect square if it can be written as n=m*mn=m*m for some other natural number mm. 1,4,9,16,251,4,9,16,25 are the first 5).

            //    for(int i = 0; i < list.Count(); i++)
            //    {
            //        for(int j = 1; j < 11; j++)
            //        {
            //            if(j*j == list[i])
            //            {
            //                Console.WriteLine(j*j);
            //                Console.WriteLine(i);
            //            }
            //        }
            //    }

            //9 Write a function that concatenates two lists. [a,b,c], [1,2,3] → [a,b,c,1,2,3]

            // List<dynamic> newList = new List<dynamic>();
            //
            // for (int i = 0; i < list.Count(); i++)
            // {
            //     newList.Add(list[i]);
            // }
            // for (int i = 0; i < listString.Count(); i++)
            // {
            //     newList.Add(listString[i]);
            // }
            // foreach (dynamic i in newList)
            // {
            //     Console.WriteLine(i);
            // }
            //10 Write a function that combines two lists by alternatingly taking elements, e.g. [a,b,c], [1,2,3] → [a,1,b,2,c,3].
            //  List<dynamic> newList = new List<dynamic>(); 
            //
            //  for(int i = 0; i < list.Count(); i++)
            //  {
            //      newList.Add(list[i]);
            //      newList.Add(listString[i]);
            //  }
            //
            //  foreach(dynamic i in newList)
            //  {
            //      Console.WriteLine(i);
            //  }

            //11 Write a function that merges two sorted lists into a new sorted list. [1,4,6],[2,3,5] → [1,2,3,4,5,6]. You can do this quicker than concatenating them followed by a sort.
            //      List<int> a = new List<int>();
            //  a.Add(88);
            //  a.Add(102);
            //  a.Add(23);
            //
            //  List<int> b = new List<int>();
            //  b.Add(222);
            //  b.Add(12);
            //  b.Add(5);
            //
            //  List<int> c = new List<int>();
            //  foreach (int num in a)
            //  {
            //      c.Add(num);
            //  }
            //
            //  foreach (int num in b)
            //  {
            //      c.Add(num);
            //  }
            //
            //  c.Sort();
            //  
            //  foreach (int i in c)
            //  {
            //      Console.Write(i + " ");
            //  }

            //12 Write a function that rotates a list by k elements. For example [1,2,3,4,5,6] rotated by two becomes [3,4,5,6,1,2]. Try solving this without creating a copy of the list. How many swap or move operations do you need?


            ListsStringsExercises a = new ListsStringsExercises();
            a.rotateList(list, 2);

        }

    }
}
