using System;
using System.Drawing;
//---------------------------
using static Octopus.Configs;
using static Octopus.Imports;
//---------------------------

namespace Octopus
{
    class Jitter
    {

        public static void Flicker(Guna.UI2.WinForms.Guna2ProgressBar trackbar, Point previousPosition)
        {
            random = new Random();  

            xAxis = random.Next(trackbar.Value / 8, trackbar.Value / 4);

            double direction = random.NextDouble() * 360;

            double frequency = 2 * Math.PI / 360;
            int x = (int)(xAxis * Math.Sin(direction * frequency));
            int y = (int)(xAxis * Math.Cos(direction * frequency));

            int noiseX = random.Next(-trackbar.Value / 2, trackbar.Value / 2);
            int noiseY = random.Next(-trackbar.Value / 2, trackbar.Value / 2);
            x += noiseX;
            y += noiseY;


            GetCursorPos(out currentPosition);

            if (previousPosition == null)
            {
                previousPosition = currentPosition;
            }

            mouse_event(0x0001, x, y, 0, 0);

            previousPosition = currentPosition;
        }
    }
}
