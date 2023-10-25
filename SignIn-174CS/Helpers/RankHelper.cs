using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn_174CS.Helpers
{
    internal class RankHelper
    {
        public static bool IsValidRank(string rank)
        {
            if (rank.Equals("ab", StringComparison.OrdinalIgnoreCase) || rank.Equals("e1", StringComparison.OrdinalIgnoreCase) || rank.Equals("e-1", StringComparison.OrdinalIgnoreCase)) return true;
            if (rank.Equals("amn", StringComparison.OrdinalIgnoreCase) || rank.Equals("e2", StringComparison.OrdinalIgnoreCase) || rank.Equals("e-2", StringComparison.OrdinalIgnoreCase)) return true;
            if (rank.Equals("a1c", StringComparison.OrdinalIgnoreCase) || rank.Equals("e3", StringComparison.OrdinalIgnoreCase) || rank.Equals("e-3", StringComparison.OrdinalIgnoreCase)) return true;
            if (rank.Equals("sra", StringComparison.OrdinalIgnoreCase) || rank.Equals("e4", StringComparison.OrdinalIgnoreCase) || rank.Equals("e-4", StringComparison.OrdinalIgnoreCase)) return true;
            if (rank.Equals("ssgt", StringComparison.OrdinalIgnoreCase) || rank.Equals("e5", StringComparison.OrdinalIgnoreCase) || rank.Equals("e-5", StringComparison.OrdinalIgnoreCase)) return true;
            if (rank.Equals("tsgt", StringComparison.OrdinalIgnoreCase) || rank.Equals("e6", StringComparison.OrdinalIgnoreCase) || rank.Equals("e-6", StringComparison.OrdinalIgnoreCase)) return true;
            if (rank.Equals("msgt", StringComparison.OrdinalIgnoreCase) || rank.Equals("e7", StringComparison.OrdinalIgnoreCase) || rank.Equals("e-7", StringComparison.OrdinalIgnoreCase)) return true;
            if (rank.Equals("smsgt", StringComparison.OrdinalIgnoreCase) || rank.Equals("e8", StringComparison.OrdinalIgnoreCase) || rank.Equals("e-8", StringComparison.OrdinalIgnoreCase)) return true;
            if (rank.Equals("cmsgt", StringComparison.OrdinalIgnoreCase) || rank.Equals("e9", StringComparison.OrdinalIgnoreCase) || rank.Equals("e-9", StringComparison.OrdinalIgnoreCase)) return true;
            if (rank.Equals("2nd lt", StringComparison.OrdinalIgnoreCase) || rank.Equals("o1", StringComparison.OrdinalIgnoreCase) || rank.Equals("o-1", StringComparison.OrdinalIgnoreCase)) return true;
            if (rank.Equals("1st lt", StringComparison.OrdinalIgnoreCase) || rank.Equals("o2", StringComparison.OrdinalIgnoreCase) || rank.Equals("o-2", StringComparison.OrdinalIgnoreCase)) return true;
            if (rank.Equals("capt", StringComparison.OrdinalIgnoreCase) || rank.Equals("o3", StringComparison.OrdinalIgnoreCase) || rank.Equals("o-3", StringComparison.OrdinalIgnoreCase)) return true;
            if (rank.Equals("maj", StringComparison.OrdinalIgnoreCase) || rank.Equals("o4", StringComparison.OrdinalIgnoreCase) || rank.Equals("o-4", StringComparison.OrdinalIgnoreCase)) return true;
            if (rank.Equals("lt col", StringComparison.OrdinalIgnoreCase) || rank.Equals("o5", StringComparison.OrdinalIgnoreCase) || rank.Equals("o-5", StringComparison.OrdinalIgnoreCase)) return true;
            if (rank.Equals("col", StringComparison.OrdinalIgnoreCase) || rank.Equals("o6", StringComparison.OrdinalIgnoreCase) || rank.Equals("o-6", StringComparison.OrdinalIgnoreCase)) return true;
            if (rank.Equals("brig gen", StringComparison.OrdinalIgnoreCase) || rank.Equals("o7", StringComparison.OrdinalIgnoreCase) || rank.Equals("o-7", StringComparison.OrdinalIgnoreCase)) return true;
            if (rank.Equals("maj gen", StringComparison.OrdinalIgnoreCase) || rank.Equals("o8", StringComparison.OrdinalIgnoreCase) || rank.Equals("o-8", StringComparison.OrdinalIgnoreCase)) return true;
            if (rank.Equals("lt gen", StringComparison.OrdinalIgnoreCase) || rank.Equals("o9", StringComparison.OrdinalIgnoreCase) || rank.Equals("o-9", StringComparison.OrdinalIgnoreCase)) return true;
            if (rank.Equals("gen", StringComparison.OrdinalIgnoreCase) || rank.Equals("o10", StringComparison.OrdinalIgnoreCase) || rank.Equals("o-10", StringComparison.OrdinalIgnoreCase)) return true;
            return false;
        }
    }
}
