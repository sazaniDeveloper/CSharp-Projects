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
using Notepad_Duplicate;

namespace Notepad_Duplicate
{
    public partial class MainForm : Form
    {
      
        private string FileName = "";
        private bool filesave = false;
       
        public MainForm()
        {
            InitializeComponent();
        }

        ////////////////////////
        //File Tool Strip Menu//
        ////////////////////////
        private void newStripMenu_Click(object sender, EventArgs e)
        {
            if (richNotepad.Modified && (filesave==false))
            {
                DialogResult result = MessageBox.Show("Do you want to save current file?"
                    , "Notepad Duplicate", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    SaveStripMenu_Click(sender, e);
                    richNotepad.Clear();
                    this.FileName = string.Empty;
                    this.Text = "Untitled - Notepad Duplicate";
                }
                else if (result == DialogResult.No)
                {
                    richNotepad.Clear();
                    this.FileName = string.Empty;
                    this.Text = "Untitled - Notepad Duplicate";
                }
                else if (result == DialogResult.Cancel)
                {

                }
            }
            else
            {
                richNotepad.Clear();
                this.FileName = string.Empty;
                this.Text = "Untitled - Notepad Duplicate";
            }

        }
        private void OpenStripMenu_Click(object sender, EventArgs e)
        {
            if (richNotepad.Modified  && (filesave==false))
            {
                DialogResult dialog = MessageBox.Show("Do you want to save this file?", "Notepad Duplicate",
                    MessageBoxButtons.YesNoCancel);
                if (dialog == DialogResult.Yes)
                {
                    SaveStripMenu_Click(sender, e);
                    OpenFileDialog openFile = new OpenFileDialog();
                    openFile.Title = "Open File";
                    openFile.Filter = "Text Filters (*.txt)|*.txt|All files (*.*)|*.*";
                    if (openFile.ShowDialog() == DialogResult.OK)
                    {
                        StreamReader read = new StreamReader(File.OpenRead(openFile.FileName));
                        FileInfo f1 = new FileInfo(openFile.FileName);
                        FileName = openFile.FileName;
                        richNotepad.Text = read.ReadToEnd();
                        this.Text = string.Format("{0} " + "- Notepad Duplicate", f1.Name);
                        read.Dispose();
                    }
                }
                else if (dialog == DialogResult.No)
                {
                    OpenFileDialog openFile = new OpenFileDialog();
                    openFile.Title = "Open File";
                    openFile.Filter = "Text Filters (*.txt)|*.txt|All files (*.*)|*.*";
                    if (openFile.ShowDialog() == DialogResult.OK)
                    {
                        StreamReader read = new StreamReader(File.OpenRead(openFile.FileName));
                        FileInfo f1 = new FileInfo(openFile.FileName);
                        FileName = openFile.FileName;
                        richNotepad.Text = read.ReadToEnd();
                        this.Text = string.Format("{0} " + "- Notepad Duplicate", f1.Name);
                        read.Dispose();
                        if (richNotepad.Modified)
                        {
                            this.Text = string.Format("*{0} " + "- Notepad Duplicate",
                            f1.Name);
                        }
                    }
                }
                else if (dialog == DialogResult.Cancel)
                {

                }

            }
            else 
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Title = "Open File";
                openFile.Filter = "Text Filters (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    StreamReader read = new StreamReader(File.OpenRead(openFile.FileName));
                    FileInfo f1 = new FileInfo(openFile.FileName);
                    FileName = openFile.FileName;
                    richNotepad.Text = read.ReadToEnd();
                    this.Text = string.Format("{0} " + "- Notepad Duplicate", f1.Name);
                    read.Dispose(); 
                }
            }

        }
        private void SaveStripMenu_Click(object sender, EventArgs e)
        {
            if (FileName == "")
            {
                SaveAsStripMenu_Click(sender, e);
                filesave = true;
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(FileName))
                {
                    sw.WriteLineAsync(richNotepad.Text);
                    sw.Dispose();
                    filesave = true;
                    FileInfo file = new FileInfo(FileName);
                    this.Text = String.Format("{0}" + " - Notepad Duplicate", file.Name);
                }
            }

        }
        private void SaveAsStripMenu_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.Title = "Save As";
            sfd.FileName = "*.txt";
            if (FileName!="")
            {
                FileInfo f = new FileInfo(FileName);
                sfd.FileName = f.Name;
            }
            sfd.DefaultExt = "txt";
            sfd.InitialDirectory = @"D:\";
            sfd.RestoreDirectory = true;
            sfd.ValidateNames = true;
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {  
                        FileInfo f = new FileInfo(sfd.FileName);
                        FileName = sfd.FileName;
                        this.Text = string.Format("{0} " + "- Notepad Duplicate",
                            f.Name);
                        sw.Write(richNotepad.Text);
                        sw.Dispose();
                        filesave = true;
                    }
                }
            }
        }
        private void PageSetupStripMenu_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void PrintStripMenu_Click(object sender, EventArgs e)
        {
            PrintDialog dlg = new PrintDialog();
            dlg.ShowDialog();
        }
        private void ExitStripMenu_Click(object sender, EventArgs e)
        {
            if (richNotepad.Modified && (filesave == false))
            {
                DialogResult dialog = MessageBox.Show("Do you want to save this file?", "Notepad Duplicate",
                    MessageBoxButtons.YesNoCancel);
                if (dialog == DialogResult.Yes)
                {
                    SaveStripMenu_Click(sender, e);
                    Application.Exit();

                }
                else if (dialog == DialogResult.No)
                {
                    Application.Exit();
                }
                else if (dialog == DialogResult.Cancel)
                {

                }
            }
            else
            {
                Application.Exit();
            }
        }
        ////////////////////////
        //File Tool Strip Menu//
        ////////////////////////


        ////////////////////////
        //Edit Tool Strip Menu//
        ////////////////////////

        private void EditMenu_Click(object sender, EventArgs e)
        {
            if (richNotepad.SelectedText.Length > 0)
            {
                CutMenu.Enabled = true;
                CopyMenu.Enabled = true;
                DeleteMenu.Enabled = true;
            }
            else
            {
                CutMenu.Enabled = false;
                CopyMenu.Enabled = false;
                DeleteMenu.Enabled = false;
            }

        }

        private void UndoMenu_Click(object sender, EventArgs e)
        {
            richNotepad.Undo();
        }
        private void CutMenu_Click(object sender, EventArgs e)
        {
            richNotepad.Cut();
        }
        private void CopyMenu_Click(object sender, EventArgs e)
        {
            richNotepad.Copy();
        }
        private void PasteMenu_Click(object sender, EventArgs e)
        {
            richNotepad.Paste();
        }
        private void DeleteMenu_Click(object sender, EventArgs e)
        {
            richNotepad.SelectedText = "";
        }

        private void SelectAllMenu_Click(object sender, EventArgs e)
        {
            richNotepad.SelectAll();
            richNotepad.Focus();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            DateTime date_time = DateTime.Now;
            richNotepad.Text = richNotepad.Text.Insert(richNotepad.SelectionStart, date_time.ToString("h:mm ttt MM/dd/yyyy"));
        }

        ////////////////////////
        //Edit Tool Strip Menu//
        ////////////////////////


        //////////////////////////
        //Format Tool Strip Menu//
        //////////////////////////
        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (wordWrap.CheckState)
            {
                case CheckState.Checked:
                    wordWrap.Checked = true;
                    richNotepad.WordWrap = true;
                    break;
                case CheckState.Unchecked:
                    wordWrap.Checked = false;
                    richNotepad.WordWrap = false;
                    break;
            }
        }
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontdlg = new FontDialog();
            fontdlg.Font = richNotepad.Font;
            if (fontdlg.ShowDialog() == DialogResult.OK)
            {
                richNotepad.Font = fontdlg.Font;
                richNotepad.SelectionFont = fontdlg.Font;
            }
        }

        //////////////////////////
        //Format Tool Strip Menu//
        //////////////////////////


        ////////////////////////
        //View Tool Strip Menu//
        ////////////////////////
        private void StatusBarItem_Click(object sender, EventArgs e)
        {

            switch (StatusBarItem.CheckState)
            {
                case CheckState.Checked:
                    StatusBarItem.Checked = true;
                    statusStrip1.Visible = true;
                    break;
                case CheckState.Unchecked:
                    StatusBarItem.Checked = false;
                    statusStrip1.Visible = false;
                    break;
            }
        }

        ////////////////////////
        //View Tool Strip Menu//
        ////////////////////////


        private void MainForm_Load(object sender, EventArgs e)
        {
            Line.Text = "Line 1, Column 1";
            richNotepad.AllowDrop = true;
            richNotepad.DragDrop += richNotepad_DragDrop;
        }

        private void richNotepad_DragDrop(object sender,DragEventArgs e)
        {
            string[] data = e.Data.GetData(DataFormats.FileDrop) as string[];
            string DDFilename = data[0];
              if (richNotepad.Modified  && (filesave==false))
            {
                DialogResult dialog = MessageBox.Show("Do you want to save this file?", "Notepad Duplicate",
                    MessageBoxButtons.YesNoCancel);
                if (dialog == DialogResult.Yes)
                {
                        SaveStripMenu_Click(sender, e);
                        StreamReader read = new StreamReader(File.OpenRead(DDFilename));
                        FileInfo f1 = new FileInfo(DDFilename);
                        FileName = DDFilename;
                        richNotepad.Text = read.ReadToEnd();
                        this.Text = string.Format("{0} " + "- Notepad Duplicate", f1.Name);
                        read.Dispose();
                    
                }
                else if (dialog == DialogResult.No)
                {          
                        StreamReader read = new StreamReader(File.OpenRead(DDFilename));
                        FileInfo f1 = new FileInfo(DDFilename);
                        FileName = DDFilename;
                        richNotepad.Text = read.ReadToEnd();
                        this.Text = string.Format("{0} " + "- Notepad Duplicate", f1.Name);
                        read.Dispose();
                        if (richNotepad.Modified)
                        {
                            this.Text = string.Format("*{0} " + "- Notepad Duplicate",
                            f1.Name);
                        }
                }
                else if (dialog == DialogResult.Cancel)
                {

                }

            }
            else 
            {
            
                    StreamReader read = new StreamReader(File.OpenRead(DDFilename));
                    FileInfo f1 = new FileInfo(DDFilename);
                    FileName = DDFilename;
                    richNotepad.Text = read.ReadToEnd();
                    this.Text = string.Format("{0} " + "- Notepad Duplicate", f1.Name);
                    read.Dispose(); 
                
            }
        }

        private void richNotepad_SelectionChanged(object sender, EventArgs e)
        {

            int pos = richNotepad.SelectionStart;
            int line = richNotepad.GetLineFromCharIndex(pos) + 1;
            int col = pos - richNotepad.GetFirstCharIndexOfCurrentLine() + 1;

            Line.Text = "Line " + line + ", Column " + col;
        }

        private void richNotepad_MouseUp(object sender, MouseEventArgs e)
        {
            int pos = richNotepad.SelectionStart;
            int line = richNotepad.GetLineFromCharIndex(pos) + 1;
            int col = pos - richNotepad.GetFirstCharIndexOfCurrentLine() + 1;

            Line.Text = "Line " + line + ", Column " + col;
        }

        private void richNotepad_MouseMove(object sender, MouseEventArgs e)
        {
            int pos = richNotepad.SelectionStart;
            int line = richNotepad.GetLineFromCharIndex(pos) + 1;
            int col = pos - richNotepad.GetFirstCharIndexOfCurrentLine() + richNotepad.SelectedText.Count() + 1;

            Line.Text = "Line " + line + ", Column " + col;
        }

        private void richNotepad_TextChanged(object sender, EventArgs e)
        {
            if (richNotepad.Text.Length == 0 && (this.Text == "*Untitled - Notepad Duplicate"))
            {
                richNotepad.Modified = false;
                this.Text = "Untitled - Notepad Duplicate";
            }
            else if (richNotepad.Modified && (this.Text=="Untitled - Notepad Duplicate"))
            {
                filesave = false;
                this.Text = "*" + "Untitled - Notepad Duplicate";
            }
            else if (richNotepad.Modified && (this.Text!="*Untitled - Notepad Duplicate"))
            {
                filesave = false;
                FileInfo file = new FileInfo(FileName);
                this.Text = "*" + String.Format("{0}" + " - Notepad Duplicate",file.Name);
            }
        }

        ////////////////////////
        ///Context Menu Strip///
        ////////////////////////


        private void UndoToolStrip_Click(object sender, EventArgs e)
        {
            UndoMenu_Click(sender, e);
        }

        private void CutToolStrip_Click(object sender, EventArgs e)
        {
            CutMenu_Click(sender, e);
        }

        private void CopyToolStrip_Click(object sender, EventArgs e)
        {
            CopyMenu_Click(sender, e);
        }

        private void PasteToolStrip_Click(object sender, EventArgs e)
        {
            PasteMenu_Click(sender, e);
        }

        private void DeleteStripTool_Click(object sender, EventArgs e)
        {
            DeleteMenu_Click(sender, e);
        }

        private void SelectAllToolStrip_Click(object sender, EventArgs e)
        {
            SelectAllMenu_Click(sender, e);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (richNotepad.SelectedText.Length > 0)
            {
                CopyToolStrip.Enabled = true;
                CutToolStrip.Enabled = true;
                DeleteStripTool.Enabled = true;
            }
            if (richNotepad.SelectedText.Length == 0)
            {
                CopyToolStrip.Enabled = false;
                CutToolStrip.Enabled = false;
                DeleteStripTool.Enabled = false;
            }
            if (richNotepad.Modified)
            {
                UndoToolStrip.Enabled = true;
            }
            if (richNotepad.Text.Length > 0)
            {
                SelectAllToolStrip.Enabled = true;
            }
            if (richNotepad.Text.Length == 0)
            {
                SelectAllToolStrip.Enabled = false;
            }
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (richNotepad.Modified && (filesave == false))
            {
                DialogResult dialog = MessageBox.Show("Do you want to save this file?", "Notepad Duplicate",
                    MessageBoxButtons.YesNoCancel);
                if (dialog == DialogResult.Yes)
                {
                    SaveStripMenu_Click(sender, e);

                }
                else if (dialog == DialogResult.No)
                {

                }
                else if (dialog == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
            else
            {

            }
        }


        ////////////////////////
        ///Context Menu Strip///
        ////////////////////////    
    }
}

