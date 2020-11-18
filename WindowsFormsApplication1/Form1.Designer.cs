namespace Horse_Race
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Photo = new System.Windows.Forms.PictureBox();
            this.Horse1 = new System.Windows.Forms.PictureBox();
            this.Horse2 = new System.Windows.Forms.PictureBox();
            this.Horse3 = new System.Windows.Forms.PictureBox();
            this.Horse4 = new System.Windows.Forms.PictureBox();
            this.GoRace = new System.Windows.Forms.Button();
            this.LeastLabel = new System.Windows.Forms.Label();
            this.JhonyRButton = new System.Windows.Forms.RadioButton();
            this.BenRButton = new System.Windows.Forms.RadioButton();
            this.AndyRButton = new System.Windows.Forms.RadioButton();
            this.BetsLabel = new System.Windows.Forms.Label();
            this.JhonyBLabel = new System.Windows.Forms.Label();
            this.BenBLabel = new System.Windows.Forms.Label();
            this.AndyBLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BetsButton = new System.Windows.Forms.Button();
            this.HighLowNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.HighLowNumberHorse = new System.Windows.Forms.NumericUpDown();
            this.ResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighLowNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighLowNumberHorse)).BeginInit();
            this.SuspendLayout();
            // 
            // Photo
            // 
            this.Photo.Image = ((System.Drawing.Image)(resources.GetObject("Photo.Image")));
            this.Photo.Location = new System.Drawing.Point(12, 12);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(605, 202);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Photo.TabIndex = 0;
            this.Photo.TabStop = false;
            this.Photo.Click += new System.EventHandler(this.Photo_Click);
            // 
            // Horse1
            // 
            this.Horse1.Image = ((System.Drawing.Image)(resources.GetObject("Horse1.Image")));
            this.Horse1.Location = new System.Drawing.Point(22, 24);
            this.Horse1.Name = "Horse1";
            this.Horse1.Size = new System.Drawing.Size(54, 21);
            this.Horse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Horse1.TabIndex = 1;
            this.Horse1.TabStop = false;
            this.Horse1.Click += new System.EventHandler(this.Horse1Click);
            // 
            // Horse2
            // 
            this.Horse2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Horse2.ErrorImage")));
            this.Horse2.Image = ((System.Drawing.Image)(resources.GetObject("Horse2.Image")));
            this.Horse2.Location = new System.Drawing.Point(22, 79);
            this.Horse2.Name = "Horse2";
            this.Horse2.Size = new System.Drawing.Size(54, 22);
            this.Horse2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Horse2.TabIndex = 2;
            this.Horse2.TabStop = false;
            // 
            // Horse3
            // 
            this.Horse3.Image = ((System.Drawing.Image)(resources.GetObject("Horse3.Image")));
            this.Horse3.Location = new System.Drawing.Point(22, 127);
            this.Horse3.Name = "Horse3";
            this.Horse3.Size = new System.Drawing.Size(54, 24);
            this.Horse3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Horse3.TabIndex = 3;
            this.Horse3.TabStop = false;
            this.Horse3.Click += new System.EventHandler(this.Horse3_Click);
            // 
            // Horse4
            // 
            this.Horse4.Image = ((System.Drawing.Image)(resources.GetObject("Horse4.Image")));
            this.Horse4.Location = new System.Drawing.Point(22, 175);
            this.Horse4.Name = "Horse4";
            this.Horse4.Size = new System.Drawing.Size(54, 24);
            this.Horse4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Horse4.TabIndex = 4;
            this.Horse4.TabStop = false;
            // 
            // GoRace
            // 
            this.GoRace.BackColor = System.Drawing.Color.Chocolate;
            this.GoRace.Location = new System.Drawing.Point(414, 287);
            this.GoRace.Name = "GoRace";
            this.GoRace.Size = new System.Drawing.Size(76, 72);
            this.GoRace.TabIndex = 5;
            this.GoRace.Text = "Race!";
            this.GoRace.UseVisualStyleBackColor = false;
            this.GoRace.Click += new System.EventHandler(this.TapStartRace);
            // 
            // LeastLabel
            // 
            this.LeastLabel.AutoSize = true;
            this.LeastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeastLabel.Location = new System.Drawing.Point(9, 241);
            this.LeastLabel.Name = "LeastLabel";
            this.LeastLabel.Size = new System.Drawing.Size(0, 13);
            this.LeastLabel.TabIndex = 6;
            // 
            // JhonyRButton
            // 
            this.JhonyRButton.AutoSize = true;
            this.JhonyRButton.Location = new System.Drawing.Point(12, 269);
            this.JhonyRButton.Name = "JhonyRButton";
            this.JhonyRButton.Size = new System.Drawing.Size(85, 17);
            this.JhonyRButton.TabIndex = 7;
            this.JhonyRButton.TabStop = true;
            this.JhonyRButton.Text = "radioButton1";
            this.JhonyRButton.UseVisualStyleBackColor = true;
            this.JhonyRButton.CheckedChanged += new System.EventHandler(this.JhonyButton_CheckedChanged);
            // 
            // BenRButton
            // 
            this.BenRButton.AutoSize = true;
            this.BenRButton.Location = new System.Drawing.Point(12, 293);
            this.BenRButton.Name = "BenRButton";
            this.BenRButton.Size = new System.Drawing.Size(85, 17);
            this.BenRButton.TabIndex = 8;
            this.BenRButton.TabStop = true;
            this.BenRButton.Text = "radioButton1";
            this.BenRButton.UseVisualStyleBackColor = true;
            this.BenRButton.CheckedChanged += new System.EventHandler(this.BenRadioButton_CheckedChanged_1);
            // 
            // AndyRButton
            // 
            this.AndyRButton.AutoSize = true;
            this.AndyRButton.Location = new System.Drawing.Point(12, 317);
            this.AndyRButton.Name = "AndyRButton";
            this.AndyRButton.Size = new System.Drawing.Size(85, 17);
            this.AndyRButton.TabIndex = 9;
            this.AndyRButton.TabStop = true;
            this.AndyRButton.Text = "radioButton2";
            this.AndyRButton.UseVisualStyleBackColor = true;
            this.AndyRButton.CheckedChanged += new System.EventHandler(this.AndyRadioButton_CheckedChanged_1);
            // 
            // BetsLabel
            // 
            this.BetsLabel.AutoSize = true;
            this.BetsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetsLabel.Location = new System.Drawing.Point(164, 241);
            this.BetsLabel.Name = "BetsLabel";
            this.BetsLabel.Size = new System.Drawing.Size(32, 13);
            this.BetsLabel.TabIndex = 10;
            this.BetsLabel.Text = "Bets";
            // 
            // JhonyBLabel
            // 
            this.JhonyBLabel.AutoSize = true;
            this.JhonyBLabel.Location = new System.Drawing.Point(186, 271);
            this.JhonyBLabel.Name = "JhonyBLabel";
            this.JhonyBLabel.Size = new System.Drawing.Size(35, 13);
            this.JhonyBLabel.TabIndex = 11;
            this.JhonyBLabel.Text = "label1";
            this.JhonyBLabel.Click += new System.EventHandler(this.JoeBLabel_Click);
            // 
            // BenBLabel
            // 
            this.BenBLabel.AutoSize = true;
            this.BenBLabel.Location = new System.Drawing.Point(186, 293);
            this.BenBLabel.Name = "BenBLabel";
            this.BenBLabel.Size = new System.Drawing.Size(35, 13);
            this.BenBLabel.TabIndex = 12;
            this.BenBLabel.Text = "label1";
            // 
            // AndyBLabel
            // 
            this.AndyBLabel.AutoSize = true;
            this.AndyBLabel.Location = new System.Drawing.Point(186, 319);
            this.AndyBLabel.Name = "AndyBLabel";
            this.AndyBLabel.Size = new System.Drawing.Size(35, 13);
            this.AndyBLabel.TabIndex = 13;
            this.AndyBLabel.Text = "label1";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(9, 359);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(0, 13);
            this.NameLabel.TabIndex = 14;
            // 
            // BetsButton
            // 
            this.BetsButton.BackColor = System.Drawing.Color.Chocolate;
            this.BetsButton.Location = new System.Drawing.Point(53, 375);
            this.BetsButton.Name = "BetsButton";
            this.BetsButton.Size = new System.Drawing.Size(55, 23);
            this.BetsButton.TabIndex = 15;
            this.BetsButton.Text = "Bets";
            this.BetsButton.UseVisualStyleBackColor = false;
            this.BetsButton.Click += new System.EventHandler(this.BetsButton_Click);
            // 
            // HighLowNumber
            // 
            this.HighLowNumber.Location = new System.Drawing.Point(53, 349);
            this.HighLowNumber.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.HighLowNumber.Name = "HighLowNumber";
            this.HighLowNumber.Size = new System.Drawing.Size(55, 20);
            this.HighLowNumber.TabIndex = 16;
            this.HighLowNumber.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "bucks on Cat number ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // HighLowNumberHorse
            // 
            this.HighLowNumberHorse.Location = new System.Drawing.Point(167, 375);
            this.HighLowNumberHorse.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.HighLowNumberHorse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HighLowNumberHorse.Name = "HighLowNumberHorse";
            this.HighLowNumberHorse.Size = new System.Drawing.Size(78, 20);
            this.HighLowNumberHorse.TabIndex = 18;
            this.HighLowNumberHorse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Chocolate;
            this.ResetButton.Location = new System.Drawing.Point(514, 300);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(57, 50);
            this.ResetButton.TabIndex = 19;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(626, 410);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.HighLowNumberHorse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HighLowNumber);
            this.Controls.Add(this.BetsButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AndyBLabel);
            this.Controls.Add(this.BenBLabel);
            this.Controls.Add(this.JhonyBLabel);
            this.Controls.Add(this.BetsLabel);
            this.Controls.Add(this.AndyRButton);
            this.Controls.Add(this.BenRButton);
            this.Controls.Add(this.JhonyRButton);
            this.Controls.Add(this.LeastLabel);
            this.Controls.Add(this.GoRace);
            this.Controls.Add(this.Horse4);
            this.Controls.Add(this.Horse3);
            this.Controls.Add(this.Horse2);
            this.Controls.Add(this.Horse1);
            this.Controls.Add(this.Photo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighLowNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighLowNumberHorse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.PictureBox Horse1;
        private System.Windows.Forms.PictureBox Horse2;
        private System.Windows.Forms.PictureBox Horse3;
        private System.Windows.Forms.PictureBox Horse4;
        private System.Windows.Forms.Button GoRace;
        private System.Windows.Forms.Label LeastLabel;
        private System.Windows.Forms.RadioButton JhonyRButton;
        private System.Windows.Forms.RadioButton BenRButton;
        private System.Windows.Forms.RadioButton AndyRButton;
        private System.Windows.Forms.Label BetsLabel;
        private System.Windows.Forms.Label JhonyBLabel;
        private System.Windows.Forms.Label BenBLabel;
        private System.Windows.Forms.Label AndyBLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button BetsButton;
        private System.Windows.Forms.NumericUpDown HighLowNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown HighLowNumberHorse;
        private System.Windows.Forms.Button ResetButton;
    }
}