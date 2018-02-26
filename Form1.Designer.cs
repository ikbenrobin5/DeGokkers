namespace DeGokkeres1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Racebaan = new System.Windows.Forms.PictureBox();
            this.Struisvogel1 = new System.Windows.Forms.PictureBox();
            this.Struisvogel2 = new System.Windows.Forms.PictureBox();
            this.Struisvogel3 = new System.Windows.Forms.PictureBox();
            this.Struisvogel4 = new System.Windows.Forms.PictureBox();
            this.Sietse = new System.Windows.Forms.RadioButton();
            this.Lidy = new System.Windows.Forms.RadioButton();
            this.Fer = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Go = new System.Windows.Forms.Button();
            this.Text3 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.Label();
            this.Text2 = new System.Windows.Forms.Label();
            this.Counter2 = new System.Windows.Forms.NumericUpDown();
            this.Counter1 = new System.Windows.Forms.NumericUpDown();
            this.Bet = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Racebaan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Struisvogel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Struisvogel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Struisvogel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Struisvogel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Counter2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Counter1)).BeginInit();
            this.SuspendLayout();
            // 
            // Racebaan
            // 
            this.Racebaan.Image = ((System.Drawing.Image)(resources.GetObject("Racebaan.Image")));
            this.Racebaan.Location = new System.Drawing.Point(2, 12);
            this.Racebaan.Name = "Racebaan";
            this.Racebaan.Size = new System.Drawing.Size(1062, 427);
            this.Racebaan.TabIndex = 0;
            this.Racebaan.TabStop = false;
            // 
            // Struisvogel1
            // 
            this.Struisvogel1.BackColor = System.Drawing.Color.Yellow;
            this.Struisvogel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Struisvogel1.BackgroundImage")));
            this.Struisvogel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Struisvogel1.Image = ((System.Drawing.Image)(resources.GetObject("Struisvogel1.Image")));
            this.Struisvogel1.InitialImage = ((System.Drawing.Image)(resources.GetObject("Struisvogel1.InitialImage")));
            this.Struisvogel1.Location = new System.Drawing.Point(2, 12);
            this.Struisvogel1.Name = "Struisvogel1";
            this.Struisvogel1.Size = new System.Drawing.Size(136, 88);
            this.Struisvogel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Struisvogel1.TabIndex = 1;
            this.Struisvogel1.TabStop = false;
            this.Struisvogel1.Click += new System.EventHandler(this.Struisvogel1_Click);
            // 
            // Struisvogel2
            // 
            this.Struisvogel2.BackColor = System.Drawing.Color.Yellow;
            this.Struisvogel2.Image = ((System.Drawing.Image)(resources.GetObject("Struisvogel2.Image")));
            this.Struisvogel2.Location = new System.Drawing.Point(2, 106);
            this.Struisvogel2.Name = "Struisvogel2";
            this.Struisvogel2.Size = new System.Drawing.Size(136, 100);
            this.Struisvogel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Struisvogel2.TabIndex = 2;
            this.Struisvogel2.TabStop = false;
            // 
            // Struisvogel3
            // 
            this.Struisvogel3.BackColor = System.Drawing.Color.Yellow;
            this.Struisvogel3.Image = ((System.Drawing.Image)(resources.GetObject("Struisvogel3.Image")));
            this.Struisvogel3.Location = new System.Drawing.Point(2, 212);
            this.Struisvogel3.Name = "Struisvogel3";
            this.Struisvogel3.Size = new System.Drawing.Size(136, 114);
            this.Struisvogel3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Struisvogel3.TabIndex = 3;
            this.Struisvogel3.TabStop = false;
            // 
            // Struisvogel4
            // 
            this.Struisvogel4.BackColor = System.Drawing.Color.Yellow;
            this.Struisvogel4.Image = ((System.Drawing.Image)(resources.GetObject("Struisvogel4.Image")));
            this.Struisvogel4.Location = new System.Drawing.Point(2, 332);
            this.Struisvogel4.Name = "Struisvogel4";
            this.Struisvogel4.Size = new System.Drawing.Size(136, 107);
            this.Struisvogel4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Struisvogel4.TabIndex = 4;
            this.Struisvogel4.TabStop = false;
            // 
            // Sietse
            // 
            this.Sietse.AutoSize = true;
            this.Sietse.Location = new System.Drawing.Point(12, 601);
            this.Sietse.Name = "Sietse";
            this.Sietse.Size = new System.Drawing.Size(54, 17);
            this.Sietse.TabIndex = 7;
            this.Sietse.TabStop = true;
            this.Sietse.Text = "Sietse";
            this.Sietse.UseVisualStyleBackColor = true;
            // 
            // Lidy
            // 
            this.Lidy.AutoSize = true;
            this.Lidy.Location = new System.Drawing.Point(13, 625);
            this.Lidy.Name = "Lidy";
            this.Lidy.Size = new System.Drawing.Size(44, 17);
            this.Lidy.TabIndex = 8;
            this.Lidy.TabStop = true;
            this.Lidy.Text = "Lidy";
            this.Lidy.UseVisualStyleBackColor = true;
            // 
            // Fer
            // 
            this.Fer.AutoSize = true;
            this.Fer.Location = new System.Drawing.Point(13, 649);
            this.Fer.Name = "Fer";
            this.Fer.Size = new System.Drawing.Size(40, 17);
            this.Fer.TabIndex = 9;
            this.Fer.TabStop = true;
            this.Fer.Text = "Fer";
            this.Fer.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(632, 600);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(632, 625);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(288, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(632, 651);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(288, 20);
            this.textBox3.TabIndex = 12;
            // 
            // Go
            // 
            this.Go.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Go.Location = new System.Drawing.Point(858, 691);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(75, 23);
            this.Go.TabIndex = 16;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = false;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            this.Go.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Go_MouseClick);
            // 
            // Text3
            // 
            this.Text3.AutoSize = true;
            this.Text3.Location = new System.Drawing.Point(734, 568);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(92, 13);
            this.Text3.TabIndex = 17;
            this.Text3.Text = "weddenschappen";
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Location = new System.Drawing.Point(10, 483);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(60, 13);
            this.text1.TabIndex = 18;
            this.text1.Text = "wedbureau";
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.Location = new System.Drawing.Point(10, 568);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(112, 13);
            this.Text2.TabIndex = 19;
            this.Text2.Text = "Minimum inzet : 5 euro";
            // 
            // Counter2
            // 
            this.Counter2.Location = new System.Drawing.Point(524, 675);
            this.Counter2.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.Counter2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Counter2.Name = "Counter2";
            this.Counter2.Size = new System.Drawing.Size(120, 20);
            this.Counter2.TabIndex = 20;
            this.Counter2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Counter1
            // 
            this.Counter1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Counter1.Location = new System.Drawing.Point(144, 675);
            this.Counter1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.Counter1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Counter1.Name = "Counter1";
            this.Counter1.Size = new System.Drawing.Size(120, 20);
            this.Counter1.TabIndex = 21;
            this.Counter1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Bet
            // 
            this.Bet.Location = new System.Drawing.Point(47, 675);
            this.Bet.Name = "Bet";
            this.Bet.Size = new System.Drawing.Size(75, 23);
            this.Bet.TabIndex = 22;
            this.Bet.Text = "Bet";
            this.Bet.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 749);
            this.Controls.Add(this.Bet);
            this.Controls.Add(this.Counter1);
            this.Controls.Add(this.Counter2);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Fer);
            this.Controls.Add(this.Lidy);
            this.Controls.Add(this.Sietse);
            this.Controls.Add(this.Struisvogel4);
            this.Controls.Add(this.Struisvogel3);
            this.Controls.Add(this.Struisvogel2);
            this.Controls.Add(this.Struisvogel1);
            this.Controls.Add(this.Racebaan);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "De Gokkers";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Racebaan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Struisvogel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Struisvogel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Struisvogel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Struisvogel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Counter2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Counter1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Racebaan;
        private System.Windows.Forms.PictureBox Struisvogel1;
        private System.Windows.Forms.PictureBox Struisvogel2;
        private System.Windows.Forms.PictureBox Struisvogel3;
        private System.Windows.Forms.PictureBox Struisvogel4;
        private System.Windows.Forms.RadioButton Sietse;
        private System.Windows.Forms.RadioButton Lidy;
        private System.Windows.Forms.RadioButton Fer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.Label Text3;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.NumericUpDown Counter2;
        private System.Windows.Forms.NumericUpDown Counter1;
        private System.Windows.Forms.Button Bet;
        private System.Windows.Forms.Timer timer1;
    }
}

