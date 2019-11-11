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
    }
}
