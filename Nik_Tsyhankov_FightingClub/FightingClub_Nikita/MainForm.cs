using GameProcess.BL;
using GameProcess.BL.Fighters;
using System;
using System.Windows.Forms;

namespace FightingClub_Nikita
{
    public partial class MainForm : Form, IGameForm
    {
        public event EventHandler<EventArgsBodyParts> ButHeadClick;
        public event EventHandler<EventArgsBodyParts> ButBodyClick;
        public event EventHandler<EventArgsBodyParts> ButLegClick;
        public event EventHandler ButLoadGameClick;
        public event EventHandler ButSaveGameClick;

        private StartForm start = new StartForm();

        public MainForm()
        {
            InitializeComponent();
            start.ShowDialog();
            NamePlayer1 = start.StartName;
        }

        public void Binding(BindingSource binding)
        {
            lblPlayer2.DataBindings.Add("Text", binding, "Player2.Name");
            //DataBindings.Add("Rounds", binding, "Round");
            //DataBindings.Add("Title", binding, "Round");
            lblHPPlayer1.DataBindings.Add("Text", binding, "Player1.HealthPoints");
            progressBarPlayer1.DataBindings.Add("Value", binding, "Player1.HealthPoints");
            lblHPPlayer2.DataBindings.Add("Text", binding, "Player2.HealthPoints");
            progressBarPlayer2.DataBindings.Add("Value", binding, "Player2.HealthPoints");
        }
        public void BlockGame(string _winner)
        {
            lblFinish.Visible = true;
            lblFinish.Text = _winner + " is winner!";
            butHead.Enabled = false;
            butBody.Enabled = false;
            butLeg.Enabled = false;
        }
        public void UnblockGame()
        {
            lblFinish.Visible = false;
            butHead.Enabled = true;
            butBody.Enabled = true;
            butLeg.Enabled = true;
        }
        public void ClearLog()
        {
            listBoxLog.Items.Clear();
        }

        #region Events
        private void butHead_Click(object sender, EventArgs e)
        {
            if (ButHeadClick != null) ButHeadClick(this, 
                new EventArgsBodyParts(BodyParts._head));
        }

        private void butBody_Click(object sender, EventArgs e)
        {
            if (ButBodyClick != null) ButBodyClick(this,
                new EventArgsBodyParts(BodyParts._body));
        }

        private void butLeg_Click(object sender, EventArgs e)
        {
            if (ButLegClick != null) ButLegClick(this,
                new EventArgsBodyParts(BodyParts._leg));
        }
        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ButSaveGameClick != null) ButSaveGameClick(this, EventArgs.Empty);
        }
        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ButLoadGameClick != null) ButLoadGameClick(this, EventArgs.Empty);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        #endregion

        #region Properties
        public string NamePlayer1
        {
            get
            {
                return lblPlayer1.Text;
            }
            set
            {
                lblPlayer1.Text = value;
            }
        }
        public string NameCPUPlayer
        {
            set
            {
                lblPlayer2.Text = value;
            }
        }
        public void HPPlayers(int player1, int player2)
        {
            lblHPPlayer1.Text = player1.ToString();
            progressBarPlayer1.Value = player1;
            lblHPPlayer2.Text = player2.ToString();
            progressBarPlayer2.Value = player2;
        }

        public int Title
        {
            set
            {
                lblTitle.Text = (value % 2 == 0) ? "Block!" : "Atack!";
            }
        }
        public int Rounds
        {
            set
            {
                lblRounds.Text = value.ToString();
            }
        }
        public string Log
        {
            set
            {
                listBoxLog.Items.Add(value);
            }
        }
        #endregion
    }
}

