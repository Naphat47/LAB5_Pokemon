namespace PokemonBattle
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            tbName = new TextBox();
            tbHP = new TextBox();
            groupBox2 = new GroupBox();
            button5 = new Button();
            button6 = new Button();
            button8 = new Button();
            tbHPEnemy = new TextBox();
            tbNameEnemy = new TextBox();
            label3 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._002;
            pictureBox1.Location = new Point(25, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._010;
            pictureBox2.Location = new Point(300, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 143);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(22, 32);
            button1.Name = "button1";
            button1.Size = new Size(99, 23);
            button1.TabIndex = 2;
            button1.Text = "Ivysaur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(22, 61);
            button2.Name = "button2";
            button2.Size = new Size(99, 23);
            button2.TabIndex = 3;
            button2.Text = "Venusaur";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(22, 90);
            button3.Name = "button3";
            button3.Size = new Size(99, 23);
            button3.TabIndex = 4;
            button3.Text = "Charmander";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(22, 119);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(99, 23);
            button4.TabIndex = 5;
            button4.Text = "Charmeleon";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(25, 249);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(145, 163);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "MyPokemon";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 186);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 219);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 8;
            label2.Text = "HP";
            // 
            // tbName
            // 
            tbName.Location = new Point(70, 182);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 9;
            // 
            // tbHP
            // 
            tbHP.Location = new Point(70, 212);
            tbHP.Name = "tbHP";
            tbHP.Size = new Size(100, 23);
            tbHP.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button8);
            groupBox2.Location = new Point(25, 418);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(145, 163);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Command";
            // 
            // button5
            // 
            button5.Location = new Point(24, 32);
            button5.Name = "button5";
            button5.Size = new Size(99, 23);
            button5.TabIndex = 5;
            button5.Text = "Attack";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(24, 61);
            button6.Name = "button6";
            button6.Size = new Size(99, 23);
            button6.TabIndex = 2;
            button6.Text = "HP + 50";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button8
            // 
            button8.Location = new Point(24, 90);
            button8.Name = "button8";
            button8.Size = new Size(99, 23);
            button8.TabIndex = 3;
            button8.Text = "Defanse + 50";
            button8.UseVisualStyleBackColor = true;
            // 
            // tbHPEnemy
            // 
            tbHPEnemy.Location = new Point(345, 211);
            tbHPEnemy.Name = "tbHPEnemy";
            tbHPEnemy.Size = new Size(100, 23);
            tbHPEnemy.TabIndex = 14;
            // 
            // tbNameEnemy
            // 
            tbNameEnemy.Location = new Point(345, 181);
            tbNameEnemy.Name = "tbNameEnemy";
            tbNameEnemy.Size = new Size(100, 23);
            tbNameEnemy.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 218);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 12;
            label3.Text = "HP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(300, 185);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 11;
            label4.Text = "Name";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button9);
            groupBox3.Controls.Add(button10);
            groupBox3.Controls.Add(button11);
            groupBox3.Location = new Point(300, 249);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(145, 163);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Command (Enemy)";
            // 
            // button9
            // 
            button9.Location = new Point(24, 32);
            button9.Name = "button9";
            button9.Size = new Size(99, 23);
            button9.TabIndex = 5;
            button9.Text = "Attack";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(24, 61);
            button10.Name = "button10";
            button10.Size = new Size(99, 23);
            button10.TabIndex = 2;
            button10.Text = "HP + 50";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(24, 90);
            button11.Name = "button11";
            button11.Size = new Size(99, 23);
            button11.TabIndex = 3;
            button11.Text = "Defanse + 50";
            button11.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 598);
            Controls.Add(groupBox3);
            Controls.Add(tbHPEnemy);
            Controls.Add(tbNameEnemy);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(tbHP);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private TextBox tbName;
        private TextBox tbHP;
        private GroupBox groupBox2;
        private Button button5;
        private Button button6;
        private Button button8;
        private TextBox tbHPEnemy;
        private TextBox tbNameEnemy;
        private Label label3;
        private Label label4;
        private GroupBox groupBox3;
        private Button button9;
        private Button button10;
        private Button button11;
    }
}