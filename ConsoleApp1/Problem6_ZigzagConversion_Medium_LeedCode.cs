using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions {
  public class Problem6_ZigzagConversion_Medium_LeedCode {
    /// <summary>
    /// We use a helper array of strings to store the characters in each row. We then iterate through
    /// the string and add the characters to the helper array. We then iterate through the helper array
    /// and concatenate the strings to get the final result
    /// </summary>
    /// <param name="s">the string to convert</param>
    /// <param name="numRows">the number of rows in the zigzag pattern</param>
    /// <returns>
    /// The string that is returned is the string that is converted to the zigzag pattern.
    /// </returns>
    public string Convert(string s, int numRows) {
      string[] helper = new string[numRows];
      for (int i = 0; i < numRows; i++) {
        helper[i] = "";
      }
      int row = 0;
      int delta = 1;
      for (int i = 0; i < s.Length; i++) {
        char c = s[i];
        helper[row] += c;
        if (row == numRows - 1) {
          delta = -1;
        } else if (row == 0) {
          delta = 1;
        }
        row = row + delta;
        row = Math.Max(0, row);
      }//for
      string result = "";
      for (int i = 0; i < numRows && s.Length > 0; i++) {
        result += helper[i];
      }
      return result;
    }
  }
}
