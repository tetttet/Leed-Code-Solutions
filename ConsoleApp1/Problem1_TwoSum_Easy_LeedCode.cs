using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions {

  public class Problem1_TwoSum_Easy_LeedCode {

    /// <summary>
    /// go in for cycle and find el by el
    /// when check, also check idx1 != idx2
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int[] TwoSum(int[] nums, int target) {
      int[] result = new int[2];

      for (int elIndex = 0; elIndex < nums.Length; elIndex++) {
        for (int elIdx = 0; elIdx < nums.Length; elIdx++) {
          if (nums[elIndex] + nums[elIdx] == target && elIndex != elIdx) {
            result[0] = elIndex;
            result[1] = elIdx;
            return result;
          }
        }
      }

      return result;
    }

  }
}
