using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigZagConversion
{
    public class ZigZagConversion
    {
        /// <summary>
        /// The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this:
        ///  P   A   H   N
        ///  A P L S I I G
        ///  Y   I   R
        /// </summary>
        /// <param name="s"></param>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public string Convert(string s, int numRows)
        {
            if (1 >= numRows)
            {
                return s;
            }
            // Use StringBuilder to avoid usage of additional memory
            var returnStr = new StringBuilder();
            var waveLength = (numRows - 1)*2;
            var arrayStr = s.ToArray();
            for (int i = 0; i < numRows; ++i)
            {
                for (int j = 0; j < s.Length; j += waveLength)
                {
                    if (j+i<s.Length)
                    {

                        returnStr.Append(arrayStr[j+i]);
                        if (i != 0 && i != numRows - 1)
                        {
                            if (j + waveLength - i < s.Length)
                            {
                                returnStr.Append(arrayStr[j + waveLength - i]);
                            }
                        }
                    }
                }
            }
            return returnStr.ToString();
        }
    }
}
