
namespace TextEditor
{
    partial class TextEditorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textEditorPanel = new System.Windows.Forms.Panel();
            this.textEditorRichTextBox = new System.Windows.Forms.RichTextBox();
            this.richTextBoxContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontStylePanel = new System.Windows.Forms.Panel();
            this.redoButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.buildButton = new System.Windows.Forms.Button();
            this.strikeoutButton = new System.Windows.Forms.Button();
            this.underscoreButton = new System.Windows.Forms.Button();
            this.italicButton = new System.Windows.Forms.Button();
            this.boldButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.restoreButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.filesTabControl = new System.Windows.Forms.TabControl();
            this.textEditorMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeCurrentTabMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatCodeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSaveTimer = new System.Windows.Forms.Timer(this.components);
            this.loggingTimer = new System.Windows.Forms.Timer(this.components);
            this.textEditorPanel.SuspendLayout();
            this.richTextBoxContextMenuStrip.SuspendLayout();
            this.fontStylePanel.SuspendLayout();
            this.textEditorMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textEditorPanel
            // 
            this.textEditorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.textEditorPanel.Controls.Add(this.textEditorRichTextBox);
            this.textEditorPanel.Controls.Add(this.fontStylePanel);
            this.textEditorPanel.Controls.Add(this.minimizeButton);
            this.textEditorPanel.Controls.Add(this.restoreButton);
            this.textEditorPanel.Controls.Add(this.exitButton);
            this.textEditorPanel.Controls.Add(this.filesTabControl);
            this.textEditorPanel.Controls.Add(this.textEditorMenuStrip);
            this.textEditorPanel.Location = new System.Drawing.Point(0, 0);
            this.textEditorPanel.Margin = new System.Windows.Forms.Padding(2);
            this.textEditorPanel.Name = "textEditorPanel";
            this.textEditorPanel.Size = new System.Drawing.Size(969, 677);
            this.textEditorPanel.TabIndex = 0;
            this.textEditorPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextEditorPanel_MouseDown);
            this.textEditorPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TextEditorPanel_MouseMove);
            // 
            // textEditorRichTextBox
            // 
            this.textEditorRichTextBox.AcceptsTab = true;
            this.textEditorRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditorRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textEditorRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEditorRichTextBox.ContextMenuStrip = this.richTextBoxContextMenuStrip;
            this.textEditorRichTextBox.Location = new System.Drawing.Point(7, 93);
            this.textEditorRichTextBox.Name = "textEditorRichTextBox";
            this.textEditorRichTextBox.Size = new System.Drawing.Size(955, 577);
            this.textEditorRichTextBox.TabIndex = 9;
            this.textEditorRichTextBox.Text = "";
            this.textEditorRichTextBox.WordWrap = false;
            // 
            // richTextBoxContextMenuStrip
            // 
            this.richTextBoxContextMenuStrip.BackColor = System.Drawing.SystemColors.ControlText;
            this.richTextBoxContextMenuStrip.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.richTextBoxContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllContextMenuItem,
            this.cutContextMenuItem,
            this.copyContextMenuItem,
            this.pasteContextMenuItem});
            this.richTextBoxContextMenuStrip.Name = "contextMenuStrip1";
            this.richTextBoxContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.richTextBoxContextMenuStrip.Size = new System.Drawing.Size(193, 100);
            // 
            // selectAllContextMenuItem
            // 
            this.selectAllContextMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.selectAllContextMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.selectAllContextMenuItem.Name = "selectAllContextMenuItem";
            this.selectAllContextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllContextMenuItem.Size = new System.Drawing.Size(192, 24);
            this.selectAllContextMenuItem.Text = "Select All";
            this.selectAllContextMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.selectAllContextMenuItem.Click += new System.EventHandler(this.SelectAllItem_Click);
            // 
            // cutContextMenuItem
            // 
            this.cutContextMenuItem.Name = "cutContextMenuItem";
            this.cutContextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutContextMenuItem.Size = new System.Drawing.Size(192, 24);
            this.cutContextMenuItem.Text = "Cut";
            this.cutContextMenuItem.Click += new System.EventHandler(this.CutMenuItem_Click);
            // 
            // copyContextMenuItem
            // 
            this.copyContextMenuItem.Name = "copyContextMenuItem";
            this.copyContextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyContextMenuItem.Size = new System.Drawing.Size(192, 24);
            this.copyContextMenuItem.Text = "Copy";
            this.copyContextMenuItem.Click += new System.EventHandler(this.CopyMenuItem_Click);
            // 
            // pasteContextMenuItem
            // 
            this.pasteContextMenuItem.Name = "pasteContextMenuItem";
            this.pasteContextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteContextMenuItem.Size = new System.Drawing.Size(192, 24);
            this.pasteContextMenuItem.Text = "Paste";
            this.pasteContextMenuItem.Click += new System.EventHandler(this.PasteMenuItem_Click);
            // 
            // fontStylePanel
            // 
            this.fontStylePanel.Controls.Add(this.redoButton);
            this.fontStylePanel.Controls.Add(this.undoButton);
            this.fontStylePanel.Controls.Add(this.buildButton);
            this.fontStylePanel.Controls.Add(this.strikeoutButton);
            this.fontStylePanel.Controls.Add(this.underscoreButton);
            this.fontStylePanel.Controls.Add(this.italicButton);
            this.fontStylePanel.Controls.Add(this.boldButton);
            this.fontStylePanel.Location = new System.Drawing.Point(7, 31);
            this.fontStylePanel.Name = "fontStylePanel";
            this.fontStylePanel.Size = new System.Drawing.Size(302, 30);
            this.fontStylePanel.TabIndex = 8;
            // 
            // redoButton
            // 
            this.redoButton.FlatAppearance.BorderSize = 0;
            this.redoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redoButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.redoButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.redoButton.Location = new System.Drawing.Point(157, 0);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(30, 30);
            this.redoButton.TabIndex = 6;
            this.redoButton.Text = "⮎";
            this.redoButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.redoButton.UseCompatibleTextRendering = true;
            this.redoButton.UseVisualStyleBackColor = true;
            this.redoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.FlatAppearance.BorderSize = 0;
            this.undoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undoButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.undoButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.undoButton.Location = new System.Drawing.Point(127, 0);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(30, 30);
            this.undoButton.TabIndex = 5;
            this.undoButton.Text = "⮌";
            this.undoButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.undoButton.UseCompatibleTextRendering = true;
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // buildButton
            // 
            this.buildButton.FlatAppearance.BorderSize = 0;
            this.buildButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buildButton.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buildButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buildButton.Location = new System.Drawing.Point(187, 0);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(30, 30);
            this.buildButton.TabIndex = 4;
            this.buildButton.TabStop = false;
            this.buildButton.Text = "⚙";
            this.buildButton.UseVisualStyleBackColor = false;
            this.buildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // strikeoutButton
            // 
            this.strikeoutButton.FlatAppearance.BorderSize = 0;
            this.strikeoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.strikeoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.strikeoutButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.strikeoutButton.ForeColor = System.Drawing.SystemColors.Control;
            this.strikeoutButton.Location = new System.Drawing.Point(97, 0);
            this.strikeoutButton.Name = "strikeoutButton";
            this.strikeoutButton.Size = new System.Drawing.Size(30, 30);
            this.strikeoutButton.TabIndex = 3;
            this.strikeoutButton.TabStop = false;
            this.strikeoutButton.Text = "b";
            this.strikeoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.strikeoutButton.UseCompatibleTextRendering = true;
            this.strikeoutButton.UseVisualStyleBackColor = true;
            this.strikeoutButton.Click += new System.EventHandler(this.StrikeoutButton_Click);
            // 
            // underscoreButton
            // 
            this.underscoreButton.FlatAppearance.BorderSize = 0;
            this.underscoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.underscoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.underscoreButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.underscoreButton.ForeColor = System.Drawing.SystemColors.Control;
            this.underscoreButton.Location = new System.Drawing.Point(67, 0);
            this.underscoreButton.Name = "underscoreButton";
            this.underscoreButton.Size = new System.Drawing.Size(30, 30);
            this.underscoreButton.TabIndex = 2;
            this.underscoreButton.TabStop = false;
            this.underscoreButton.Text = "U";
            this.underscoreButton.UseCompatibleTextRendering = true;
            this.underscoreButton.UseVisualStyleBackColor = false;
            this.underscoreButton.Click += new System.EventHandler(this.UnderscoreButton_Click);
            // 
            // italicButton
            // 
            this.italicButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.italicButton.FlatAppearance.BorderSize = 0;
            this.italicButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.italicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.italicButton.Font = new System.Drawing.Font("Lucida Calligraphy", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.italicButton.ForeColor = System.Drawing.SystemColors.Control;
            this.italicButton.Location = new System.Drawing.Point(7, 0);
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(30, 30);
            this.italicButton.TabIndex = 1;
            this.italicButton.TabStop = false;
            this.italicButton.Text = "I";
            this.italicButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.italicButton.UseCompatibleTextRendering = true;
            this.italicButton.UseVisualStyleBackColor = false;
            this.italicButton.Click += new System.EventHandler(this.ItalicButton_Click);
            // 
            // boldButton
            // 
            this.boldButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.boldButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.boldButton.FlatAppearance.BorderSize = 0;
            this.boldButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.boldButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boldButton.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boldButton.ForeColor = System.Drawing.SystemColors.Control;
            this.boldButton.Location = new System.Drawing.Point(37, 0);
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(30, 30);
            this.boldButton.TabIndex = 0;
            this.boldButton.TabStop = false;
            this.boldButton.Text = "B";
            this.boldButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.boldButton.UseCompatibleTextRendering = true;
            this.boldButton.UseVisualStyleBackColor = false;
            this.boldButton.Click += new System.EventHandler(this.BoldButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.minimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(205)))));
            this.minimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.minimizeButton.Location = new System.Drawing.Point(867, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(34, 34);
            this.minimizeButton.TabIndex = 7;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Text = "🗕︎";
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MinimizeButton_MouseClick);
            // 
            // restoreButton
            // 
            this.restoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.restoreButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.restoreButton.FlatAppearance.BorderSize = 0;
            this.restoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(205)))));
            this.restoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.restoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.restoreButton.Location = new System.Drawing.Point(901, 0);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(34, 34);
            this.restoreButton.TabIndex = 6;
            this.restoreButton.TabStop = false;
            this.restoreButton.Text = "🗗";
            this.restoreButton.UseVisualStyleBackColor = false;
            this.restoreButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RestoreButton_MouseClick);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(205)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.exitButton.Location = new System.Drawing.Point(935, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(34, 34);
            this.exitButton.TabIndex = 5;
            this.exitButton.TabStop = false;
            this.exitButton.Text = "🗙︎";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ExitButton_MouseClick);
            // 
            // filesTabControl
            // 
            this.filesTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesTabControl.Location = new System.Drawing.Point(7, 60);
            this.filesTabControl.Name = "filesTabControl";
            this.filesTabControl.SelectedIndex = 0;
            this.filesTabControl.Size = new System.Drawing.Size(955, 27);
            this.filesTabControl.TabIndex = 2;
            this.filesTabControl.TabStop = false;
            this.filesTabControl.SelectedIndexChanged += new System.EventHandler(this.FilesTabControl_SelectedIndexChanged);
            // 
            // textEditorMenuStrip
            // 
            this.textEditorMenuStrip.AutoSize = false;
            this.textEditorMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.textEditorMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.textEditorMenuStrip.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textEditorMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.textEditorMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.viewMenuItem,
            this.settingsMenuItem});
            this.textEditorMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.textEditorMenuStrip.Name = "textEditorMenuStrip";
            this.textEditorMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.textEditorMenuStrip.Size = new System.Drawing.Size(323, 28);
            this.textEditorMenuStrip.TabIndex = 4;
            this.textEditorMenuStrip.Text = "menuStrip2";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileMenuItem,
            this.openFileMenuItem,
            this.saveFileMenuItem,
            this.saveAsMenuItem,
            this.saveAllMenuItem,
            this.closeCurrentTabMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fileMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(59, 24);
            this.fileMenuItem.Text = "File";
            // 
            // newFileMenuItem
            // 
            this.newFileMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.newFileMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newFileMenuItem.Name = "newFileMenuItem";
            this.newFileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFileMenuItem.Size = new System.Drawing.Size(308, 26);
            this.newFileMenuItem.Text = "New";
            this.newFileMenuItem.Click += new System.EventHandler(this.NewFileMenuItem_Click);
            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.openFileMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.openFileMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.openFileMenuItem.Name = "openFileMenuItem";
            this.openFileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileMenuItem.Size = new System.Drawing.Size(308, 26);
            this.openFileMenuItem.Text = "Open";
            this.openFileMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openFileMenuItem.Click += new System.EventHandler(this.OpenFileMenuItem_Click);
            // 
            // saveFileMenuItem
            // 
            this.saveFileMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.saveFileMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveFileMenuItem.Name = "saveFileMenuItem";
            this.saveFileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileMenuItem.Size = new System.Drawing.Size(308, 26);
            this.saveFileMenuItem.Text = "Save";
            this.saveFileMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveFileMenuItem.Click += new System.EventHandler(this.SaveFileMenuItem_Click);
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.saveAsMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.Size = new System.Drawing.Size(308, 26);
            this.saveAsMenuItem.Text = "Save As";
            this.saveAsMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveAsMenuItem.Click += new System.EventHandler(this.SaveAsMenuItem_Click);
            // 
            // saveAllMenuItem
            // 
            this.saveAllMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.saveAllMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveAllMenuItem.Name = "saveAllMenuItem";
            this.saveAllMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAllMenuItem.Size = new System.Drawing.Size(308, 26);
            this.saveAllMenuItem.Text = "Save all";
            this.saveAllMenuItem.Click += new System.EventHandler(this.SaveAllMenuItem_Click);
            // 
            // closeCurrentTabMenuItem
            // 
            this.closeCurrentTabMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.closeCurrentTabMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeCurrentTabMenuItem.Name = "closeCurrentTabMenuItem";
            this.closeCurrentTabMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeCurrentTabMenuItem.Size = new System.Drawing.Size(308, 26);
            this.closeCurrentTabMenuItem.Text = "Close current tab";
            this.closeCurrentTabMenuItem.Click += new System.EventHandler(this.CloseCurrentTabMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.exitMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitMenuItem.Size = new System.Drawing.Size(308, 26);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllMenuItem,
            this.cutMenuItem,
            this.copyMenuItem,
            this.pasteMenuItem,
            this.undoMenuItem,
            this.redoMenuItem});
            this.editMenuItem.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(59, 24);
            this.editMenuItem.Text = "Edit";
            // 
            // selectAllMenuItem
            // 
            this.selectAllMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.selectAllMenuItem.Name = "selectAllMenuItem";
            this.selectAllMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllMenuItem.Size = new System.Drawing.Size(245, 26);
            this.selectAllMenuItem.Text = "Select All";
            this.selectAllMenuItem.Click += new System.EventHandler(this.SelectAllItem_Click);
            // 
            // cutMenuItem
            // 
            this.cutMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.cutMenuItem.Name = "cutMenuItem";
            this.cutMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutMenuItem.Size = new System.Drawing.Size(245, 26);
            this.cutMenuItem.Text = "Cut";
            this.cutMenuItem.Click += new System.EventHandler(this.CutMenuItem_Click);
            // 
            // copyMenuItem
            // 
            this.copyMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.copyMenuItem.Name = "copyMenuItem";
            this.copyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyMenuItem.Size = new System.Drawing.Size(245, 26);
            this.copyMenuItem.Text = "Copy";
            this.copyMenuItem.Click += new System.EventHandler(this.CopyMenuItem_Click);
            // 
            // pasteMenuItem
            // 
            this.pasteMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.pasteMenuItem.Name = "pasteMenuItem";
            this.pasteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteMenuItem.Size = new System.Drawing.Size(245, 26);
            this.pasteMenuItem.Text = "Paste";
            this.pasteMenuItem.Click += new System.EventHandler(this.PasteMenuItem_Click);
            // 
            // undoMenuItem
            // 
            this.undoMenuItem.Name = "undoMenuItem";
            this.undoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoMenuItem.Size = new System.Drawing.Size(245, 26);
            this.undoMenuItem.Text = "Undo";
            this.undoMenuItem.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // redoMenuItem
            // 
            this.redoMenuItem.Name = "redoMenuItem";
            this.redoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.redoMenuItem.Size = new System.Drawing.Size(245, 26);
            this.redoMenuItem.Text = "Redo";
            this.redoMenuItem.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatCodeMenuItem,
            this.backUpMenuItem,
            this.fontMenuItem});
            this.viewMenuItem.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Size = new System.Drawing.Size(59, 24);
            this.viewMenuItem.Text = "View";
            // 
            // formatCodeMenuItem
            // 
            this.formatCodeMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.formatCodeMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.formatCodeMenuItem.Name = "formatCodeMenuItem";
            this.formatCodeMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.formatCodeMenuItem.Size = new System.Drawing.Size(263, 26);
            this.formatCodeMenuItem.Text = "Format code";
            this.formatCodeMenuItem.Click += new System.EventHandler(this.FormatCodeMenuItem_Click);
            // 
            // backUpMenuItem
            // 
            this.backUpMenuItem.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backUpMenuItem.Name = "backUpMenuItem";
            this.backUpMenuItem.Size = new System.Drawing.Size(263, 26);
            this.backUpMenuItem.Text = "Choose file version";
            this.backUpMenuItem.Click += new System.EventHandler(this.BackUpMenuItem_Click);
            // 
            // fontMenuItem
            // 
            this.fontMenuItem.Name = "fontMenuItem";
            this.fontMenuItem.Size = new System.Drawing.Size(263, 26);
            this.fontMenuItem.Text = "Change font";
            this.fontMenuItem.Click += new System.EventHandler(this.FontMenuItem_Click);
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingsMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(95, 24);
            this.settingsMenuItem.Text = "Settings";
            this.settingsMenuItem.Click += new System.EventHandler(this.SettingsMenuItem_Click);
            // 
            // autoSaveTimer
            // 
            this.autoSaveTimer.Enabled = true;
            this.autoSaveTimer.Interval = 1000000;
            this.autoSaveTimer.Tick += new System.EventHandler(this.AutoSaveTimer_Tick);
            // 
            // loggingTimer
            // 
            this.loggingTimer.Interval = 100000;
            this.loggingTimer.Tick += new System.EventHandler(this.LoggingTimer_Tick);
            // 
            // TextEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(969, 677);
            this.Controls.Add(this.textEditorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TextEditorForm";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextEditor_FormClosing);
            this.textEditorPanel.ResumeLayout(false);
            this.richTextBoxContextMenuStrip.ResumeLayout(false);
            this.fontStylePanel.ResumeLayout(false);
            this.textEditorMenuStrip.ResumeLayout(false);
            this.textEditorMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel textEditorPanel;
        private System.Windows.Forms.TabControl filesTabControl;
        private System.Windows.Forms.MenuStrip textEditorMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Format;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem Settings;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripSaveAs;
        private System.Windows.Forms.ToolStripMenuItem toolStripExit;
        private System.Windows.Forms.Timer autoSaveTimer;
        private System.Windows.Forms.ToolStripMenuItem NewFile;
        private System.Windows.Forms.ToolStripMenuItem CloseCurrentTab;
        private System.Windows.Forms.ToolStripMenuItem SaveAll;
        private System.Windows.Forms.ToolStripMenuItem newFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeCurrentTabMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ContextMenuStrip richTextBoxContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem selectAllContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteMenuItem;
        private System.Windows.Forms.Panel fontStylePanel;
        private System.Windows.Forms.Button boldButton;
        private System.Windows.Forms.Button italicButton;
        private System.Windows.Forms.Button strikeoutButton;
        private System.Windows.Forms.Button underscoreButton;
        private System.Windows.Forms.Timer loggingTimer;
        private System.Windows.Forms.RichTextBox textEditorRichTextBox;
        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.ToolStripMenuItem formatCodeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenuItem;
        private System.Windows.Forms.Button redoButton;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.ToolStripMenuItem backUpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontMenuItem;
    }
}

