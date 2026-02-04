using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise51_60
{
    internal class Exercise59
    {
        public static void Run()
        {
            int[] nums1 = { 1, 3, 2, 4 };
            int[] nums2 = { 1, 3, 2, 1 };
            int[] nums3 = { 1, 2, 3, 4 };

            Console.WriteLine(CanBeIncreasing(nums1));
            Console.WriteLine(CanBeIncreasing(nums2));
            Console.WriteLine(CanBeIncreasing(nums3));
        }

        static bool CanBeIncreasing(int[] nums)
        {
            int count = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] <= nums[i - 1])
                {
                    count++;
                    if (count > 1)
                        return false;
                    if (i > 1 && nums[i] <= nums[i - 2])
                    {
                        nums[i] = nums[i - 1];
                    }
                }
            }

            return true;
        }
    }
}
