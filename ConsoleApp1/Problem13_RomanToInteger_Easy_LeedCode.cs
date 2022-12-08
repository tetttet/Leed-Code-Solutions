using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions {
  public class Problem13_RomanToInteger_Easy_LeedCode {


    /// <summary>
    /// A dictionary that maps the roman numerals to their integer values
    /// </summary>
    private static Dictionary<char, int> _romanMap = new Dictionary<char, int>
    {
       {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
    };


   /// <summary>
   /// We iterate through the string, and if the current value is greater than the previous value, we
   /// subtract the previous value twice from the total value
   /// </summary>
   /// <param name="text">The string to convert to an integer.</param>
   /// <returns>
   /// The total value of the Roman Numeral.
   /// </returns>
    public int RomanToInt(string text) {
      int totalValue = 0, prevValue = 0;
      foreach (var c in text) {
        if (!_romanMap.ContainsKey(c))
          return 0;
        var crtValue = _romanMap[c];
        totalValue += crtValue;
        if (prevValue != 0 && prevValue < crtValue) {
          if (prevValue == 1 && (crtValue == 5 || crtValue == 10)
              || prevValue == 10 && (crtValue == 50 || crtValue == 100)
              || prevValue == 100 && (crtValue == 500 || crtValue == 1000))
            totalValue -= 2 * prevValue;
          else
            return 0;
        }
        prevValue = crtValue;
      }
      return totalValue;
    }

  }
}
