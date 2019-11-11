using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace C07MTools
{
    public static class MArr
    {
        public static bool Yes(ICollection tarr)
        {
            return (tarr != null) && (tarr.Count > 0);
        }

        public static T[] LstToArr<T>(List<T> lst)
        {
            if ((lst != null) && (lst.Count > 0))
            {
                return lst.ToArray();
            }
            return null;
        }

        public static List<T> ArrToLst<T>(T[] arr)
        {
            if ((arr != null) && (arr.Length > 0))
            {
                return new List<T>(arr);
            }
            return null;            
        }
    }

    public static class MStr
    {
    }
}
