using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Horse_Race
{
    public class Bet_Horse
    {
        public int moneyvalue; 
        public int horse;
        public Rider  Betsetting;

        

    public int GiveMoney(int PersonWin)
        {
                     if (PersonWin == horse)
    {
                int GiveMoney = moneyvalue * 2;
            return GiveMoney;
                      }
     else
   {
                int GiveMoney = 0;
                return GiveMoney;
                                 }
                              } 
     public string Describe()
   {
            if (moneyvalue > 0)
                return  Betsetting.Name + " bets " + moneyvalue + " bucks on horse #" + horse;
            else
                return  Betsetting.Name + " not placed a bet";
        }
    }
}