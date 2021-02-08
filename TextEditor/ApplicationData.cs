using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace TextEditor
{
    /// <summary>
    /// Class for saving settings.
    /// </summary>
    class ApplicationData
    {
        /// <summary>
        /// Char to separate parameters.
        /// </summary>
        static private readonly char separator = (char)198;

        /// <summary>
        /// Char equal empty string.
        /// </summary>
        static private readonly char invisibleChar = (char)199;

        /// <summary>
        /// Name of file where to save data.
        /// </summary>
        static private readonly string fileName = "ApplicationData.txt";

        /// <summary>
        /// List with saving parameters.
        /// </summary>
        /// [0] - theme name.
        /// [1] - autosave period.
        /// [2] - logging period.
        /// [3] - compiler path.
        public List<string> settingsParams = new List<string>();

        /// <summary>
        /// List of opened tabs.
        /// </summary>
        List<string> openedTabs = new List<string>();


        /// <summary>
        /// Index of selected tab.
        /// </summary>
        public int CurTabId = -1;

        public ApplicationData()
        {
            try
            {
                ReadData();
            }
            catch
            {
                SetDefault();
            }
        }

        public ApplicationData(List<string> settingsParams, MyFileList files, TabControl tabControl)
        {
            this.settingsParams = settingsParams;
            SetOpenedTabs(files);
            CurTabId = tabControl.SelectedIndex;
        }

        /// <summary>
        /// Sets deafult settings.
        /// </summary>
        public void SetDefault()
        {
            openedTabs.Clear();
            settingsParams = new List<string>()
                {
                    "Light",
                    "0",
                    "0",
                    invisibleChar.ToString()

                };
            CurTabId = -1;
        }

        /// <summary>
        /// Fills list with saved files.
        /// </summary>
        /// <param name="files"> Where to stack files. </param>
        public void SetOpenedTabs(MyFileList files)
        {
            for (int i = 0; i < files.Count; i++)
            {
                if (files[i].FilePath != null)
                {
                    openedTabs.Add(files[i].FilePath);
                }
            }
        }

        /// <summary>
        /// Loads tabs in tabControl.
        /// </summary>
        /// <param name="tabControl"> Where to load tabs. </param>
        /// <returns> List with opened files. </returns>
        public MyFileList SetTabControl(TabControl tabControl)
        {
            MyFileList files = new MyFileList();
            foreach (var e in openedTabs) files.Add(new MyFile(e));
            for (int i = 0; i < files.Count; i++)
            {
                tabControl.TabPages.Add(files[i].Page);
            }
            tabControl.SelectedIndex = CurTabId;
            return files;
        }

        /// <summary>
        /// Save settings in .txt file.
        /// </summary>
        public void WriteData()
        {
            // *ThemeName*|separator|*AutoSavePeriod*|separator|*LoggingPeriod*|separator|*CompilerPath*|separator|
            // *FilePath*|separator|*FilePath*| ... |separator|*FilePath*|separator.
            // *SelectedTab index*
            string text = "";
            foreach (var e in settingsParams) text += e + separator;
            text += '\n';
            foreach (var e in openedTabs) text += e + separator;
            text += '\n';
            text += CurTabId;

            File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), fileName), text);
        }

        /// <summary>
        /// Reads settings from .txt. file.
        /// </summary>
        public void ReadData()
        {
            string[] text = new string[3];
            using (StreamReader sr = new StreamReader(Path.Combine(Directory.GetCurrentDirectory(), fileName)))
            {
                for (int i = 0; i < text.Length; i++)
                {
                    text[i] = sr.ReadLine();
                }
            }
            string[] curText;
            curText = text[0].Split(separator, StringSplitOptions.RemoveEmptyEntries);
            foreach (var e in curText) settingsParams.Add(e);
            if (settingsParams.Count > 4)
            {
                settingsParams.RemoveRange(4, settingsParams.Count - 4);
            }
            curText = text[1].Split(separator, StringSplitOptions.RemoveEmptyEntries);
            foreach (var e in curText) openedTabs.Add(e);
            if (openedTabs.Count > 10)
            {
                openedTabs.RemoveRange(10, settingsParams.Count - 10);
            }
            int.TryParse(text[2], out CurTabId);
        }
    }
}
