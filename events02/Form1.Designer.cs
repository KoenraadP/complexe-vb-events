namespace events02
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
            this.cbxLanguages = new System.Windows.Forms.ComboBox();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.pbxFlag = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxLanguages
            // 
            this.cbxLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLanguages.FormattingEnabled = true;
            this.cbxLanguages.Items.AddRange(new object[] {
            "Nederlands",
            "Français",
            "English",
            "Deutsch"});
            this.cbxLanguages.Location = new System.Drawing.Point(13, 13);
            this.cbxLanguages.Name = "cbxLanguages";
            this.cbxLanguages.Size = new System.Drawing.Size(243, 21);
            this.cbxLanguages.TabIndex = 0;
            this.cbxLanguages.SelectedIndexChanged += new System.EventHandler(this.CbxLanguages_SelectedIndexChanged);
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Location = new System.Drawing.Point(15, 42);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(77, 13);
            this.lblGreeting.TabIndex = 1;
            this.lblGreeting.Text = "Goedemorgen!";
            // 
            // pbxFlag
            // 
            this.pbxFlag.Image = global::events02.Properties.Resources.Flag_NL;
            this.pbxFlag.Location = new System.Drawing.Point(16, 69);
            this.pbxFlag.Name = "pbxFlag";
            this.pbxFlag.Size = new System.Drawing.Size(240, 124);
            this.pbxFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFlag.TabIndex = 2;
            this.pbxFlag.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 205);
            this.Controls.Add(this.pbxFlag);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.cbxLanguages);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxLanguages;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.PictureBox pbxFlag;
    }
}

