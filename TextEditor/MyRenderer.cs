using System.Windows.Forms;

namespace TextEditor
{
    /// <summary>
    /// Custom render class for themes.
    /// </summary>
    class MyRenderer : ToolStripProfessionalRenderer
    {
        public MyRenderer() { }

        public MyRenderer(MyColorTable e) : base(e) { }
    }
}
