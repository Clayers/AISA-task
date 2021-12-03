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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxCoffeeMaker.SuspendLayout();
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
            this.buttonOnCoffeeMaker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(70)))));
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
            this.comboBox1.Items.AddRange(new object[] {
            "espresso",
            "cappuccino",
            "double espresso",
            "americano "});
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
            this.buttonClean.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
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
            this.buttonPourWater.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
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
            this.buttonPourCoffee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
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
            this.buttonСoffee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.buttonСoffee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.buttonСoffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonСoffee.ForeColor = System.Drawing.Color.White;
            this.buttonСoffee.Location = new System.Drawing.Point(319, 60);
            this.buttonСoffee.Name = "buttonСoffee";
            this.buttonСoffee.Size = new System.Drawing.Size(217, 23);
            this.buttonСoffee.TabIndex = 7;
            this.buttonСoffee.Text = "Сoffee";
            this.buttonСoffee.UseVisualStyleBackColor = false;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxCoffeeMaker.ResumeLayout(false);
            this.groupBoxCoffeeMaker.PerformLayout();
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
    }
}