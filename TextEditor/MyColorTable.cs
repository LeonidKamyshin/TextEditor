using System.Drawing;
using System.Windows.Forms;

namespace TextEditor
{
    /// <summary>
    /// Custom color table for themes.
    /// </summary>
    class MyColorTable : ProfessionalColorTable
    {
        public override Color MenuItemSelected => Color.FromArgb(41, 41, 44);

        public override Color MenuBorder => Color.FromArgb(41, 41, 44);

        public override Color MenuItemBorder => Color.FromArgb(41, 41, 44);

        public override Color ToolStripBorder => Color.FromArgb(41, 41, 44);

        public override Color ToolStripDropDownBackground => Color.FromArgb(41, 41, 44);

        public override Color ToolStripGradientBegin => Color.FromArgb(41, 41, 44);

        public override Color ToolStripGradientEnd => Color.FromArgb(41, 41, 44);

        public override Color ToolStripGradientMiddle => Color.FromArgb(41, 41, 44);

        public override Color MenuItemPressedGradientBegin => Color.FromArgb(41, 41, 44);

        public override Color MenuItemPressedGradientEnd => Color.FromArgb(41, 41, 44);

        public override Color MenuItemPressedGradientMiddle => Color.FromArgb(41, 41, 44);
    }
}
