using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace TextEditor
{
    /// <summary>
    /// File class with information about it.
    /// </summary>
    public class MyFile
    {
        public MyFile() { }

        public MyFile(string path)
        {
            FilePath = path;
            try
            {
                StartText = FileText = File.ReadAllText(path);
                Page.Text = Path.GetFileName(FilePath);
                DirectoryPath = path.Substring(0, path.Length - Page.Text.Length);
                if (FilePath.EndsWith(".rtf"))
                {
                    wasRtf = true;
                }
                DoCurrentCopy();
            }
            catch
            {
                MessageBox.Show("Unexpected error occured");
                TextEditorForm.firstErrorOccuranse = true;
            }
        }

        public string FilePath { get; set; }

        public string DirectoryPath { get; set; }

        /// <summary>
        /// Text in plain format.
        /// </summary>
        public string FileTextPlain { get; set; } = "";

        /// <summary>
        /// Current text in rtf or plain format.
        /// </summary>
        public string FileText { get; set; } = "";

        /// <summary>
        /// Starting text in rtf or plain format.
        /// </summary>
        public string StartText { get; set; } = "";

        /// <summary>
        /// Page with name of this file.
        /// </summary>
        public TabPage Page { get; set; } = new TabPage();

        /// <summary>
        /// If opened file had rtf format.
        /// </summary>
        public bool wasRtf = false;

        /// <summary>
        /// List with logging versions.
        /// </summary>
        ///  TabPage - Tab, string - text.
        public List<Tuple<TabPage, string>> log = new List<Tuple<TabPage, string>>();

        /// <summary>
        /// Time of saved logs.
        /// </summary>
        public List<DateTime> timings = new List<DateTime>();

        /// <summary>
        /// True if file changed.
        /// </summary>
        public bool Changed
        {
            get
            {
                return (FileText != StartText && FileTextPlain != StartText);
            }
        }

        /// <summary>
        /// Assign text to richTextBox for the first time, determing text format.
        /// </summary>
        /// <param name="richTextBox"> RichTextBox where to assign. </param>
        public void ShowTextFirstTime(RichTextBox richTextBox)
        {
            try
            {
                // If was rtf, then text in rtf format so put it in textbox.rtf.
                if (FilePath.EndsWith(".rtf"))
                {
                    richTextBox.Rtf = FileText;
                    FileTextPlain = richTextBox.Text;
                }
                else
                {
                    // Otherwise its plain text.
                    richTextBox.Text = FileText;
                }
            }
            catch
            {
                MessageBox.Show("Unexpected error occured");
            }

        }

        /// <summary>
        /// Assing text to richTextBox.
        /// </summary>
        /// <param name="richTextBox"> RichTextBox where to assign. </param>
        public void ShowText(RichTextBox richTextBox)
        {
            try
            {
                // Try to save fonts, if text in .rtf.
                richTextBox.Rtf = FileText;
            }
            catch
            {
                // Otherwise it is plain.
                richTextBox.Text = FileText;
            }
        }

        /// <summary>
        /// Saves file.
        /// </summary>
        /// <returns> True if saved successfully. </returns>
        public bool Save()
        {
            if (FilePath == null)
            {
                return SaveAs();
            }
            try
            {
                using (StreamWriter writer = new StreamWriter(FilePath, false))
                {
                    if (FilePath.EndsWith(".rtf"))
                    {
                        writer.Write(FileText);
                    }
                    else
                    {
                        writer.Write(FileTextPlain);
                    }
                }
                StartText = FileText;
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Save file as.
        /// </summary>
        /// <returns> True if saved successfully. </returns>
        public bool SaveAs()
        {
            SaveFileDialog saver = new SaveFileDialog();
            saver.Title = "Save As";
            saver.Filter = "(*.rtf)|*.rtf|(*.txt)|*.txt|(*.cs)|*.cs";
            saver.RestoreDirectory = true;
            saver.FileName = Page.Text;
            if (saver.ShowDialog() == DialogResult.OK)
            {
                FilePath = saver.FileName;
                Page.Text = Path.GetFileName(FilePath);
                return Save();
            }
            return false;
        }

        /// <summary>
        /// Save current version.
        /// </summary>
        public void DoCurrentCopy()
        {
            if (log.Count == 10)
            {
                log.RemoveAt(0);
                timings.RemoveAt(0);
            }
            log.Add(new Tuple<TabPage, string>(Page, FileText));
            timings.Add(DateTime.Now);
        }
    }
}
