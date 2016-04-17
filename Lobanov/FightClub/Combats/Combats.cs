using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Combats
{
    public partial class Combats : Form
    {
        Controller currentgame; 
        
        public Combats()
        {
            InitializeComponent();
            ConnectNewGame();

            
            statusLabel.DataBindings.Add("Text", gameBindingSource, "status");
            firstPlayerLabel.DataBindings.Add("Text", gameBindingSource, "humanHP");
            secondPlayerLabel.DataBindings.Add("Text", gameBindingSource, "compHP");

            firstPlayerBar.DataBindings.Add("Value", gameBindingSource, "humanPercentHP");
            secondPlayerBar.DataBindings.Add("Value", gameBindingSource, "compPercentHP");
        }

        private void Combats_Load(object sender, EventArgs e)
        {
            
        }

        void Lock()
        {
            HeadButton.Enabled = false;
            BodyButton.Enabled = false;
            LegsButton.Enabled = false;
        }
        void Unlock()
        {
            HeadButton.Enabled = true;
            BodyButton.Enabled = true;
            LegsButton.Enabled = true;
        }
        
        private void HeadButton_Click(object sender, EventArgs e)
        {
            currentgame.Tick(BodyPart.Head);
            
        }

        private void BodyButton_Click(object sender, EventArgs e)
        {
            currentgame.Tick(BodyPart.Body);
        }

        private void LegsButton_Click(object sender, EventArgs e)
        {
            currentgame.Tick(BodyPart.Legs);
        }

        void ConnectNewGame()
        {
            Player human = new Player("You", 110, 10);
            Player comp = new Player("Easy", 80, 12);

            currentgame = new Controller(human,comp);

            currentgame.GameEnded += Lock;
            currentgame.Logged += LogToBox;
          
            logBox.Items.Clear();
            gameBindingSource.DataSource = currentgame;
            Unlock();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectNewGame();
        }

        void LogToBox(string str)
        {
            logBox.Items.Add(str);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
