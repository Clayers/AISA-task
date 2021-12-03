namespace CoffeeMaker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOnCoffeeMaker = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonPourWater = new System.Windows.Forms.Button();
            this.buttonPourCoffee = new System.Windows.Forms.Button();
            this.buttonСoffee = new System.Windows.Forms.Button();
            this.groupBoxCoffeeMaker = new System.Windows.Forms.GroupBox();
            this.labelCoffee = new System.Windows.Forms.Label();
            this.labelWater = new System.Windows.Forms.Label();
            this.labelClean = new System.Windows.Forms.Label();
            this.groupBoxLastCoffe = new System.Windows.Forms.GroupBox();
            this.listBoxCoffee = new System.Windows.Forms.ListBox();
            this.groupBoxTotalUse = new System.Windows.Forms.GroupBox();
            this.labelAllPourCoffee = new System.Windows.Forms.Label();
            this.labelAllPourWater = new System.Windows.Forms.Label();
            this.labelAllClean = new System.Windows.Forms.Label();
            this.groupBoxInformationMonth = new System.Windows.Forms.GroupBox();
            this.labelCoffeeBeansMonth = new System.Windows.Forms.Label();
            this.labelWaterMonth = new System.Windows.Forms.Label();
            this.labelPopularMonth = new System.Windows.Forms.Label();
            this.labelCoffeeMonth = new System.Windows.Forms.Label();
            this.groupBoxIformationAllTime = new System.Windows.Forms.GroupBox();
            this.labelCoffeeBeansAllTime = new System.Windows.Forms.Label();
            this.labelWaterAllTime = new System.Windows.Forms.Label();
            this.labelPopularCofeeAllTime = new System.Windows.Forms.Label();
            this.labelCofeeAllTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxCoffeeMaker.SuspendLayout();
            this.groupBoxLastCoffe.SuspendLayout();
            this.groupBoxTotalUse.SuspendLayout();
            this.groupBoxInformationMonth.SuspendLayout();
            this.groupBoxIformationAllTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoffeeMaker.Properties.Resources.Coffee;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 291);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonOnCoffeeMaker
            // 
            this.buttonOnCoffeeMaker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.buttonOnCoffeeMaker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.buttonOnCoffeeMaker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(80)))));
            this.buttonOnCoffeeMaker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.buttonOnCoffeeMaker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOnCoffeeMaker.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOnCoffeeMaker.Location = new System.Drawing.Point(13, 310);
            this.buttonOnCoffeeMaker.Name = "buttonOnCoffeeMaker";
            this.buttonOnCoffeeMaker.Size = new System.Drawing.Size(139, 23);
            this.buttonOnCoffeeMaker.TabIndex = 1;
            this.buttonOnCoffeeMaker.Text = "On Coffee Maker";
            this.buttonOnCoffeeMaker.UseVisualStyleBackColor = false;
            this.buttonOnCoffeeMaker.Click += new System.EventHandler(this.buttonOnCoffeeMaker_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(415, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select type coffee";
            // 
            // buttonClean
            // 
            this.buttonClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.buttonClean.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.buttonClean.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(80)))));
            this.buttonClean.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.buttonClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClean.ForeColor = System.Drawing.Color.White;
            this.buttonClean.Location = new System.Drawing.Point(13, 340);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(139, 23);
            this.buttonClean.TabIndex = 4;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = false;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonPourWater
            // 
            this.buttonPourWater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.buttonPourWater.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.buttonPourWater.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(80)))));
            this.buttonPourWater.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.buttonPourWater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPourWater.ForeColor = System.Drawing.Color.White;
            this.buttonPourWater.Location = new System.Drawing.Point(12, 370);
            this.buttonPourWater.Name = "buttonPourWater";
            this.buttonPourWater.Size = new System.Drawing.Size(140, 23);
            this.buttonPourWater.TabIndex = 5;
            this.buttonPourWater.Text = "Pour Water";
            this.buttonPourWater.UseVisualStyleBackColor = false;
            this.buttonPourWater.Click += new System.EventHandler(this.buttonPourWater_Click);
            // 
            // buttonPourCoffee
            // 
            this.buttonPourCoffee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.buttonPourCoffee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.buttonPourCoffee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(80)))));
            this.buttonPourCoffee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.buttonPourCoffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPourCoffee.ForeColor = System.Drawing.Color.White;
            this.buttonPourCoffee.Location = new System.Drawing.Point(13, 400);
            this.buttonPourCoffee.Name = "buttonPourCoffee";
            this.buttonPourCoffee.Size = new System.Drawing.Size(139, 23);
            this.buttonPourCoffee.TabIndex = 6;
            this.buttonPourCoffee.Text = "Pour Coffee";
            this.buttonPourCoffee.UseVisualStyleBackColor = false;
            this.buttonPourCoffee.Click += new System.EventHandler(this.buttonPourCoffee_Click);
            // 
            // buttonСoffee
            // 
            this.buttonСoffee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.buttonСoffee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.buttonСoffee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(80)))));
            this.buttonСoffee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.buttonСoffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonСoffee.ForeColor = System.Drawing.Color.White;
            this.buttonСoffee.Location = new System.Drawing.Point(319, 60);
            this.buttonСoffee.Name = "buttonСoffee";
            this.buttonСoffee.Size = new System.Drawing.Size(217, 23);
            this.buttonСoffee.TabIndex = 7;
            this.buttonСoffee.Text = "Сoffee";
            this.buttonСoffee.UseVisualStyleBackColor = false;
            this.buttonСoffee.Click += new System.EventHandler(this.buttonСoffee_Click);
            // 
            // groupBoxCoffeeMaker
            // 
            this.groupBoxCoffeeMaker.BackColor = System.Drawing.Color.White;
            this.groupBoxCoffeeMaker.Controls.Add(this.labelCoffee);
            this.groupBoxCoffeeMaker.Controls.Add(this.labelWater);
            this.groupBoxCoffeeMaker.Controls.Add(this.labelClean);
            this.groupBoxCoffeeMaker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.groupBoxCoffeeMaker.Location = new System.Drawing.Point(169, 309);
            this.groupBoxCoffeeMaker.Name = "groupBoxCoffeeMaker";
            this.groupBoxCoffeeMaker.Size = new System.Drawing.Size(141, 114);
            this.groupBoxCoffeeMaker.TabIndex = 8;
            this.groupBoxCoffeeMaker.TabStop = false;
            this.groupBoxCoffeeMaker.Text = "Coffee maker";
            // 
            // labelCoffee
            // 
            this.labelCoffee.AutoSize = true;
            this.labelCoffee.Location = new System.Drawing.Point(6, 91);
            this.labelCoffee.Name = "labelCoffee";
            this.labelCoffee.Size = new System.Drawing.Size(35, 13);
            this.labelCoffee.TabIndex = 3;
            this.labelCoffee.Text = "label5";
            // 
            // labelWater
            // 
            this.labelWater.AutoSize = true;
            this.labelWater.Location = new System.Drawing.Point(7, 61);
            this.labelWater.Name = "labelWater";
            this.labelWater.Size = new System.Drawing.Size(35, 13);
            this.labelWater.TabIndex = 2;
            this.labelWater.Text = "label4";
            // 
            // labelClean
            // 
            this.labelClean.AutoSize = true;
            this.labelClean.Location = new System.Drawing.Point(7, 31);
            this.labelClean.Name = "labelClean";
            this.labelClean.Size = new System.Drawing.Size(35, 13);
            this.labelClean.TabIndex = 1;
            this.labelClean.Text = "label3";
            // 
            // groupBoxLastCoffe
            // 
            this.groupBoxLastCoffe.Controls.Add(this.listBoxCoffee);
            this.groupBoxLastCoffe.Location = new System.Drawing.Point(319, 99);
            this.groupBoxLastCoffe.Name = "groupBoxLastCoffe";
            this.groupBoxLastCoffe.Size = new System.Drawing.Size(217, 204);
            this.groupBoxLastCoffe.TabIndex = 9;
            this.groupBoxLastCoffe.TabStop = false;
            this.groupBoxLastCoffe.Text = "The last coffee";
            // 
            // listBoxCoffee
            // 
            this.listBoxCoffee.FormattingEnabled = true;
            this.listBoxCoffee.Location = new System.Drawing.Point(6, 19);
            this.listBoxCoffee.Name = "listBoxCoffee";
            this.listBoxCoffee.Size = new System.Drawing.Size(205, 173);
            this.listBoxCoffee.TabIndex = 0;
            // 
            // groupBoxTotalUse
            // 
            this.groupBoxTotalUse.Controls.Add(this.labelAllPourCoffee);
            this.groupBoxTotalUse.Controls.Add(this.labelAllPourWater);
            this.groupBoxTotalUse.Controls.Add(this.labelAllClean);
            this.groupBoxTotalUse.Location = new System.Drawing.Point(319, 309);
            this.groupBoxTotalUse.Name = "groupBoxTotalUse";
            this.groupBoxTotalUse.Size = new System.Drawing.Size(217, 114);
            this.groupBoxTotalUse.TabIndex = 10;
            this.groupBoxTotalUse.TabStop = false;
            this.groupBoxTotalUse.Text = "Total use of the coffee machine";
            // 
            // labelAllPourCoffee
            // 
            this.labelAllPourCoffee.AutoSize = true;
            this.labelAllPourCoffee.Location = new System.Drawing.Point(7, 91);
            this.labelAllPourCoffee.Name = "labelAllPourCoffee";
            this.labelAllPourCoffee.Size = new System.Drawing.Size(35, 13);
            this.labelAllPourCoffee.TabIndex = 2;
            this.labelAllPourCoffee.Text = "label4";
            // 
            // labelAllPourWater
            // 
            this.labelAllPourWater.AutoSize = true;
            this.labelAllPourWater.Location = new System.Drawing.Point(7, 61);
            this.labelAllPourWater.Name = "labelAllPourWater";
            this.labelAllPourWater.Size = new System.Drawing.Size(35, 13);
            this.labelAllPourWater.TabIndex = 1;
            this.labelAllPourWater.Text = "label3";
            // 
            // labelAllClean
            // 
            this.labelAllClean.AutoSize = true;
            this.labelAllClean.Location = new System.Drawing.Point(7, 31);
            this.labelAllClean.Name = "labelAllClean";
            this.labelAllClean.Size = new System.Drawing.Size(35, 13);
            this.labelAllClean.TabIndex = 0;
            this.labelAllClean.Text = "label2";
            // 
            // groupBoxInformationMonth
            // 
            this.groupBoxInformationMonth.Controls.Add(this.labelCoffeeBeansMonth);
            this.groupBoxInformationMonth.Controls.Add(this.labelWaterMonth);
            this.groupBoxInformationMonth.Controls.Add(this.labelPopularMonth);
            this.groupBoxInformationMonth.Controls.Add(this.labelCoffeeMonth);
            this.groupBoxInformationMonth.Location = new System.Drawing.Point(554, 21);
            this.groupBoxInformationMonth.Name = "groupBoxInformationMonth";
            this.groupBoxInformationMonth.Size = new System.Drawing.Size(234, 195);
            this.groupBoxInformationMonth.TabIndex = 11;
            this.groupBoxInformationMonth.TabStop = false;
            this.groupBoxInformationMonth.Text = "Information for the month";
            // 
            // labelCoffeeBeansMonth
            // 
            this.labelCoffeeBeansMonth.AutoSize = true;
            this.labelCoffeeBeansMonth.Location = new System.Drawing.Point(18, 131);
            this.labelCoffeeBeansMonth.Name = "labelCoffeeBeansMonth";
            this.labelCoffeeBeansMonth.Size = new System.Drawing.Size(98, 13);
            this.labelCoffeeBeansMonth.TabIndex = 3;
            this.labelCoffeeBeansMonth.Text = "CoffeeBeansMonth";
            // 
            // labelWaterMonth
            // 
            this.labelWaterMonth.AutoSize = true;
            this.labelWaterMonth.Location = new System.Drawing.Point(18, 109);
            this.labelWaterMonth.Name = "labelWaterMonth";
            this.labelWaterMonth.Size = new System.Drawing.Size(66, 13);
            this.labelWaterMonth.TabIndex = 2;
            this.labelWaterMonth.Text = "WaterMonth";
            // 
            // labelPopularMonth
            // 
            this.labelPopularMonth.AutoSize = true;
            this.labelPopularMonth.Location = new System.Drawing.Point(18, 49);
            this.labelPopularMonth.Name = "labelPopularMonth";
            this.labelPopularMonth.Size = new System.Drawing.Size(104, 13);
            this.labelPopularMonth.TabIndex = 1;
            this.labelPopularMonth.Text = "PopularCoffeeMonth";
            // 
            // labelCoffeeMonth
            // 
            this.labelCoffeeMonth.AutoSize = true;
            this.labelCoffeeMonth.Location = new System.Drawing.Point(18, 29);
            this.labelCoffeeMonth.Name = "labelCoffeeMonth";
            this.labelCoffeeMonth.Size = new System.Drawing.Size(68, 13);
            this.labelCoffeeMonth.TabIndex = 0;
            this.labelCoffeeMonth.Text = "CoffeeMonth";
            // 
            // groupBoxIformationAllTime
            // 
            this.groupBoxIformationAllTime.Controls.Add(this.labelCoffeeBeansAllTime);
            this.groupBoxIformationAllTime.Controls.Add(this.labelWaterAllTime);
            this.groupBoxIformationAllTime.Controls.Add(this.labelPopularCofeeAllTime);
            this.groupBoxIformationAllTime.Controls.Add(this.labelCofeeAllTime);
            this.groupBoxIformationAllTime.Location = new System.Drawing.Point(554, 228);
            this.groupBoxIformationAllTime.Name = "groupBoxIformationAllTime";
            this.groupBoxIformationAllTime.Size = new System.Drawing.Size(234, 195);
            this.groupBoxIformationAllTime.TabIndex = 12;
            this.groupBoxIformationAllTime.TabStop = false;
            this.groupBoxIformationAllTime.Text = "Information for all time";
            // 
            // labelCoffeeBeansAllTime
            // 
            this.labelCoffeeBeansAllTime.AutoSize = true;
            this.labelCoffeeBeansAllTime.Location = new System.Drawing.Point(18, 131);
            this.labelCoffeeBeansAllTime.Name = "labelCoffeeBeansAllTime";
            this.labelCoffeeBeansAllTime.Size = new System.Drawing.Size(102, 13);
            this.labelCoffeeBeansAllTime.TabIndex = 3;
            this.labelCoffeeBeansAllTime.Text = "CoffeeBeansAllTime";
            // 
            // labelWaterAllTime
            // 
            this.labelWaterAllTime.AutoSize = true;
            this.labelWaterAllTime.Location = new System.Drawing.Point(18, 109);
            this.labelWaterAllTime.Name = "labelWaterAllTime";
            this.labelWaterAllTime.Size = new System.Drawing.Size(70, 13);
            this.labelWaterAllTime.TabIndex = 2;
            this.labelWaterAllTime.Text = "WaterAllTime";
            // 
            // labelPopularCofeeAllTime
            // 
            this.labelPopularCofeeAllTime.AutoSize = true;
            this.labelPopularCofeeAllTime.Location = new System.Drawing.Point(18, 49);
            this.labelPopularCofeeAllTime.Name = "labelPopularCofeeAllTime";
            this.labelPopularCofeeAllTime.Size = new System.Drawing.Size(105, 13);
            this.labelPopularCofeeAllTime.TabIndex = 1;
            this.labelPopularCofeeAllTime.Text = "PopularCofeeAllTime";
            // 
            // labelCofeeAllTime
            // 
            this.labelCofeeAllTime.AutoSize = true;
            this.labelCofeeAllTime.Location = new System.Drawing.Point(18, 29);
            this.labelCofeeAllTime.Name = "labelCofeeAllTime";
            this.labelCofeeAllTime.Size = new System.Drawing.Size(72, 13);
            this.labelCofeeAllTime.TabIndex = 0;
            this.labelCofeeAllTime.Text = "CoffeeAllTime";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxIformationAllTime);
            this.Controls.Add(this.groupBoxInformationMonth);
            this.Controls.Add(this.groupBoxTotalUse);
            this.Controls.Add(this.groupBoxLastCoffe);
            this.Controls.Add(this.groupBoxCoffeeMaker);
            this.Controls.Add(this.buttonСoffee);
            this.Controls.Add(this.buttonPourCoffee);
            this.Controls.Add(this.buttonPourWater);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonOnCoffeeMaker);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Coffee Maker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxCoffeeMaker.ResumeLayout(false);
            this.groupBoxCoffeeMaker.PerformLayout();
            this.groupBoxLastCoffe.ResumeLayout(false);
            this.groupBoxTotalUse.ResumeLayout(false);
            this.groupBoxTotalUse.PerformLayout();
            this.groupBoxInformationMonth.ResumeLayout(false);
            this.groupBoxInformationMonth.PerformLayout();
            this.groupBoxIformationAllTime.ResumeLayout(false);
            this.groupBoxIformationAllTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonOnCoffeeMaker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonPourWater;
        private System.Windows.Forms.Button buttonPourCoffee;
        private System.Windows.Forms.Button buttonСoffee;
        private System.Windows.Forms.GroupBox groupBoxCoffeeMaker;
        private System.Windows.Forms.Label labelCoffee;
        private System.Windows.Forms.Label labelWater;
        private System.Windows.Forms.Label labelClean;
        private System.Windows.Forms.GroupBox groupBoxLastCoffe;
        private System.Windows.Forms.ListBox listBoxCoffee;
        private System.Windows.Forms.GroupBox groupBoxTotalUse;
        private System.Windows.Forms.Label labelAllPourCoffee;
        private System.Windows.Forms.Label labelAllPourWater;
        private System.Windows.Forms.Label labelAllClean;
        private System.Windows.Forms.GroupBox groupBoxInformationMonth;
        private System.Windows.Forms.Label labelCoffeeBeansMonth;
        private System.Windows.Forms.Label labelWaterMonth;
        private System.Windows.Forms.Label labelPopularMonth;
        private System.Windows.Forms.Label labelCoffeeMonth;
        private System.Windows.Forms.GroupBox groupBoxIformationAllTime;
        private System.Windows.Forms.Label labelCoffeeBeansAllTime;
        private System.Windows.Forms.Label labelWaterAllTime;
        private System.Windows.Forms.Label labelPopularCofeeAllTime;
        private System.Windows.Forms.Label labelCofeeAllTime;
    }
}