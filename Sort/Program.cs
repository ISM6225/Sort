using System;

namespace Sort
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] selection_sort_numbers = { 7, 45, 4, 12, 22, 555, 1, 2, 999, 7 };
            int[] bubble_sort_numbers = { 22, 3, 77, 16, 777, 6, 9, 43, 899, 7 };
            Console.WriteLine("Here is the original array that will be used to execute the Selection Sort Algorithm: ");
            for(int i = 0;i < selection_sort_numbers.Length;i++)
                {
                    Console.Write("  " + selection_sort_numbers[i]);
                }
            Console.WriteLine("");
            Console.WriteLine("Here is the array after the execution of the Selection Sort Algorithm: ");
            Selection_Sort(selection_sort_numbers);
            Console.WriteLine("");
            Console.WriteLine("Here is the original array that will be used to execute the Bubble Sort Algorithm: ");
            for (int i = 0; i < bubble_sort_numbers.Length; i++)
            {
                Console.Write("  " + bubble_sort_numbers[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Here is the array after the execution of the Bubble Sort Algorithm: ");
            Bubble_Sort(bubble_sort_numbers);
            for(int i = 0; i < bubble_sort_numbers.Length; i++)
            {
                Console.Write("  " + bubble_sort_numbers[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit the program ...");
            Console.ReadKey(true);
        }
        /*
            Since there are two nested loops included in this algrorithm, we would
            describe its time complexity (or Big O notation) as O(n^2). The advantage it
            has over the Bubble Sort is that it never makes more than O(n) swaps. 
            So, less data is required to write to memory during the swap process.
        */
        static void Selection_Sort(int[] ss_arr)
        {
            // min_position is used to keep track of the element position with the current lowest value
            int min_position;
            // temp is used to conduct the swap during during the Selection Sort Algorithm
            int temp;

            for (int i = 0; i < ss_arr.Length; i++)
            {
                // Here we initialize the min_position to the current index of array
                min_position = i;
                // From the min_position, check to see if the next element is smaller
                for (int x = i + 1; x < ss_arr.Length; x++)
                {
                    // If the next element from the current min_position is smaller, then make that the new min_position
                    if (ss_arr[x] < ss_arr[min_position])
                    {
                        //min_position will keep track of the index that min is in, this is needed when a swap happens
                        min_position = x;
                    }
                } // End of inner for loop

                // If the min_position does not equal the current element being evaluated in the loop
                // Then execute the swap. by switching the postion of the lowest with the current element
                if (min_position != i)
                {
                    temp = ss_arr[i];
                    ss_arr[i] = ss_arr[min_position];
                    ss_arr[min_position] = temp;
                }
                Console.Write("  " + ss_arr[i]);
            } // End of outer for loop
        } // End of Selection_Sort

        // This method executes the Bubble Sort Algorithm with a worst case of time complexity (Big O Notation) of O(n^2)
        static void Bubble_Sort(int [] bs_arr)
        {
            // The for loop will continue until the array is sorted in ascending order.
            // Bubble Sort starts from the beginning of the array each for loop iteration and checks the value
            // of the next element in the array to see if it is less. If it is less, then swap.
            for (int i = 0; i < bs_arr.Length - 1; i++)
            {
                for (int x = 0; x < bs_arr.Length - i - 1; x++)                  
                {
                    // In each nested for loop iteration check to see if the next element value is lower than the current element value
                    // If the next element value is less, then conduct the swap
                    if (bs_arr[x] > bs_arr[x + 1])
                    {
                        // Here you will swap temp and bs_arr[x]
                        // The temp variable is used to temporarily hold the value of the current element so that it can be swapped
                        int temp = bs_arr[x];
                        bs_arr[x] = bs_arr[x + 1];
                        bs_arr[x + 1] = temp;
                    } // End of if
                } // End of inner for loop
            } // End of outer for loop
        }
    }
}