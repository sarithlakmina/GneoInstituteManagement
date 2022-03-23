using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GneoCommonDataLibrary.Common
{
    public class RegIDGenerator
    {
        public static string GenerateID(string currentID)
        {
            int val = int.Parse(currentID.Substring(3));
            val++;
            return currentID.Substring(0, 3) + val.ToString().PadLeft(3, '0');
        }
    }
}
