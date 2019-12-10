namespace Branch
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Button();
            this.Awards = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Award_return = new System.Windows.Forms.Button();
            this.TableOfRewards3x3 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureAward = new System.Windows.Forms.PictureBox();
            this.TableOfRewards5x5 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(228, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать в игру!";
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Play.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Play.Location = new System.Drawing.Point(344, 123);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(212, 87);
            this.Play.TabIndex = 1;
            this.Play.Text = "Играть";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Awards
            // 
            this.Awards.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Awards.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Awards.Location = new System.Drawing.Point(344, 235);
            this.Awards.Name = "Awards";
            this.Awards.Size = new System.Drawing.Size(212, 87);
            this.Awards.TabIndex = 2;
            this.Awards.Text = "Рекорды";
            this.Awards.UseVisualStyleBackColor = false;
            this.Awards.Click += new System.EventHandler(this.Awards_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(344, 349);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(212, 87);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Award_return
            // 
            this.Award_return.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Award_return.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Award_return.Location = new System.Drawing.Point(14, 443);
            this.Award_return.Name = "Award_return";
            this.Award_return.Size = new System.Drawing.Size(174, 35);
            this.Award_return.TabIndex = 4;
            this.Award_return.Text = "Вернуться в меню";
            this.Award_return.UseVisualStyleBackColor = false;
            this.Award_return.Visible = false;
            this.Award_return.Click += new System.EventHandler(this.Award_return_Click);
            // 
            // TableOfRewards3x3
            // 
            this.TableOfRewards3x3.Enabled = false;
            this.TableOfRewards3x3.Font = new System.Drawing.Font("Garamond", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableOfRewards3x3.FormattingEnabled = true;
            this.TableOfRewards3x3.ItemHeight = 19;
            this.TableOfRewards3x3.Location = new System.Drawing.Point(213, 68);
            this.TableOfRewards3x3.Name = "TableOfRewards3x3";
            this.TableOfRewards3x3.Size = new System.Drawing.Size(302, 384);
            this.TableOfRewards3x3.TabIndex = 5;
            this.TableOfRewards3x3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "Таблица рекордов";
            this.label2.Visible = false;
            // 
            // pictureAward
            // 
            this.pictureAward.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureAward.Image = ((System.Drawing.Image)(resources.GetObject("pictureAward.Image")));
            this.pictureAward.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureAward.InitialImage")));
            this.pictureAward.Location = new System.Drawing.Point(14, 81);
            this.pictureAward.Name = "pictureAward";
            this.pictureAward.Size = new System.Drawing.Size(174, 365);
            this.pictureAward.TabIndex = 7;
            this.pictureAward.TabStop = false;
            this.pictureAward.Visible = false;
            // 
            // TableOfRewards5x5
            // 
            this.TableOfRewards5x5.Enabled = false;
            this.TableOfRewards5x5.Font = new System.Drawing.Font("Garamond", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableOfRewards5x5.FormattingEnabled = true;
            this.TableOfRewards5x5.ItemHeight = 19;
            this.TableOfRewards5x5.Location = new System.Drawing.Point(544, 68);
            this.TableOfRewards5x5.Name = "TableOfRewards5x5";
            this.TableOfRewards5x5.Size = new System.Drawing.Size(302, 384);
            this.TableOfRewards5x5.TabIndex = 8;
            this.TableOfRewards5x5.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 317);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(679, 213);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 278);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(884, 491);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TableOfRewards5x5);
            this.Controls.Add(this.pictureAward);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TableOfRewards3x3);
            this.Controls.Add(this.Award_return);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Awards);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "Ветка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureAward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Awards;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Award_return;
        private System.Windows.Forms.ListBox TableOfRewards3x3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureAward;
        private System.Windows.Forms.ListBox TableOfRewards5x5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

