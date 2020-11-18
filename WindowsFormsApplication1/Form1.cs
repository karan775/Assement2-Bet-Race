using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Horse_Race
{
    public partial class Form1 : Form
    {
        Rider[] BetonHorse;
          s[] horse;
             Rider BetinAction;

     public Form1()
  {
      InitializeComponent();
        Random RandamlyTake = new Random();
            
          BetonHorse = new Rider[3];
               horse = new s[4];

               BetonHorse[0] = new Rider();
                BetonHorse[0].Name = "Jhony";
                 BetonHorse[0].RBTN = JhonyRButton;
                  BetonHorse[0].Labeling = JhonyBLabel;
                   BetonHorse[0].USDaller = 50;
                     BetonHorse[0].AllLabelUpdate();

                    BetonHorse[1] = new Rider();
                   BetonHorse[1].Name = "Ben";
                 BetonHorse[1].RBTN = BenRButton;
               BetonHorse[1].Labeling = BenBLabel;
              BetonHorse[1].USDaller = 75;
            BetonHorse[1].AllLabelUpdate();

            BetonHorse[2] = new Rider();
             BetonHorse[2].Name = "Andy";
              BetonHorse[2].RBTN = AndyRButton;
               BetonHorse[2].Labeling = AndyBLabel;
                BetonHorse[2].USDaller = 45;
                 BetonHorse[2].AllLabelUpdate();


         int BeginPoint = Horse1.Location.X;
           int distance = Photo.Width;
            for (int i = 0; i < 4; i++)
  {
                horse[i] = new s();

                horse[i].RandamlyTake = RandamlyTake;

                horse[i].RaceingTrackLength = distance;

                horse[i].Location = horse[i].RaceStartPoint = BeginPoint;
                                               }
 
     horse[0].BoxofImz = Horse1;

              horse[1].BoxofImz = Horse2;

                        horse[2].BoxofImz = Horse3;

                                   horse[3].BoxofImz = Horse4;

     BetinAction = BetonHorse[0];

                                                                           }

   private void TapStartRace(object sender, EventArgs e)


        {



   int RaceWinner = 0;

       int Winner_Number = 0;

          while (Winner_Number == 0)


  {

                for (int i = 0; i < horse.Length; i++)


   {
                    if (horse[i].HorseMoving())
 {

                        Winner_Number++;

                        RaceWinner = i + 1;


                                                            }
                                                       }
     Application.DoEvents();
           System.Threading.Thread.Sleep(3);

                                                                 }


    for (int i = 0; i < horse.Length; i++)

    {
                horse[i].HorseTFPoint();
            }

              string messageContent = "Congrat \n";
   
                       bool SomeoneWins = false;

                             for (int i = 0; i < BetonHorse.Length; i++)

   {

                if (BetonHorse[i].ThisBetOur.horse == RaceWinner)
    {



                    SomeoneWins = true;

                    messageContent += BetonHorse[i].Name + "\n";


                                                                     }

             BetonHorse[i].Collect(RaceWinner);

                      BetonHorse[i].OkBetClear();

                               BetonHorse[i].AllLabelUpdate();
                                                                             }

      if (SomeoneWins)


      {
                MessageBox.Show(" horse" + RaceWinner + "wins!\n" + messageContent);
            }



            if (Winner_Number > 1)


                MessageBox.Show("We have " + Winner_Number + " wins");


            else if (!SomeoneWins)


{

                MessageBox.Show(" horse " + RaceWinner + "wins!");

                                                         }
             HighLowNumber.Value = HighLowNumber.Minimum;

                        HighLowNumberHorse.Value = HighLowNumberHorse.Minimum;

                                  ResetHorseGame();
                                                        }

private void ResetHorseGame()
{
             Horse1.Location = new Point(61, 32);

                    Horse2.Location = new Point(61, 84);

                            Horse3.Location = new Point(61, 131);

                                        Horse4.Location = new Point(61, 181);


                                                                                  }

private void JhonyButton_CheckedChanged(object sender, EventArgs e)

{
                    SetBetting(0);
                                                             }

private void BenRadioButton_CheckedChanged_1(object sender, EventArgs e)

{
                  SetBetting(1);
                                                                         }

private void AndyRadioButton_CheckedChanged_1(object sender, EventArgs e)

{

                              SetBetting(2);

                                                                     }

        private void BetsButton_Click(object sender, EventArgs e)
        {
            BetinAction.Setting_Horse_Bet((int)HighLowNumber.Value, (int)HighLowNumberHorse.Value);
            BetinAction.AllLabelUpdate();
        }
        private void SetBetting(int index)
        {
            BetinAction = BetonHorse[index];
            NameLabel.Text = BetinAction.Name;
            if (BetinAction.ThisBetOur != null)
            {
                HighLowNumber.Value = BetinAction.ThisBetOur.moneyvalue;
                HighLowNumberHorse.Value = BetinAction.ThisBetOur.horse;
            }
            else
            {
                HighLowNumber.Value = HighLowNumber.Minimum;
                HighLowNumberHorse.Value = 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeastLabel.Text = "Atleast Bet $5.00";
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetHorseGame();
        }
        private void Horse1Click(object sender, EventArgs e)
        {

        }
        private void formButtonRace_Click(object sender, EventArgs e)
        {
            int RaceWinner = 0;
            int winHorse = 0;
            int count = 0;
            for (int i = 0; i < BetonHorse.Length; i++)
            {
                if (BetonHorse[1].ThisBetOur != null)
                {
                    count++;
                }
            }

            if (count == BetonHorse.Length)
            {
                while (RaceWinner == 0)
                {
                    for (int i = 0; i < horse.Length; i++)
                    {
                        if (horse[i].HorseMoving())
                        {
                            RaceWinner++;
                            winHorse = i + 1;
                            for (int i2 = 0; i2 < BetonHorse.Length; i2++)
                            {
                                BetonHorse[i2].Collect(i + 1);
                                                             }
                                                }

                        Application.DoEvents();


                        System.Threading.Thread.Sleep(3);

                                                  }
                                      }


if (RaceWinner > 1)


{


                       MessageBox.Show("WOW!", "Winner Are Many");


                }


else


                {
                           MessageBox.Show("The RaceWinner was horse Number" + winHorse);



                }


                for (int i = 0; i < BetonHorse.Length; i++)


                {


                    BetonHorse[i].OkBetClear(true);


                }


                for (int i = 0; i < horse.Length; i++)
                {
                    horse[i].HorseTFPoint();


                }
            }
            else

            {


                MessageBox.Show("Not all players have placed their bets!", "Wait wait!");


            }
        }
        private void Photo_Click(object sender, EventArgs e)



        {

        }
        private void label1_Click(object sender, EventArgs e)


        {

        }

        private void JoeBLabel_Click(object sender, EventArgs e)


        {

        }


private void Horse3_Click(object sender, EventArgs e)


        {

        }
    }
}
