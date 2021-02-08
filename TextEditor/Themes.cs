using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TextEditor
{
    partial class TextEditorForm
    {
        // Lists of all controls on form.
        List<RichTextBox> richTextBoxes = new List<RichTextBox>();
        List<ToolStripMenuItem> outerToolStripMenuItems = new List<ToolStripMenuItem>();
        List<ToolStripMenuItem> innerToolStripMenuItems = new List<ToolStripMenuItem>();
        List<Button> outerButtons = new List<Button>();
        List<Button> innerButtons = new List<Button>();
        List<ContextMenuStrip> contextMenuStrips = new List<ContextMenuStrip>();
        List<Panel> panels = new List<Panel>();
        List<MenuStrip> menuStrips = new List<MenuStrip>();

        /// <summary>
        /// Sets chosen theme.
        /// </summary>
        /// <param name="name"> Theme name. </param>
        public void SetTheme(string name)
        {
            switch (name)
            {
                case "Light":
                    SetLightTheme();
                    return;
                case "Dark":
                    SetDarkTheme();
                    return;
                default:
                    SetLightTheme();
                    return;
            }
        }

        /// <summary>
        /// Adding all form controls to lists.
        /// </summary>
        private void InitializeThemeElements()
        {
            richTextBoxes.Add(textEditorRichTextBox);

            outerToolStripMenuItems.Add(fileMenuItem);
            outerToolStripMenuItems.Add(viewMenuItem);
            outerToolStripMenuItems.Add(editMenuItem);
            outerToolStripMenuItems.Add(settingsMenuItem);
            outerToolStripMenuItems.Add(newFileMenuItem);
            outerToolStripMenuItems.Add(openFileMenuItem);
            outerToolStripMenuItems.Add(saveFileMenuItem);
            outerToolStripMenuItems.Add(saveAsMenuItem);
            outerToolStripMenuItems.Add(saveAllMenuItem);
            outerToolStripMenuItems.Add(closeCurrentTabMenuItem);
            outerToolStripMenuItems.Add(exitMenuItem);
            outerToolStripMenuItems.Add(selectAllMenuItem);
            outerToolStripMenuItems.Add(cutMenuItem);
            outerToolStripMenuItems.Add(copyMenuItem);
            outerToolStripMenuItems.Add(pasteMenuItem);
            outerToolStripMenuItems.Add(formatCodeMenuItem);
            outerToolStripMenuItems.Add(backUpMenuItem);
            outerToolStripMenuItems.Add(undoMenuItem);
            outerToolStripMenuItems.Add(redoMenuItem);
            outerToolStripMenuItems.Add(fontMenuItem);

            innerToolStripMenuItems.Add(selectAllContextMenuItem);
            innerToolStripMenuItems.Add(cutContextMenuItem);
            innerToolStripMenuItems.Add(copyContextMenuItem);
            innerToolStripMenuItems.Add(pasteContextMenuItem);

            outerButtons.Add(exitButton);
            outerButtons.Add(restoreButton);
            outerButtons.Add(minimizeButton);

            innerButtons.Add(boldButton);
            innerButtons.Add(italicButton);
            innerButtons.Add(underscoreButton);
            innerButtons.Add(strikeoutButton);
            innerButtons.Add(buildButton);
            innerButtons.Add(undoButton);
            innerButtons.Add(redoButton);

            panels.Add(textEditorPanel);

            menuStrips.Add(textEditorMenuStrip);

            contextMenuStrips.Add(richTextBoxContextMenuStrip);
        }

        /// <summary>
        /// Set light theme.
        /// </summary>
        private void SetLightTheme()
        {
            foreach (var e in menuStrips)
            {
                e.Renderer = new MyRenderer();
                e.BackColor = SystemColors.ButtonFace;
            }
            foreach (var e in contextMenuStrips) e.Renderer = new MyRenderer();

            foreach (var e in panels)
            {
                e.BackColor = Color.FromArgb(243, 242, 241);
            }

            foreach (var e in richTextBoxes)
            {
                e.BackColor = Color.White;
                e.ForeColor = Color.Black;
            }

            foreach (var e in outerToolStripMenuItems)
            {
                e.ForeColor = Color.Black;
                e.BackColor = SystemColors.ButtonFace;
            }

            foreach (var e in innerToolStripMenuItems)
            {
                e.BackColor = SystemColors.ButtonFace;
                e.ForeColor = Color.Black;
            }

            foreach (var e in outerButtons)
            {
                e.FlatAppearance.MouseOverBackColor = Color.White;
                e.BackColor = SystemColors.ButtonFace;
                e.ForeColor = Color.Black;
            }

            foreach (var e in innerButtons)
            {
                e.BackColor = SystemColors.ButtonFace;
                e.FlatAppearance.MouseOverBackColor = e.FlatAppearance.BorderColor = Color.FromArgb(201, 199, 197);
                e.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 177, 174);
                e.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Set dark theme.
        /// </summary>
        private void SetDarkTheme()
        {

            foreach (var e in menuStrips)
            {
                e.Renderer = new MyRenderer(new MyColorTable());
                e.BackColor = Color.FromArgb(41, 41, 41);
            }
            foreach (var e in contextMenuStrips) e.Renderer = new MyRenderer(new MyColorTable());
            foreach (var e in panels)
            {
                e.BackColor = Color.FromArgb(41, 41, 44);
            }

            foreach (var e in richTextBoxes)
            {
                e.BackColor = Color.FromArgb(30, 30, 30);
                e.ForeColor = SystemColors.ButtonFace;
            }

            foreach (var e in outerToolStripMenuItems)
            {
                e.ForeColor = SystemColors.ButtonFace;
                e.BackColor = Color.FromArgb(41, 41, 44);
            }

            foreach (var e in innerToolStripMenuItems)
            {
                e.BackColor = Color.FromArgb(20, 20, 21);
                e.ForeColor = Color.White;
            }

            foreach (var e in outerButtons)
            {
                e.FlatAppearance.MouseOverBackColor = Color.FromArgb(61, 61, 63);
                e.BackColor = Color.FromArgb(41, 41, 44);
                e.ForeColor = SystemColors.ActiveBorder;
            }

            foreach (var e in innerButtons)
            {
                e.BackColor = Color.FromArgb(41, 41, 44);
                e.FlatAppearance.MouseOverBackColor = e.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 62);
                e.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 123, 205);
                e.ForeColor = SystemColors.Control;
            }

        }
    }
}
