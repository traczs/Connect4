using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Connect_4
{
    public partial class Form2 : Form
    {
        string play1;
        string play2;
        int p1 = 0;
        int p2 = 1;
        bool turn1 = false;
        bool turn2 = false;
        int col1 = 0;
        int col2 = 0;
        int col3 = 0;
        int col4 = 0;
        int col5 = 0;
        int col6 = 0;
        int col7 = 0;
        int[] cola = new int[6];
        int[] colb = new int[6];
        int[] colc = new int[6];
        int[] cold = new int[6];
        int[] cole = new int[6];
        int[] colf = new int[6];
        int[] colg = new int[6];

        public Form2(string x, string y)
        {
            InitializeComponent();
            play1 = x;
            play2 = y;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = play1;
            label2.Text = play2;

            Random rdm = new Random();
            int player = rdm.Next(2);

            if (player == p1)
            {
                turn1 = true;
                MessageBox.Show("" + play1 + " goes first");
            }
            else if (player == p2)
            {
                turn2 = true;
                MessageBox.Show("" + play2 + " goes first");
            }

            A.Image = Properties.Resources.blank;
            B.Image = Properties.Resources.blank;
            C.Image = Properties.Resources.blank;
            D.Image = Properties.Resources.blank;
            E.Image = Properties.Resources.blank;
            F.Image = Properties.Resources.blank;
            G.Image = Properties.Resources.blank;
        }
        //image show top
        #region
        private void A_MouseEnter(object sender, EventArgs e)
        {
            A.Visible = true;
            if (turn1 == true)
            {
                A.Image = Properties.Resources.c4yellow;
            }
            else if (turn2 == true)
            {
                A.Image = Properties.Resources.c4red;
            }
        }

        private void B_MouseEnter(object sender, EventArgs e)
        {
            B.Visible = true;
            if (turn1 == true)
            {
                B.Image = Properties.Resources.c4yellow;
            }
            else if (turn2 == true)
            {
                B.Image = Properties.Resources.c4red;
            }
        }

        private void C_MouseEnter(object sender, EventArgs e)
        {
            C.Visible = true;
            if (turn1 == true)
            {
                C.Image = Properties.Resources.c4yellow;
            }
            else if (turn2 == true)
            {
                C.Image = Properties.Resources.c4red;
            }
        }

        private void D_MouseEnter(object sender, EventArgs e)
        {
            D.Visible = true;
            if (turn1 == true)
            {
                D.Image = Properties.Resources.c4yellow;
            }
            else if (turn2 == true)
            {
                D.Image = Properties.Resources.c4red;
            }
        }

        private void E_MouseEnter(object sender, EventArgs e)
        {
            E.Visible = true;
            if (turn1 == true)
            {
                E.Image = Properties.Resources.c4yellow;
            }
            else if (turn2 == true)
            {
                E.Image = Properties.Resources.c4red;
            }
        }

        private void F_MouseEnter(object sender, EventArgs e)
        {
            F.Visible = true;
            if (turn1 == true)
            {
                F.Image = Properties.Resources.c4yellow;
            }
            else if (turn2 == true)
            {
                F.Image = Properties.Resources.c4red;
            }
        }

        private void G_MouseEnter(object sender, EventArgs e)
        {
            G.Visible = true;
            if (turn1 == true)
            {
                G.Image = Properties.Resources.c4yellow;
            }
            else if (turn2 == true)
            {
                G.Image = Properties.Resources.c4red;
            }
        }
        #endregion
        //image go away top
        #region
        private void A_MouseLeave(object sender, EventArgs e)
        {
            A.Image = Properties.Resources.blank;
        }

        private void B_MouseLeave(object sender, EventArgs e)
        {
            B.Image = Properties.Resources.blank;
        }

        private void C_MouseLeave(object sender, EventArgs e)
        {
            C.Image = Properties.Resources.blank;
        }

        private void D_MouseLeave(object sender, EventArgs e)
        {
            D.Image = Properties.Resources.blank;
        }

        private void E_MouseLeave(object sender, EventArgs e)
        {
            E.Image = Properties.Resources.blank;
        }

        private void F_MouseLeave(object sender, EventArgs e)
        {
            F.Image = Properties.Resources.blank;
        }

        private void G_MouseLeave(object sender, EventArgs e)
        {
            G.Image = Properties.Resources.blank;
        }
        #endregion
        //check to win
        private void checkwin()
        {
            #region
            //column a yellow
            if (cola[0]==cola[1] && cola[1]==cola[2] && cola[2]==cola[3] && cola[0]==1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?",MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cola[1]==cola[2] && cola[2]==cola[3] && cola[3]==cola[4] && cola[1]==1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cola[2] == cola[3] && cola[3] == cola[4] && cola[4] == cola[5] && cola[2] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            //column b yellow
            else if (colb[0] == colb[1] && colb[1] == colb[2] && colb[2] == colb[3] && colb[0] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[1] == colb[2] && colb[2] == colb[3] && colb[3] == colb[4] && colb[1] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[2] == colb[3] && colb[3] == colb[4] && colb[4] == colb[5] && colb[2] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            //column c yellow
            else if (colc[0] == colc[1] && colc[1] == colc[2] && colc[2] == colc[3] && colc[0] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colc[1] == colc[2] && colc[2] == colc[3] && colc[3] == colc[4] && colc[1] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colc[2] == colc[3] && colc[3] == colc[4] && colc[4] == colc[5] && colc[2] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            //column d yellow
            else if (cold[0] == cold[1] && cold[1] == cold[2] && cold[2] == cold[3] && cold[0] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cold[1] == cold[2] && cold[2] == cold[3] && cold[3] == cold[4] && cold[1] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cold[2] == cold[3] && cold[3] == cold[4] && cold[4] == cold[5] && cold[2] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            //column e yellow
            else if (cole[0] == cole[1] && cole[1] == cole[2] && cole[2] == cole[3] && cole[0] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cole[1] == cole[2] && cole[2] == cole[3] && cole[3] == cole[4] && cole[1] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cole[2] == cole[3] && cole[3] == cole[4] && cole[4] == cole[5] && cole[2] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            //column f yellow
            else if (colf[0] == colf[1] && colf[1] == colf[2] && colf[2] == colf[3] && colf[0] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colf[1] == colf[2] && colf[2] == colf[3] && colf[3] == colf[4] && colf[1] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colf[2] == colf[3] && colf[3] == colf[4] && colf[4] == colf[5] && colf[2] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            //column g yellow
            else if (colg[0] == colg[1] && colg[1] == colg[2] && colg[2] == colg[3] && colg[0] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colg[1] == colg[2] && colg[2] == colg[3] && colg[3] == colg[4] && colg[1] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colg[2] == colg[3] && colg[3] == colg[4] && colg[4] == colg[5] && colg[2] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            #endregion
            #region
            //column a red
            if (cola[0] == cola[1] && cola[1] == cola[2] && cola[2] == cola[3] && cola[0] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cola[1] == cola[2] && cola[2] == cola[3] && cola[3] == cola[4] && cola[1] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cola[2] == cola[3] && cola[3] == cola[4] && cola[4] == cola[5] && cola[2] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            //column b red
            else if (colb[0] == colb[1] && colb[1] == colb[2] && colb[2] == colb[3] && colb[0] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[1] == colb[2] && colb[2] == colb[3] && colb[3] == colb[4] && colb[1] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[2] == colb[3] && colb[3] == colb[4] && colb[4] == colb[5] && colb[2] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            //column c red
            else if (colc[0] == colc[1] && colc[1] == colc[2] && colc[2] == colc[3] && colc[0] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colc[1] == colc[2] && colc[2] == colc[3] && colc[3] == colc[4] && colc[1] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colc[2] == colc[3] && colc[3] == colc[4] && colc[4] == colc[5] && colc[2] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            //column d red
            else if (cold[0] == cold[1] && cold[1] == cold[2] && cold[2] == cold[3] && cold[0] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cold[1] == cold[2] && cold[2] == cold[3] && cold[3] == cold[4] && cold[1] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cold[2] == cold[3] && cold[3] == cold[4] && cold[4] == cold[5] && cold[2] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            //column e red
            else if (cole[0] == cole[1] && cole[1] == cole[2] && cole[2] == cole[3] && cole[0] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cole[1] == cole[2] && cole[2] == cole[3] && cole[3] == cole[4] && cole[1] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cole[2] == cole[3] && cole[3] == cole[4] && cole[4] == cole[5] && cole[2] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            //column f red
            else if (colf[0] == colf[1] && colf[1] == colf[2] && colf[2] == colf[3] && colf[0] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colf[1] == colf[2] && colf[2] == colf[3] && colf[3] == colf[4] && colf[1] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colf[2] == colf[3] && colf[3] == colf[4] && colf[4] == colf[5] && colf[2] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            //column g red
            else if (colg[0] == colg[1] && colg[1] == colg[2] && colg[2] == colg[3] && colg[0] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colg[1] == colg[2] && colg[2] == colg[3] && colg[3] == colg[4] && colg[1] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colg[2] == colg[3] && colg[3] == colg[4] && colg[4] == colg[5] && colg[2] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            #endregion
            #region
            //across yellow [5]///////////////////////////////////
            if (cola[5] == colb[5] && colb[5] == colc[5] && colc[5] == cold[5] && cold[5] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[5] == colc[5] && colc[5] == cold[5] && cold[5] == cole[5] && cole[5] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colc[5] == cold[5] && cold[5] == cole[5] && cole[5] == colf[5] && colf[5] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cold[5] == cole[5] && cole[5] == colf[5] && colf[5] == colg[5] && colg[5] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            // yellow [4]
            else if (cola[4] == colb[4] && colb[4] == colc[4] && colc[4] == cold[4] && cold[4] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[4] == colc[4] && colc[4] == cold[4] && cold[4] == cole[4] && cole[4] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colc[4] == cold[4] && cold[4] == cole[4] && cole[4] == colf[4] && colf[4] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cold[4] == cole[4] && cole[4] == colf[4] && colf[4] == colg[4] && colg[4] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            // yellow [3]
            if (cola[3] == colb[3] && colb[3] == colc[3] && colc[3] == cold[3] && cold[3] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[3] == colc[3] && colc[3] == cold[3] && cold[3] == cole[3] && cole[3] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colc[3] == cold[3] && cold[3] == cole[3] && cole[3] == colf[3] && colf[3] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cold[3] == cole[3] && cole[3] == colf[3] && colf[3] == colg[3] && colg[3] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            // yellow [2]
            if (cola[2] == colb[2] && colb[2] == colc[2] && colc[2] == cold[2] && cold[2] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[2] == colc[2] && colc[2] == cold[2] && cold[2] == cole[2] && cole[2] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colc[2] == cold[2] && cold[2] == cole[2] && cole[2] == colf[2] && colf[2] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cold[2] == cole[2] && cole[2] == colf[2] && colf[2] == colg[2] && colg[2] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            // yellow [1]
            if (cola[1] == colb[1] && colb[1] == colc[1] && colc[1] == cold[1] && cold[1] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[1] == colc[1] && colc[1] == cold[1] && cold[1] == cole[1] && cole[1] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colc[1] == cold[1] && cold[1] == cole[1] && cole[1] == colf[1] && colf[1] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cold[1] == cole[1] && cole[1] == colf[1] && colf[1] == colg[1] && colg[1] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            // yellow [0]
            if (cola[0] == colb[0] && colb[0] == colc[0] && colc[0] == cold[0] && cold[0] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[0] == colc[0] && colc[0] == cold[0] && cold[0] == cole[0] && cole[0] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colc[0] == cold[0] && cold[0] == cole[0] && cole[0] == colf[0] && colf[0] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cold[0] == cole[0] && cole[0] == colf[0] && colf[0] == colg[0] && colg[0] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
#endregion
            #region
            //across red [5]///////////////////////////////////
            if (cola[5] == colb[5] && colb[5] == colc[5] && colc[5] == cold[5] && cold[5] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[5] == colc[5] && colc[5] == cold[5] && cold[5] == cole[5] && cole[5] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colc[5] == cold[5] && cold[5] == cole[5] && cole[5] == colf[5] && colf[5] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cold[5] == cole[5] && cole[5] == colf[5] && colf[5] == colg[5] && colg[5] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            // red [4]
            else if (cola[4] == colb[4] && colb[4] == colc[4] && colc[4] == cold[4] && cold[4] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[4] == colc[4] && colc[4] == cold[4] && cold[4] == cole[4] && cole[4] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colc[4] == cold[4] && cold[4] == cole[4] && cole[4] == colf[4] && colf[4] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cold[4] == cole[4] && cole[4] == colf[4] && colf[4] == colg[4] && colg[4] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            // red [3]
            if (cola[3] == colb[3] && colb[3] == colc[3] && colc[3] == cold[3] && cold[3] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[3] == colc[3] && colc[3] == cold[3] && cold[3] == cole[3] && cole[3] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colc[3] == cold[3] && cold[3] == cole[3] && cole[3] == colf[3] && colf[3] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cold[3] == cole[3] && cole[3] == colf[3] && colf[3] == colg[3] && colg[3] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            // red [2]
            if (cola[2] == colb[2] && colb[2] == colc[2] && colc[2] == cold[2] && cold[2] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[2] == colc[2] && colc[2] == cold[2] && cold[2] == cole[2] && cole[2] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colc[2] == cold[2] && cold[2] == cole[2] && cole[2] == colf[2] && colf[2] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cold[2] == cole[2] && cole[2] == colf[2] && colf[2] == colg[2] && colg[2] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            // red [1]
            if (cola[1] == colb[1] && colb[1] == colc[1] && colc[1] == cold[1] && cold[1] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[1] == colc[1] && colc[1] == cold[1] && cold[1] == cole[1] && cole[1] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colc[1] == cold[1] && cold[1] == cole[1] && cole[1] == colf[1] && colf[1] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cold[1] == cole[1] && cole[1] == colf[1] && colf[1] == colg[1] && colg[1] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            // red [0]
            if (cola[0] == colb[0] && colb[0] == colc[0] && colc[0] == cold[0] && cold[0] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[0] == colc[0] && colc[0] == cold[0] && cold[0] == cole[0] && cole[0] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colc[0] == cold[0] && cold[0] == cole[0] && cole[0] == colf[0] && colf[0] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cold[0] == cole[0] && cole[0] == colf[0] && colf[0] == colg[0] && colg[0] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
#endregion
            //diagonal bottom left to top right///////////////////////////////////////////////////
            #region
            //yellow 
            if (cold[5] == cole[4] && cole[4] == colf[3] && colf[3] == colg[2] && colg[2] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colc[5] == cold[4] && cold[4] == cole[3] && cole[3] == colf[2] && colf[2] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cold[4] == cole[3] && cole[3] == colf[2] && colf[2] == colg[1] && colg[1] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[5] == colc[4] && colc[4] == cold[3] && cold[3] == cole[2] && cole[2] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colc[4] == cold[3] && cold[3] == cole[2] && cole[2] == colf[1] && colf[1] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cold[3] == cole[2] && cole[2] == colf[1] && colf[1] == colg[0] && colg[0] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cola[5] == colb[4] && colb[4] == colc[3] && colc[3] == cold[2] && cold[2] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[4] == colc[3] && colc[3] == cold[2] && cold[2] == cole[1] && cole[1] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colc[3] == cold[2] && cold[2] == cole[1] && cole[1] == colf[0] && colf[0] ==1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cola[4] == colb[3] && colb[3] == colc[2] && colc[2] == cold[1] && cold[1] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[3] == colc[2] && colc[2] == cold[1] && cold[1] == cole[0] && cole[0] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cola[3] == colb[2] && colb[2] == colc[1] && colc[1] == cold[0] && cold[0] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            #endregion
            #region
            //red
            if (cold[5] == cole[4] && cole[4] == colf[3] && colf[3] == colg[2] && colg[2] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colc[5] == cold[4] && cold[4] == cole[3] && cole[3] == colf[2] && colf[2] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cold[4] == cole[3] && cole[3] == colf[2] && colf[2] == colg[1] && colg[1] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[5] == colc[4] && colc[4] == cold[3] && cold[3] == cole[2] && cole[2] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colc[4] == cold[3] && cold[3] == cole[2] && cole[2] == colf[1] && colf[1] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cold[3] == cole[2] && cole[2] == colf[1] && colf[1] == colg[0] && colg[0] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cola[5] == colb[4] && colb[4] == colc[3] && colc[3] == cold[2] && cold[2] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[4] == colc[3] && colc[3] == cold[2] && cold[2] == cole[1] && cole[1] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colc[3] == cold[2] && cold[2] == cole[1] && cole[1] == colf[0] && colf[0] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cola[4] == colb[3] && colb[3] == colc[2] && colc[2] == cold[1] && cold[1] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[3] == colc[2] && colc[2] == cold[1] && cold[1] == cole[0] && cole[0] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cola[3] == colb[2] && colb[2] == colc[1] && colc[1] == cold[0] && cold[0] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            #endregion
            //diagonal bottom right to top left///////////////////////////////////////////////////
            #region
            //yellow
            if (cola[2]==colb[3] && colb[3] == colc[4] && colc[4] == cold[5] && cold[5]==1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cola[1] == colb[2] && colb[2] == colc[3] && colc[3] == cold[4] && cold[4] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[2] == colc[3] && colc[3] == cold[4] && cold[4] == cole[5] && cole[5] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cola[0] == colb[1] && colb[1] == colc[2] && colc[2] == cold[3] && cold[3] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[1] == colc[2] && colc[2] == cold[3] && cold[3] == cole[4] && cole[4] ==1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colc[2] == cold[3] && cold[3] == cole[4] && cole[4] == colf[5] && colf[5] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[0] == colc[1] && colc[1] == cold[2] && cold[2] == cole[3] && cole[3] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colc[1] == cold[2] && cold[2] == cole[3] && cole[3] == colf[4] && colf[4] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cold[2] == cole[3] && cole[3] == colf[4] && colf[4] == colg[5] && colg[5] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }           
            }
            else if (colc[0] == cold[1] && cold[1] == cole[2] && cole[2] == colf[3] && colf[3] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cold[1] == cole[2] && cole[2] == colf[3] && colf[3] == colg[4] && colg[4] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cold[0] == cole[1] && cole[1] == colf[2] && colf[2] == colg[3] && colg[3] == 1)
            {
                DialogResult playagain = MessageBox.Show("" + play1 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            #endregion
            #region
            // red
            if (cola[2] == colb[3] && colb[3] == colc[4] && colc[4] == cold[5] && cold[5] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cola[1] == colb[2] && colb[2] == colc[3] && colc[3] == cold[4] && cold[4] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[2] == colc[3] && colc[3] == cold[4] && cold[4] == cole[5] && cole[5] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cola[0] == colb[1] && colb[1] == colc[2] && colc[2] == cold[3] && cold[3] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[1] == colc[2] && colc[2] == cold[3] && cold[3] == cole[4] && cole[4] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colc[2] == cold[3] && cold[3] == cole[4] && cole[4] == colf[5] && colf[5] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colb[0] == colc[1] && colc[1] == cold[2] && cold[2] == cole[3] && cole[3] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colc[1] == cold[2] && cold[2] == cole[3] && cole[3] == colf[4] && colf[4] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cold[2] == cole[3] && cole[3] == colf[4] && colf[4] == colg[5] && colg[5] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (colc[0] == cold[1] && cold[1] == cole[2] && cole[2] == colf[3] && colf[3] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cold[1] == cole[2] && cole[2] == colf[3] && colf[3] == colg[4] && colg[4] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (cold[0] == cole[1] && cole[1] == colf[2] && colf[2] == colg[3] && colg[3] == 2)
            {
                DialogResult playagain = MessageBox.Show("" + play2 + " wins!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            #endregion
            //tie
            if (col1==col2 && col2==col3 && col3==col4 && col4==col5 && col5==col6 &&col6==6)
            {
                DialogResult playagain = MessageBox.Show("It's a Tie!", "Play again?", MessageBoxButtons.YesNo);
                if (playagain == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (playagain == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }
        //image click
        //
        #region
        private void A_Click(object sender, EventArgs e)
        {
            if (turn1 == true)
            {
                col1++;
                if (col1 == 1)
                {
                    a1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a1.Image = Properties.Resources.blank;
                    a2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a2.Image = Properties.Resources.blank;
                    a3.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a3.Image = Properties.Resources.blank;
                    a4.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a4.Image = Properties.Resources.blank;
                    a5.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a5.Image = Properties.Resources.blank;
                    a6.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    cola[5] = 1;
                    checkwin();
                }
                else if (col1 == 2)
                {
                    a1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a1.Image = Properties.Resources.blank;
                    a2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a2.Image = Properties.Resources.blank;
                    a3.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a3.Image = Properties.Resources.blank;
                    a4.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a4.Image = Properties.Resources.blank;
                    a5.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    cola[4] = 1;
                    checkwin();
                }
                else if (col1 == 3)
                {
                    a1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a1.Image = Properties.Resources.blank;
                    a2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a2.Image = Properties.Resources.blank;
                    a3.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a3.Image = Properties.Resources.blank;
                    a4.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    cola[3] = 1;
                    checkwin();
                }
                else if (col1 == 4)
                {
                    a1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a1.Image = Properties.Resources.blank;
                    a2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a2.Image = Properties.Resources.blank;
                    a3.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    cola[2] = 1;
                    checkwin();
                }
                else if (col1 == 5)
                {
                    a1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a1.Image = Properties.Resources.blank;
                    a2.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    cola[1] = 1;
                    checkwin();
                }
                else if (col1 == 6)
                {
                    a1.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    cola[0] = 1;
                    checkwin();
                }
            }
            else if (turn2 == true)
            {
                col1++;
                if (col1 == 1)
                {
                    a1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a1.Image = Properties.Resources.blank;
                    a2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a2.Image = Properties.Resources.blank;
                    a3.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a3.Image = Properties.Resources.blank;
                    a4.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a4.Image = Properties.Resources.blank;
                    a5.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a5.Image = Properties.Resources.blank;
                    a6.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    cola[5] = 2;
                    checkwin();
                }
                else if (col1 == 2)
                {
                    a1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a1.Image = Properties.Resources.blank;
                    a2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a2.Image = Properties.Resources.blank;
                    a3.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a3.Image = Properties.Resources.blank;
                    a4.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a4.Image = Properties.Resources.blank;
                    a5.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    cola[4] = 2;
                    checkwin();
                }
                else if (col1 == 3)
                {
                    a1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a1.Image = Properties.Resources.blank;
                    a2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a2.Image = Properties.Resources.blank;
                    a3.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a3.Image = Properties.Resources.blank;
                    a4.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    cola[3] = 2;
                    checkwin();
                }
                else if (col1 == 4)
                {
                    a1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a1.Image = Properties.Resources.blank;
                    a2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a2.Image = Properties.Resources.blank;
                    a3.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    cola[2] = 2;
                    checkwin();
                }
                else if (col1 == 5)
                {
                    a1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    a1.Image = Properties.Resources.blank;
                    a2.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    cola[1] = 2;
                    checkwin();
                }
                else if (col1 == 6)
                {
                    a1.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    cola[0] = 2;
                    checkwin();
                }
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            if (turn1 == true)
            {
                col2++;
                if (col2 == 1)
                {
                    b1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b1.Image = Properties.Resources.blank;
                    b2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b2.Image = Properties.Resources.blank;
                    b3.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b3.Image = Properties.Resources.blank;
                    b4.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b4.Image = Properties.Resources.blank;
                    b5.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b5.Image = Properties.Resources.blank;
                    b6.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    colb[5] = 1;
                    checkwin();
                }
                else if (col2 == 2)
                {
                    b1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b1.Image = Properties.Resources.blank;
                    b2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b2.Image = Properties.Resources.blank;
                    b3.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b3.Image = Properties.Resources.blank;
                    b4.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b4.Image = Properties.Resources.blank;
                    b5.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    colb[4] = 1;
                    checkwin();
                }
                else if (col2 == 3)
                {
                    b1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b1.Image = Properties.Resources.blank;
                    b2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b2.Image = Properties.Resources.blank;
                    b3.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b3.Image = Properties.Resources.blank;
                    b4.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    colb[3] = 1;
                    checkwin();
                }
                else if (col2 == 4)
                {
                    b1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b1.Image = Properties.Resources.blank;
                    b2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b2.Image = Properties.Resources.blank;
                    b3.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    colb[2] = 1;
                    checkwin();
                }
                else if (col2 == 5)
                {
                    b1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b1.Image = Properties.Resources.blank;
                    b2.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    colb[1] = 1;
                    checkwin();
                }
                else if (col2 == 6)
                {
                    b1.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    colb[0] = 1;
                    checkwin();
                }
            }
            else if (turn2 == true)
            {
                col2++;
                if (col2 == 1)
                {
                    b1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b1.Image = Properties.Resources.blank;
                    b2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b2.Image = Properties.Resources.blank;
                    b3.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b3.Image = Properties.Resources.blank;
                    b4.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b4.Image = Properties.Resources.blank;
                    b5.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b5.Image = Properties.Resources.blank;
                    b6.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    colb[5] = 2;
                    checkwin();
                }
                else if (col2 == 2)
                {
                    b1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b1.Image = Properties.Resources.blank;
                    b2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b2.Image = Properties.Resources.blank;
                    b3.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b3.Image = Properties.Resources.blank;
                    b4.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b4.Image = Properties.Resources.blank;
                    b5.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    colb[4] = 2;
                    checkwin();
                }
                else if (col2 == 3)
                {
                    b1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b1.Image = Properties.Resources.blank;
                    b2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b2.Image = Properties.Resources.blank;
                    b3.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b3.Image = Properties.Resources.blank;
                    b4.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    colb[3] = 2;
                    checkwin();
                }
                else if (col2 == 4)
                {
                    b1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b1.Image = Properties.Resources.blank;
                    b2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b2.Image = Properties.Resources.blank;
                    b3.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    colb[2] = 2;
                    checkwin();
                }
                else if (col2 == 5)
                {
                    b1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    b1.Image = Properties.Resources.blank;
                    b2.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    colb[1] = 2;
                    checkwin();
                }
                else if (col2 == 6)
                {
                    b1.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    colb[0] = 2;
                    checkwin();
                }
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            if (turn1 == true)
            {
                col3++;
                if (col3 == 1)
                {
                    c1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c1.Image = Properties.Resources.blank;
                    c2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c2.Image = Properties.Resources.blank;
                    c3.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c3.Image = Properties.Resources.blank;
                    c4.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c4.Image = Properties.Resources.blank;
                    c5.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c5.Image = Properties.Resources.blank;
                    c6.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    colc[5] = 1;
                    checkwin();
                }
                else if (col3 == 2)
                {
                    c1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c1.Image = Properties.Resources.blank;
                    c2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c2.Image = Properties.Resources.blank;
                    c3.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c3.Image = Properties.Resources.blank;
                    c4.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c4.Image = Properties.Resources.blank;
                    c5.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    colc[4] = 1;
                    checkwin();
                }
                else if (col3 == 3)
                {
                    c1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c1.Image = Properties.Resources.blank;
                    c2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c2.Image = Properties.Resources.blank;
                    c3.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c3.Image = Properties.Resources.blank;
                    c4.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    colc[3] = 1;
                    checkwin();
                }
                else if (col3 == 4)
                {
                    c1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c1.Image = Properties.Resources.blank;
                    c2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c2.Image = Properties.Resources.blank;
                    c3.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    colc[2] = 1;
                    checkwin();
                }
                else if (col3 == 5)
                {
                    c1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c1.Image = Properties.Resources.blank;
                    c2.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    colc[1] = 1;
                    checkwin();
                }
                else if (col3 == 6)
                {
                    c1.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    colc[0] = 1;
                    checkwin();
                }
            }
            else if (turn2 == true)
            {
                col3++;
                if (col3 == 1)
                {
                    c1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c1.Image = Properties.Resources.blank;
                    c2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c2.Image = Properties.Resources.blank;
                    c3.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c3.Image = Properties.Resources.blank;
                    c4.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c4.Image = Properties.Resources.blank;
                    c5.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c5.Image = Properties.Resources.blank;
                    c6.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    colc[5] = 2;
                    checkwin();
                }
                else if (col3 == 2)
                {
                    c1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c1.Image = Properties.Resources.blank;
                    c2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c2.Image = Properties.Resources.blank;
                    c3.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c3.Image = Properties.Resources.blank;
                    c4.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c4.Image = Properties.Resources.blank;
                    c5.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    colc[4] = 2;
                    checkwin();
                }
                else if (col3 == 3)
                {
                    c1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c1.Image = Properties.Resources.blank;
                    c2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c2.Image = Properties.Resources.blank;
                    c3.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c3.Image = Properties.Resources.blank;
                    c4.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    colc[3] = 2;
                    checkwin();
                }
                else if (col3 == 4)
                {
                    c1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c1.Image = Properties.Resources.blank;
                    c2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c2.Image = Properties.Resources.blank;
                    c3.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false; 
                    colc[2] = 2;
                    checkwin();
                }
                else if (col3 == 5)
                {
                    c1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    c1.Image = Properties.Resources.blank;
                    c2.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    colc[1] = 2;
                    checkwin();
                }
                else if (col3 == 6)
                {
                    c1.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    colc[0] = 2;
                    checkwin();
                }
            }
        }

        private void D_Click(object sender, EventArgs e)
        {
            if (turn1 == true)
            {
                col4++;
                if (col4 == 1)
                {
                    d1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d1.Image = Properties.Resources.blank;
                    d2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d2.Image = Properties.Resources.blank;
                    d3.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d3.Image = Properties.Resources.blank;
                    d4.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d4.Image = Properties.Resources.blank;
                    d5.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d5.Image = Properties.Resources.blank;
                    d6.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    cold[5] = 1;
                    checkwin();
                }
                else if (col4 == 2)
                {
                    d1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d1.Image = Properties.Resources.blank;
                    d2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d2.Image = Properties.Resources.blank;
                    d3.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d3.Image = Properties.Resources.blank;
                    d4.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d4.Image = Properties.Resources.blank;
                    d5.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    cold[4] = 1;
                    checkwin();
                }
                else if (col4 == 3)
                {
                    d1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d1.Image = Properties.Resources.blank;
                    d2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d2.Image = Properties.Resources.blank;
                    d3.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d3.Image = Properties.Resources.blank;
                    d4.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    cold[3] = 1;
                    checkwin();
                }
                else if (col4 == 4)
                {
                    d1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d1.Image = Properties.Resources.blank;
                    d2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d2.Image = Properties.Resources.blank;
                    d3.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    cold[2] = 1;
                    checkwin();
                }
                else if (col4 == 5)
                {
                    d1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d1.Image = Properties.Resources.blank;
                    d2.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    cold[1] = 1;
                    checkwin();
                }
                else if (col4 == 6)
                {
                    d1.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    cold[0] = 1;
                    checkwin();
                }
            }
            else if (turn2 == true)
            {
                col4++;
                if (col4 == 1)
                {
                    d1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d1.Image = Properties.Resources.blank;
                    d2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d2.Image = Properties.Resources.blank;
                    d3.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d3.Image = Properties.Resources.blank;
                    d4.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d4.Image = Properties.Resources.blank;
                    d5.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d5.Image = Properties.Resources.blank;
                    d6.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    cold[5] = 2;
                    checkwin();
                }
                else if (col4 == 2)
                {
                    d1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d1.Image = Properties.Resources.blank;
                    d2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d2.Image = Properties.Resources.blank;
                    d3.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d3.Image = Properties.Resources.blank;
                    d4.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d4.Image = Properties.Resources.blank;
                    d5.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    cold[4] = 2;
                    checkwin();
                }
                else if (col4 == 3)
                {
                    d1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d1.Image = Properties.Resources.blank;
                    d2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d2.Image = Properties.Resources.blank;
                    d3.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d3.Image = Properties.Resources.blank;
                    d4.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    cold[3] = 2;
                    checkwin();
                }
                else if (col4 == 4)
                {
                    d1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d1.Image = Properties.Resources.blank;
                    d2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d2.Image = Properties.Resources.blank;
                    d3.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    cold[2] = 2;
                    checkwin();
                }
                else if (col4 == 5)
                {
                    d1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    d1.Image = Properties.Resources.blank;
                    d2.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    cold[1] = 2;
                    checkwin();
                }
                else if (col4 == 6)
                {
                    d1.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    cold[0] = 2;
                    checkwin();
                }
            }
        }

        private void E_Click(object sender, EventArgs e)
        {
            if (turn1 == true)
            {
                col5++;
                if (col5 == 1)
                {
                    e1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e1.Image = Properties.Resources.blank;
                    e2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e2.Image = Properties.Resources.blank;
                    e3.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e3.Image = Properties.Resources.blank;
                    e4.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e4.Image = Properties.Resources.blank;
                    e5.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e5.Image = Properties.Resources.blank;
                    e6.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    cole[5] = 1;
                    checkwin();
                }
                else if (col5 == 2)
                {
                    e1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e1.Image = Properties.Resources.blank;
                    e2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e2.Image = Properties.Resources.blank;
                    e3.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e3.Image = Properties.Resources.blank;
                    e4.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e4.Image = Properties.Resources.blank;
                    e5.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    cole[4] = 1;
                    checkwin();
                }
                else if (col5 == 3)
                {
                    e1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e1.Image = Properties.Resources.blank;
                    e2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e2.Image = Properties.Resources.blank;
                    e3.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e3.Image = Properties.Resources.blank;
                    e4.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    cole[3] = 1;
                    checkwin();
                }
                else if (col5 == 4)
                {
                    e1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e1.Image = Properties.Resources.blank;
                    e2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e2.Image = Properties.Resources.blank;
                    e3.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    cole[2] = 1;
                    checkwin();
                }
                else if (col5 == 5)
                {
                    e1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e1.Image = Properties.Resources.blank;
                    e2.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    cole[1] = 1;
                    checkwin();
                }
                else if (col5 == 6)
                {
                    e1.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    cole[0] = 1;
                    checkwin();
                }
            }
            else if (turn2 == true)
            {
                col5++;
                if (col5 == 1)
                {
                    e1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e1.Image = Properties.Resources.blank;
                    e2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e2.Image = Properties.Resources.blank;
                    e3.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e3.Image = Properties.Resources.blank;
                    e4.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e4.Image = Properties.Resources.blank;
                    e5.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e5.Image = Properties.Resources.blank;
                    e6.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    cole[5] = 2;
                    checkwin();
                }
                else if (col5 == 2)
                {
                    e1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e1.Image = Properties.Resources.blank;
                    e2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e2.Image = Properties.Resources.blank;
                    e3.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e3.Image = Properties.Resources.blank;
                    e4.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e4.Image = Properties.Resources.blank;
                    e5.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    cole[4] = 2;
                    checkwin();
                }
                else if (col5 == 3)
                {
                    e1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e1.Image = Properties.Resources.blank;
                    e2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e2.Image = Properties.Resources.blank;
                    e3.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e3.Image = Properties.Resources.blank;
                    e4.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    cole[3] = 2;
                    checkwin();
                }
                else if (col5 == 4)
                {
                    e1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e1.Image = Properties.Resources.blank;
                    e2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e2.Image = Properties.Resources.blank;
                    e3.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    cole[2] = 2;
                    checkwin();
                }
                else if (col5 == 5)
                {
                    e1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    e1.Image = Properties.Resources.blank;
                    e2.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    cole[1] = 2;
                    checkwin();
                }
                else if (col5 == 6)
                {
                    e1.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    cole[0] = 2;
                    checkwin();
                }
            }
        }

        private void F_Click(object sender, EventArgs e)
        {
            if (turn1 == true)
            {
                col6++;
                if (col6 == 1)
                {
                    f1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f1.Image = Properties.Resources.blank;
                    f2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f2.Image = Properties.Resources.blank;
                    f3.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f3.Image = Properties.Resources.blank;
                    f4.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f4.Image = Properties.Resources.blank;
                    f5.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f5.Image = Properties.Resources.blank;
                    f6.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    colf[5] = 1;
                    checkwin();
                }
                else if (col6 == 2)
                {
                    f1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f1.Image = Properties.Resources.blank;
                    f2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f2.Image = Properties.Resources.blank;
                    f3.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f3.Image = Properties.Resources.blank;
                    f4.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f4.Image = Properties.Resources.blank;
                    f5.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    colf[4] = 1;
                    checkwin();
                }
                else if (col6 == 3)
                {
                    f1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f1.Image = Properties.Resources.blank;
                    f2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f2.Image = Properties.Resources.blank;
                    f3.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f3.Image = Properties.Resources.blank;
                    f4.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    colf[3] = 1;
                    checkwin();
                }
                else if (col6 == 4)
                {
                    f1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f1.Image = Properties.Resources.blank;
                    f2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f2.Image = Properties.Resources.blank;
                    f3.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    colf[2] = 1;
                    checkwin();
                }
                else if (col6 == 5)
                {
                    f1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f1.Image = Properties.Resources.blank;
                    f2.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    colf[1] = 1;
                    checkwin();
                }
                else if (col6 == 6)
                {
                    f1.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    colf[0] = 1;
                    checkwin();
                }
            }
            else if (turn2 == true)
            {
                col6++;
                if (col6 == 1)
                {
                    f1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f1.Image = Properties.Resources.blank;
                    f2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f2.Image = Properties.Resources.blank;
                    f3.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f3.Image = Properties.Resources.blank;
                    f4.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f4.Image = Properties.Resources.blank;
                    f5.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f5.Image = Properties.Resources.blank;
                    f6.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    colf[5] = 2;
                    checkwin();
                }
                else if (col6 == 2)
                {
                    f1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f1.Image = Properties.Resources.blank;
                    f2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f2.Image = Properties.Resources.blank;
                    f3.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f3.Image = Properties.Resources.blank;
                    f4.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f4.Image = Properties.Resources.blank;
                    f5.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    colf[4] = 2;
                    checkwin();
                }
                else if (col6 == 3)
                {
                    f1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f1.Image = Properties.Resources.blank;
                    f2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f2.Image = Properties.Resources.blank;
                    f3.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f3.Image = Properties.Resources.blank;
                    f4.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    colf[3] = 2;
                    checkwin();
                }
                else if (col6 == 4)
                {
                    f1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f1.Image = Properties.Resources.blank;
                    f2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f2.Image = Properties.Resources.blank;
                    f3.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    colf[2] = 2;
                    checkwin();
                }
                else if (col6 == 5)
                {
                    f1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    f1.Image = Properties.Resources.blank;
                    f2.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    colf[1] = 2;
                    checkwin();
                }
                else if (col6 == 6)
                {
                    f1.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    colf[0] = 2;
                    checkwin();
                }
            }
        }

        private void G_Click(object sender, EventArgs e)
        {
            if (turn1 == true)
            {
                col7++;
                if (col7 == 1)
                {
                    g1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g1.Image = Properties.Resources.blank;
                    g2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g2.Image = Properties.Resources.blank;
                    g3.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g3.Image = Properties.Resources.blank;
                    g4.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g4.Image = Properties.Resources.blank;
                    g5.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g5.Image = Properties.Resources.blank;
                    g6.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    colg[5] = 1;
                    checkwin();
                }
                else if (col7 == 2)
                {
                    g1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g1.Image = Properties.Resources.blank;
                    g2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g2.Image = Properties.Resources.blank;
                    g3.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g3.Image = Properties.Resources.blank;
                    g4.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g4.Image = Properties.Resources.blank;
                    g5.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    colg[4] = 1;
                    checkwin();
                }
                else if (col7 == 3)
                {
                    g1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g1.Image = Properties.Resources.blank;
                    g2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g2.Image = Properties.Resources.blank;
                    g3.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g3.Image = Properties.Resources.blank;
                    g4.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    colg[3] = 1;
                    checkwin();
                }
                else if (col7 == 4)
                {
                    g1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g1.Image = Properties.Resources.blank;
                    g2.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g2.Image = Properties.Resources.blank;
                    g3.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    colg[2] = 1;
                    checkwin();
                }
                else if (col7 == 5)
                {
                    g1.Image = Properties.Resources.c4yellow;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g1.Image = Properties.Resources.blank;
                    g2.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    colg[1] = 1;
                    checkwin();
                }
                else if (col7 == 6)
                {
                    g1.Image = Properties.Resources.c4yellow;
                    turn1 = false;
                    turn2 = true;
                    colg[0] = 1;
                    checkwin();
                }
            }
            else if (turn2 == true)
            {
                col7++;
                if (col7 == 1)
                {
                    g1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g1.Image = Properties.Resources.blank;
                    g2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g2.Image = Properties.Resources.blank;
                    g3.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g3.Image = Properties.Resources.blank;
                    g4.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g4.Image = Properties.Resources.blank;
                    g5.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g5.Image = Properties.Resources.blank;
                    g6.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    colg[5] = 2;
                    checkwin();
                }
                else if (col7 == 2)
                {
                    g1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g1.Image = Properties.Resources.blank;
                    g2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g2.Image = Properties.Resources.blank;
                    g3.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g3.Image = Properties.Resources.blank;
                    g4.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g4.Image = Properties.Resources.blank;
                    g5.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    colg[4] = 2;
                    checkwin();
                }
                else if (col7 == 3)
                {
                    g1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g1.Image = Properties.Resources.blank;
                    g2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g2.Image = Properties.Resources.blank;
                    g3.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g3.Image = Properties.Resources.blank;
                    g4.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    colg[3] = 2;
                    checkwin();
                }
                else if (col7 == 4)
                {
                    g1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g1.Image = Properties.Resources.blank;
                    g2.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g2.Image = Properties.Resources.blank;
                    g3.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    colg[2] = 2;
                    checkwin();
                }
                else if (col7 == 5)
                {
                    g1.Image = Properties.Resources.c4red;
                    System.Threading.Thread.Sleep(100);
                    this.Refresh();
                    g1.Image = Properties.Resources.blank;
                    g2.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    colg[1] = 2;
                    checkwin();
                }
                else if (col7 == 6)
                {
                    g1.Image = Properties.Resources.c4red;
                    turn1 = true;
                    turn2 = false;
                    colg[0] = 2;
                    checkwin();
                }
            }
        }
#endregion
        






    }
}
