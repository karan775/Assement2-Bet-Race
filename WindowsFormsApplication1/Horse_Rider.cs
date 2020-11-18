using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Horse_Race
{
    public class Rider
    {
       public RadioButton RBTN;
        
          public int USDaller;

             public string Name;

               public Label Labeling;

                  public Bet_Horse ThisBetOur = null;
        
       

          public void AllLabelUpdate()

     {

        if (ThisBetOur == null)

              Labeling.Text = Name + " Bet Noting";

  else

            Labeling.Text = ThisBetOur.Describe();

               RBTN.Text = Name + " Having " + USDaller + " USDaller";

   }


    public void OkBetClear(bool OverRace)

    {
            
       if (OverRace)

  {

                ThisBetOur = null;

                        }

      else

         {
  if (ThisBetOur != null)

    {
                    USDaller += ThisBetOur.moneyvalue;

                    this.ThisBetOur = null;

                            }

                else

  {
                    ThisBetOur = null;

                         }

                       }

  AllLabelUpdate();

                       }


   public bool Setting_Horse_Bet(int moneyvalue, int horse)

  {

 if (moneyvalue > USDaller)

 {
         MessageBox.Show("I Have no USDaller now for Bet", Name + " saying");

                return false;

                            }

  else

   {

     if (ThisBetOur == null)

        {

                    ThisBetOur = new Bet_Horse() { moneyvalue = moneyvalue,  Betsetting = this, horse = horse };
        this.USDaller -= moneyvalue;


        this.AllLabelUpdate();

        return true;

        }

        else

        {

               USDaller += ThisBetOur.moneyvalue;

                ThisBetOur = null;

                    ThisBetOur = new Bet_Horse() { moneyvalue = moneyvalue,  Betsetting = this, horse = horse };
                    USDaller -= moneyvalue;

                    AllLabelUpdate();

        return true;

        }

        }

        }

        static void Main()

  {

        Application.EnableVisualStyles();


        Application.SetCompatibleTextRenderingDefault(false);


        Application.Run(new Form1());

        }

        internal void Collect(int win)

        {

       

        }

        internal void OkBetClear()


        {

       


        }

    }

}
