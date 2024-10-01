namespace projLampadina
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            bottoneSu = new Button();
            bottoneGiu = new Button();
            RESET = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(176, 153);
            button1.Name = "button1";
            button1.Size = new Size(133, 92);
            button1.TabIndex = 0;
            button1.Text = "ACCENDI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(779, 153);
            button2.Name = "button2";
            button2.Size = new Size(133, 92);
            button2.TabIndex = 1;
            button2.Text = "SPEGNI";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(371, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(348, 348);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(371, 153);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(348, 348);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // bottoneSu
            // 
            bottoneSu.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bottoneSu.Location = new Point(176, 409);
            bottoneSu.Name = "bottoneSu";
            bottoneSu.Size = new Size(133, 92);
            bottoneSu.TabIndex = 5;
            bottoneSu.Text = "ALZA";
            bottoneSu.UseVisualStyleBackColor = true;
            bottoneSu.Click += bottoneSu_Click;
            bottoneSu.MouseDown += bottoneSu_MouseDown;
            bottoneSu.MouseUp += bottone_MouseUp;
            // 
            // bottoneGiu
            // 
            bottoneGiu.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bottoneGiu.Location = new Point(779, 409);
            bottoneGiu.Name = "bottoneGiu";
            bottoneGiu.Size = new Size(133, 92);
            bottoneGiu.TabIndex = 6;
            bottoneGiu.Text = "ABBASSA";
            bottoneGiu.UseVisualStyleBackColor = true;
            bottoneGiu.Click += bottoneGiu_Click;
            bottoneGiu.MouseDown += bottoneGiu_MouseDown;
            bottoneGiu.MouseUp += bottone_MouseUp;
            // 
            // RESET
            // 
            RESET.BackColor = Color.Red;
            RESET.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RESET.Location = new Point(12, 284);
            RESET.Name = "RESET";
            RESET.Size = new Size(133, 92);
            RESET.TabIndex = 7;
            RESET.Text = "RESET";
            RESET.UseVisualStyleBackColor = false;
            RESET.Click += RESET_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 584);
            Controls.Add(RESET);
            Controls.Add(bottoneGiu);
            Controls.Add(bottoneSu);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Lampadina";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button bottoneSu;
        private Button bottoneGiu;
        private Button RESET;
    }
}