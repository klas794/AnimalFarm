namespace InheritanceProject
{
    partial class FormAnimalFarm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnBuyChicken = new System.Windows.Forms.Button();
            this.btnBuyCow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.btnNextYear = new System.Windows.Forms.Button();
            this.lblMilk = new System.Windows.Forms.Label();
            this.lblEggs = new System.Windows.Forms.Label();
            this.btnSell = new System.Windows.Forms.Button();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblMeat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnForage = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblForage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelInfoDead = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtButchYear = new System.Windows.Forms.TextBox();
            this.btnButchYear = new System.Windows.Forms.Button();
            this.checkBoxFeelGood = new System.Windows.Forms.CheckBox();
            this.btnBuyCowShed = new System.Windows.Forms.Button();
            this.btnBuyHenShed = new System.Windows.Forms.Button();
            this.labelBuildings = new System.Windows.Forms.Label();
            this.lblBuildings = new System.Windows.Forms.Label();
            this.btnBuyBigBarn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(19, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ålder";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(132, 33);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 2;
            // 
            // btnBuyChicken
            // 
            this.btnBuyChicken.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuyChicken.Location = new System.Drawing.Point(248, 31);
            this.btnBuyChicken.Name = "btnBuyChicken";
            this.btnBuyChicken.Size = new System.Drawing.Size(98, 23);
            this.btnBuyChicken.TabIndex = 4;
            this.btnBuyChicken.Text = "Köp kyckling";
            this.btnBuyChicken.UseVisualStyleBackColor = false;
            this.btnBuyChicken.Click += new System.EventHandler(this.btnChicken_Click);
            // 
            // btnBuyCow
            // 
            this.btnBuyCow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuyCow.Location = new System.Drawing.Point(352, 31);
            this.btnBuyCow.Name = "btnBuyCow";
            this.btnBuyCow.Size = new System.Drawing.Size(98, 23);
            this.btnBuyCow.TabIndex = 5;
            this.btnBuyCow.Text = "Köp ko";
            this.btnBuyCow.UseVisualStyleBackColor = false;
            this.btnBuyCow.Click += new System.EventHandler(this.btnBuyCow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Antal djur: ";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(83, 66);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(10, 13);
            this.labelCount.TabIndex = 7;
            this.labelCount.Text = "-";
            // 
            // btnNextYear
            // 
            this.btnNextYear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNextYear.Location = new System.Drawing.Point(352, 61);
            this.btnNextYear.Name = "btnNextYear";
            this.btnNextYear.Size = new System.Drawing.Size(98, 23);
            this.btnNextYear.TabIndex = 9;
            this.btnNextYear.Text = "Nästa år";
            this.btnNextYear.UseVisualStyleBackColor = false;
            this.btnNextYear.Click += new System.EventHandler(this.btnNextYear_Click);
            // 
            // lblMilk
            // 
            this.lblMilk.AutoSize = true;
            this.lblMilk.Location = new System.Drawing.Point(333, 181);
            this.lblMilk.Name = "lblMilk";
            this.lblMilk.Size = new System.Drawing.Size(13, 13);
            this.lblMilk.TabIndex = 17;
            this.lblMilk.Text = "0";
            // 
            // lblEggs
            // 
            this.lblEggs.AutoSize = true;
            this.lblEggs.Location = new System.Drawing.Point(257, 181);
            this.lblEggs.Name = "lblEggs";
            this.lblEggs.Size = new System.Drawing.Size(13, 13);
            this.lblEggs.TabIndex = 14;
            this.lblEggs.Text = "0";
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSell.Location = new System.Drawing.Point(260, 207);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(112, 23);
            this.btnSell.TabIndex = 18;
            this.btnSell.Text = "Sälj!";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Location = new System.Drawing.Point(296, 244);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(25, 13);
            this.lblCash.TabIndex = 19;
            this.lblCash.Text = "0 kr";
            // 
            // lblMeat
            // 
            this.lblMeat.AutoSize = true;
            this.lblMeat.Location = new System.Drawing.Point(397, 181);
            this.lblMeat.Name = "lblMeat";
            this.lblMeat.Size = new System.Drawing.Size(13, 13);
            this.lblMeat.TabIndex = 21;
            this.lblMeat.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Vinst:";
            // 
            // btnForage
            // 
            this.btnForage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnForage.Location = new System.Drawing.Point(485, 207);
            this.btnForage.Name = "btnForage";
            this.btnForage.Size = new System.Drawing.Size(100, 23);
            this.btnForage.TabIndex = 26;
            this.btnForage.Text = "Fodra";
            this.btnForage.UseVisualStyleBackColor = false;
            this.btnForage.Click += new System.EventHandler(this.btnForage_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(482, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Foder:";
            // 
            // lblForage
            // 
            this.lblForage.AutoSize = true;
            this.lblForage.Location = new System.Drawing.Point(521, 244);
            this.lblForage.Name = "lblForage";
            this.lblForage.Size = new System.Drawing.Size(13, 13);
            this.lblForage.TabIndex = 27;
            this.lblForage.Text = "0";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.labelInfoDead);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelInfo);
            this.panel1.Location = new System.Drawing.Point(23, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 339);
            this.panel1.TabIndex = 30;
            // 
            // labelInfoDead
            // 
            this.labelInfoDead.AutoSize = true;
            this.labelInfoDead.Location = new System.Drawing.Point(107, 20);
            this.labelInfoDead.Name = "labelInfoDead";
            this.labelInfoDead.Size = new System.Drawing.Size(16, 13);
            this.labelInfoDead.TabIndex = 16;
            this.labelInfoDead.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Levande djur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Döda djur";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(-2, 20);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(16, 13);
            this.labelInfo.TabIndex = 13;
            this.labelInfo.Text = "...";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::InheritanceProject.Properties.Resources.knife;
            this.pictureBox6.Location = new System.Drawing.Point(631, 104);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(96, 90);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 31;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::InheritanceProject.Properties.Resources.forage;
            this.pictureBox5.Location = new System.Drawing.Point(489, 104);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(96, 90);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 29;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::InheritanceProject.Properties.Resources.meat;
            this.pictureBox4.Location = new System.Drawing.Point(389, 103);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(68, 62);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::InheritanceProject.Properties.Resources.milk;
            this.pictureBox3.Location = new System.Drawing.Point(323, 103);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InheritanceProject.Properties.Resources.eggs;
            this.pictureBox2.Location = new System.Drawing.Point(246, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InheritanceProject.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(248, 275);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // txtButchYear
            // 
            this.txtButchYear.Location = new System.Drawing.Point(631, 209);
            this.txtButchYear.Name = "txtButchYear";
            this.txtButchYear.Size = new System.Drawing.Size(96, 20);
            this.txtButchYear.TabIndex = 32;
            // 
            // btnButchYear
            // 
            this.btnButchYear.Location = new System.Drawing.Point(631, 239);
            this.btnButchYear.Name = "btnButchYear";
            this.btnButchYear.Size = new System.Drawing.Size(96, 23);
            this.btnButchYear.TabIndex = 33;
            this.btnButchYear.Text = "Slaktår";
            this.btnButchYear.UseVisualStyleBackColor = true;
            this.btnButchYear.Click += new System.EventHandler(this.btnButchYear_Click);
            // 
            // checkBoxFeelGood
            // 
            this.checkBoxFeelGood.AutoSize = true;
            this.checkBoxFeelGood.Location = new System.Drawing.Point(485, 275);
            this.checkBoxFeelGood.Name = "checkBoxFeelGood";
            this.checkBoxFeelGood.Size = new System.Drawing.Size(88, 17);
            this.checkBoxFeelGood.TabIndex = 34;
            this.checkBoxFeelGood.Text = "Behandla väl";
            this.checkBoxFeelGood.UseVisualStyleBackColor = true;
            // 
            // btnBuyCowShed
            // 
            this.btnBuyCowShed.Location = new System.Drawing.Point(485, 326);
            this.btnBuyCowShed.Name = "btnBuyCowShed";
            this.btnBuyCowShed.Size = new System.Drawing.Size(84, 23);
            this.btnBuyCowShed.TabIndex = 35;
            this.btnBuyCowShed.Text = "Köp kostall";
            this.btnBuyCowShed.UseVisualStyleBackColor = true;
            this.btnBuyCowShed.Click += new System.EventHandler(this.btnBuyCowShed_Click);
            // 
            // btnBuyHenShed
            // 
            this.btnBuyHenShed.Location = new System.Drawing.Point(569, 326);
            this.btnBuyHenShed.Name = "btnBuyHenShed";
            this.btnBuyHenShed.Size = new System.Drawing.Size(84, 23);
            this.btnBuyHenShed.TabIndex = 36;
            this.btnBuyHenShed.Text = "Köp hönshus";
            this.btnBuyHenShed.UseVisualStyleBackColor = true;
            this.btnBuyHenShed.Click += new System.EventHandler(this.btnBuyHenShed_Click);
            // 
            // labelBuildings
            // 
            this.labelBuildings.AutoSize = true;
            this.labelBuildings.Location = new System.Drawing.Point(493, 359);
            this.labelBuildings.Name = "labelBuildings";
            this.labelBuildings.Size = new System.Drawing.Size(61, 13);
            this.labelBuildings.TabIndex = 37;
            this.labelBuildings.Text = "Byggnader:";
            // 
            // lblBuildings
            // 
            this.lblBuildings.AutoSize = true;
            this.lblBuildings.Location = new System.Drawing.Point(493, 380);
            this.lblBuildings.Name = "lblBuildings";
            this.lblBuildings.Size = new System.Drawing.Size(10, 13);
            this.lblBuildings.TabIndex = 38;
            this.lblBuildings.Text = "-";
            // 
            // btnBuyBigBarn
            // 
            this.btnBuyBigBarn.Location = new System.Drawing.Point(653, 326);
            this.btnBuyBigBarn.Name = "btnBuyBigBarn";
            this.btnBuyBigBarn.Size = new System.Drawing.Size(84, 23);
            this.btnBuyBigBarn.TabIndex = 39;
            this.btnBuyBigBarn.Text = "Köp stor lada";
            this.btnBuyBigBarn.UseVisualStyleBackColor = true;
            this.btnBuyBigBarn.Click += new System.EventHandler(this.btnBuyBigBarn_Click);
            // 
            // FormAnimalFarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(767, 474);
            this.Controls.Add(this.btnBuyBigBarn);
            this.Controls.Add(this.lblBuildings);
            this.Controls.Add(this.labelBuildings);
            this.Controls.Add(this.btnBuyHenShed);
            this.Controls.Add(this.btnBuyCowShed);
            this.Controls.Add(this.checkBoxFeelGood);
            this.Controls.Add(this.btnButchYear);
            this.Controls.Add(this.txtButchYear);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblForage);
            this.Controls.Add(this.btnForage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblMeat);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.lblMilk);
            this.Controls.Add(this.lblEggs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNextYear);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuyCow);
            this.Controls.Add(this.btnBuyChicken);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "FormAnimalFarm";
            this.Text = "Animal Farm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnBuyChicken;
        private System.Windows.Forms.Button btnBuyCow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button btnNextYear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMilk;
        private System.Windows.Forms.Label lblEggs;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblMeat;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnForage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblForage;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelInfoDead;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox txtButchYear;
        private System.Windows.Forms.Button btnButchYear;
        private System.Windows.Forms.CheckBox checkBoxFeelGood;
        private System.Windows.Forms.Button btnBuyCowShed;
        private System.Windows.Forms.Button btnBuyHenShed;
        private System.Windows.Forms.Label labelBuildings;
        private System.Windows.Forms.Label lblBuildings;
        private System.Windows.Forms.Button btnBuyBigBarn;
    }
}