using System;
using System.Drawing;
using System.Windows.Forms;

namespace TextEditor
{
    /// <summary>
    /// BackUp window.
    /// </summary>
    public partial class BackUp : Form
    {
        /// <summary>
        /// Mouse position.
        /// </summary>
        Point wasPos;

        /// <summary>
        /// Delegates to do before closing.
        /// </summary>
        DoAtMainFormFile[] doBeforeClosure;

        /// <summary>
        /// Current file from main form.
        /// </summary>
        MyFile curFile;

        public BackUp(DoAtMainFormFile[] todo, MyFile myFile)
        {
            InitializeComponent();
            doBeforeClosure = todo;
            curFile = myFile;
            foreach (var elem in myFile.timings)
            {
                versionsComboBox.Items.Add(elem);
            }
            versionsComboBox.SelectedIndex = myFile.timings.Count - 1;
        }

        // Make user able to move window with holding mouse down.
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
            for (int i = 1; i < doBeforeClosure.Length; i++)
            {
                doBeforeClosure[i](curFile);
            }
            Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            string name = curFile.Page.Text;
            curFile.Page = curFile.log[versionsComboBox.SelectedIndex].Item1;
            curFile.Page.Text = name;
            curFile.FileText = curFile.StartText = curFile.log[versionsComboBox.SelectedIndex].Item2;
            foreach (var elem in doBeforeClosure)
            {
                elem(curFile);
            }
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < doBeforeClosure.Length; i++)
            {
                doBeforeClosure[i](curFile);
            }
            Close();
        }
    }
}
