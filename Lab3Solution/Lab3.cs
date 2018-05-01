using System;

namespace Lab3Solution
{
    class Lab3
    {
        static int[] intArray = {17,  166,  288,  324,  531,  792,  946,  157,  276,  441, 533, 355, 228, 879, 100, 421, 23, 490, 259, 227,
                                 216, 317, 161, 4, 352, 463, 420, 513, 194, 299, 25, 32, 11, 943, 748, 336, 973, 483, 897, 396,
                                 10, 42, 334, 744, 945, 97, 47, 835, 269, 480, 651, 725, 953, 677, 112, 265, 28, 358, 119, 784,
                                 220, 62, 216, 364, 256, 117, 867, 968, 749, 586, 371, 221, 437, 374, 575, 669, 354, 678, 314, 450,
                                 808, 182, 138, 360, 585, 970, 787, 3, 889, 418, 191, 36, 193, 629, 295, 840, 339, 181, 230, 150 };


        static void Main(string[] args)
        {
            // Variables
            int[] haystack = intArray;
            int[] arr = intArray;

            // Linear search
            // Display unsorted array
            Console.WriteLine("The unsorted integer array is:\n");
            PrintArray(arr);

            // User input
            Console.Write("\n\nEnter an integer: ");

            // Variables
            int numOfComparison = 0;
            int niddle = int.Parse(Console.ReadLine());
            int niddleIndex = LinearSearch(haystack, niddle, ref numOfComparison);

            // Output
            if (niddleIndex != -1)
            {
                Console.WriteLine("\nLinear search made " + numOfComparison + " comparisons to find out that " + niddle + " is at index " + niddleIndex + " in this unsorted array.");
            } else
            {
                Console.WriteLine("\nLinear search made " + numOfComparison + " comparisons to find out that " + niddle + " is not in the unsorted array.");
            }
            
            // Bubble sort
            // Display sorted array
            Console.WriteLine("\nBubble sort made " + BubbleSort(arr) + " swaps to sort this array\n\nThe sorted array is: \n");
            PrintArray(arr);


            // Binary search
            // User input
            Console.Write("\nEnter an integer: ");

            // Variables
            niddle = int.Parse(Console.ReadLine());
            numOfComparison = 0;
            niddleIndex = BinarySearch(haystack, niddle, ref numOfComparison);
            
            // Output
            if (niddleIndex != -1)
            {
                Console.Write("\nThe binary search made " + numOfComparison + " comparisons to find out that " + niddle + " is at index " + niddleIndex + " in the sorted array");
            } else
            {
                Console.Write("\nThe binary search made " + numOfComparison + " comparisons to find out that " + niddle + " is not in the sorted array.");
            }

            // Exit
            Console.WriteLine("\n\nPress Enter to exit.");
            string exit = Console.ReadLine();
            if (exit == "")
            {
                Environment.Exit(0);
            }
        }
        //This method returns the index of a given niddle (an int) in the haystack (an int array)
        //by using linear search. It also returns the value of the number of comparison used to 
        //find the given niddle through the reference parameter numOfComparison.
        static int LinearSearch(int[] haystack, int niddle, ref int numOfComparison)
        {
            int niddleIndex = -1;

            // Based on solution showed in class
            //Here you search the niddle in the haystack.

            for (int i = 0; i < haystack.Length; i++)
            {
                numOfComparison++;
                if (haystack[i] == niddle)
                {
                    return i;
                }
            }
            return niddleIndex;
        }

        
        static int BubbleSort(int[] arr)
        {
            int numOfSwaps = 0;
            // https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-3.php
            //Here you implement the bubble sort to sort the integer array arr.
            for (int i = 0; i <= (arr.Length - 2); i++){
                for (int j = 0; j <= (arr.Length - 2); j++){
                    if(arr[j] > arr[j + 1])
                    {
                        int x = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = x;
                        numOfSwaps++;
                    }
                }
            }
            return numOfSwaps;
        }

        //This method returns the index of a given niddle (an int) in the haystack (an int array)
        //by using binary search. It also returns the value of the number of comparison used to 
        //find the given niddle through the reference parameter numOfComparison.
        static int BinarySearch(int[] haystack, int niddle, ref int numOfComparison)
        {
            int niddleIndex = -1;

            //Based on solution showed in class
            //Here you implement the binary search to find the niddle in the haystack.
            int low = 0;
            int high = haystack.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                numOfComparison++;
                if(haystack[mid] > niddle)
                {
                    high = mid - 1;
                    continue;
                } else if(haystack[mid] < niddle)
                {
                    low = mid + 1;
                    continue;
                } else
                {
                    return mid;
                }
            }

                return niddleIndex;
        }
        //call this method to print an integer array to the console.
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != arr.Length - 1)
                {
                    Console.Write("{0}, ", arr[i]);
                }
                else
                {
                    Console.Write("{0} ", arr[i]);
                }
            }
            Console.WriteLine();
        }


    }
}
