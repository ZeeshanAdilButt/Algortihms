using System;
using System.Linq;

namespace Array_01_Hard_MedianOfSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program obj = new Program();

            var median = obj.FindMedianSortedArrays(new int[]{3}, new int[] {-2,-1});

            Console.WriteLine(median);
        }


        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {

            if (nums1.Length == 0 && nums2.Length == 0)
                return 0;

            if (nums1.Length == 0 && nums2.Length != 0)
                return getMedian(nums2);

            if (nums2.Length == 0 && nums1.Length != 0)
                return getMedian(nums1);

            if (nums2.Length == 1 && nums1.Length == 1)
                return nums1[0] + nums2[0] / 2;

            if (nums1.Length == 2 && nums2.Length == 2)
                return (double)(Math.Max(nums1[0], nums2[0]) + Math.Min(nums1[1], nums2[1])) / 2;


            double medianOfArray1 = getMedian(nums1);
            double medianOfArray2 = getMedian(nums2);

            if (medianOfArray1 == medianOfArray2)
                return medianOfArray1;


            int midIndexarr1 = getMidIndex(nums1);
            int midIndexarr2 = getMidIndex(nums2);

            if (medianOfArray1 < medianOfArray2)
            {

                return FindMedianSortedArrays(nums1.Skip(midIndexarr1 + 1).ToArray(), nums2.Take(midIndexarr2 + 1).ToArray());
            }
            else
            {
                return FindMedianSortedArrays(nums1.Take(midIndexarr1 + 1).ToArray(), nums2.Skip(midIndexarr2 + 1).ToArray());
            }

            return 0;

        }

        public int getMidIndex(int[] arr)
        {

            if (arr.Length == 0)
                return 0;

            if (arr.Length % 2 == 0)
            {
                return (int)arr.Length / 2 - 1;
            }
            //if odd
            else
            {
                return (int)arr.Length / 2;
            }

        }

        public double getMedian(int[] arr)
        {

            if (arr.Length == 0)
                return arr[0];

            //if even
            if (arr.Length % 2 == 0)
            {
                //{1,2} 
                // n = 2
                // => n/2 => index 1 (2) 
                // n/2 - 1 = index 0 (1)
                return (double)(arr[arr.Length / 2] + arr[arr.Length / 2 - 1]) / 2;
            }
            //if odd
            else
            {
                return arr[arr.Length / 2];
            }
        }
    }

}
