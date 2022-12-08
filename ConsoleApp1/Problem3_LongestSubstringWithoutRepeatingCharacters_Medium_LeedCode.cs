using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions {
  public class Problem3_LongestSubstringWithoutRepeatingCharacters_Medium_LeedCode {
    /// <summary>
    /// For each character in the string, we check if the character is already in the substring. If it
    /// is, we move on to the next character. If not, we add the character to the substring and check
    /// the length of the substring. If the length of the substring is greater than the length of the
    /// longest substring, we update the length of the longest substring
    /// </summary>
    /// <param name="s">the string to be evaluated</param>
    /// <returns>
    /// The length of the longest substring without repeating characters.
    /// </returns>
    public int LengthOfLongestSubstring(string s) {
      int n = s.Length;
      int res = 0;

      List<char> array = new List<char>();
      for (int idx1 = 0; idx1 < n; ++idx1) {
        for (int idx2 = idx1; idx2 < n; ++idx2) {
          if (array.Contains((s[idx2]))) {
            array.Clear();
            break;
          } else {
            array.Add((s[idx2]));
            if (res < idx2 - idx1 + 1) {
              res = idx2 - idx1 + 1;
            }

          }
        }

      }
      return res;
    }
  }
}