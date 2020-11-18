using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Drawing;
using System.Windows.Forms;

namespace Horse_Race
{
    public class s
    {
        public int RaceStartPoint;
        public int Location = 0;

        public Random RandamlyTake;
        public int RaceingTrackLength;
        public PictureBox BoxofImz = null; 
        

        public bool HorseMoving()
        {
        int HorseForwardmove = RandamlyTake.Next(1, 4);
        Point p = BoxofImz.Location;
        p.X += HorseForwardmove;
        BoxofImz.Location = p;
        if (p.X >= RaceingTrackLength)
        return true;
        else
        return false;
        }

        public void HorseTFPoint()
        {
            RaceStartPoint = 0;
        }
    }
}