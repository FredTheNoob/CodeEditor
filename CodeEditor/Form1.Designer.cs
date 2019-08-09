namespace CodeEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ccsprojToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textFiletxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pythonpyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileCTRLSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileAsCTRLSHIFTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pythonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.javaScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectiveCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vBNetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.saveFileCTRLSToolStripMenuItem,
            this.saveFileAsCTRLSHIFTSToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ccsprojToolStripMenuItem,
            this.textFiletxtToolStripMenuItem,
            this.pythonpyToolStripMenuItem});
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.newFileToolStripMenuItem.Text = "New File";
            // 
            // ccsprojToolStripMenuItem
            // 
            this.ccsprojToolStripMenuItem.Name = "ccsprojToolStripMenuItem";
            this.ccsprojToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.ccsprojToolStripMenuItem.Text = "C# (.csproj)";
            // 
            // textFiletxtToolStripMenuItem
            // 
            this.textFiletxtToolStripMenuItem.Name = "textFiletxtToolStripMenuItem";
            this.textFiletxtToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.textFiletxtToolStripMenuItem.Text = "Text File (.txt)";
            // 
            // pythonpyToolStripMenuItem
            // 
            this.pythonpyToolStripMenuItem.Name = "pythonpyToolStripMenuItem";
            this.pythonpyToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.pythonpyToolStripMenuItem.Text = "Python (.py)";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // saveFileCTRLSToolStripMenuItem
            // 
            this.saveFileCTRLSToolStripMenuItem.Name = "saveFileCTRLSToolStripMenuItem";
            this.saveFileCTRLSToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.saveFileCTRLSToolStripMenuItem.Text = "Save File (CTRL+S)";
            // 
            // saveFileAsCTRLSHIFTSToolStripMenuItem
            // 
            this.saveFileAsCTRLSHIFTSToolStripMenuItem.Name = "saveFileAsCTRLSHIFTSToolStripMenuItem";
            this.saveFileAsCTRLSHIFTSToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.saveFileAsCTRLSHIFTSToolStripMenuItem.Text = "Save File As (CTRL+SHIFT+S)";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox1.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.BackColor = System.Drawing.Color.DimGray;
            this.fastColoredTextBox1.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fastColoredTextBox1.CaretColor = System.Drawing.Color.White;
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.CurrentLineColor = System.Drawing.Color.Silver;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(180)))), ((int)(((byte)(92)))));
            this.fastColoredTextBox1.IndentBackColor = System.Drawing.Color.DimGray;
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.CSharp;
            this.fastColoredTextBox1.LeftBracket = '(';
            this.fastColoredTextBox1.LeftBracket2 = '{';
            this.fastColoredTextBox1.LineNumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(180)))), ((int)(((byte)(92)))));
            this.fastColoredTextBox1.Location = new System.Drawing.Point(0, 27);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.RightBracket = ')';
            this.fastColoredTextBox1.RightBracket2 = '}';
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(800, 423);
            this.fastColoredTextBox1.TabIndex = 1;
            this.fastColoredTextBox1.Zoom = 100;
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem1,
            this.cToolStripMenuItem2,
            this.cToolStripMenuItem,
            this.javaScriptToolStripMenuItem,
            this.luaToolStripMenuItem,
            this.objectiveCToolStripMenuItem,
            this.pythonToolStripMenuItem,
            this.perlToolStripMenuItem,
            this.pHPToolStripMenuItem,
            this.vBNetToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cToolStripMenuItem.Text = "C#";
            // 
            // pythonToolStripMenuItem
            // 
            this.pythonToolStripMenuItem.Name = "pythonToolStripMenuItem";
            this.pythonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pythonToolStripMenuItem.Text = "Python";
            // 
            // javaScriptToolStripMenuItem
            // 
            this.javaScriptToolStripMenuItem.Name = "javaScriptToolStripMenuItem";
            this.javaScriptToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.javaScriptToolStripMenuItem.Text = "JavaScript";
            // 
            // objectiveCToolStripMenuItem
            // 
            this.objectiveCToolStripMenuItem.Name = "objectiveCToolStripMenuItem";
            this.objectiveCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.objectiveCToolStripMenuItem.Text = "Objective-C";
            // 
            // perlToolStripMenuItem
            // 
            this.perlToolStripMenuItem.Name = "perlToolStripMenuItem";
            this.perlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.perlToolStripMenuItem.Text = "Perl";
            // 
            // vBNetToolStripMenuItem
            // 
            this.vBNetToolStripMenuItem.Name = "vBNetToolStripMenuItem";
            this.vBNetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vBNetToolStripMenuItem.Text = "VB.Net";
            // 
            // luaToolStripMenuItem
            // 
            this.luaToolStripMenuItem.Name = "luaToolStripMenuItem";
            this.luaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.luaToolStripMenuItem.Text = "Lua";
            // 
            // pHPToolStripMenuItem
            // 
            this.pHPToolStripMenuItem.Name = "pHPToolStripMenuItem";
            this.pHPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pHPToolStripMenuItem.Text = "PHP";
            // 
            // cToolStripMenuItem1
            // 
            this.cToolStripMenuItem1.Name = "cToolStripMenuItem1";
            this.cToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cToolStripMenuItem1.Text = "C";
            // 
            // cToolStripMenuItem2
            // 
            this.cToolStripMenuItem2.Name = "cToolStripMenuItem2";
            this.cToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.cToolStripMenuItem2.Text = "C++";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fastColoredTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ccsprojToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textFiletxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pythonpyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileCTRLSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileAsCTRLSHIFTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem javaScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objectiveCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pythonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vBNetToolStripMenuItem;
    }
}

