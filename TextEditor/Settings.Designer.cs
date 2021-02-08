
namespace TextEditor
{
    partial class MySettings
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
            this.compilerPathLabel = new System.Windows.Forms.Label();
            this.logginingTimerComboBox = new System.Windows.Forms.ComboBox();
            this.autoSaveTimerComboBox = new System.Windows.Forms.ComboBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.compilerLabel = new System.Windows.Forms.Label();
            this.logginingTimerLabel = new System.Windows.Forms.Label();
            this.formNameLabel = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.themeComboBox = new System.Windows.Forms.ComboBox();
            this.autoSaveLabel = new System.Windows.Forms.Label();
            this.themeLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.formPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.formPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.formPanel.Controls.Add(this.compilerPathLabel);
            this.formPanel.Controls.Add(this.logginingTimerComboBox);
            this.formPanel.Controls.Add(this.autoSaveTimerComboBox);
            this.formPanel.Controls.Add(this.browseButton);
            this.formPanel.Controls.Add(this.compilerLabel);
            this.formPanel.Controls.Add(this.logginingTimerLabel);
            this.formPanel.Controls.Add(this.formNameLabel);
            this.formPanel.Controls.Add(this.applyButton);
            this.formPanel.Controls.Add(this.cancelButton);
            this.formPanel.Controls.Add(this.themeComboBox);
            this.formPanel.Controls.Add(this.autoSaveLabel);
            this.formPanel.Controls.Add(this.themeLabel);
            this.formPanel.Controls.Add(this.exitButton);
            this.formPanel.Location = new System.Drawing.Point(0, 0);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(620, 300);
            this.formPanel.TabIndex = 0;
            this.formPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPanel_MouseDown);
            this.formPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormPanel_MouseMove);
            // 
            // compilerPathLabel
            // 
            this.compilerPathLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.compilerPathLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.compilerPathLabel.Location = new System.Drawing.Point(189, 200);
            this.compilerPathLabel.Name = "compilerPathLabel";
            this.compilerPathLabel.Size = new System.Drawing.Size(376, 27);
            this.compilerPathLabel.TabIndex = 18;
            this.compilerPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logginingTimerComboBox
            // 
            this.logginingTimerComboBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.logginingTimerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.logginingTimerComboBox.FormattingEnabled = true;
            this.logginingTimerComboBox.Items.AddRange(new object[] {
            "0 mins",
            "1 min",
            "5 mins",
            "10 mins",
            "15 mins",
            "30 mins"});
            this.logginingTimerComboBox.Location = new System.Drawing.Point(189, 150);
            this.logginingTimerComboBox.Name = "logginingTimerComboBox";
            this.logginingTimerComboBox.Size = new System.Drawing.Size(151, 28);
            this.logginingTimerComboBox.TabIndex = 17;
            this.logginingTimerComboBox.TextChanged += new System.EventHandler(this.LogginingTimerComboBox_TextChanged);
            // 
            // autoSaveTimerComboBox
            // 
            this.autoSaveTimerComboBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.autoSaveTimerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.autoSaveTimerComboBox.FormattingEnabled = true;
            this.autoSaveTimerComboBox.Items.AddRange(new object[] {
            "0 mins",
            "1 min",
            "5 mins",
            "10 mins",
            "15 mins",
            "30 mins"});
            this.autoSaveTimerComboBox.Location = new System.Drawing.Point(189, 100);
            this.autoSaveTimerComboBox.Name = "autoSaveTimerComboBox";
            this.autoSaveTimerComboBox.Size = new System.Drawing.Size(151, 28);
            this.autoSaveTimerComboBox.TabIndex = 16;
            this.autoSaveTimerComboBox.TextChanged += new System.EventHandler(this.AutoSaveTimerComboBox_TextChanged);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(571, 200);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(27, 27);
            this.browseButton.TabIndex = 15;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // compilerLabel
            // 
            this.compilerLabel.Location = new System.Drawing.Point(10, 200);
            this.compilerLabel.Name = "compilerLabel";
            this.compilerLabel.Size = new System.Drawing.Size(113, 20);
            this.compilerLabel.TabIndex = 13;
            this.compilerLabel.Text = "Compiler:";
            // 
            // logginingTimerLabel
            // 
            this.logginingTimerLabel.Location = new System.Drawing.Point(10, 150);
            this.logginingTimerLabel.Name = "logginingTimerLabel";
            this.logginingTimerLabel.Size = new System.Drawing.Size(131, 25);
            this.logginingTimerLabel.TabIndex = 9;
            this.logginingTimerLabel.Text = "Do logging every:";
            // 
            // formNameLabel
            // 
            this.formNameLabel.BackColor = System.Drawing.Color.White;
            this.formNameLabel.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formNameLabel.Location = new System.Drawing.Point(0, 0);
            this.formNameLabel.Name = "formNameLabel";
            this.formNameLabel.Size = new System.Drawing.Size(586, 34);
            this.formNameLabel.TabIndex = 8;
            this.formNameLabel.Text = " Settings";
            this.formNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.formNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPanel_MouseDown);
            this.formNameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormPanel_MouseMove);
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.applyButton.Location = new System.Drawing.Point(408, 256);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(94, 29);
            this.applyButton.TabIndex = 7;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(513, 256);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 29);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // themeComboBox
            // 
            this.themeComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Светлая тема",
            "Тёмная тема"});
            this.themeComboBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.themeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.themeComboBox.FormattingEnabled = true;
            this.themeComboBox.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.themeComboBox.Location = new System.Drawing.Point(189, 50);
            this.themeComboBox.Name = "themeComboBox";
            this.themeComboBox.Size = new System.Drawing.Size(151, 28);
            this.themeComboBox.TabIndex = 4;
            this.themeComboBox.SelectedValueChanged += new System.EventHandler(this.ThemeComboBox_SelectedValueChanged);
            // 
            // autoSaveLabel
            // 
            this.autoSaveLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoSaveLabel.Location = new System.Drawing.Point(12, 100);
            this.autoSaveLabel.Name = "autoSaveLabel";
            this.autoSaveLabel.Size = new System.Drawing.Size(132, 34);
            this.autoSaveLabel.TabIndex = 3;
            this.autoSaveLabel.Text = "AutoSave every:";
            // 
            // themeLabel
            // 
            this.themeLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.themeLabel.Location = new System.Drawing.Point(12, 50);
            this.themeLabel.Name = "themeLabel";
            this.themeLabel.Size = new System.Drawing.Size(107, 34);
            this.themeLabel.TabIndex = 2;
            this.themeLabel.Text = "Color Theme:";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(112)))), ((int)(((byte)(123)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitButton.Location = new System.Drawing.Point(586, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(34, 34);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "🗙︎";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(620, 300);
            this.Controls.Add(this.formPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MySettings";
            this.Text = "Settings";
            this.formPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label themeLabel;
        private System.Windows.Forms.Label autoSaveLabel;
        private System.Windows.Forms.ComboBox themeComboBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label formNameLabel;
        private System.Windows.Forms.Label logginingTimerLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label compilerLabel;
        private System.Windows.Forms.ComboBox logginingTimerComboBox;
        private System.Windows.Forms.ComboBox autoSaveTimerComboBox;
        private System.Windows.Forms.Label compilerPathLabel;
    }
}