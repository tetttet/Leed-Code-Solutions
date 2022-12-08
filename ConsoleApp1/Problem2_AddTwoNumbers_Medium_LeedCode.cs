using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions {
  public class Problem2_AddTwoNumbers_Medium_LeedCode {
    /// <summary>
    /// Convert the two lists to strings, add the strings, convert the result to a list, and return the
    /// list
    /// </summary>
    /// <param name="l1">[2,4,3]</param>
    /// <param name="l2">[2,4,3]</param>
    /// <returns>
    /// A list of integers.
    /// </returns>
    public List<int> AddTwoNumbers(List<int> l1, List<int> l2) {
      List<int> result = new List<int>();
      string str1 = "";
      string str2 = "";

      //
      int length = l1.Count;
      for (int idx = 0; idx < length; ++idx) {
        str1 += l1[length - idx - 1].ToString();
      }

      //
      length = l2.Count;
      for (int idx = 0; idx < length; ++idx) {
        str2 += l2[length - idx - 1].ToString();
      }

      string res = (Convert.ToInt32(str1) + Convert.ToInt32(str2)).ToString();

      length = res.Length;
      for (int idx = 0; idx < length; ++idx) {
        result.Add(Convert.ToInt32(res[length - idx - 1].ToString()));
      }

      return result;
    }

  }
}
