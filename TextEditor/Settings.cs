using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TextEditor
{
    /// <summary>
    /// Settings window.
    /// </summary>
    public partial class MySettings : Form
    {
        /// <summary>
        /// Char equal empty string.
        /// </summary>
        static private readonly char invisibleChar = (char)199;

        /// <summary>
        /// Current settings list.
        /// </summary>
        List<string> currentSettingsList = new List<string> { "", "", "", invisibleChar.ToString() };

        // [0] - theme name.
        // [1] - autosave period.
        // [2] - logging period.
        // [3] - compiler path.

        /// <summary>
        /// Settings list from main form.
        /// </summary>
        List<string> settingsList = new List<string>();

        /// <summary>
        /// Timings table for settings transcription.
        /// </summary>
        List<int> standartTimings = new List<int>() { 0, 1, 5, 10, 15, 30 };

        /// <summary>
        /// Cursor position.
        /// </summary>
        Point wasPos;

        /// <summary>
        /// List of delegates to do before closing.
        /// </summary>
        List<DoAtMainForm> doBeforeClosure;

        public MySettings(List<DoAtMainForm> todo, List<string> settings)
        {
            // Loading saved settings.
            settingsList = settings;

            // Delegates from main form.
            doBeforeClosure = todo;

            InitializeComponent();

            // Set settings.
            themeComboBox.SelectedIndex = (settings[0] == "Light" ? 0 : 1);
            autoSaveTimerComboBox.SelectedIndex = standartTimings.FindIndex(x => x == int.Parse(settings[1]) / 60 / 1000);
            logginingTimerComboBox.SelectedIndex = standartTimings.FindIndex(x => x == int.Parse(settings[2]) / 60 / 1000);
            compilerPathLabel.Text = settings[3];
            if (compilerPathLabel.Text == invisibleChar.ToString())
            {
                compilerPathLabel.Text = "";
            }
        }

        // User ability to move window while holding mouse down.
        private void FormPanel_MouseDown(object sender, MouseEventArgs e)
        {
            wasPos = new Point(e.X, e.Y);
        }

        private void FormPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - wasPos.X;
                Top += e.Y - wasPos.Y;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Dont forget to do invoke all delegates except first one, that responsible for "applying" settings.
            for (int i = 1; i < doBeforeClosure.Count; i++)
            {
                doBeforeClosure[i]();
            }

            Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            // Align chosen settings.
            for (int i = 0; i < settingsList.Count; i++)
            {
                settingsList[i] = currentSettingsList[i];
            }

            foreach (var elem in doBeforeClosure)
            {
                elem();
            }

            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Dont forget to do invoke all delegates except first one, that responsible for "applying" settings.
            for (int i = 1; i < doBeforeClosure.Count; i++)
            {
                doBeforeClosure[i]();
            }

            Close();
        }

        private void ThemeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            currentSettingsList[0] = themeComboBox.Text;
        }

        private void AutoSaveTimerComboBox_Validated(object sender, EventArgs e)
        {
            currentSettingsList[2] = autoSaveTimerComboBox.Text;
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog getPath = new OpenFileDialog();
            getPath.Filter = "(*.exe)|*.exe";
            getPath.Title = "Open File.";
            if (getPath.ShowDialog() == DialogResult.OK)
            {
                compilerPathLabel.Text = getPath.FileName;
            }
            currentSettingsList[3] = compilerPathLabel.Text;
            if (currentSettingsList[3] == "")
            {
                currentSettingsList[3] = invisibleChar.ToString();
            }
        }

        private void AutoSaveTimerComboBox_TextChanged(object sender, EventArgs e)
        {
            currentSettingsList[1] = (standartTimings[autoSaveTimerComboBox.SelectedIndex] * 60 * 1000).ToString();
        }

        private void LogginingTimerComboBox_TextChanged(object sender, EventArgs e)
        {
            currentSettingsList[2] = (standartTimings[logginingTimerComboBox.SelectedIndex] * 60 * 1000).ToString();
        }
    }
}
