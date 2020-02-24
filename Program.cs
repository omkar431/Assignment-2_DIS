using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_2_DIS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1");
            int[] l1 = new int[] { 5, 6, 6, 9, 9, 12 };
            int target = 9;
            int[] r = TargetRange(l1, target);
            // Write your code to print range r here
            
            Console.WriteLine("Question 2");
            string s = "University of South Florida";
            string rs = StringReverse(s);
            Console.WriteLine(rs);
            
            Console.WriteLine("Question 3");
            int[] l2 = new int[] { 4, 5, 6, 9 } ;
            int sum = MinimumSum(l2);
            Console.WriteLine(sum);
            
            Console.WriteLine("Question 4");
            string s2 = "Dell";
            string sortedString = FreqSort(s2);
            Console.WriteLine(sortedString);
            
            Console.WriteLine("Question 5-Part 1");
            int[] nums1 = { 3, 6, 2 };
            int[] nums2 = { 6,3,6,7,3 };
            int[] intersect1 = Intersect1(nums1, nums2);
            Console.WriteLine("Part 1- Intersection of two arrays is: ");
            DisplayArray(intersect1);
            Console.WriteLine("\n");
            
            Console.WriteLine("Question 5-Part 2");
            int[] intersect2 = Intersect2(nums1, nums2);
            Console.WriteLine("Part 2- Intersection of two arrays is: ");
            DisplayArray(intersect2);
            Console.WriteLine("\n");
            
            Console.WriteLine("Question 6");
            char[] arr = new char[] { 'a', 'g', 'h', 'a' };
            int k = 3;
            Console.WriteLine(ContainsDuplicate(arr, k));
            
            Console.WriteLine("Question 7");
            int rodLength = 15;
            int priceProduct = GoldRod(rodLength);
            Console.WriteLine(priceProduct);
            
            Console.WriteLine("Question 8");
            string[] userDict = new string[] { "rocky", "usf", "hello", "apple" };
            string keyword = "hhllo";
            
 Console.WriteLine(DictSearch(userDict, keyword));
            Console.WriteLine("Question 8");
            SolvePuzzle();
        }
        public static void DisplayArray(int[] a)
        {
            foreach (int n in a)
            {
                Console.Write(n + " ");
            }
        }
        public static int[] TargetRange(int[] l1, int t)
        {
            try
            {
             //write your code here   
            }
            catch (Exception)
            {
                throw;
            }
            return new int[] { };
        }
        public static string StringReverse(string s)
        {
            try
            {
                //write your code here
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }
        public static int MinimumSum(int[] l2)
        {
            try
            {
                //Write your code here;
                var h = new HashSet<int>(l2); // making a set to remove duplicates
                int[] arr2 = h.ToArray();  
                if (!l2.SequenceEqual(arr2)) // if array is already distint no action
                {
                    int sum = 0;
                    //Console.WriteLine();
                    //foreach(int i in h){
                    //Console.WriteLine(i);
                    //}
                    int average = Convert.ToInt32(arr2.Average()); // taking avarage to ensure minimum sum
                    //Console.WriteLine("Average"+average);
                    foreach (int i in h)
                    {
                        if (average == i)
                        {
                            average = average + 1;

                        }
                    }


                    h.Add(average);

                    return h.Sum();
                }
                else
                {
                   return l2.Sum();
                }

            }


            

    
            catch (Exception)
            {
                throw;
            }
            return 0;
        }
        public static string FreqSort(string s2)

 {
 try
 {
 //Write Your Code Here
 }
 catch (Exception)
 {
 throw;
 }
 return null;
 }
public static int[] Intersect1(int[] nums1, int[] nums2)
{
            try
            {
                // Write your code here
                Array.Sort(nums1);
                Array.Sort(nums2);
                // Sorted both the array
                int m = nums1.Length;
                int n = nums2.Length;
                int i = 0, j = 0;
                ArrayList myAL = new ArrayList(); 


                while (i < m && j < n)
                {
                    if (nums1[i] < nums2[j])
                        i++;
                    else if (nums2[j] < nums1[i])
                        j++; // comparing elements in both the array with each other to find intersection
                    else
                    {
                        
                        myAL.Add(nums2[j++]);
                        i++;
                    }  
                    
                }
                object[] obj1 = myAL.ToArray(); 
                int[] a = new int[obj1.Length]; 
                int x = 0;
                foreach (int st in obj1)
                {
                    
                    a[x++] = st;
                }
                return a;
            }

            catch
            {
                throw;
            }
    return new int[] { };
}
public static int[] Intersect2(int[] nums1, int[] nums2)
{
            try
            {
                var Countnum = new Dictionary<int, int>(); // creating a dictionary

                foreach (var num in nums1)
                {
                    if (!Countnum.ContainsKey(num))
                    Countnum[num] = 0;
                    Countnum[num]++;
                }

                var Intersection = new List<int>();

                foreach (var num in nums2)
                {
                    if (Countnum.ContainsKey(num) && Countnum[num] > 0)
                    {
                        Intersection.Add(num);

                        Countnum[num]--;
                    }

                }
                return Intersection.ToArray();
            }

            catch
            {
                throw;
            }
    return new int[] { };
}
public static bool ContainsDuplicate(char[] arr, int k)
{
    try
    {
        //Write your code here;
    }
    catch (Exception)
    {
        throw;
    }
    return default;
}
public static int GoldRod(int rodLength)
{
    try
    {
                if (rodLength == 2)
                    return 1;
                else if (rodLength == 3)
                    return 2;
                else if (rodLength == 4)
                    return 4;
                else if (rodLength == 5)
                    return 6;
                else if (rodLength == 6)
                    return 9;
                else
                    return 3 * GoldRod(rodLength - 3); // Recursion used

            }
    catch (Exception)
    {
        throw;
    }
    return 0;
}
public static bool DictSearch(string[] userDict, string keyword)
{
    try
    {
        //Write Your Code Here

    }
    catch (Exception)
    {
        throw;
    }
    return default;
}
public static void SolvePuzzle()
{
    try
    {
        //Write Your Code Here
    }
    catch (Exception)
    {
        throw;
    }
}
 }
}
        
    
