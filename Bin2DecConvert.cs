using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bin2Dec
{
    internal class Bin2DecConvert
    {
        public static string bin2DecConvert(String text)
        {
            int decimalText = 0;
            for (int i = text.Length - 1; i > -1; i--)
            {
                decimalText += (int)Math.Pow(2, (text.Length - 1) - i) * (int)Char.GetNumericValue(text[i]);
            }
            return decimalText.ToString();
        }
    }
}
