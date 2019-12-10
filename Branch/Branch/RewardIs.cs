using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Branch
{
    public partial class RewardIs : Form
    {
        public const int pl = 21;

        public RewardIs()
        {
            InitializeComponent();
        }

        public struct player
        {
            public string login;
            public int point;
        }

        player[] Reward = new player[pl];

        private void Table_Of_Rewards(int mode)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("RewardList.xml");
            XmlElement xRoot = xDoc.DocumentElement;

            XmlNode get;
            get = xRoot.ChildNodes[mode];
            XmlNodeList node = get.ChildNodes;

            Reward[0].login = textBox1.Text;
            Reward[0].point = Points.IsWin;

            for (int i = 1; i < pl; i++)
            {
                XmlNodeList player = node[i - 1].ChildNodes;
                Reward[i].login = Convert.ToString(player[0].InnerText);
                Reward[i].point = Convert.ToInt32(player[1].InnerText);
            }

            Array.Sort(Reward, new Comparison<player>((a, b) => a.point.CompareTo(b.point)));

            for (int i = 0; i < pl - 1; i++)
            {
                XmlNodeList player = node[i].ChildNodes;
                player[0].InnerText = Reward[i].login;
                player[1].InnerText = Convert.ToString(Reward[i].point);
            }
            xDoc.Save("RewardList.xml");
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "" || textBox1.Text == " " || textBox1.Text == "  ")
                    label1.ForeColor = Color.Red;
                else
                {
                    if (Mode.Select == 3)
                        Table_Of_Rewards(0);
                    if (Mode.Select == 5)
                        Table_Of_Rewards(1);
                    this.Close();
                }
            }
        }
    }
}