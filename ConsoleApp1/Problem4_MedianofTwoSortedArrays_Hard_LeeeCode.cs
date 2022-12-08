using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions {
  public class Problem4_MedianofTwoSortedArrays_Hard_LeeeCode {
    /// <summary>
    /// It returns the average of the two arrays.
    /// </summary>
    /// <param name="nums1">[1, 2]</param>
    /// <param name="nums2">[1, 2]</param>
    /// <returns>
    /// The sum of the two arrays divided by the length of the two arrays.
    /// </returns>
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
      // long -> (long)
      return (nums1.Sum() + nums2.Sum()) / (nums1.Length + nums2.Length);
    }
  }
}
