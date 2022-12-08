using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions {
  public class Problem20_ValidParentheses_Easy_LeedCode {

    /// <summary>
    /// If the item is a closing bracket, return the corresponding opening bracket. 
    /// Otherwise, return a space
    /// </summary>
    /// <param name="item">The current character in the string</param>
    /// <returns>
    /// The complement of the bracket.
    /// </returns>
    private char GetComplementBracket(char item) {
      switch (item) {
        case ')':
          return '(';
        case '}':
          return '{';
        case ']':
          return '[';
        default:
          return ' ';
      }
    }

    /// <summary>
    /// We iterate through the string and push the opening brackets onto a stack. When we encounter a
    /// closing bracket, we check if the top of the stack is the corresponding opening bracket. If it
    /// is, we pop the opening bracket off the stack. If it isn't, we return false
    /// </summary>
    /// <param name="str">The string to be validated.</param>
    /// <returns>
    /// A boolean value.
    /// </returns>
    public bool IsValid(string str) {
      Stack<char> stack = new Stack<char>();
      foreach (var item in str.ToCharArray()) {
        if (item == '(' || item == '{' || item == '[') {
          stack.Push(item);
        } else if (item == ')' || item == '}' || item == ']') {
          if (stack.Peek() != GetComplementBracket(item)) {
            return false;
          }
        }
      }
      return true;
    }
  }
}
