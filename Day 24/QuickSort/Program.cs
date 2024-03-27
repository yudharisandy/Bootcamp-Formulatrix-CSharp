using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(){
        // ----------------------------------------------------
        // 1. Receive inputs
        List<int> nums1 = new List<int>{1, 2, 3, 0, 0, 0};
        System.Console.Write("Problem1: ");
        Print(nums1);
        int m = 3;
        List<int> nums2 = new List<int>{2, 5, 6};
        System.Console.Write("Problem2: ");
        Print(nums2);
        int n = 3;

        // 2. Merging
        Merge(nums1, m, nums2, n);
        System.Console.Write("Merged: ");
        Print(nums1);

        // 3. Sorting
        List<int> sortedNums = QuickSort(nums1);
        System.Console.Write("Sorted: ");
        Print(sortedNums);
        System.Console.WriteLine();

        // -----------------------------------------------------

        List<int> nums3 = new List<int>{9, 2, 5, 3, 0, 0, 0};
        System.Console.Write("Problem1: ");
        Print(nums3);
        int o = 4;
        List<int> nums4 = new List<int>{7, 2, 4, 6, 1};
        System.Console.Write("Problem2: ");
        Print(nums4);
        int p = 5;

        Merge(nums3, o, nums4, p);
        System.Console.Write("Merged: ");
        Print(nums3);

        List<int> sortedNums2 = QuickSort(nums3);
        System.Console.Write("Sorted: ");
        Print(sortedNums2);
        System.Console.WriteLine();
    }

    static void Merge(List<int> nums1, int m, List<int> nums2, int n){
        int temp = nums1.Count - m;
        for(int i = 0; i < temp; i++){
            nums1.Remove(nums1[nums1.Count - 1]);
        }
        for(int i = 0; i < n; i++){
            nums1.Add(nums2[i]);
        }
    }

    static List<int> QuickSort(List<int> nums){
        if(nums.Count <= 1){
            return nums;
        }
        int pivot = nums[0];
        // System.Console.WriteLine(pivot);
        List<int> left = new();
        List<int> right = new();

        for(int i = 1; i < nums.Count; i++){
            if (nums[i] < pivot){
                left.Add(nums[i]);
            }
        }

        for(int i = 1; i < nums.Count; i++){
            if (nums[i] >= pivot){ // Bug
                right.Add(nums[i]);
            }
        }
        
        List<int> pivots = new List<int>{pivot};
        List<int> newLeft = QuickSort(left);
        List<int> newRight = QuickSort(right);
        newLeft.AddRange(pivots);
        newLeft.AddRange(newRight);
        return newLeft;

    }

    static void Print(List<int> nums){
        foreach(int i in nums){
            System.Console.Write(i + ", ");
        }
        System.Console.WriteLine();
    }
}