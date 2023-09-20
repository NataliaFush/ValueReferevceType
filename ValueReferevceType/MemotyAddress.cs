using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ValueReferevceType
{
    public static class MemoryAddress
    {
        public static unsafe string Get(object a)
        {
            TypedReference tr = __makeref(a);
            IntPtr ptr = **(IntPtr**)(&tr);
            return "0x" + ptr.ToString("X");
        }

        public static unsafe string Get(ref object a)
        {
            TypedReference tr = __makeref(a);
            IntPtr ptr = **(IntPtr**)(&tr);
            return "0x" + ptr.ToString("X");
        }
    }
}
