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
using System.Xml;

namespace Branch
{
    public partial class MainMenu : Form
    {
        private SoundPlayer player;

        public MainMenu()
        {
            InitializeComponent();
            player = new SoundPlayer("ThemeOf_Itachi-san(Loop).wav");
            player.PlayLooping();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer("Silence.wav");
            player.PlayLooping();
            this.Close();
        }

        public const int pl = 20;

        private void Awards_Click(object sender, EventArgs e)
        {
            Exit.Visible = false;
            label1.Visible = false;
            Play.Visible = false;
            Awards.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            Award_return.Visible = true;
            label2.Visible = true;
            TableOfRewards3x3.Visible = true;
            TableOfRewards5x5.Visible = true;
            pictureAward.Visible = true;

            //Вывод рекордов
            TableOfRewards3x3.Items.Clear();
            TableOfRewards5x5.Items.Clear();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("RewardList.xml");
            XmlElement xRoot = xDoc.DocumentElement;

            XmlNode get;
            get = xRoot.ChildNodes[0];
            XmlNodeList node = get.ChildNodes;

            for (int i = 0; i < pl; i++)
            {
                XmlNodeList player = node[i].ChildNodes;
                if (player[0].InnerText != "empty" && player[1].InnerText != "100000000")
                    TableOfRewards3x3.Items.Add(Convert.ToString(player[0].InnerText) + "     " + Convert.ToString(player[1].InnerText));
                else
                    break;
            }

            XmlNode got;
            got = xRoot.ChildNodes[1];
            XmlNodeList nodes = got.ChildNodes;

            for (int i = 0; i < pl; i++)
            {
                XmlNodeList player = nodes[i].ChildNodes;
                if (player[0].InnerText != "empty" && player[1].InnerText != "100000000")
                    TableOfRewards5x5.Items.Add(Convert.ToString(player[0].InnerText) + "     " + Convert.ToString(player[1].InnerText));
                else
                    break;
            }
        }

        private void Award_return_Click(object sender, EventArgs e)
        {
            Exit.Visible = true;
            label1.Visible = true;
            Play.Visible = true;
            Awards.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            Award_return.Visible = false;
            label2.Visible = false;
            TableOfRewards3x3.Visible = false;
            TableOfRewards5x5.Visible = false;
            pictureAward.Visible = false;
        }

        private void Play_Click(object sender, EventArgs e)
        {
            Hide();
            Choice go = new Choice();
            go.Show();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            player = new SoundPlayer("Silence.wav");
            player.PlayLooping();
            this.Close();
            Application.Exit();
        }

        private void MainMenu_FormClose_Click(object sender, FormClosedEventArgs e)
        {
            player = new SoundPlayer("Silence.wav");
            player.PlayLooping();
            this.Close();
            Application.Exit();
        }
    }
}