namespace installer
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
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fullPathLabel = new System.Windows.Forms.Label();
            this.installDirectoryLabel = new System.Windows.Forms.Label();
            this.installingLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.Location = new System.Drawing.Point(324, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 28);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.nextButton);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 28);
            this.panel1.TabIndex = 1;
            // 
            // nextButton
            // 
            this.nextButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.nextButton.Location = new System.Drawing.Point(249, 0);
            this.nextButton.Margin = new System.Windows.Forms.Padding(3, 3, 120, 3);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 28);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Install";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Install Directory";
            // 
            // chooseButton
            // 
            this.chooseButton.Location = new System.Drawing.Point(114, 4);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(75, 23);
            this.chooseButton.TabIndex = 4;
            this.chooseButton.Text = "Choose...";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.chooseButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Full Path:";
            // 
            // fullPathLabel
            // 
            this.fullPathLabel.AutoSize = true;
            this.fullPathLabel.BackColor = System.Drawing.Color.Transparent;
            this.fullPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullPathLabel.Location = new System.Drawing.Point(12, 113);
            this.fullPathLabel.Name = "fullPathLabel";
            this.fullPathLabel.Size = new System.Drawing.Size(46, 18);
            this.fullPathLabel.TabIndex = 6;
            this.fullPathLabel.Text = "label3";
            // 
            // installDirectoryLabel
            // 
            this.installDirectoryLabel.AutoSize = true;
            this.installDirectoryLabel.Location = new System.Drawing.Point(12, 39);
            this.installDirectoryLabel.Name = "installDirectoryLabel";
            this.installDirectoryLabel.Size = new System.Drawing.Size(35, 13);
            this.installDirectoryLabel.TabIndex = 7;
            this.installDirectoryLabel.Text = "label3";
            // 
            // installingLabel
            // 
            this.installingLabel.AutoSize = true;
            this.installingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installingLabel.Location = new System.Drawing.Point(12, 203);
            this.installingLabel.Name = "installingLabel";
            this.installingLabel.Size = new System.Drawing.Size(126, 29);
            this.installingLabel.TabIndex = 8;
            this.installingLabel.Text = "Installing...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 368);
            this.Controls.Add(this.installingLabel);
            this.Controls.Add(this.installDirectoryLabel);
            this.Controls.Add(this.fullPathLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chooseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Toggl Windows App Installer";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fullPathLabel;
        private System.Windows.Forms.Label installDirectoryLabel;
        private System.Windows.Forms.Label installingLabel;
    }
}

