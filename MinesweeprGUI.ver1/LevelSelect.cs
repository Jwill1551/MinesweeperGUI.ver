using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinesweeprGUI.ver1
{
    public partial class LevelSelect : Form
    {
        public static int Size = 12;
        public Button[,] btnGrid = new Button[Size, Size];
        public int counter = 0;

        public LevelSelect()
        {
            InitializeComponent();
        }

        // Launches a new grid when the player selects a difficulty for the game 
        private void playBtn_Click(object sender, EventArgs e)
        {
            

            Form Game = new Form();
            Game.Text = "Game";
            Game.Size = new Size(435, 450);

            for (int j = 0; j < Size; j++)
            {
                for (int k = 0; k < Size; k++)
                {
                    btnGrid[j, k] = new Button();
                    btnGrid[j, k].Name = "box" + j + "-" + k;
                    btnGrid[j, k].Size = new Size(34, 34);
                    btnGrid[j, k].Location = new Point(34 * j, 34 * k);
                    btnGrid[j, k].Click += Grid_Btn_Click;
                    Game.Controls.Add(btnGrid[j, k]);
                }
            }

            Game.ShowDialog();
        }

        // Method to increment the number of button clicks on the grid
        private void Grid_Btn_Click(object sender, EventArgs e)
        {
            counter++;
            var btn = (sender as Button);
            btn.Text = counter.ToString();
        }

        // Exit Button to terminate program
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Easy Difficulty
        private void easyRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            Size = 6;
        }

        // Medium Difficulty 
        private void mediumRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            Size = 8;
        }

        // Hard Difficulty
        private void hardRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            Size = 12;
        }
    }
}
