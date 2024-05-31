namespace WinFormArenaGame
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnNewGame = new System.Windows.Forms.Button();
            this.tbHeroOne = new System.Windows.Forms.TextBox();
            this.tbHeroTwo = new System.Windows.Forms.TextBox();
            this.imgFight = new System.Windows.Forms.PictureBox();
            this.lbWinner = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbAssassin = new System.Windows.Forms.RadioButton();
            this.rbGladiator = new System.Windows.Forms.RadioButton();
            this.rbDwarf = new System.Windows.Forms.RadioButton();
            this.rbKnight = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSpear = new System.Windows.Forms.RadioButton();
            this.rbAxe = new System.Windows.Forms.RadioButton();
            this.rbCrossbow = new System.Windows.Forms.RadioButton();
            this.rbDagger = new System.Windows.Forms.RadioButton();
            this.rbSword = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgFight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(675, 63);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(94, 29);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // tbHeroOne
            // 
            this.tbHeroOne.Location = new System.Drawing.Point(36, 35);
            this.tbHeroOne.Multiline = true;
            this.tbHeroOne.Name = "tbHeroOne";
            this.tbHeroOne.Size = new System.Drawing.Size(547, 328);
            this.tbHeroOne.TabIndex = 1;
            // 
            // tbHeroTwo
            // 
            this.tbHeroTwo.Location = new System.Drawing.Point(879, 44);
            this.tbHeroTwo.Multiline = true;
            this.tbHeroTwo.Name = "tbHeroTwo";
            this.tbHeroTwo.Size = new System.Drawing.Size(536, 319);
            this.tbHeroTwo.TabIndex = 2;
            // 
            // imgFight
            // 
            this.imgFight.Enabled = false;
            this.imgFight.Image = ((System.Drawing.Image)(resources.GetObject("imgFight.Image")));
            this.imgFight.Location = new System.Drawing.Point(631, 252);
            this.imgFight.Name = "imgFight";
            this.imgFight.Size = new System.Drawing.Size(206, 134);
            this.imgFight.TabIndex = 3;
            this.imgFight.TabStop = false;
            // 
            // lbWinner
            // 
            this.lbWinner.Location = new System.Drawing.Point(631, 121);
            this.lbWinner.Name = "lbWinner";
            this.lbWinner.Size = new System.Drawing.Size(206, 89);
            this.lbWinner.TabIndex = 4;
            this.lbWinner.Visible = false;
            this.lbWinner.Click += new System.EventHandler(this.lbWinner_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(879, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hero TWO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hero ONE:";
            // 
            // rbAssassin
            // 
            this.rbAssassin.AutoSize = true;
            this.rbAssassin.Location = new System.Drawing.Point(13, 26);
            this.rbAssassin.Name = "rbAssassin";
            this.rbAssassin.Size = new System.Drawing.Size(84, 24);
            this.rbAssassin.TabIndex = 7;
            this.rbAssassin.TabStop = true;
            this.rbAssassin.Text = "Assassin";
            this.rbAssassin.UseVisualStyleBackColor = true;
            // 
            // rbGladiator
            // 
            this.rbGladiator.AutoSize = true;
            this.rbGladiator.Location = new System.Drawing.Point(117, 26);
            this.rbGladiator.Name = "rbGladiator";
            this.rbGladiator.Size = new System.Drawing.Size(92, 24);
            this.rbGladiator.TabIndex = 8;
            this.rbGladiator.TabStop = true;
            this.rbGladiator.Text = "Gladiator";
            this.rbGladiator.UseVisualStyleBackColor = true;
            // 
            // rbDwarf
            // 
            this.rbDwarf.AutoSize = true;
            this.rbDwarf.Location = new System.Drawing.Point(226, 26);
            this.rbDwarf.Name = "rbDwarf";
            this.rbDwarf.Size = new System.Drawing.Size(70, 24);
            this.rbDwarf.TabIndex = 9;
            this.rbDwarf.TabStop = true;
            this.rbDwarf.Text = "Dwarf";
            this.rbDwarf.UseVisualStyleBackColor = true;
            // 
            // rbKnight
            // 
            this.rbKnight.AutoSize = true;
            this.rbKnight.Location = new System.Drawing.Point(337, 26);
            this.rbKnight.Name = "rbKnight";
            this.rbKnight.Size = new System.Drawing.Size(73, 24);
            this.rbKnight.TabIndex = 10;
            this.rbKnight.TabStop = true;
            this.rbKnight.Text = "Knight";
            this.rbKnight.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGladiator);
            this.groupBox1.Controls.Add(this.rbAssassin);
            this.groupBox1.Controls.Add(this.rbKnight);
            this.groupBox1.Controls.Add(this.rbDwarf);
            this.groupBox1.Location = new System.Drawing.Point(23, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 53);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECT HERO ONE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSpear);
            this.groupBox2.Controls.Add(this.rbAxe);
            this.groupBox2.Controls.Add(this.rbCrossbow);
            this.groupBox2.Controls.Add(this.rbDagger);
            this.groupBox2.Controls.Add(this.rbSword);
            this.groupBox2.Location = new System.Drawing.Point(23, 428);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 51);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CHOOSE WEAPON";
            // 
            // rbSpear
            // 
            this.rbSpear.AutoSize = true;
            this.rbSpear.Location = new System.Drawing.Point(493, 21);
            this.rbSpear.Name = "rbSpear";
            this.rbSpear.Size = new System.Drawing.Size(68, 24);
            this.rbSpear.TabIndex = 4;
            this.rbSpear.TabStop = true;
            this.rbSpear.Text = "Spear";
            this.rbSpear.UseVisualStyleBackColor = true;
            // 
            // rbAxe
            // 
            this.rbAxe.AutoSize = true;
            this.rbAxe.Location = new System.Drawing.Point(370, 21);
            this.rbAxe.Name = "rbAxe";
            this.rbAxe.Size = new System.Drawing.Size(55, 24);
            this.rbAxe.TabIndex = 3;
            this.rbAxe.TabStop = true;
            this.rbAxe.Text = "Axe";
            this.rbAxe.UseVisualStyleBackColor = true;
            // 
            // rbCrossbow
            // 
            this.rbCrossbow.AutoSize = true;
            this.rbCrossbow.Location = new System.Drawing.Point(249, 21);
            this.rbCrossbow.Name = "rbCrossbow";
            this.rbCrossbow.Size = new System.Drawing.Size(94, 24);
            this.rbCrossbow.TabIndex = 2;
            this.rbCrossbow.TabStop = true;
            this.rbCrossbow.Text = "Crossbow";
            this.rbCrossbow.UseVisualStyleBackColor = true;
            // 
            // rbDagger
            // 
            this.rbDagger.AutoSize = true;
            this.rbDagger.Location = new System.Drawing.Point(126, 21);
            this.rbDagger.Name = "rbDagger";
            this.rbDagger.Size = new System.Drawing.Size(80, 24);
            this.rbDagger.TabIndex = 1;
            this.rbDagger.TabStop = true;
            this.rbDagger.Text = "Dagger";
            this.rbDagger.UseVisualStyleBackColor = true;
            // 
            // rbSword
            // 
            this.rbSword.AutoSize = true;
            this.rbSword.Location = new System.Drawing.Point(3, 23);
            this.rbSword.Name = "rbSword";
            this.rbSword.Size = new System.Drawing.Size(72, 24);
            this.rbSword.TabIndex = 0;
            this.rbSword.TabStop = true;
            this.rbSword.Text = "Sword";
            this.rbSword.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Location = new System.Drawing.Point(879, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(493, 53);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SELECT HERO ONE";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(117, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 24);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Gladiator";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 24);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Assassin";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(337, 26);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 24);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Knight";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(226, 26);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(70, 24);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Dwarf";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton5);
            this.groupBox4.Controls.Add(this.radioButton6);
            this.groupBox4.Controls.Add(this.radioButton7);
            this.groupBox4.Controls.Add(this.radioButton8);
            this.groupBox4.Controls.Add(this.radioButton9);
            this.groupBox4.Location = new System.Drawing.Point(879, 441);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(637, 51);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CHOOSE WEAPON";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(493, 21);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(68, 24);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Spear";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(370, 21);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(55, 24);
            this.radioButton6.TabIndex = 3;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Axe";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(249, 21);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(94, 24);
            this.radioButton7.TabIndex = 2;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Crossbow";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(126, 21);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(80, 24);
            this.radioButton8.TabIndex = 1;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Dagger";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(3, 23);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(72, 24);
            this.radioButton9.TabIndex = 0;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Sword";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 504);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbWinner);
            this.Controls.Add(this.imgFight);
            this.Controls.Add(this.tbHeroTwo);
            this.Controls.Add(this.tbHeroOne);
            this.Controls.Add(this.btnNewGame);
            this.Name = "MainForm";
            this.Text = "Arena Game";
            ((System.ComponentModel.ISupportInitialize)(this.imgFight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnNewGame;
        private TextBox tbHeroOne;
        private TextBox tbHeroTwo;
        private PictureBox imgFight;
        private Label lbWinner;
        private Label label1;
        private Label label2;
        private RadioButton rbAssassin;
        private RadioButton rbGladiator;
        private RadioButton rbDwarf;
        private RadioButton rbKnight;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton rbSpear;
        private RadioButton rbAxe;
        private RadioButton rbCrossbow;
        private RadioButton rbDagger;
        private RadioButton rbSword;
        private GroupBox groupBox3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private GroupBox groupBox4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
    }
}