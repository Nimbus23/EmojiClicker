namespace CatchTheEmoji
{
    partial class Game_Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_Menu));
            this.Start_btn = new System.Windows.Forms.Button();
            this.radioEazy = new System.Windows.Forms.RadioButton();
            this.DifficultLabel = new System.Windows.Forms.Label();
            this.radioMedium = new System.Windows.Forms.RadioButton();
            this.radioHard = new System.Windows.Forms.RadioButton();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.ScoreBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TimeLabl = new System.Windows.Forms.Label();
            this.ScoreLabl = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LabelChange = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PicFirstEmo = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.BoxGameOver = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicFirstEmo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_btn
            // 
            this.Start_btn.AutoSize = true;
            this.Start_btn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_btn.Location = new System.Drawing.Point(45, 106);
            this.Start_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(95, 47);
            this.Start_btn.TabIndex = 1;
            this.Start_btn.Text = "Start";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioEazy
            // 
            this.radioEazy.AutoSize = true;
            this.radioEazy.Location = new System.Drawing.Point(34, 60);
            this.radioEazy.Margin = new System.Windows.Forms.Padding(4);
            this.radioEazy.Name = "radioEazy";
            this.radioEazy.Size = new System.Drawing.Size(67, 24);
            this.radioEazy.TabIndex = 2;
            this.radioEazy.TabStop = true;
            this.radioEazy.Text = "Easy";
            this.radioEazy.UseVisualStyleBackColor = true;
            this.radioEazy.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // DifficultLabel
            // 
            this.DifficultLabel.AutoSize = true;
            this.DifficultLabel.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultLabel.Location = new System.Drawing.Point(23, 23);
            this.DifficultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DifficultLabel.Name = "DifficultLabel";
            this.DifficultLabel.Size = new System.Drawing.Size(106, 21);
            this.DifficultLabel.TabIndex = 3;
            this.DifficultLabel.Text = "Difficulty";
            // 
            // radioMedium
            // 
            this.radioMedium.AutoSize = true;
            this.radioMedium.Location = new System.Drawing.Point(34, 92);
            this.radioMedium.Margin = new System.Windows.Forms.Padding(4);
            this.radioMedium.Name = "radioMedium";
            this.radioMedium.Size = new System.Drawing.Size(89, 24);
            this.radioMedium.TabIndex = 4;
            this.radioMedium.TabStop = true;
            this.radioMedium.Text = "Medium";
            this.radioMedium.UseVisualStyleBackColor = true;
            this.radioMedium.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioHard
            // 
            this.radioHard.AutoSize = true;
            this.radioHard.Location = new System.Drawing.Point(34, 124);
            this.radioHard.Margin = new System.Windows.Forms.Padding(4);
            this.radioHard.Name = "radioHard";
            this.radioHard.Size = new System.Drawing.Size(67, 24);
            this.radioHard.TabIndex = 5;
            this.radioHard.TabStop = true;
            this.radioHard.Text = "Hard";
            this.radioHard.UseVisualStyleBackColor = true;
            this.radioHard.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // TimeBox
            // 
            this.TimeBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TimeBox.Location = new System.Drawing.Point(18, 62);
            this.TimeBox.Margin = new System.Windows.Forms.Padding(4);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(124, 27);
            this.TimeBox.TabIndex = 6;
            this.TimeBox.Text = "0";
            this.TimeBox.TextChanged += new System.EventHandler(this.BoxText_TextChanged);
            // 
            // ScoreBox
            // 
            this.ScoreBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ScoreBox.Location = new System.Drawing.Point(16, 155);
            this.ScoreBox.Margin = new System.Windows.Forms.Padding(4);
            this.ScoreBox.Multiline = true;
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.Size = new System.Drawing.Size(124, 27);
            this.ScoreBox.TabIndex = 7;
            this.ScoreBox.Text = "0";
            this.ScoreBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(45, 546);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TimeLabl
            // 
            this.TimeLabl.AutoSize = true;
            this.TimeLabl.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabl.Location = new System.Drawing.Point(42, 23);
            this.TimeLabl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeLabl.Name = "TimeLabl";
            this.TimeLabl.Size = new System.Drawing.Size(50, 21);
            this.TimeLabl.TabIndex = 9;
            this.TimeLabl.Text = "Time";
            // 
            // ScoreLabl
            // 
            this.ScoreLabl.AutoSize = true;
            this.ScoreLabl.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabl.Location = new System.Drawing.Point(42, 116);
            this.ScoreLabl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreLabl.Name = "ScoreLabl";
            this.ScoreLabl.Size = new System.Drawing.Size(62, 21);
            this.ScoreLabl.TabIndex = 10;
            this.ScoreLabl.Text = "Score";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LabelChange
            // 
            this.LabelChange.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelChange.Location = new System.Drawing.Point(13, 24);
            this.LabelChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelChange.Name = "LabelChange";
            this.LabelChange.Size = new System.Drawing.Size(276, 78);
            this.LabelChange.TabIndex = 13;
            this.LabelChange.Text = "Welcome, Nick";
            this.LabelChange.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.LabelChange);
            this.panel1.Controls.Add(this.Start_btn);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 673);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TimeLabl);
            this.groupBox2.Controls.Add(this.ScoreLabl);
            this.groupBox2.Controls.Add(this.ScoreBox);
            this.groupBox2.Controls.Add(this.TimeBox);
            this.groupBox2.Location = new System.Drawing.Point(18, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 193);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DifficultLabel);
            this.groupBox1.Controls.Add(this.radioMedium);
            this.groupBox1.Controls.Add(this.radioEazy);
            this.groupBox1.Controls.Add(this.radioHard);
            this.groupBox1.Location = new System.Drawing.Point(18, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 165);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // PicFirstEmo
            // 
            this.PicFirstEmo.Image = ((System.Drawing.Image)(resources.GetObject("PicFirstEmo.Image")));
            this.PicFirstEmo.Location = new System.Drawing.Point(576, 57);
            this.PicFirstEmo.Name = "PicFirstEmo";
            this.PicFirstEmo.Size = new System.Drawing.Size(100, 80);
            this.PicFirstEmo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicFirstEmo.TabIndex = 15;
            this.PicFirstEmo.TabStop = false;
            this.PicFirstEmo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(388, 77);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 60);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(438, 183);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(140, 100);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // BoxGameOver
            // 
            this.BoxGameOver.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BoxGameOver.Enabled = false;
            this.BoxGameOver.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxGameOver.ForeColor = System.Drawing.Color.Red;
            this.BoxGameOver.Location = new System.Drawing.Point(214, 200);
            this.BoxGameOver.Margin = new System.Windows.Forms.Padding(4);
            this.BoxGameOver.Multiline = true;
            this.BoxGameOver.Name = "BoxGameOver";
            this.BoxGameOver.Size = new System.Drawing.Size(592, 330);
            this.BoxGameOver.TabIndex = 21;
            this.BoxGameOver.Text = "    Game Over\r\n Your Score:";
            this.BoxGameOver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BoxGameOver.Visible = false;
            this.BoxGameOver.TextChanged += new System.EventHandler(this.BoxGameOver_TextChanged);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Game_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(702, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BoxGameOver);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.PicFirstEmo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Game_Menu";
            this.Text = "-;.";
            this.Load += new System.EventHandler(this.Game_Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicFirstEmo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.RadioButton radioEazy;
        private System.Windows.Forms.Label DifficultLabel;
        private System.Windows.Forms.RadioButton radioMedium;
        private System.Windows.Forms.RadioButton radioHard;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.TextBox ScoreBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label TimeLabl;
        private System.Windows.Forms.Label ScoreLabl;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label LabelChange;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PicFirstEmo;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox BoxGameOver;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}