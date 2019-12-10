using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Branch // 1491
{
    public partial class Game : Form
    {

        private void Mode3x3()
        {
            pictureBox84.Enabled = true;
            pictureBox83.Enabled = true;
            pictureBox82.Enabled = true;
            pictureBox73.Enabled = true;
            pictureBox72.Enabled = true;
            pictureBox71.Enabled = true;
            pictureBox62.Enabled = true;
            pictureBox61.Enabled = false;
            pictureBox60.Enabled = true;
        }

        private void Mode5x5()
        {
            Mode3x3();
            pictureBox30.Enabled = true;
            pictureBox29.Enabled = true;
            pictureBox28.Enabled = false;
            pictureBox27.Enabled = true;
            pictureBox26.Enabled = true;
            pictureBox85.Enabled = true;
            pictureBox81.Enabled = true;
            pictureBox63.Enabled = true;
            pictureBox59.Enabled = true;
            pictureBox74.Enabled = true;
            pictureBox70.Enabled = true;
            pictureBox52.Enabled = true;
            pictureBox51.Enabled = true;
            pictureBox49.Enabled = true;
            pictureBox48.Enabled = true;
            pictureBox50.Enabled = true;
        }

        //private void Mode7x7()
        //{
        //    Mode5x5();
        //    pictureBox31.Enabled = true;
        //    pictureBox25.Enabled = true;
        //    pictureBox86.Enabled = true;
        //    pictureBox80.Enabled = true;
        //    pictureBox64.Enabled = true;
        //    pictureBox58.Enabled = true;
        //    pictureBox42.Enabled = true;
        //    pictureBox41.Enabled = true;
        //    pictureBox40.Enabled = true;
        //    pictureBox39.Enabled = true;
        //    pictureBox38.Enabled = true;
        //    pictureBox37.Enabled = true;
        //    pictureBox36.Enabled = true;
        //    pictureBox75.Enabled = true;
        //    pictureBox69.Enabled = true;
        //    pictureBox47.Enabled = true;
        //    pictureBox53.Enabled = true;
        //    pictureBox119.Enabled = true;
        //    pictureBox118.Enabled = true;
        //    pictureBox117.Enabled = true;
        //    pictureBox116.Enabled = true;
        //    pictureBox115.Enabled = true;
        //    pictureBox114.Enabled = true;
        //    pictureBox113.Enabled = true;
        //} 

        int count30 = 0, count29 = 0, count27 = 0, count26 = 0, count85 = 0, count81 = 0, 
            count74 = 0, count70 = 0, count63 = 0, count59 = 0, count52 = 0, count51 = 0, 
            count50 = 0, count49 = 0, count48 = 0, count84 = 0, count83 = 0, count82 = 0, 
            count73 = 0, count72 = 0, count71 = 0, count62 = 0, count61 = 0, count60 = 0;

        public Game()
        {
            InitializeComponent();
            label2.Text = "";
            if (Mode.Select == 3)
            {
                Points.IsWin = 0;
                label1.Text = "Новичок";
                Mode3x3();
                
            }
            if (Mode.Select == 5)
            {
                Points.IsWin = 0;
                Mode5x5();
                label1.Text = "Стажёр";
            }
            //if (Mode.Select == 7)
            //{
            //    Mode7x7();
            //    label1.Text = "Профи";
            //}
            
            if (Mode.Select == 3)
            {
                pictureBox84.Image = Image.FromFile("DeadFlower.png");
                pictureBox84.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                count84++;
                pictureBox84.Refresh();
                pictureBox83.Image = Image.FromFile("DeadCorner.png");
                pictureBox83.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                count83++;
                pictureBox83.Refresh();
                pictureBox82.Image = Image.FromFile("DeadFlower.png");
                pictureBox82.Refresh();
                pictureBox73.Image = Image.FromFile("DeadStick.png");
                pictureBox73.Refresh();
                pictureBox72.Image = Image.FromFile("DeadCorner.png");
                pictureBox72.Refresh();
                pictureBox71.Image = Image.FromFile("DeadCorner.png");
                pictureBox71.Refresh();
                pictureBox62.Image = Image.FromFile("DeadCorner.png");
                pictureBox62.Refresh();
                pictureBox61.Image = Image.FromFile("Stick.png");//нельзя повернуть
                pictureBox61.Refresh();
                pictureBox60.Image = Image.FromFile("DeadCorner.png");
                pictureBox60.Refresh();
            }
            
            if (Mode.Select == 5)
            {
                pictureBox30.Image = Image.FromFile("DeadCorner.png");
                pictureBox30.Refresh();
                pictureBox29.Image = Image.FromFile("DeadThird.png");
                pictureBox29.Refresh();
                pictureBox28.Image = Image.FromFile("Third.png");
                pictureBox28.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                pictureBox28.Refresh();
                pictureBox27.Image = Image.FromFile("DeadStick.png");
                pictureBox27.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                count27++;
                pictureBox27.Refresh();
                pictureBox26.Image = Image.FromFile("DeadCorner.png");
                pictureBox26.Refresh();
                pictureBox85.Image = Image.FromFile("DeadStick.png");
                pictureBox85.Refresh();
                pictureBox84.Image = Image.FromFile("DeadFlower.png");
                pictureBox84.Refresh();
                pictureBox83.Image = Image.FromFile("DeadStick.png");
                pictureBox83.Refresh();
                pictureBox82.Image = Image.FromFile("DeadFlower.png");
                pictureBox82.Refresh();
                pictureBox81.Image = Image.FromFile("DeadThird.png");
                pictureBox81.Refresh();
                pictureBox74.Image = Image.FromFile("DeadThird.png");
                pictureBox74.Refresh();
                pictureBox73.Image = Image.FromFile("DeadCorner.png");
                pictureBox73.Refresh();
                pictureBox72.Image = Image.FromFile("DeadCorner.png");
                pictureBox72.Refresh();
                pictureBox71.Image = Image.FromFile("DeadFlower.png");
                pictureBox71.Refresh();
                pictureBox70.Image = Image.FromFile("DeadStick.png");
                pictureBox70.Refresh();
                pictureBox63.Image = Image.FromFile("DeadStick.png");
                pictureBox63.Refresh();
                pictureBox62.Image = Image.FromFile("DeadCorner.png");
                pictureBox62.Refresh();
                pictureBox61.Image = Image.FromFile("DeadStick.png");
                pictureBox61.Refresh();
                pictureBox60.Image = Image.FromFile("DeadFlower.png");
                pictureBox60.Refresh();
                pictureBox59.Image = Image.FromFile("DeadStick.png");
                pictureBox59.Refresh();
                pictureBox52.Image = Image.FromFile("DeadCorner.png");
                pictureBox52.Refresh();
                pictureBox51.Image = Image.FromFile("DeadFlower.png");
                pictureBox51.Refresh();
                pictureBox50.Image = Image.FromFile("DeadFlower.png");
                pictureBox50.Refresh();
                pictureBox49.Image = Image.FromFile("DeadStick.png");
                pictureBox49.Refresh();
                pictureBox48.Image = Image.FromFile("DeadCorner.png");
                pictureBox48.Refresh();
            }
        }

        private void IsYouWin()
        {
            if (Mode.Select == 3)
            {
                if (pictureBox84.Enabled == false &&
                    pictureBox83.Enabled == false &&
                    pictureBox82.Enabled == false &&
                    pictureBox73.Enabled == false &&
                    pictureBox72.Enabled == false &&
                    pictureBox71.Enabled == false &&
                    pictureBox62.Enabled == false &&
                    pictureBox61.Enabled == false &&
                    pictureBox60.Enabled == false)
                {
                    RewardIs go = new RewardIs();
                    go.ShowDialog();
                }
            }
            if (Mode.Select == 5)
            {
                if (pictureBox84.Enabled == false &&
                    pictureBox83.Enabled == false &&
                    pictureBox82.Enabled == false &&
                    pictureBox73.Enabled == false &&
                    pictureBox72.Enabled == false &&
                    pictureBox71.Enabled == false &&
                    pictureBox62.Enabled == false &&
                    pictureBox61.Enabled == false &&
                    pictureBox60.Enabled == false &&
                    pictureBox30.Enabled == false && 
                    pictureBox29.Enabled == false && 
                    pictureBox28.Enabled == false && 
                    pictureBox27.Enabled == false && 
                    pictureBox26.Enabled == false && 
                    pictureBox85.Enabled == false && 
                    pictureBox81.Enabled == false && 
                    pictureBox63.Enabled == false && 
                    pictureBox59.Enabled == false && 
                    pictureBox74.Enabled == false && 
                    pictureBox70.Enabled == false && 
                    pictureBox52.Enabled == false && 
                    pictureBox51.Enabled == false && 
                    pictureBox49.Enabled == false && 
                    pictureBox48.Enabled == false && 
                    pictureBox50.Enabled == false)
                {
                    RewardIs go = new RewardIs();
                    go.ShowDialog();
                }
            }
        }

        private void AliveFlower(PictureBox pictureBox, int count)
        {
            pictureBox.Image = Image.FromFile("Flower.png");
            for (int i = 0; i < count; i++)
                pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox.Refresh();
            pictureBox.Enabled = false;
        }

        private void AliveStick(PictureBox pictureBox, int count)
        {
            pictureBox.Image = Image.FromFile("Stick.png");
            for (int i = 0; i < count; i++)
                pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox.Refresh();
            pictureBox.Enabled = false;
        }

        private void AliveCorner(PictureBox pictureBox, int count)
        {
            pictureBox.Image = Image.FromFile("Corner.png");
            for (int i = 0; i < count; i++)
                pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox.Refresh();
            pictureBox.Enabled = false;
        }

        private void AliveThird(PictureBox pictureBox, int count)
        {
            pictureBox.Image = Image.FromFile("Third.png");
            for (int i = 0; i < count; i++)
                pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox.Refresh();
            pictureBox.Enabled = false;
        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {
            if (Mode.Select == 5)
            {
                pictureBox49.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox49.Refresh();
                count49++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if (count49 % 2 == 0 && count48 % 2 == 0 && count48 % 4 != 0 && count59 % 2 != 0 && 
                    count70 % 2 != 0 && (count81 == 3 || count81 == 7 || count81 == 11 || count81 == 15 || 
                    count81 == 19 || count81 == 23 || count81 == 27 || count81 == 31 || count81 == 35) && 
                    (count26 == 1 || count26 == 5 || count26 == 9 || count26 == 13 || count26 == 17 || 
                    count26 == 21 || count26 == 25 || count26 == 29 || count26 == 33) && count27 % 2 == 0)
                {
                    AliveStick(pictureBox49, count49);
                    if (count50 == 3 || count50 == 7 || count50 == 11 || count50 == 15 || count50 == 19 ||
                        count50 == 23 || count50 == 27 || count50 == 31 || count50 == 35)
                        AliveFlower(pictureBox50, count50);
                }
            }
            IsYouWin();
        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {
            if (Mode.Select == 5)
            {
                pictureBox48.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox48.Refresh();
                count48++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if (count48 % 2 == 0 && count48 % 4 != 0 && count59 % 2 != 0 &&
                    count70 % 2 != 0 && (count81 == 3 || count81 == 7 || count81 == 11 || count81 == 15 ||
                    count81 == 19 || count81 == 23 || count81 == 27 || count81 == 31 || count81 == 35) &&
                    (count26 == 1 || count26 == 5 || count26 == 9 || count26 == 13 || count26 == 17 ||
                    count26 == 21 || count26 == 25 || count26 == 29 || count26 == 33) && count27 % 2 == 0)
                {
                    AliveCorner(pictureBox48, count48);
                    if (count49 % 2 == 0)
                    {
                        AliveStick(pictureBox49, count49);
                        if (count50 == 3 || count50 == 7 || count50 == 11 || count50 == 15 || count50 == 19 ||
                            count50 == 23 || count50 == 27 || count50 == 31 || count50 == 35)
                            AliveFlower(pictureBox50, count50);
                    }
                }
            }
            IsYouWin();
        }

        private void pictureBox70_Click(object sender, EventArgs e)
        {
            if (Mode.Select == 5)
            {
                pictureBox70.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox70.Refresh();
                count70++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if (count70 % 2 != 0 && (count81 == 3 || count81 == 7 || count81 == 11 || count81 == 15 ||
                    count81 == 19 || count81 == 23 || count81 == 27 || count81 == 31 || count81 == 35) &&
                    (count26 == 1 || count26 == 5 || count26 == 9 || count26 == 13 || count26 == 17 ||
                    count26 == 21 || count26 == 25 || count26 == 29 || count26 == 33) && count27 % 2 == 0)
                {
                    AliveStick(pictureBox70, count70);
                    if (count59 % 2 != 0)
                    {
                        AliveStick(pictureBox59, count59);
                        if (count48 % 2 == 0 && count48 % 4 != 0)
                        {
                            AliveCorner(pictureBox48, count48);
                            if (count49 % 2 == 0)
                            {
                                AliveStick(pictureBox49, count49);
                                if (count50 == 3 || count50 == 7 || count50 == 11 || count50 == 15 || count50 == 19 ||
                                    count50 == 23 || count50 == 27 || count50 == 31 || count50 == 35)
                                    AliveFlower(pictureBox50, count50);
                            }
                        }
                    }
                }
            }
            IsYouWin();
        }

        private void pictureBox81_Click(object sender, EventArgs e)
        {
            if (Mode.Select == 5)
            {
                pictureBox81.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox81.Refresh();
                count81++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if ((count81 == 3 || count81 == 7 || count81 == 11 || count81 == 15 ||
                    count81 == 19 || count81 == 23 || count81 == 27 || count81 == 31 || count81 == 35) &&
                    (count26 == 1 || count26 == 5 || count26 == 9 || count26 == 13 || count26 == 17 ||
                    count26 == 21 || count26 == 25 || count26 == 29 || count26 == 33) && count27 % 2 == 0)
                {
                    AliveThird(pictureBox81, count81);
                    if (count70 % 2 != 0)
                    {
                        AliveStick(pictureBox70, count70);
                        if (count59 % 2 != 0)
                        {
                            AliveStick(pictureBox59, count59);
                            if (count48 % 2 == 0 && count48 % 4 != 0)
                            {
                                AliveCorner(pictureBox48, count48);
                                if (count49 % 2 == 0)
                                {
                                    AliveStick(pictureBox49, count49);
                                    if (count50 == 3 || count50 == 7 || count50 == 11 || count50 == 15 || count50 == 19 ||
                                        count50 == 23 || count50 == 27 || count50 == 31 || count50 == 35)
                                        AliveFlower(pictureBox50, count50);
                                }
                            }
                        }
                    }
                    if (count82 == 3 || count82 == 7 || count82 == 11 || count82 == 15 ||
                    count82 == 19 || count82 == 23 || count82 == 27 || count82 == 31 || count82 == 35)
                        AliveFlower(pictureBox82, count82);
                }
            }
            IsYouWin();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            if (Mode.Select == 5)
            {
                pictureBox26.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox26.Refresh();
                count26++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if ((count26 == 1 || count26 == 5 || count26 == 9 || count26 == 13 || count26 == 17 ||
                    count26 == 21 || count26 == 25 || count26 == 29 || count26 == 33) && count27 % 2 == 0)
                {
                    AliveCorner(pictureBox26, count26);
                    if (count81 == 3 || count81 == 7 || count81 == 11 || count81 == 15 ||
                    count81 == 19 || count81 == 23 || count81 == 27 || count81 == 31 || count81 == 35)
                    {
                        AliveThird(pictureBox81, count81);
                        if (count70 % 2 != 0)
                        {
                            AliveStick(pictureBox70, count70);
                            if (count59 % 2 != 0)
                            {
                                AliveStick(pictureBox59, count59);
                                if (count48 % 2 == 0 && count48 % 4 != 0)
                                {
                                    AliveCorner(pictureBox48, count48);
                                    if (count49 % 2 == 0)
                                    {
                                        AliveStick(pictureBox49, count49);
                                        if (count50 == 3 || count50 == 7 || count50 == 11 || count50 == 15 || count50 == 19 ||
                                            count50 == 23 || count50 == 27 || count50 == 31 || count50 == 35)
                                            AliveFlower(pictureBox50, count50);
                                    }
                                }
                            }
                        }
                        if (count82 == 3 || count82 == 7 || count82 == 11 || count82 == 15 ||
                        count82 == 19 || count82 == 23 || count82 == 27 || count82 == 31 || count82 == 35)
                            AliveFlower(pictureBox82, count82);
                    }
                }
            }
            IsYouWin();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            if (Mode.Select == 5)
            {
                pictureBox27.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox27.Refresh();
                count27++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if (count27 % 2 == 0)
                {
                    AliveStick(pictureBox27, count27);
                    if (count26 == 1 || count26 == 5 || count26 == 9 || count26 == 13 || count26 == 17 ||
                    count26 == 21 || count26 == 25 || count26 == 29 || count26 == 33)
                    {
                        AliveCorner(pictureBox26, count26);
                        if (count81 == 3 || count81 == 7 || count81 == 11 || count81 == 15 ||
                        count81 == 19 || count81 == 23 || count81 == 27 || count81 == 31 || count81 == 35)
                        {
                            AliveThird(pictureBox81, count81);
                            if (count70 % 2 != 0)
                            {
                                AliveStick(pictureBox70, count70);
                                if (count59 % 2 != 0)
                                {
                                    AliveStick(pictureBox59, count59);
                                    if (count48 % 2 == 0 && count48 % 4 != 0)
                                    {
                                        AliveCorner(pictureBox48, count48);
                                        if (count49 % 2 == 0)
                                        {
                                            AliveStick(pictureBox49, count49);
                                            if (count50 == 3 || count50 == 7 || count50 == 11 || count50 == 15 || count50 == 19 ||
                                                count50 == 23 || count50 == 27 || count50 == 31 || count50 == 35)
                                                AliveFlower(pictureBox50, count50);
                                        }
                                    }
                                }
                            }
                            if (count82 == 3 || count82 == 7 || count82 == 11 || count82 == 15 ||
                            count82 == 19 || count82 == 23 || count82 == 27 || count82 == 31 || count82 == 35)
                                AliveFlower(pictureBox82, count82);
                        }
                    }
                }
            }
            IsYouWin();
        }

        private void pictureBox85_Click(object sender, EventArgs e)
        {
            if (Mode.Select == 5)
            {
                pictureBox85.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox85.Refresh();
                count85++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if (count85 % 2 != 0 &&
                    count30 % 4 == 0 && count30 % 2 == 0 && count29 % 4 != 0 && count29 % 2 == 0)
                {
                    AliveStick(pictureBox85, count85);
                    if (count74 == 1 || count74 == 5 ||
                    count74 == 9 || count74 == 13 || count74 == 17 || count74 == 21 ||
                    count74 == 25 || count74 == 29 || count74 == 33)
                    {
                        AliveThird(pictureBox74, count74);
                        if (count63 % 2 != 0)
                            AliveStick(pictureBox63, count63);
                        {
                            if (count52 == 3 || count52 == 7 || count52 == 11 || count52 == 15 ||
                            count52 == 19 || count52 == 23 || count52 == 27 || count52 == 31 ||
                            count52 == 35)
                            {
                                AliveCorner(pictureBox52, count52);
                                if (count51 == 1 || count51 == 5 || count51 == 9 || count51 == 13 || count51 == 17 ||
                                count51 == 21 || count51 == 25 || count51 == 29 || count51 == 33)
                                    AliveFlower(pictureBox51, count51);
                            }
                        }
                        if ((count73 == 1 ||
                            count73 == 5 || count73 == 9 || count73 == 13 || count73 == 17 ||
                            count73 == 21 || count73 == 25 || count73 == 29 || count73 == 33))
                        {
                            AliveCorner(pictureBox73, count73);
                            if (count62 == 3 || count62 == 7 || count62 == 11 || count62 == 15 || count62 == 19 ||
                                    count62 == 23 || count62 == 27 || count62 == 31 || count62 == 35)
                            {
                                AliveCorner(pictureBox62, count62);
                                if (count61 % 2 == 0)
                                {
                                    AliveStick(pictureBox61, count61);
                                    if (count60 == 1 || count60 == 5 || count60 == 9 || count60 == 13 || count60 == 17 ||
                                        count60 == 21 || count60 == 25 || count60 == 29 || count60 == 33)
                                        AliveFlower(pictureBox60, count60);
                                }
                            }
                        }

                    }
                }
            }
            IsYouWin();
        }

        private void pictureBox61_Click(object sender, EventArgs e)
        {
            if (Mode.Select == 5)
            {
                pictureBox61.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox61.Refresh();
                count61++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if (count61 % 2 == 0 && (count73 == 1 ||
                    count73 == 5 || count73 == 9 || count73 == 13 || count73 == 17 ||
                    count73 == 21 || count73 == 25 || count73 == 29 || count73 == 33) &&
                    (count62 == 3 || count62 == 7 || count62 == 11 || count62 == 15 || count62 == 19 ||
                    count62 == 23 || count62 == 27 || count62 == 31 || count62 == 35) && (count74 == 1 || count74 == 5 ||
                    count74 == 9 || count74 == 13 || count74 == 17 || count74 == 21 ||
                    count74 == 25 || count74 == 29 || count74 == 33) && count85 % 2 != 0 &&
                    count30 % 4 == 0 && count30 % 2 == 0 && count29 % 4 != 0 && count29 % 2 == 0)
                {
                    AliveStick(pictureBox61, count61);
                    if (count60 == 1 || count60 == 5 || count60 == 9 || count60 == 13 || count60 == 17 ||
                    count60 == 21 || count60 == 25 || count60 == 29 || count60 == 33)
                        AliveFlower(pictureBox60, count60);
                }
            }
            IsYouWin();
        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {
            if (Mode.Select == 5)
            {
                pictureBox50.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox50.Refresh();
                count50++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if ((count50 == 3 || count50 == 7 || count50 == 11 || count50 == 15 || count50 == 19 ||
                    count50 == 23 || count50 == 27 || count50 == 31 || count50 == 35) && count49%2 == 0 &&
                    count48%2 == 0 && count48%4 != 0 && count59%2 != 0 && count70%2 != 0 && (count81 == 3 || 
                    count81 == 7 || count81 == 11 || count81 == 15 || count81 == 19 || count81 == 23 || 
                    count81 == 27 || count81 == 31 || count81 == 35) && (count26 == 1 || count26 == 5 ||
                    count26 == 9 || count26 == 13 || count26 == 17 || count26 == 21 || count26 == 25 || 
                    count26 == 29 || count26 == 33) && count27%2 == 0)
                {
                    AliveFlower(pictureBox50, count50);
                }
            }
            IsYouWin();
        }

        private void pictureBox74_Click(object sender, EventArgs e)
        {
            if (Mode.Select == 5)
            {
                pictureBox74.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox74.Refresh();
                count74++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if ((count74 == 1 || count74 == 5 ||
                    count74 == 9 || count74 == 13 || count74 == 17 || count74 == 21 ||
                    count74 == 25 || count74 == 29 || count74 == 33) && count85 % 2 != 0 &&
                    count30 % 4 == 0 && count30 % 2 == 0 && count29 % 4 != 0 && count29 % 2 == 0)
                {
                    AliveThird(pictureBox74, count74);
                    if ((count73 == 1 ||
                    count73 == 5 || count73 == 9 || count73 == 13 || count73 == 17 ||
                    count73 == 21 || count73 == 25 || count73 == 29 || count73 == 33))
                    {
                        AliveCorner(pictureBox73, count73);
                        if (count62 == 3 || count62 == 7 || count62 == 11 || count62 == 15 || count62 == 19 ||
                                count62 == 23 || count62 == 27 || count62 == 31 || count62 == 35)
                        {
                            AliveCorner(pictureBox62, count62);
                            if (count61 % 2 == 0)
                            {
                                AliveStick(pictureBox61, count61);
                                if (count60 == 1 || count60 == 5 || count60 == 9 || count60 == 13 || count60 == 17 ||
                                count60 == 21 || count60 == 25 || count60 == 29 || count60 == 33)
                                    AliveFlower(pictureBox60, count60);
                            }
                        }
                    }
                    if (count63 % 2 != 0)
                    {
                        AliveStick(pictureBox63, count63);
                        if (count52 == 3 || count52 == 7 || count52 == 11 || count52 == 15 ||
                        count52 == 19 || count52 == 23 || count52 == 27 || count52 == 31 ||
                        count52 == 35)
                        {
                            AliveCorner(pictureBox52, count52);
                            if (count51 == 1 || count51 == 5 || count51 == 9 || count51 == 13 || count51 == 17 ||
                            count51 == 21 || count51 == 25 || count51 == 29 || count51 == 33)
                                AliveFlower(pictureBox51, count51);
                        }
                    }
                }
            }
            IsYouWin();
        }

        private void pictureBox51_Click(object sender, EventArgs e)
        {
            if (Mode.Select == 5)
            {
                pictureBox51.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox51.Refresh();
                count51++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if ((count51 == 1 || count51 == 5 || count51 == 9 || count51 == 13 || count51 == 17 ||
                    count51 == 21 || count51 == 25 || count51 == 29 || count51 == 33) && (count52 == 3 ||
                    count52 == 7 || count52 == 11 || count52 == 15 || count52 == 19 || count52 == 23 ||
                    count52 == 27 || count52 == 31 || count52 == 35) && count63 % 2 != 0 && (count74 == 1 ||
                    count74 == 5 || count74 == 9 || count74 == 13 || count74 == 17 || count74 == 21 ||
                    count74 == 25 || count74 == 29 || count74 == 33) && count85 % 2 != 0 && count30 % 4 == 0 &&
                    count30 % 2 == 0 && count29 % 4 != 0 && count29 % 2 == 0)
                {
                    AliveFlower(pictureBox51, count51);
                }
            }
            IsYouWin();
        }

        private void pictureBox52_Click(object sender, EventArgs e)
        {
            if (Mode.Select == 5)
            {
                pictureBox52.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox52.Refresh();
                count52++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if ((count52 == 3 || count52 == 7 || count52 == 11 || count52 == 15 ||
                    count52 == 19 || count52 == 23 || count52 == 27 || count52 == 31 ||
                    count52 == 35) && count63 % 2 != 0 && (count74 == 1 || count74 == 5 ||
                    count74 == 9 || count74 == 13 || count74 == 17 || count74 == 21 ||
                    count74 == 25 || count74 == 29 || count74 == 33) && count85 % 2 != 0 &&
                    count30 % 4 == 0 && count30 % 2 == 0 && count29 % 4 != 0 && count29 % 2 == 0)
                {
                    AliveCorner(pictureBox52, count52);
                    if (count51 == 1 || count51 == 5 || count51 == 9 || count51 == 13 || count51 == 17 ||
                    count51 == 21 || count51 == 25 || count51 == 29 || count51 == 33)
                        AliveFlower(pictureBox51, count51);
                }
            }
            IsYouWin();
        }

        private void pictureBox63_Click(object sender, EventArgs e)
        {
            if (Mode.Select == 5)
            {
                pictureBox63.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox63.Refresh();
                count63++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if (count63 % 2 != 0 && (count74 == 1 || count74 == 5 ||
                    count74 == 9 || count74 == 13 || count74 == 17 || count74 == 21 ||
                    count74 == 25 || count74 == 29 || count74 == 33) && count85 % 2 != 0 &&
                    count30 % 4 == 0 && count30 % 2 == 0 && count29 % 4 != 0 && count29 % 2 == 0)
                {
                    AliveStick(pictureBox63, count63);
                    if (count52 == 3 || count52 == 7 || count52 == 11 || count52 == 15 ||
                    count52 == 19 || count52 == 23 || count52 == 27 || count52 == 31 ||
                    count52 == 35)
                        AliveCorner(pictureBox52, count52);
                    if (count51 == 1 || count51 == 5 || count51 == 9 || count51 == 13 || count51 == 17 ||
                    count51 == 21 || count51 == 25 || count51 == 29 || count51 == 33)
                        AliveFlower(pictureBox51, count51);
                }

            }
            IsYouWin();
        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {
            if (Mode.Select == 5)
            {
                pictureBox59.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox59.Refresh();
                count59++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if (count59 % 2 != 0 &&
                    count70 % 2 != 0 && (count81 == 3 || count81 == 7 || count81 == 11 || count81 == 15 ||
                    count81 == 19 || count81 == 23 || count81 == 27 || count81 == 31 || count81 == 35) &&
                    (count26 == 1 || count26 == 5 || count26 == 9 || count26 == 13 || count26 == 17 ||
                    count26 == 21 || count26 == 25 || count26 == 29 || count26 == 33) && count27 % 2 == 0)
                {
                    AliveStick(pictureBox59, count59);
                    if (count48 % 2 == 0 && count48 % 4 != 0)
                    {
                        AliveCorner(pictureBox48, count48);
                        if (count49 % 2 == 0)
                        {
                            AliveStick(pictureBox49, count49);
                            if (count50 == 3 || count50 == 7 || count50 == 11 || count50 == 15 || count50 == 19 ||
                                count50 == 23 || count50 == 27 || count50 == 31 || count50 == 35)
                                AliveFlower(pictureBox50, count50);
                        }
                    }
                }
            }
            IsYouWin();
        }

        private void pictureBox84_Click(object sender, EventArgs e)
        {
            //playBreakBranch();
            if (Mode.Select == 3)
            {
                pictureBox84.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox84.Refresh();
                count84++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if (count84%4 == 0 && count73 % 2 != 0 && (count62 % 3 == 0 && count62 != 0))
                {
                    AliveStick(pictureBox73, count73);
                    AliveFlower(pictureBox84, count84);
                }
            }
            if(Mode.Select == 5)
            {
                pictureBox84.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox84.Refresh();
                count84++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if (count84 % 4 != 0 && count84 % 2 == 0 && count29 % 4 != 0 && count29 % 2 == 0 && count29 != 0)
                    AliveFlower(pictureBox84, count84);
            }
            IsYouWin();
        }

        private void pictureBox83_Click(object sender, EventArgs e)
        {
            if (Mode.Select == 3)
            {
                pictureBox83.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox83.Refresh();
                count83++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if ((count60 % 2 == 0 && count60 % 4 != 0) && (count71 == 1 || count71 == 5 || 
                    count71 == 9 || count71 == 13 || count71 == 17) && (count72 == 3 || 
                    count72 == 7 || count72 == 11 || count72 == 15) && count83 % 4 == 0)
                {
                    AliveCorner(pictureBox83, count83);
                    if (count82 == 1 || count82 == 5 || count82 == 9 || count82 == 13 || count82 == 17)
                        AliveFlower(pictureBox82, count82);
                }
            }
            if (Mode.Select == 5)
            {
                pictureBox83.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox83.Refresh();
                count83++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if (count83 % 2 != 0)
                {
                    AliveStick(pictureBox83, count83);
                    if (count72 == 3 || count72 == 7 || count72 == 11 ||
                    count72 == 15 || count72 == 19 || count72 == 23 || count72 == 27 || count72 == 31 || count72 == 35)
                    {
                        AliveCorner(pictureBox72, count72);
                        if (count71 == 1 || count71 == 5 || count71 == 9 || count71 == 13 || count71 == 17 || count71 == 21 ||
                        count71 == 25 || count71 == 29 || count71 == 33)
                            AliveFlower(pictureBox71, count71);
                    }

                }
            }
            IsYouWin();
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            if (Mode.Select == 5)
            {
                pictureBox30.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox30.Refresh();
                count30++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if (count30 % 4 == 0 && count30 % 2 == 0 && count29 % 4 != 0 && count29 % 2 == 0)
                {
                    AliveCorner(pictureBox30, count30);
                    if (count85 % 2 != 0)
                        AliveStick(pictureBox85, count85);
                    if (count74 == 1 || count74 == 5 ||
                    count74 == 9 || count74 == 13 || count74 == 17 || count74 == 21 ||
                    count74 == 25 || count74 == 29 || count74 == 33)
                    {
                        AliveThird(pictureBox74, count74);
                        if (count63 % 2 != 0)
                            AliveStick(pictureBox63, count63);
                        {
                            if (count52 == 3 || count52 == 7 || count52 == 11 || count52 == 15 ||
                            count52 == 19 || count52 == 23 || count52 == 27 || count52 == 31 ||
                            count52 == 35)
                            {
                                AliveCorner(pictureBox52, count52);
                                if (count51 == 1 || count51 == 5 || count51 == 9 || count51 == 13 || count51 == 17 ||
                                count51 == 21 || count51 == 25 || count51 == 29 || count51 == 33)
                                    AliveFlower(pictureBox51, count51);
                            }
                        }
                        if ((count73 == 1 ||
                            count73 == 5 || count73 == 9 || count73 == 13 || count73 == 17 ||
                            count73 == 21 || count73 == 25 || count73 == 29 || count73 == 33))
                        {
                            AliveCorner(pictureBox73, count73);
                            if (count62 == 3 || count62 == 7 || count62 == 11 || count62 == 15 || count62 == 19 ||
                                    count62 == 23 || count62 == 27 || count62 == 31 || count62 == 35)
                            {
                                AliveCorner(pictureBox62, count62);
                                if (count61 % 2 == 0)
                                {
                                    AliveStick(pictureBox61, count61);
                                    if (count60 == 1 || count60 == 5 || count60 == 9 || count60 == 13 || count60 == 17 ||
                                        count60 == 21 || count60 == 25 || count60 == 29 || count60 == 33)
                                        AliveFlower(pictureBox60, count60);
                                }
                            }
                        }
                    }
                }
            }
            IsYouWin();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            //playBreakBranch();
            if (Mode.Select == 5)
            {
                pictureBox29.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox29.Refresh();
                count29++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if (count29 % 4 != 0 && count29 % 2 == 0)
                {
                    AliveThird(pictureBox29, count29);
                    if (count30 % 4 == 0 && count30 % 2 == 0)
                    {
                        AliveCorner(pictureBox30, count30);
                        if (count85 % 2 != 0)
                            AliveStick(pictureBox85, count85);
                        if (count74 == 1 || count74 == 5 ||
                        count74 == 9 || count74 == 13 || count74 == 17 || count74 == 21 ||
                        count74 == 25 || count74 == 29 || count74 == 33)
                        {
                            AliveThird(pictureBox74, count74);
                            if (count63 % 2 != 0)
                                AliveStick(pictureBox63, count63);
                            {
                                if (count52 == 3 || count52 == 7 || count52 == 11 || count52 == 15 ||
                                count52 == 19 || count52 == 23 || count52 == 27 || count52 == 31 ||
                                count52 == 35)
                                {
                                    AliveCorner(pictureBox52, count52);
                                    if (count51 == 1 || count51 == 5 || count51 == 9 || count51 == 13 || count51 == 17 ||
                                    count51 == 21 || count51 == 25 || count51 == 29 || count51 == 33)
                                        AliveFlower(pictureBox51, count51);
                                }
                            }
                            if ((count73 == 1 ||
                                count73 == 5 || count73 == 9 || count73 == 13 || count73 == 17 ||
                                count73 == 21 || count73 == 25 || count73 == 29 || count73 == 33))
                            {
                                AliveCorner(pictureBox73, count73);
                                if (count62 == 3 || count62 == 7 || count62 == 11 || count62 == 15 || count62 == 19 ||
                                        count62 == 23 || count62 == 27 || count62 == 31 || count62 == 35)
                                {
                                    AliveCorner(pictureBox62, count62);
                                    if (count61 % 2 == 0)
                                    {
                                        AliveStick(pictureBox61, count61);
                                        if (count60 == 1 || count60 == 5 || count60 == 9 || count60 == 13 || count60 == 17 ||
                                            count60 == 21 || count60 == 25 || count60 == 29 || count60 == 33)
                                            AliveFlower(pictureBox60, count60);
                                    }
                                }
                            }
                        }
                    }
                    if (count84 % 4 != 0 && count84 % 2 == 0)
                        AliveFlower(pictureBox84, count84);
                }
            }
            IsYouWin();
        }

        private void pictureBox82_Click(object sender, EventArgs e)
        {
            if (Mode.Select == 3)
            {
                pictureBox82.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox82.Refresh();
                count82++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if ((count60 % 2 == 0 && count60 % 4 != 0) && (count71 == 1 || count71 == 5 || 
                    count71 == 9 || count71 == 13 || count71 == 17) && (count72 == 3 || 
                    count72 == 7 || count72 == 11 || count72 == 15) && count83 % 4 == 0 && 
                    (count82 == 1 || count82 == 5 || count82 == 9 || count82 == 13 || count82 == 17))
                {
                    AliveCorner(pictureBox83, count83);
                    AliveFlower(pictureBox82, count82);
                }
            }
            if (Mode.Select == 5)
            {
                pictureBox82.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox82.Refresh();
                count82++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if ((count82 == 3 || count82 == 7 || count82 == 11 || count82 == 15 ||
                    count82 == 19 || count82 == 23 || count82 == 27 || count82 == 31 || count82 == 35) && 
                    (count81 == 3 || count81 == 7 || count81 == 11 || count81 == 15 ||
                    count81 == 19 || count81 == 23 || count81 == 27 || count81 == 31 || count81 == 35) &&
                    (count26 == 1 || count26 == 5 || count26 == 9 || count26 == 13 || count26 == 17 ||
                    count26 == 21 || count26 == 25 || count26 == 29 || count26 == 33) && count27 % 2 == 0)
                {
                    AliveFlower(pictureBox82, count82);
                }
            }
            IsYouWin();
        }

        private void pictureBox73_Click(object sender, EventArgs e)
        {
            if (Mode.Select == 3)
            {
                pictureBox73.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox73.Refresh();
                count73++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if ((count62 % 3 == 0 && count62 != 0) && count73%2 != 0)
                {
                    AliveStick(pictureBox73, count73);
                    if(count84 % 4 == 0)
                        AliveFlower(pictureBox84, count84);
                }
            }
            if (Mode.Select == 5)
            {
                pictureBox73.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox73.Refresh();
                count73++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if ((count73 == 1 ||
                    count73 == 5 || count73 == 9 || count73 == 13 || count73 == 17 ||
                    count73 == 21 || count73 == 25 || count73 == 29 || count73 == 33)&& (count74 == 1 || count74 == 5 ||
                    count74 == 9 || count74 == 13 || count74 == 17 || count74 == 21 ||
                    count74 == 25 || count74 == 29 || count74 == 33) && count85 % 2 != 0 &&
                    count30 % 4 == 0 && count30 % 2 == 0 && count29 % 4 != 0 && count29 % 2 == 0)
                {
                    AliveCorner(pictureBox73, count73);
                    if (count62 == 3 || count62 == 7 || count62 == 11 || count62 == 15 || count62 == 19 ||
                            count62 == 23 || count62 == 27 || count62 == 31 || count62 == 35)
                    {
                        AliveCorner(pictureBox62, count62);
                        if (count61 % 2 == 0)
                        {
                            AliveStick(pictureBox61, count61);
                            if (count60 == 1 || count60 == 5 || count60 == 9 || count60 == 13 || count60 == 17 ||
                            count60 == 21 || count60 == 25 || count60 == 29 || count60 == 33)
                                AliveFlower(pictureBox60, count60);
                        }
                    }
                }
            }
            IsYouWin();
        }

        private void pictureBox72_Click(object sender, EventArgs e)
        {
            if (Mode.Select == 3)
            {
                pictureBox72.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox72.Refresh();
                count72++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if ((count60 % 2 == 0 && count60 % 4 != 0) && (count71 == 1 || count71 == 5 ||
                    count71 == 9 || count71 == 13 || count71 == 17) && (count72 == 3 || 
                    count72 == 7 || count72 == 11 || count72 == 15))
                {
                    AliveCorner(pictureBox72, count72);
                    if ( count83 % 4 == 0)
                        AliveCorner(pictureBox83, count83);
                    if ( count83 % 4 == 0 && (count82 == 1 || count82 == 5 || count82 == 9 || 
                        count82 == 13 || count82 == 17))
                    {
                        AliveCorner(pictureBox83, count83);
                        AliveFlower(pictureBox82, count82);
                    }
                }
            }
            if (Mode.Select == 5)
            {
                pictureBox72.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox72.Refresh();
                count72++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if ((count72 == 3 || count72 == 7 || count72 == 11 ||
                    count72 == 15 || count72 == 19 || count72 == 23 || count72 == 27 || count72 == 31 || count72 == 35) &&
                    count83 % 2 != 0)
                {
                    AliveCorner(pictureBox72, count72);
                    if (count71 == 1 || count71 == 5 || count71 == 9 || count71 == 13 || count71 == 17 || count71 == 21 ||
                    count71 == 25 || count71 == 29 || count71 == 33)
                        AliveFlower(pictureBox71, count71);
                }
            }
            IsYouWin();
        }

        private void pictureBox71_Click(object sender, EventArgs e)
        {
            if (Mode.Select == 3)
            {
                pictureBox71.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox71.Refresh();
                count71++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if ((count60 % 2 == 0 && count60 % 4 != 0) && (count71 == 1 || count71 == 5 || 
                    count71 == 9 || count71 == 13 || count71 == 17))
                {
                    AliveCorner(pictureBox71, count71);
                    if (count72 == 3 || count72 == 7 || count72 == 11 || count72 == 15)
                        AliveCorner(pictureBox72, count72);
                    if ((count72 == 3 || count72 == 7 || count72 == 11 || count72 == 15) && 
                        count83 % 4 == 0)
                    {
                        AliveCorner(pictureBox72, count72);
                        AliveCorner(pictureBox83, count83);
                    }
                    if ((count72 == 3 || count72 == 7 || count72 == 11 || count72 == 15) && 
                        count83 % 4 == 0 && (count82 == 1 || count82 == 5 || count82 == 9 || 
                        count82 == 13 || count82 == 17))
                    {
                        AliveCorner(pictureBox72, count72);
                        AliveCorner(pictureBox83, count83);
                        AliveFlower(pictureBox82, count82);
                    }
                }
            }
            if (Mode.Select == 5)
            {
                pictureBox71.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox71.Refresh();
                count71++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if ((count71 == 1 || count71 == 5 || count71 == 9 || count71 == 13 || count71 == 17 || count71 == 21 ||
                    count71 == 25 || count71 == 29 || count71 == 33) && (count72 == 3 || count72 == 7 || count72 == 11 || 
                    count72 == 15 || count72 == 19 || count72 == 23 || count72 == 27 || count72 == 31 || count72 == 35) &&
                    count83%2 != 0)
                {
                    AliveFlower(pictureBox71, count71);
                }
            }
            IsYouWin();
        }

        private void pictureBox62_Click(object sender, EventArgs e)
        {
            if (Mode.Select == 3)
            {
                pictureBox62.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox62.Refresh();
                count62++;//на 3 без остатка и !0
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if (count62 % 3 == 0 && count62 != 0)
                {
                    AliveCorner(pictureBox62, count62);
                    if (count73 % 2 != 0)
                    {
                        AliveStick(pictureBox73, count73);
                        if (count84 % 4 == 0 && count73 % 2 != 0)
                            AliveFlower(pictureBox84, count84);
                    }
                }
            }
            if (Mode.Select == 5)
            {
                pictureBox62.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox62.Refresh();
                count62++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if ((count73 == 1 ||
                    count73 == 5 || count73 == 9 || count73 == 13 || count73 == 17 ||
                    count73 == 21 || count73 == 25 || count73 == 29 || count73 == 33) && 
                    (count62 == 3 || count62 == 7 || count62 == 11 || count62 == 15 || count62 == 19 ||
                    count62 == 23 || count62 == 27 || count62 == 31 || count62 == 35) && (count74 == 1 || count74 == 5 ||
                    count74 == 9 || count74 == 13 || count74 == 17 || count74 == 21 ||
                    count74 == 25 || count74 == 29 || count74 == 33) && count85 % 2 != 0 &&
                    count30 % 4 == 0 && count30 % 2 == 0 && count29 % 4 != 0 && count29 % 2 == 0)
                {
                    AliveCorner(pictureBox62, count62);
                    if (count61 % 2 == 0)
                    {
                        AliveStick(pictureBox61, count61);
                        if (count60 == 1 || count60 == 5 || count60 == 9 || count60 == 13 || count60 == 17 ||
                        count60 == 21 || count60 == 25 || count60 == 29 || count60 == 33)
                            AliveFlower(pictureBox60, count60);
                    }
                }
            }
            IsYouWin();
        }

        private void pictureBox60_Click(object sender, EventArgs e)
        {
            if (Mode.Select == 3)
            {
                pictureBox60.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox60.Refresh();
                count60++;//%2==0 %4!=0
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if (count60 % 2 == 0 && count60 % 4 != 0)
                {
                    AliveCorner(pictureBox60, count60);
                    if (count71 == 1 || count71 == 5 ||
                    count71 == 9 || count71 == 13 || count71 == 17)
                        AliveCorner(pictureBox71, count71);
                    if ((count71 == 1 || count71 == 5 || count71 == 9 || count71 == 13 || count71 == 17) && 
                        (count72 == 3 || count72 == 7 || count72 == 11 || count72 == 15))
                        AliveCorner(pictureBox72, count72);
                    if ((count71 == 1 || count71 == 5 || count71 == 9 || count71 == 13 || count71 == 17) && 
                        (count72 == 3 || count72 == 7 || count72 == 11 || count72 == 15) && count83 % 4 == 0)
                    {
                        AliveCorner(pictureBox72, count72);
                        AliveCorner(pictureBox83, count83);
                    }
                    if ((count71 == 1 || count71 == 5 || count71 == 9 || count71 == 13 || count71 == 17) && (count72 == 3 || count72 == 7 || count72 == 11 || count72 == 15) && count83 % 4 == 0 && 
                    (count82 == 1 || count82 == 5 || count82 == 9 || count82 == 13 || count82 == 17))
                    {
                        AliveCorner(pictureBox72, count72);
                        AliveCorner(pictureBox83, count83);
                        AliveFlower(pictureBox82, count82);
                    }
                }
            }
            if (Mode.Select == 5)
            {
                pictureBox60.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox60.Refresh();
                count60++;
                label2.Text = Convert.ToString(Points.IsWin += 10);
                if ((count60 == 1 || count60 == 5 || count60 == 9 || count60 == 13 || count60 == 17 ||
                    count60 == 21 || count60 == 25 || count60 == 29 || count60 == 33) && count61 % 2 == 0 &&
                    (count62 == 3 || count62 == 7 || count62 == 11 || count62 == 15 || count62 == 19 ||
                    count62 == 23 || count62 == 27 || count62 == 31 || count62 == 35) && (count73 == 1 ||
                    count73 == 5 || count73 == 9 || count73 == 13 || count73 == 17 ||
                    count73 == 21 || count73 == 25 || count73 == 29 || count73 == 33) && (count74 == 1 ||
                    count74 == 5 || count74 == 9 || count74 == 13 || count74 == 17 || count74 == 21 ||
                    count74 == 25 || count74 == 29 || count74 == 33) && count85 % 2 != 0 && count30 % 4 == 0 &&
                    count30 % 2 == 0 && count29 % 4 != 0 && count29 % 2 == 0)
                    AliveFlower(pictureBox60, count60);
            }
            IsYouWin();
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void returnonchoice_Click(object sender, EventArgs e)
        {
            Hide();
            Choice go = new Choice();
            go.Show();
            this.Close();
        }
        
        private void again_Click(object sender, EventArgs e)
        {
            Points.IsWin = 0;
            Hide();
            Game go = new Game();
            go.Show();
        }
    }

    static class Points
    {
        public static int IsWin { get; set; }
    }
}