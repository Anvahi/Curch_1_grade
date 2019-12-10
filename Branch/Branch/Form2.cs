using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Branch
{
    public partial class Choice : Form
    {
        public Choice()
        {
            InitializeComponent();
        }
        
        private void returnOnmain_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu go = new MainMenu();
            go.Show();
            this.Close();
        }

        private void Beginner_Click(object sender, EventArgs e)
        {
            Mode.Select = 3;
            Hide();
            Game go = new Game();
            go.Show();
        }

        private void Intern_Click(object sender, EventArgs e)
        {
            Mode.Select = 5;
            Hide();
            Game go = new Game();
            go.Show();
        }

        private SoundPlayer player;

        private void Choice_Closed_Click(object sender, FormClosedEventArgs e)
        {
            player = new SoundPlayer("Silence.wav");
            player.PlayLooping();
            Application.Exit();
            this.Close();
        }

        private void Choice_FormClosed(object sender, FormClosedEventArgs e)
        {
            player = new SoundPlayer("Silence.wav");
            player.PlayLooping();
            Application.Exit();
            this.Close();
        }
    }

    static class Mode
    {
        public static int Select { get; set; }
    }
}