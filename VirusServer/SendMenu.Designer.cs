namespace VirusServer
{
    partial class SendMenu
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
            this.SendButton = new System.Windows.Forms.Button();
            this.FirstParametrLabel = new System.Windows.Forms.Label();
            this.SecondParametrLabel = new System.Windows.Forms.Label();
            this.FirstParametrTextBox = new System.Windows.Forms.TextBox();
            this.SecondParametrTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(233, 279);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(285, 122);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            // 
            // FirstParametrLabel
            // 
            this.FirstParametrLabel.AutoSize = true;
            this.FirstParametrLabel.Location = new System.Drawing.Point(131, 122);
            this.FirstParametrLabel.Name = "FirstParametrLabel";
            this.FirstParametrLabel.Size = new System.Drawing.Size(68, 13);
            this.FirstParametrLabel.TabIndex = 1;
            this.FirstParametrLabel.Text = "FirstParametr";
            this.FirstParametrLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SecondParametrLabel
            // 
            this.SecondParametrLabel.AutoSize = true;
            this.SecondParametrLabel.Location = new System.Drawing.Point(131, 222);
            this.SecondParametrLabel.Name = "SecondParametrLabel";
            this.SecondParametrLabel.Size = new System.Drawing.Size(86, 13);
            this.SecondParametrLabel.TabIndex = 2;
            this.SecondParametrLabel.Text = "SecondParametr";
            // 
            // FirstParametrTextBox
            // 
            this.FirstParametrTextBox.Location = new System.Drawing.Point(253, 122);
            this.FirstParametrTextBox.Name = "FirstParametrTextBox";
            this.FirstParametrTextBox.Size = new System.Drawing.Size(235, 20);
            this.FirstParametrTextBox.TabIndex = 3;
            // 
            // SecondParametrTextBox
            // 
            this.SecondParametrTextBox.Location = new System.Drawing.Point(253, 219);
            this.SecondParametrTextBox.Name = "SecondParametrTextBox";
            this.SecondParametrTextBox.Size = new System.Drawing.Size(235, 20);
            this.SecondParametrTextBox.TabIndex = 4;
            // 
            // SendMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SecondParametrTextBox);
            this.Controls.Add(this.FirstParametrTextBox);
            this.Controls.Add(this.SecondParametrLabel);
            this.Controls.Add(this.FirstParametrLabel);
            this.Controls.Add(this.SendButton);
            this.Name = "SendMenu";
            this.Text = "SendMenu";
            this.Load += new System.EventHandler(this.SendMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label FirstParametrLabel;
        private System.Windows.Forms.Label SecondParametrLabel;
        private System.Windows.Forms.TextBox FirstParametrTextBox;
        private System.Windows.Forms.TextBox SecondParametrTextBox;
    }
}