using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Globalization;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace TextEditor
{
    /// <summary>
    /// Delegate to communicate between forms.
    /// </summary>
    public delegate void DoAtMainForm();

    /// <summary>
    /// Delegate to communicate between forms.
    /// </summary>
    /// <param name="t"> MyFile parameter. </param>
    public delegate void DoAtMainFormFile(MyFile t);

    /// <summary>
    /// Main form.
    /// </summary>
    public partial class TextEditorForm : Form
    {
        /// <summary>
        /// True when catched first exception.
        /// </summary>
        public static bool firstErrorOccuranse = false;

        /// <summary>
        /// Count of created files.
        /// </summary>
        int id = 1;

        /// <summary>
        /// List of pairs - button on pannel and if it is active.
        /// </summary>
        List<KeyValuePair<Button, bool>> activeInnerButtons = new List<KeyValuePair<Button, bool>>();

        /// <summary>
        /// List of all font styles.
        /// </summary>
        List<FontStyle> fontStyles = new List<FontStyle>();

        /// <summary>
        /// List of saved settings.
        /// </summary>
        List<string> settingsList = new List<string>();

        /// <summary>
        /// List with opened files.
        /// </summary>
        MyFileList files = new MyFileList();

        /// <summary>
        /// Active file.
        /// </summary>
        MyFile curFile;

        /// <summary>
        /// Active font.
        /// </summary>
        Font currentFont;

        /// <summary>
        /// Mouse position.
        /// </summary>
        Point wasPos;

        /// <summary>
        /// True if window in full-state mode.
        /// </summary>
        bool isFull = false;

        /// <summary>
        /// Path to compiler.
        /// </summary>
        string compilerPath;

        public TextEditorForm()
        {
            InitializeComponent();

            // Put in lists all controls need to be colored.
            InitializeThemeElements();

            // Trying to get saved settings list from txt file.
            PreLoadData();

            // If failed.
            if (firstErrorOccuranse)
            {
                MessageBox.Show("Default settings were loaded");
                SetDefaultSettings();
            }

            // Set settings.
            UpdateSettings();

            // Initialize font list.
            SetFontLists();

            // Updating form if have no opened tabs.
            if (filesTabControl.TabCount == 0)
            {
                filesTabControl.Visible = false;
                textEditorRichTextBox.Visible = false;
                fontStylePanel.Visible = false;
            }
            currentFont = textEditorRichTextBox.Font;
        }

        /// <summary>
        /// Initalize font list and buttons responsible for font.
        /// </summary>
        private void SetFontLists()
        {
            activeInnerButtons.Add(new KeyValuePair<Button, bool>(italicButton, false));
            activeInnerButtons.Add(new KeyValuePair<Button, bool>(boldButton, false));
            activeInnerButtons.Add(new KeyValuePair<Button, bool>(underscoreButton, false));
            activeInnerButtons.Add(new KeyValuePair<Button, bool>(strikeoutButton, false));

            fontStyles.Add(FontStyle.Italic);
            fontStyles.Add(FontStyle.Bold);
            fontStyles.Add(FontStyle.Underline);
            fontStyles.Add(FontStyle.Strikeout);
        }

        /// <summary>
        /// Loading saved settings.
        /// </summary>
        private void UpdateSettings()
        {
            SetTheme(settingsList[0]);
            foreach (var e in activeInnerButtons)
            {
                if (e.Value)
                {
                    SwapBackAndMouseOverColors(e.Key);
                }
            }
            autoSaveTimer.Interval = Math.Max(1, int.Parse(settingsList[1]));
            autoSaveTimer.Enabled = (autoSaveTimer.Interval != 1);
            loggingTimer.Interval = Math.Max(1, int.Parse(settingsList[2]));
            loggingTimer.Enabled = (loggingTimer.Interval != 1);
            try
            {
                compilerPath = settingsList[3];
            }
            catch
            {
                compilerPath = "";
                settingsList.Add("");
                MessageBox.Show("Cant load compiler");
            }
        }

        /// <summary>
        /// Trying to get saved settings from ApplicationData.txt.
        /// </summary>
        private void PreLoadData()
        {
            var data = new ApplicationData();
            try
            {
                settingsList = data.settingsParams;
                files = data.SetTabControl(filesTabControl);
                if (files.Count > 0)
                {
                    curFile = files[filesTabControl.SelectedIndex];
                    curFile.ShowTextFirstTime(textEditorRichTextBox);
                }
            }
            catch
            {
                data.SetDefault();
                settingsList = data.settingsParams;
                files = new MyFileList();
                filesTabControl.TabPages.Clear();
            }

        }

        /// <summary>
        /// Set default settings.
        /// </summary>
        private void SetDefaultSettings()
        {
            var data = new ApplicationData();
            data.SetDefault();
            settingsList = data.settingsParams;
            files = new MyFileList();
            filesTabControl.TabPages.Clear();
        }

        /// <summary>
        /// Synchronizes textbox and text in file.
        /// </summary>
        private void UpdateText()
        {
            if (curFile == null)
            {
                textEditorRichTextBox.Visible = false;
                return;
            }
            textEditorRichTextBox.Visible = true;
            curFile.FileText = textEditorRichTextBox.Rtf;
            curFile.FileTextPlain = textEditorRichTextBox.Text;
        }

        // Made for moving window while holding down mouse.
        private void TextEditorPanel_MouseDown(object sender, MouseEventArgs e)
        {
            wasPos = new Point(e.X, e.Y);
        }

        private void TextEditorPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - wasPos.X;
                Top += e.Y - wasPos.Y;
            }
        }

        private void ExitButton_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void RestoreButton_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = isFull ? FormWindowState.Normal : FormWindowState.Maximized;
            isFull = !isFull;
        }

        private void MinimizeButton_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Adds new tab in tab control.
        /// </summary>
        /// <param name="name"> Tab name. </param>
        private void AddTab(string name)
        {
            filesTabControl.Visible = true;
            fontStylePanel.Visible = true;
            curFile.Page.Text = name;
            filesTabControl.TabPages.Add(curFile.Page);
        }

        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {
            // Set limit for opened files.
            if (files.Count == 10)
            {
                MessageBox.Show("You can open no more than 10 files");
                return;
            }

            OpenFileDialog open = new OpenFileDialog
            {
                Title = "Open File",
                Filter = "(*.txt)|*.txt|(*.rtf)|*.rtf|(*.cs)|*.cs|All files (*.txt;*.rtf;*.cs*)|*.txt;*.rtf;*.cs;",
                FilterIndex = 4
            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    UpdateText();
                    MyFile file = new MyFile(open.FileName);
                    files.Add(file);
                    curFile = file;

                    // Check for correct text assignment.
                    if (curFile.wasRtf)
                    {
                        textEditorRichTextBox.Rtf = curFile.FileText;
                    }
                    else
                    {
                        textEditorRichTextBox.Text = curFile.FileText;
                    }
                    textEditorRichTextBox.Visible = true;
                    AddTab(Path.GetFileName(curFile.FilePath));
                    filesTabControl.SelectedTab = curFile.Page;
                }
                catch (Exception exc)
                {

                    MessageBox.Show(exc.Message);
                }
            }
        }

        /// <summary>
        /// Save current file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveFileMenuItem_Click(object sender, EventArgs e)
        {
            UpdateText();
            if (curFile != null)
            {
                curFile.Save();
                UpdateTab();
            }
        }

        /// <summary>
        /// Save current file as.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAsMenuItem_Click(object sender, EventArgs e)
        {
            UpdateText();
            if (curFile != null)
            {
                curFile.SaveAs();
                UpdateTab();
            }
        }

        private void FilesTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateText();
            if (filesTabControl.SelectedIndex >= 0)
            {
                curFile = files[filesTabControl.SelectedIndex];
                curFile.ShowText(textEditorRichTextBox);
            }
            UpdateFont(currentFont);
        }

        private void TextEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateText();

            // Saving current settings to txt file.
            ApplicationData applicationData = new ApplicationData(settingsList, files, filesTabControl);
            applicationData.WriteData();

            if (!files.Changed && !(filesTabControl.TabCount != 0 && curFile.FilePath == null)) return;

            switch (MessageBox.Show("Save changes?", "Text editor", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Yes:
                    files.SaveChanges();
                    break;
                case DialogResult.No:
                    break;
                default:
                    e.Cancel = true;
                    break;
            }
        }

        private void RichTextBox1_Leave(object sender, EventArgs e)
        {
            UpdateText();
        }

        private void AutoSaveTimer_Tick(object sender, EventArgs e)
        {
            UpdateText();
            if (files.Count > 0) files.SaveChanges();
        }

        private void SettingsMenuItem_Click(object sender, EventArgs e)
        {
            // List of delegates that settings form should do before closing.
            List<DoAtMainForm> todo = new List<DoAtMainForm>();

            // Update settings.
            todo.Add(new DoAtMainForm(UpdateSettings));

            // Enable current window.
            todo.Add(delegate ()
            {
                Enabled = true;
            });

            // Turn on text box.
            if (textEditorRichTextBox.Visible)
            {
                textEditorRichTextBox.Visible = false;
                todo.Add(delegate ()
                {
                    textEditorRichTextBox.Visible = true;
                });
            }

            MySettings mySettings;
            mySettings = new MySettings(todo, settingsList);
            mySettings.Show();

            // Disabling main window for user.
            Enabled = false;

        }

        /// <summary>
        /// Set current file in selected tab.
        /// </summary>
        private void UpdateTab()
        {
            filesTabControl.SelectedTab = curFile.Page;
        }

        /// <summary>
        /// Synchronize textbox and curFile.
        /// </summary>
        /// <param name="file"> Fake parameter to set multidelegate. </param>
        private void UpdateCurFile(MyFile file)
        {
            curFile.ShowText(textEditorRichTextBox);
            UpdateTab();
        }

        private void BackUpMenuItem_Click(object sender, EventArgs e)
        {
            if (curFile == null) return;

            // Array of delegates backUp menu should do before closing;
            DoAtMainFormFile[] todo = new DoAtMainFormFile[3];

            // Update current file.
            todo[0] = new DoAtMainFormFile(UpdateCurFile);

            // Enable window.
            todo[1] = delegate (MyFile tmp)
            {
                Enabled = true;
            };

            // Turn on text box.
            if (textEditorRichTextBox.Visible)
            {
                textEditorRichTextBox.Visible = false;
                todo[2] = delegate (MyFile tmp)
                {
                    textEditorRichTextBox.Visible = true;
                };
            }

            BackUp backUp = new BackUp(todo, curFile);
            backUp.Show();

            // Disabling main window for user.
            Enabled = false;
        }

        /// <summary>
        /// Create new file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewFileMenuItem_Click(object sender, EventArgs e)
        {
            // Set limit for opened files.
            if (files.Count == 10)
            {
                MessageBox.Show("You can open no more than 10 files");
                return;
            }
            try
            {
                UpdateText();
                MyFile file = new MyFile();
                files.Add(file);
                curFile = file;
                curFile.ShowText(textEditorRichTextBox);
                textEditorRichTextBox.Visible = true;
                AddTab($"New document {id++}");
                filesTabControl.SelectedTab = curFile.Page;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        /// <summary>
        /// Save all opened files.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAllMenuItem_Click(object sender, EventArgs e)
        {
            UpdateText();
            files.SaveChanges();
        }

        /// <summary>
        /// Close opened tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseCurrentTabMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // If tab was unsaved.
                if (curFile.Changed || curFile.FilePath == null)
                {
                    switch (MessageBox.Show($"Do you want to save changes to {filesTabControl.SelectedTab.Text}?", "Text Editor", MessageBoxButtons.YesNoCancel))
                    {
                        case DialogResult.Yes:
                            curFile.Save();
                            break;
                        case DialogResult.Cancel:
                            return;
                    }
                }
                int id = filesTabControl.SelectedIndex;
                filesTabControl.TabPages.Remove(curFile.Page);
                curFile = files.Remove(id);
                if (curFile != null)
                {
                    filesTabControl.SelectedTab = curFile.Page;
                    textEditorRichTextBox.Rtf = curFile.FileText;
                    filesTabControl.SelectedIndex = Math.Max(id - 1, 0);
                }
                else
                {
                    textEditorRichTextBox.Visible = false;
                    filesTabControl.Visible = false;
                    fontStylePanel.Visible = false;
                }

            }
            catch
            {

            }

        }

        private void SelectAllItem_Click(object sender, EventArgs e)
        {
            textEditorRichTextBox.SelectAll();
        }

        private void CutMenuItem_Click(object sender, EventArgs e)
        {
            textEditorRichTextBox.Cut();

        }

        private void PasteMenuItem_Click(object sender, EventArgs e)
        {
            textEditorRichTextBox.Paste();
        }

        private void CopyMenuItem_Click(object sender, EventArgs e)
        {
            textEditorRichTextBox.Copy();

        }

        /// <summary>
        /// Sets new font in textbox.
        /// </summary>
        /// <param name="newFont"> New font. </param>
        private void UpdateFont(Font newFont)
        {
            textEditorRichTextBox.SelectionFont = newFont;
            currentFont = newFont;
            textEditorRichTextBox.Focus();
        }

        /// <summary>
        /// Change button state active - inactive.
        /// </summary>
        /// <param name="e"> Button. </param>
        private void SwapBackAndMouseOverColors(Button e)
        {
            Color tmp = e.BackColor;
            e.BackColor = e.FlatAppearance.BorderColor;
            e.FlatAppearance.BorderColor = tmp;
        }

        /// <summary>
        /// Change button state active - inactive in button list.
        /// </summary>
        /// <param name="index"> Button index. </param>
        private void InvertInnerButton(int index)
        {
            activeInnerButtons[index] = new KeyValuePair<Button, bool>(activeInnerButtons[index].Key, activeInnerButtons[index].Value ^ true);
        }

        /// <summary>
        /// Change italic style.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItalicButton_Click(object sender, EventArgs e)
        {
            SwapBackAndMouseOverColors(italicButton);
            InvertInnerButton(0);
            Font newFont;
            if (currentFont.Italic)
                newFont = new Font(currentFont, currentFont.Style & ~FontStyle.Italic);
            else
                newFont = new Font(currentFont, currentFont.Style | FontStyle.Italic);

            UpdateFont(newFont);
        }

        /// <summary>
        /// Change bold style.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoldButton_Click(object sender, EventArgs e)
        {
            SwapBackAndMouseOverColors(boldButton);
            InvertInnerButton(1);
            Font newFont;
            if (currentFont.Bold)
                newFont = new Font(currentFont, currentFont.Style & ~FontStyle.Bold);
            else
                newFont = new Font(currentFont, currentFont.Style | FontStyle.Bold);

            UpdateFont(newFont);
        }

        /// <summary>
        /// Change underscore style.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnderscoreButton_Click(object sender, EventArgs e)
        {
            SwapBackAndMouseOverColors(underscoreButton);
            InvertInnerButton(2);
            Font newFont;
            if (currentFont.Underline)
                newFont = new Font(currentFont, currentFont.Style & ~FontStyle.Underline);
            else
                newFont = new Font(currentFont, currentFont.Style | FontStyle.Underline);

            UpdateFont(newFont);
        }

        /// <summary>
        /// Change strikeout style.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StrikeoutButton_Click(object sender, EventArgs e)
        {
            SwapBackAndMouseOverColors(strikeoutButton);
            InvertInnerButton(3);
            Font newFont;
            if (currentFont.Strikeout)
                newFont = new Font(currentFont, currentFont.Style & ~FontStyle.Strikeout);
            else
                newFont = new Font(currentFont, currentFont.Style | FontStyle.Strikeout);

            UpdateFont(newFont);
        }

        /// <summary>
        /// Compile current file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuildButton_Click(object sender, EventArgs e)
        {
            if (curFile.FilePath == null || !curFile.FilePath.EndsWith(".cs"))
            {
                MessageBox.Show("At this moments it is only possible to compile .cs extentions");
                return;
            }
            // Synchronize before compiling.
            UpdateText();
            curFile.Save();

            try
            {
                if (!compilerPath.EndsWith(".exe"))
                {
                    throw new Exception();
                }
                // Opens console to execute compiler with current file.
                Process console = new Process();
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                console.StartInfo = new ProcessStartInfo(@"cmd.exe");
                console.StartInfo.RedirectStandardInput = true;
                console.StartInfo.RedirectStandardOutput = true;
                console.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(CultureInfo.CurrentCulture.TextInfo.OEMCodePage);
                console.StartInfo.UseShellExecute = false;
                console.StartInfo.CreateNoWindow = true;
                console.Start();
                using (StreamWriter sr = console.StandardInput)
                {
                    console.StandardInput.WriteLine($@"{compilerPath} {curFile.FilePath}");
                    sr.Close();
                }
                console.StandardOutput.ReadLine();
                console.StandardOutput.ReadLine();

                // Compiler output.
                string output = console.StandardOutput.ReadToEnd();

                console.WaitForExit();
                console.Close();
                MessageBox.Show(output);
            }
            catch
            {
                MessageBox.Show("Cant open file or wrong compiler");
            }

        }

        /// <summary>
        /// Formatting opened file as .cs code.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormatCodeMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < activeInnerButtons.Count; i++)
            {
                if (activeInnerButtons[i].Value)
                {
                    InvertInnerButton(i);
                    SwapBackAndMouseOverColors(activeInnerButtons[i].Key);
                }
            }
            textEditorRichTextBox.Text = CSharpSyntaxTree.ParseText(textEditorRichTextBox.Text).GetRoot().NormalizeWhitespace().ToFullString();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            textEditorRichTextBox.Undo();
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            textEditorRichTextBox.Redo();
        }

        /// <summary>
        /// Doing copy of file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoggingTimer_Tick(object sender, EventArgs e)
        {
            curFile.DoCurrentCopy();
        }

        private void FontMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            fontDialog.Font = currentFont;
            fontDialog.Color = textEditorRichTextBox.ForeColor;
            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                currentFont = fontDialog.Font;
                textEditorRichTextBox.ForeColor = fontDialog.Color;
                textEditorRichTextBox.SelectionFont = currentFont;

                //Synchronizing font buttons state with chosen font.
                for (int i = 0; i < activeInnerButtons.Count; i++)
                {
                    if (i == 1)
                    {
                        continue;
                    }
                    if (activeInnerButtons[i].Value != ((currentFont.Style & fontStyles[i]) == fontStyles[i]))
                    {
                        InvertInnerButton(i);
                        SwapBackAndMouseOverColors(activeInnerButtons[i].Key);
                    }
                }
            }

        }
    }
}
