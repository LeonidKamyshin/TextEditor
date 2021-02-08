
namespace TextEditor
{
    partial class BackUp
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
            this.formPanel = new System.Windows.Forms.Panel();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.versionsComboBox = new System.Windows.Forms.ComboBox();
            this.backUpLabel = new System.Windows.Forms.Label();
            this.formNameLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.formPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.formPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.formPanel.Controls.Add(this.applyButton);
            this.formPanel.Controls.Add(this.cancelButton);
            this.formPanel.Controls.Add(this.versionsComboBox);
            this.formPanel.Controls.Add(this.backUpLabel);
            this.formPanel.Controls.Add(this.formNameLabel);
            this.formPanel.Controls.Add(this.exitButton);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.Location = new System.Drawing.Point(0, 0);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(800, 450);
            this.formPanel.TabIndex = 1;
            this.formPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPanel_MouseDown);
            this.formPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormPanel_MouseMove);
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.applyButton.Location = new System.Drawing.Point(587, 407);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(94, 29);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(692, 407);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 29);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // versionsComboBox
            // 
            this.versionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.versionsComboBox.FormattingEnabled = true;
            this.versionsComboBox.Location = new System.Drawing.Point(184, 54);
            this.versionsComboBox.Name = "versionsComboBox";
            this.versionsComboBox.Size = new System.Drawing.Size(543, 28);
            this.versionsComboBox.TabIndex = 3;
            // 
            // backUpLabel
            // 
            this.backUpLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backUpLabel.Location = new System.Drawing.Point(10, 54);
            this.backUpLabel.Name = "backUpLabel";
            this.backUpLabel.Size = new System.Drawing.Size(128, 28);
            this.backUpLabel.TabIndex = 2;
            this.backUpLabel.Text = "Choose version:";
            // 
            // formNameLabel
            // 
            this.formNameLabel.BackColor = System.Drawing.Color.White;
            this.formNameLabel.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formNameLabel.Location = new System.Drawing.Point(0, 0);
            this.formNameLabel.Name = "formNameLabel";
            this.formNameLabel.Size = new System.Drawing.Size(766, 34);
            this.formNameLabel.TabIndex = 1;
            this.formNameLabel.Text = " BackUp options";
            this.formNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.formNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPanel_MouseDown);
            this.formNameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormPanel_MouseMove);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(766, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(34, 34);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "🗙︎";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BackUp";
            this.formPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label formNameLabel;
        private System.Windows.Forms.Label backUpLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox versionsComboBox;
        private System.Windows.Forms.Button applyButton;
    }
}