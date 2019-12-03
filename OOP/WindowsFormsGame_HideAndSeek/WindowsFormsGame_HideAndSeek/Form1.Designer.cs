namespace WindowsFormsGame_HideAndSeek
{
    partial class GameForm
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
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonGoHere = new System.Windows.Forms.Button();
            this.comboBoxExists = new System.Windows.Forms.ComboBox();
            this.buttonGoThroughTheDoor = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonHide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Location = new System.Drawing.Point(12, 12);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(257, 157);
            this.textBoxDescription.TabIndex = 2;
            this.textBoxDescription.Text = "Let\'s go?";
            // 
            // buttonGoHere
            // 
            this.buttonGoHere.Location = new System.Drawing.Point(12, 175);
            this.buttonGoHere.Name = "buttonGoHere";
            this.buttonGoHere.Size = new System.Drawing.Size(75, 23);
            this.buttonGoHere.TabIndex = 3;
            this.buttonGoHere.Text = "Go here";
            this.buttonGoHere.UseVisualStyleBackColor = true;
            this.buttonGoHere.Visible = false;
            this.buttonGoHere.Click += new System.EventHandler(this.buttonGoHere_Click);
            // 
            // comboBoxExists
            // 
            this.comboBoxExists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxExists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExists.FormattingEnabled = true;
            this.comboBoxExists.Location = new System.Drawing.Point(103, 175);
            this.comboBoxExists.Name = "comboBoxExists";
            this.comboBoxExists.Size = new System.Drawing.Size(167, 24);
            this.comboBoxExists.TabIndex = 4;
            this.comboBoxExists.Visible = false;
            // 
            // buttonGoThroughTheDoor
            // 
            this.buttonGoThroughTheDoor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGoThroughTheDoor.Location = new System.Drawing.Point(12, 204);
            this.buttonGoThroughTheDoor.Name = "buttonGoThroughTheDoor";
            this.buttonGoThroughTheDoor.Size = new System.Drawing.Size(258, 23);
            this.buttonGoThroughTheDoor.TabIndex = 5;
            this.buttonGoThroughTheDoor.Text = "Go through the door";
            this.buttonGoThroughTheDoor.UseVisualStyleBackColor = true;
            this.buttonGoThroughTheDoor.Visible = false;
            this.buttonGoThroughTheDoor.Click += new System.EventHandler(this.buttonGoThroughTheDoor_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCheck.Location = new System.Drawing.Point(13, 234);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(256, 23);
            this.buttonCheck.TabIndex = 6;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Visible = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonHide
            // 
            this.buttonHide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHide.Location = new System.Drawing.Point(13, 264);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(256, 23);
            this.buttonHide.TabIndex = 7;
            this.buttonHide.Text = "Hide!";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 295);
            this.Controls.Add(this.buttonHide);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonGoThroughTheDoor);
            this.Controls.Add(this.comboBoxExists);
            this.Controls.Add(this.buttonGoHere);
            this.Controls.Add(this.textBoxDescription);
            this.Name = "GameForm";
            this.Text = "Hide and seek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonGoHere;
        private System.Windows.Forms.ComboBox comboBoxExists;
        private System.Windows.Forms.Button buttonGoThroughTheDoor;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonHide;
    }
}

