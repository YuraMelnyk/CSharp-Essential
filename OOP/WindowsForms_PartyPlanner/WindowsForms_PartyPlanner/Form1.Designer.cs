namespace WindowsForms_PartyPlanner
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxHealthyOption = new System.Windows.Forms.CheckBox();
            this.checkBoxFuncyDecor = new System.Windows.Forms.CheckBox();
            this.numericUpDownNumPeople = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownBirthday = new System.Windows.Forms.NumericUpDown();
            this.checkBoxFancyBirthday = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTooLong = new System.Windows.Forms.Label();
            this.textBoxCakeWriting = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBirthdayCost = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(225, 248);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxCost);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.checkBoxHealthyOption);
            this.tabPage1.Controls.Add(this.checkBoxFuncyDecor);
            this.tabPage1.Controls.Add(this.numericUpDownNumPeople);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(217, 219);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner Party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxBirthdayCost);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBoxCakeWriting);
            this.tabPage2.Controls.Add(this.labelTooLong);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.checkBoxFancyBirthday);
            this.tabPage2.Controls.Add(this.numericUpDownBirthday);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(217, 219);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(77, 168);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(100, 22);
            this.textBoxCost.TabIndex = 11;
            this.textBoxCost.TextChanged += new System.EventHandler(this.textBoxCost_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cost";
            // 
            // checkBoxHealthyOption
            // 
            this.checkBoxHealthyOption.AutoSize = true;
            this.checkBoxHealthyOption.Location = new System.Drawing.Point(51, 125);
            this.checkBoxHealthyOption.Name = "checkBoxHealthyOption";
            this.checkBoxHealthyOption.Size = new System.Drawing.Size(124, 21);
            this.checkBoxHealthyOption.TabIndex = 9;
            this.checkBoxHealthyOption.Text = "Healthy Option";
            this.checkBoxHealthyOption.UseVisualStyleBackColor = true;
            this.checkBoxHealthyOption.CheckedChanged += new System.EventHandler(this.checkBoxHealthyOption_CheckedChanged_1);
            // 
            // checkBoxFuncyDecor
            // 
            this.checkBoxFuncyDecor.AutoSize = true;
            this.checkBoxFuncyDecor.Checked = true;
            this.checkBoxFuncyDecor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFuncyDecor.Location = new System.Drawing.Point(51, 97);
            this.checkBoxFuncyDecor.Name = "checkBoxFuncyDecor";
            this.checkBoxFuncyDecor.Size = new System.Drawing.Size(141, 21);
            this.checkBoxFuncyDecor.TabIndex = 8;
            this.checkBoxFuncyDecor.Text = "Fancy Decoration";
            this.checkBoxFuncyDecor.UseVisualStyleBackColor = false;
            this.checkBoxFuncyDecor.CheckedChanged += new System.EventHandler(this.checkBoxFuncyDecor_CheckedChanged_1);
            // 
            // numericUpDownNumPeople
            // 
            this.numericUpDownNumPeople.Location = new System.Drawing.Point(51, 59);
            this.numericUpDownNumPeople.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownNumPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumPeople.Name = "numericUpDownNumPeople";
            this.numericUpDownNumPeople.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownNumPeople.TabIndex = 7;
            this.numericUpDownNumPeople.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownNumPeople.ValueChanged += new System.EventHandler(this.numericUpDownNumPeople_ValueChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number of People";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number of People";
            // 
            // numericUpDownBirthday
            // 
            this.numericUpDownBirthday.Location = new System.Drawing.Point(23, 44);
            this.numericUpDownBirthday.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBirthday.Name = "numericUpDownBirthday";
            this.numericUpDownBirthday.Size = new System.Drawing.Size(135, 22);
            this.numericUpDownBirthday.TabIndex = 1;
            this.numericUpDownBirthday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownBirthday.ValueChanged += new System.EventHandler(this.numericUpDownBirthday_ValueChanged);
            // 
            // checkBoxFancyBirthday
            // 
            this.checkBoxFancyBirthday.AutoSize = true;
            this.checkBoxFancyBirthday.Location = new System.Drawing.Point(23, 72);
            this.checkBoxFancyBirthday.Name = "checkBoxFancyBirthday";
            this.checkBoxFancyBirthday.Size = new System.Drawing.Size(148, 21);
            this.checkBoxFancyBirthday.TabIndex = 2;
            this.checkBoxFancyBirthday.Text = "Funcy Decorations";
            this.checkBoxFancyBirthday.UseVisualStyleBackColor = true;
            this.checkBoxFancyBirthday.CheckedChanged += new System.EventHandler(this.checkBoxFancyBirthday_CheckedChanged);
            this.checkBoxFancyBirthday.TextChanged += new System.EventHandler(this.cakeWriting_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cake Writing";
            // 
            // labelTooLong
            // 
            this.labelTooLong.AutoSize = true;
            this.labelTooLong.BackColor = System.Drawing.Color.Maroon;
            this.labelTooLong.Location = new System.Drawing.Point(114, 112);
            this.labelTooLong.Name = "labelTooLong";
            this.labelTooLong.Size = new System.Drawing.Size(83, 17);
            this.labelTooLong.TabIndex = 4;
            this.labelTooLong.Text = "TOO LONG";
            // 
            // textBoxCakeWriting
            // 
            this.textBoxCakeWriting.Location = new System.Drawing.Point(23, 132);
            this.textBoxCakeWriting.Name = "textBoxCakeWriting";
            this.textBoxCakeWriting.Size = new System.Drawing.Size(174, 22);
            this.textBoxCakeWriting.TabIndex = 5;
            this.textBoxCakeWriting.Text = "Happy Birthday";
            this.textBoxCakeWriting.TextChanged += new System.EventHandler(this.textBoxCakeWriting_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cost";
            // 
            // textBoxBirthdayCost
            // 
            this.textBoxBirthdayCost.Location = new System.Drawing.Point(97, 172);
            this.textBoxBirthdayCost.Name = "textBoxBirthdayCost";
            this.textBoxBirthdayCost.Size = new System.Drawing.Size(100, 22);
            this.textBoxBirthdayCost.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 250);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxHealthyOption;
        private System.Windows.Forms.CheckBox checkBoxFuncyDecor;
        private System.Windows.Forms.NumericUpDown numericUpDownNumPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxBirthdayCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCakeWriting;
        private System.Windows.Forms.Label labelTooLong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxFancyBirthday;
        private System.Windows.Forms.NumericUpDown numericUpDownBirthday;
        private System.Windows.Forms.Label label3;
    }
}

