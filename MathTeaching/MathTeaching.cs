using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Threading;

namespace MathTeaching
{
    public partial class MathTeaching : Form
    {
        int TimeLeft;
        int StreakAnswerd = 0;
        int CorrectAnswerd;
        int FalseAnswerd;
        int Answer;
        int HardnessLevel;
        int MathType;
        int MaxAttempts;
        int CAnswer;


        Vector NumberMinMAx = new Vector();
        Vector GeneratedNumbers = new Vector();

        public MathTeaching()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.AcceptButton = this.BtnValidate;
        }

        private void MathTeaching_Load(object sender, EventArgs e)
        {
            // Set the selected index to 0 (Addition)
            CbMathOption.SelectedIndex = 0;
            CbMaxAttempts.SelectedIndex = 0;
            CbTimeOption.SelectedIndex = 0;
            CbDifficulty.SelectedIndex = 0;

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSecondsLeft.Text = TimeLeft.ToString();
            TimeLeft--;

            if(TimeLeft < 0)
            {
                timer1.Stop();
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show("Sorry time's up\nPress OK to restart", "Your time is up");

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    // Closes the parent form.
                    reset();
                }
            }
        }

        private void BtnValidate_Click(object sender, EventArgs e)
        {
            checkAnswer();
        }

        private void checkAnswer()
        {
            try
            {
                Answer = Convert.ToInt32(TbAnswer.Text);

                if (Answer == CAnswer)
                {
                    CorrectAnswerd++;
                    StreakAnswerd++;

                    lblCorrectAnswerd.Text = CorrectAnswerd.ToString();
                    lblStreakAnswerd.Text = StreakAnswerd.ToString();
                    TimeLeft += 5;

                    newProblem();
                    TbAnswer.Clear();


                }
                else
                {
                   
                    FalseAnswerd++;
                    StreakAnswerd = 0;

                    lblStreakAnswerd.Text = StreakAnswerd.ToString();
                    lblFalseAnswerd.Text = FalseAnswerd.ToString();
                    TimeLeft -= 2;

                    if (MaxAttempts <= 0)
                    {
                        DialogResult result;

                        // Displays the MessageBox.

                        result = MessageBox.Show("Sorry to many false answers\nPress OK to restart", "You lost");

                        if (result == System.Windows.Forms.DialogResult.OK)
                        {
                            // Closes the parent form.
                            reset();
                        }
                    }

                    MaxAttempts--;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newProblem()
        {
            #region declaring a list with relative names for hardness
            var dictLevel = new Dictionary<string, int>();
            dictLevel["Easy"] = 0;
            dictLevel["Easy-Normal"] = 1;
            dictLevel["Normal"] = 2;
            dictLevel["Hard"] = 3;
            dictLevel["Over 9000"] = 4;
            dictLevel["Super Sayen God Goku"] = 5;
            #endregion

            #region declaring a list with number for math type
            var dictMathType = new Dictionary<string, int>();
            dictMathType["Addition"] = 0;
            dictMathType["Subtraction"] = 1;
            dictMathType["Mulitiplication"] = 2;
            dictMathType["Division"] = 3;
            #endregion

            #region declaring a list with char for math type
            var dictMathChar = new Dictionary<string, string>();
            dictMathChar["Addition"] = "+";
            dictMathChar["Subtraction"] = "-";
            dictMathChar["Mulitiplication"] = "*";
            dictMathChar["Division"] = "/";
            #endregion

            #region Setting all the init vars;
            HardnessLevel = dictLevel[CbDifficulty.Text];
            MathType = dictMathType[CbMathOption.Text];
            MaxAttempts = Convert.ToInt32(CbMaxAttempts.Text);
            GeneratedNumbers = GetNumbers();
            CAnswer = GetAnswer(GeneratedNumbers, MathType);
            #endregion

            #region Displayng the numbers and math type on the screen
            lblNumberOne.Text = GeneratedNumbers.X.ToString();
            lblNumberTwo.Text = GeneratedNumbers.Y.ToString();
            lblMathType.Text = dictMathChar[CbMathOption.Text];
            #endregion
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            newProblem();

            #region Switch for getting min max numbers for the game.
            switch (HardnessLevel)
            {
                case 0:
                    NumberMinMAx.X = 1;
                    NumberMinMAx.Y = 10;
                    break;
                case 1:
                    NumberMinMAx.X = 1;
                    NumberMinMAx.Y = 15;
                    break;
                case 2:
                    NumberMinMAx.X = 1;
                    NumberMinMAx.Y = 50;
                    break;
                case 3:
                    NumberMinMAx.X = 50;
                    NumberMinMAx.Y = 500;
                    break;
                case 4:
                    NumberMinMAx.X = 100;
                    NumberMinMAx.Y = 5000;
                    break;
                case 5:
                    NumberMinMAx.X = 120;
                    NumberMinMAx.Y = 100000;
                    break;

                default:
                    NumberMinMAx.X = 1;
                    NumberMinMAx.Y = 100;
                    break;
            }
            #endregion


            timer1.Enabled = true;
            timer1.Start();

            TimeLeft = Convert.ToInt32(CbTimeOption.Text);
            MaxAttempts = Convert.ToInt32(CbMaxAttempts.Text);

            BtnStart.Enabled = false;


        }

        private int GetAnswer(Vector mGeneratedNumbers, int mMathType)
        {
            int mResult = 0;

            switch (mMathType)
            {
                case 0:
                    mResult = Convert.ToInt32(mGeneratedNumbers.X) + Convert.ToInt32(mGeneratedNumbers.Y);
                    break;
                case 1:
                    mResult = Convert.ToInt32(mGeneratedNumbers.X) - Convert.ToInt32(mGeneratedNumbers.Y);
                    break;
                case 2:
                    mResult = Convert.ToInt32(mGeneratedNumbers.X) * Convert.ToInt32(mGeneratedNumbers.Y);
                    break;
                case 3:
                    mResult = Convert.ToInt32(mGeneratedNumbers.X) / Convert.ToInt32(mGeneratedNumbers.Y);
                    break;
            }
            
            return mResult;
        }

        public Vector GetNumbers()
        {
            Vector temp = new Vector();
            temp.X = GenerateRandomNumber(Convert.ToInt32(NumberMinMAx.X) + 1, Convert.ToInt32(NumberMinMAx.Y) + 1);
            temp.Y = GenerateRandomNumber(Convert.ToInt32(NumberMinMAx.X) + 1, Convert.ToInt32(NumberMinMAx.Y) + 1);

            return temp;
        }

        private static int GenerateRandomNumber(int min, int max)
        {
            // Sleep 1 millisecond, because Seed needs another value
            Thread.Sleep(1);
            int temp = new System.Random(DateTime.Now.Millisecond).Next(min, max);
            return temp;
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            reset();

        }

        private void reset()
        {
            CbMathOption.SelectedIndex = 0;
            CbMaxAttempts.SelectedIndex = 0;
            CbTimeOption.SelectedIndex = 0;
            CbDifficulty.SelectedIndex = 0;

            TimeLeft = 0;
            StreakAnswerd = 0;
            CorrectAnswerd = 0;
            FalseAnswerd = 0;
            Answer = 0;
            HardnessLevel = 0;
            MathType = 0;
            MaxAttempts = 0;
            CAnswer = 0;

            lblNumberOne.Text = "_";
            lblNumberTwo.Text = "_";
            lblMathType.Text = "?";

            lblCorrectAnswerd.Text = "0";
            lblFalseAnswerd.Text = "0";
            lblStreakAnswerd.Text = "0";

            lblSecondsLeft.Text = "__";
            timer1.Stop();

            TbAnswer.Clear();

            BtnStart.Enabled = true;
        }

        private void TbAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    BtnValidate_Click(this, new EventArgs());
            //}
        }
    }
}
