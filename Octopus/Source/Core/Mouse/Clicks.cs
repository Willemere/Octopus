using System;
using System.Threading.Tasks;
//---------------------------
using static Octopus.Configs;
using static Octopus.Imports;
//---------------------------

namespace Octopus
{
    class Clicks
    {
        public async static void Left()
        {
            SendMessage(hWnd, 0x0201, 0, 0);
            await Task.Delay(30);
            SendMessage(hWnd, 0x0202, 0, 0);
        }

        public async static void Right()
        {
            SendMessage(hWnd, 0x0204, 0, 0);
            await Task.Delay(30);
            SendMessage(hWnd, 0x0205, 0, 0);
        }

        public async static void RightModified()
        {
            SendMessage(hWnd, 0x0204, 0, 0);
            await Task.Delay(30);
        }

        public async static void Blocked()
        {
            SendMessage(hWnd, 0x0204, 0, 0);
            await Task.Delay(30);
            SendMessage(hWnd, 0x0205, 0, 0);
        }
    }
}
