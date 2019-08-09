using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CodeEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Select A File To Open - Ensure You Match The Formats Supported";
            file.Filter = "C# files|*.csproj;*.cs|VB.net|*.vb|HTML|*.html|XML|*.xml|SQL|*.sql|PHP|*.php|JavaScript Files|*.js|Lua Files|*.lua";
            file.ShowDialog();

            try
            {
                StreamReader streamReader = new StreamReader(file.FileName);
                fastColoredTextBox1.Text = streamReader.ReadToEnd();
                streamReader.Close();
            }
            catch {}
        }
    }
}
