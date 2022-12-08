using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions {
  public class Problem14_LongestCommonPrefix_Easy_LeedCode {

    /// <summary>
    /// from container of string[]
    /// find longest prefix of word (string)
    /// </summary>
    /// <param name="strs"></param>
    /// <returns>
    /// return longest prefix of words in container
    /// </returns>
    public string LongestCommonPrefix(string[] strs) {
      int length = strs.Length;
      if (length == 0) return "";
      if (length == 1) return strs[0];

      int count = strs[0].Length;
      string answer = strs[0];
      for (int i = 1; i < length; i++) {
        int strsLength = strs[i].Length;
        for (int j = 0; j < count; j++) {

          if (j == strsLength || strs[i][j] != answer[j]) {
            answer = answer.Substring(0, j);
            count = answer.Length;
            if (count == 0) return "";
            break;
          }
        }
      }

      return answer;
    }

  }
}