using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions {
  public class Problem9_PalindromeNumber_Easy_LeedCode {

    /// <summary>
    /// just use method of class string
    /// </summary>
    /// <param name="x"></param>
    /// <returns>
    /// boolean -> true / false
    /// </returns>
    public bool IsPalindrome(int x) {
      string myString = Convert.ToString(x);
      return myString.SequenceEqual(myString.Reverse());
    }

  }
}
