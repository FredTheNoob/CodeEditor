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
        string currentFile = " ";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFileType.SelectedItem = "CSharp";
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            open();
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            save();
        }

        private void SaveFileAs_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        private void Save_KeyDown(object sender, KeyEventArgs e)
        {
            // if CTRL+SHIFT+S is pressed simultaneously
            if (e.KeyCode == Keys.S && e.Modifiers == (Keys.Control | Keys.Shift))
            {
                saveAs();
            }
            else if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control) // if CTRL+S is pressed simultaneously
            {
                save();
            }
            else if (e.KeyCode == Keys.O && e.Modifiers == Keys.Control) // If CTRL+O is pressed simultaneously
            {
                open();
            }
        }

        private void CmbFileType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //

            switch (cmbFileType.SelectedItem)
            {
                case "CSharp":
                    fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.CSharp;
                    break;
                case "VB":
                    fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.VB;
                    break;
                case "HTML":
                    fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML;
                    break;
                case "XML":
                    fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.XML;
                    break;
                case "SQL":
                    fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.SQL;
                    break;
                case "PHP":
                    fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.PHP;
                    break;
                case "JS":
                    fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS;
                    break;
                case "Lua":
                    fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Lua;
                    break;
                default:
                    break;
            }
            string text = fastColoredTextBox1.Text;

            fastColoredTextBox1.Clear();
            fastColoredTextBox1.Text = text;
        }

        void save()
        {
            // If file has not been saved before
            if (currentFile == " ")
            {
                saveAs();
            }
            else
            {
                StreamWriter sw = new StreamWriter(currentFile);
                sw.Write(fastColoredTextBox1.Text);
                sw.Close();
            }
        }

        void saveAs()
        {
            SaveFileDialog SaveAsfile = new SaveFileDialog();
            SaveAsfile.Title = "Select Where You Wish Your File Stored - Ensure You Match The Formats Supported";
            SaveAsfile.Filter = "C# files|*.csproj;*.cs|VB.net|*.vb|HTML|*.html|XML|*.xml|SQL|*.sql|PHP|*.php|JavaScript Files|*.js|Lua Files|*.lua|All Files|*.*";
            SaveAsfile.RestoreDirectory = true;
            SaveAsfile.ShowDialog();

            try
            {
                StreamWriter streamWriter = new StreamWriter(SaveAsfile.FileName);
                streamWriter.Write(fastColoredTextBox1.Text);
                streamWriter.Close();
                currentFile = SaveAsfile.FileName;
            }
            catch { }
        }

        void open()
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Select A File To Open - Ensure You Match The Formats Supported";
            file.Filter = "C# files|*.csproj;*.cs|VB.net|*.vb|HTML|*.html|XML|*.xml|SQL|*.sql|PHP|*.php|JavaScript Files|*.js|Lua Files|*.lua|All Files|*.*";
            file.ShowDialog();

            try
            {
                StreamReader streamReader = new StreamReader(file.FileName);
                fastColoredTextBox1.Text = streamReader.ReadToEnd();
                streamReader.Close();
                currentFile = file.FileName;
            }
            catch { }
        }
    }
}
