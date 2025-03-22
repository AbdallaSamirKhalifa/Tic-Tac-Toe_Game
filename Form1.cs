using Draw.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public partial class Form1 : Form
    {
        enPlayer PlayerTurn = enPlayer.Player1;
        stGameStatus GameStatus;
        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short GameCounter;

        }
       public enum enPlayer { Player1,Player2};
        public enum enWinner
        {
            Player1,Player2,GameInProgress,Draw
        }
        public Form1()
        {
            InitializeComponent();
        }

        void ResetButton(Button button)
        {
            button.BackColor=Color.Transparent;
            button.BackgroundImage = Resources.question_mark_96;
            button.Tag = "?";
            button.Enabled = true;
        }

        void RestartGame()
        {
            ResetButton(btn1);
            ResetButton(btn2);
            ResetButton(btn3);
            ResetButton(btn4);
            ResetButton(btn5);
            ResetButton(btn6);
            ResetButton(btn7);
            ResetButton(btn8);
            ResetButton(btn9);

            PlayerTurn=enPlayer.Player1;
            lblTurn.Text = "   Player 1";
            GameStatus.Winner = enWinner.GameInProgress;
            GameStatus.GameCounter = 0;
            GameStatus.GameOver = false;
            lblWinner.Text = "In Progress";
        }
        void DisableButtons()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }
        bool CheckButton(Button btn1,Button btn2,Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            
            {               
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;
                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
            }
            return false;
        }   

        void EndGame()
        {
            lblTurn.Text = "Game Over";
            switch (GameStatus.Winner)
            {
                case enWinner.Player1:
                    lblWinner.Text = "  Player 1";
                    break;
                case enWinner.Player2:
                    lblWinner.Text = "  Player 2";
                    break;
                default:
                    lblWinner.Text = "  Draw";
                    break;
            }
            MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisableButtons();
        }
        void checkWinner()
        {
            if (CheckButton(btn1, btn2, btn3))
                return;
            if (CheckButton(btn4, btn5, btn6))
                return;
            if (CheckButton(btn7, btn8, btn9))
                return;
            if (CheckButton(btn1, btn4, btn7))
                return;
            if (CheckButton(btn2, btn5, btn8))
                return;
            if (CheckButton(btn3, btn6, btn9))
                return;
            if (CheckButton(btn1, btn5, btn9))
                return;
            if (CheckButton(btn3, btn5, btn7))
                return;

        }

        public void ChangeImage(Button btn)
        {
            btn.Enabled = false;
            if (btn.Tag.ToString() != "?")
            {
                MessageBox.Show("Wrong Choice", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch(PlayerTurn)
            {
                case enPlayer.Player1:
                    btn.BackgroundImage= Resources.X;
                    
                    PlayerTurn=enPlayer.Player2;
                    lblTurn.Text = "  Player 2";
                    btn.Tag = "X";
                    GameStatus.GameCounter++;
                    checkWinner();
                    break;
                case enPlayer.Player2:
                    btn.BackgroundImage = Resources.O;
                    PlayerTurn = enPlayer.Player1;
                    lblTurn.Text = "  Player 1";
                    btn.Tag = "O";
                    GameStatus.GameCounter++;
                    checkWinner();
                    break;
            }
            if (GameStatus.GameCounter == 9)
            {
                GameStatus.Winner = enWinner.Draw;
                GameStatus.GameOver = true;
                EndGame();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color Black = Color.FromArgb(255,255,255, 255);

            Pen Pen = new Pen(Black);
            Pen.Width = 10;

           // Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            
         
            e.Graphics.DrawLine(Pen, 675, 75, 675, 350);
            e.Graphics.DrawLine(Pen, 550, 75, 550, 350);
            e.Graphics.DrawLine(Pen, 420, 160, 800, 160);
            e.Graphics.DrawLine(Pen, 420, 250, 800, 250);



        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }
        

    }
}
