using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPSong
{
    public partial class MainForm : Form, IMainForm
    {
        public void ListBoxAddItem(string item)
        {
            listBoxMesssage.Items.Add(item);
        }
        public event EventHandler buttonPlaySongClick;

        public MainForm()
        {
            InitializeComponent();
            buttonPlaySong.Click += buttonPlaySong_Click;
        }

        void buttonPlaySong_Click(object sender, EventArgs e)
        {
            if (buttonPlaySongClick != null)
                buttonPlaySongClick(this, EventArgs.Empty);
        }

        
    }
}
