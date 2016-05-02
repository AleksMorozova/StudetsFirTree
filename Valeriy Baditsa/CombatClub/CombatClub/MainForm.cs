using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatClub
{    
    public partial class MainForm : Form, IMainForm
    {        
        Presenter presenter;
        public event EventHandler HeadClick; 
        public event EventHandler BodyClick;
        public event EventHandler LegsClick;
        public event EventHandler newGameToolStripMenuItemClick;
        public event EventHandler loadGameToolStripMenuItemClick;
        public event EventHandler saveGameToolStripMenuItemClick;

        public MainForm()
        {            
            InitializeComponent();
            buttonHead.Click += buttonHead_Click;
            buttonBody.Click += buttonBody_Click;
            buttonLegs.Click += buttonLegs_Click;

            newGameToolStripMenuItem.Click +=newGameToolStripMenuItem_Click;
            loadGameToolStripMenuItem.Click += loadGameToolStripMenuItem_Click;
            saveGameToolStripMenuItem.Click += saveGameToolStripMenuItem_Click;

            presenter = new Presenter(this);                       
        }

        public void SetBinding(IPlayer player, IPlayer comp)
        {
            Binding binding;           
            binding = new Binding("Text", player, "Hp");
            labelPlayerHP.DataBindings.Add(binding);
            binding = new Binding("Text", comp, "Hp");
            labelCompPlayerHP.DataBindings.Add(binding);

            binding = new Binding("Text", player, "Name");
            labelPlayerName.DataBindings.Add(binding);
            binding = new Binding("Text", comp, "Name");
            labelCompPlayerName.DataBindings.Add(binding);
                        
            binding = new Binding("Value", player, "Hp");
            progressBarPlayer.DataBindings.Add(binding);

            //progressBarComputer.Maximum = comp.HP;
            binding = new Binding("Value", comp, "Hp");
            progressBarComputer.DataBindings.Add(binding);            
        }

        public ProgressBar ProgressBar_Player 
        {
            get { return progressBarPlayer; }            
        }
        public ProgressBar ProgressBar_CompName 
        {
            get { return progressBarComputer; }
        }       

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {              
            if (newGameToolStripMenuItemClick != null)
                newGameToolStripMenuItemClick(this, EventArgs.Empty);
        }        

        public string LstBox
        {
            set { listBox1.Items.Add(value); }
        }

        public void buttonText(string text)
        {
            buttonHead.Text = text + " head";
            buttonBody.Text = text + " body";
            buttonLegs.Text = text + " legs";
        }

        public bool buttonVisible
        {
            set 
            { 
                buttonHead.Visible = value;
                buttonLegs.Visible = value;
                buttonBody.Visible = value;
            }
        }                     
        
        void buttonHead_Click(object sender, EventArgs e)
        {
             if (BodyClick != null)
                BodyClick(this, EventArgs.Empty);
        }

        void buttonLegs_Click(object sender, EventArgs e)
        {
            if (LegsClick != null)
                LegsClick(this, EventArgs.Empty);
        }

        void buttonBody_Click(object sender, EventArgs e)
        {
            if (BodyClick != null)
                BodyClick(this, EventArgs.Empty);
        }

        void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (saveGameToolStripMenuItemClick != null)
                saveGameToolStripMenuItemClick(this, EventArgs.Empty);
        }

        void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadGameToolStripMenuItemClick != null)
                loadGameToolStripMenuItemClick(this, EventArgs.Empty);
        }
                                
    }
}
