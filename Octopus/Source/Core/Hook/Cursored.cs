using System.Runtime.InteropServices;
//---------------------------
using static Octopus.Imports;
//---------------------------

namespace Octopus
{
    class Cursored
    {
        public static bool InMenu()
        {
            return IsCursorVisible();
        }

        public static bool IsCursorVisible()
        {
            CursorInfoStruct pci = new CursorInfoStruct { cbSize = Marshal.SizeOf(typeof(CursorInfoStruct)) };

            GetCursorInfo(ref pci);
            if (pci.hCursor.ToInt32() > 100000)
            {
                return false;
            }

            return true;
        }
    }
}
