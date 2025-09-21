
namespace Notepad_Duplicate
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.PageSetupStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.CutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectAllMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeAndDateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.formatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Line = new System.Windows.Forms.ToolStripStatusLabel();
            this.WriteTextBox = new System.Windows.Forms.RichTextBox();
            this.richNotepad = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UndoToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.CutToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteStripTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectAllToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.EditMenu,
            this.formatMenu,
            this.ViewMenu});
            resources.ApplyResources(this.menuStrip2, "menuStrip2");
            this.menuStrip2.Name = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStripMenu,
            this.OpenStripMenu,
            this.toolStripMenuItem2,
            this.SaveStripMenu,
            this.SaveAsStripMenu,
            this.toolStripMenuItem5,
            this.PageSetupStripMenu,
            this.PrintStripMenu,
            this.toolStripMenuItem8,
            this.ExitStripMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // newStripMenu
            // 
            this.newStripMenu.Name = "newStripMenu";
            resources.ApplyResources(this.newStripMenu, "newStripMenu");
            this.newStripMenu.Click += new System.EventHandler(this.newStripMenu_Click);
            // 
            // OpenStripMenu
            // 
            this.OpenStripMenu.Name = "OpenStripMenu";
            resources.ApplyResources(this.OpenStripMenu, "OpenStripMenu");
            this.OpenStripMenu.Click += new System.EventHandler(this.OpenStripMenu_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // SaveStripMenu
            // 
            this.SaveStripMenu.Name = "SaveStripMenu";
            resources.ApplyResources(this.SaveStripMenu, "SaveStripMenu");
            this.SaveStripMenu.Click += new System.EventHandler(this.SaveStripMenu_Click);
            // 
            // SaveAsStripMenu
            // 
            this.SaveAsStripMenu.Name = "SaveAsStripMenu";
            resources.ApplyResources(this.SaveAsStripMenu, "SaveAsStripMenu");
            this.SaveAsStripMenu.Click += new System.EventHandler(this.SaveAsStripMenu_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            // 
            // PageSetupStripMenu
            // 
            this.PageSetupStripMenu.Name = "PageSetupStripMenu";
            resources.ApplyResources(this.PageSetupStripMenu, "PageSetupStripMenu");
            this.PageSetupStripMenu.Click += new System.EventHandler(this.PageSetupStripMenu_Click);
            // 
            // PrintStripMenu
            // 
            this.PrintStripMenu.Name = "PrintStripMenu";
            resources.ApplyResources(this.PrintStripMenu, "PrintStripMenu");
            this.PrintStripMenu.Click += new System.EventHandler(this.PrintStripMenu_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            resources.ApplyResources(this.toolStripMenuItem8, "toolStripMenuItem8");
            // 
            // ExitStripMenu
            // 
            this.ExitStripMenu.Name = "ExitStripMenu";
            resources.ApplyResources(this.ExitStripMenu, "ExitStripMenu");
            this.ExitStripMenu.Click += new System.EventHandler(this.ExitStripMenu_Click);
            // 
            // EditMenu
            // 
            this.EditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoMenu,
            this.toolStripMenuItem4,
            this.CutMenu,
            this.CopyMenu,
            this.PasteMenu,
            this.DeleteMenu,
            this.toolStripMenuItem7,
            this.SelectAllMenu,
            this.TimeAndDateMenu});
            this.EditMenu.Name = "EditMenu";
            resources.ApplyResources(this.EditMenu, "EditMenu");
            this.EditMenu.Click += new System.EventHandler(this.EditMenu_Click);
            // 
            // UndoMenu
            // 
            this.UndoMenu.Name = "UndoMenu";
            resources.ApplyResources(this.UndoMenu, "UndoMenu");
            this.UndoMenu.Click += new System.EventHandler(this.UndoMenu_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            // 
            // CutMenu
            // 
            resources.ApplyResources(this.CutMenu, "CutMenu");
            this.CutMenu.Name = "CutMenu";
            this.CutMenu.Click += new System.EventHandler(this.CutMenu_Click);
            // 
            // CopyMenu
            // 
            resources.ApplyResources(this.CopyMenu, "CopyMenu");
            this.CopyMenu.Name = "CopyMenu";
            this.CopyMenu.Click += new System.EventHandler(this.CopyMenu_Click);
            // 
            // PasteMenu
            // 
            this.PasteMenu.Name = "PasteMenu";
            resources.ApplyResources(this.PasteMenu, "PasteMenu");
            this.PasteMenu.Click += new System.EventHandler(this.PasteMenu_Click);
            // 
            // DeleteMenu
            // 
            resources.ApplyResources(this.DeleteMenu, "DeleteMenu");
            this.DeleteMenu.Name = "DeleteMenu";
            this.DeleteMenu.Click += new System.EventHandler(this.DeleteMenu_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            resources.ApplyResources(this.toolStripMenuItem7, "toolStripMenuItem7");
            // 
            // SelectAllMenu
            // 
            this.SelectAllMenu.Name = "SelectAllMenu";
            resources.ApplyResources(this.SelectAllMenu, "SelectAllMenu");
            this.SelectAllMenu.Click += new System.EventHandler(this.SelectAllMenu_Click);
            // 
            // TimeAndDateMenu
            // 
            this.TimeAndDateMenu.Name = "TimeAndDateMenu";
            resources.ApplyResources(this.TimeAndDateMenu, "TimeAndDateMenu");
            this.TimeAndDateMenu.Click += new System.EventHandler(this.toolStripMenuItem15_Click);
            // 
            // formatMenu
            // 
            this.formatMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordWrap,
            this.fontToolStripMenuItem});
            this.formatMenu.Name = "formatMenu";
            resources.ApplyResources(this.formatMenu, "formatMenu");
            // 
            // wordWrap
            // 
            this.wordWrap.Checked = true;
            this.wordWrap.CheckOnClick = true;
            this.wordWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wordWrap.Name = "wordWrap";
            resources.ApplyResources(this.wordWrap, "wordWrap");
            this.wordWrap.Click += new System.EventHandler(this.wordWrapToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            resources.ApplyResources(this.fontToolStripMenuItem, "fontToolStripMenuItem");
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // ViewMenu
            // 
            this.ViewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarItem});
            this.ViewMenu.Name = "ViewMenu";
            resources.ApplyResources(this.ViewMenu, "ViewMenu");
            // 
            // StatusBarItem
            // 
            this.StatusBarItem.Checked = true;
            this.StatusBarItem.CheckOnClick = true;
            this.StatusBarItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StatusBarItem.Name = "StatusBarItem";
            resources.ApplyResources(this.StatusBarItem, "StatusBarItem");
            this.StatusBarItem.Click += new System.EventHandler(this.StatusBarItem_Click);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Line});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // Line
            // 
            this.Line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Line.Name = "Line";
            resources.ApplyResources(this.Line, "Line");
            this.Line.Spring = true;
            // 
            // WriteTextBox
            // 
            resources.ApplyResources(this.WriteTextBox, "WriteTextBox");
            this.WriteTextBox.Name = "WriteTextBox";
            // 
            // richNotepad
            // 
            this.richNotepad.ContextMenuStrip = this.contextMenuStrip1;
            this.richNotepad.DetectUrls = false;
            resources.ApplyResources(this.richNotepad, "richNotepad");
            this.richNotepad.Name = "richNotepad";
            this.richNotepad.SelectionChanged += new System.EventHandler(this.richNotepad_SelectionChanged);
            this.richNotepad.TextChanged += new System.EventHandler(this.richNotepad_TextChanged);
            this.richNotepad.MouseMove += new System.Windows.Forms.MouseEventHandler(this.richNotepad_MouseMove);
            this.richNotepad.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richNotepad_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AllowDrop = true;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoToolStrip,
            this.toolStripMenuItem3,
            this.CutToolStrip,
            this.CopyToolStrip,
            this.PasteToolStrip,
            this.DeleteStripTool,
            this.toolStripMenuItem9,
            this.SelectAllToolStrip});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // UndoToolStrip
            // 
            resources.ApplyResources(this.UndoToolStrip, "UndoToolStrip");
            this.UndoToolStrip.Name = "UndoToolStrip";
            this.UndoToolStrip.Click += new System.EventHandler(this.UndoToolStrip_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // CutToolStrip
            // 
            resources.ApplyResources(this.CutToolStrip, "CutToolStrip");
            this.CutToolStrip.Name = "CutToolStrip";
            this.CutToolStrip.Click += new System.EventHandler(this.CutToolStrip_Click);
            // 
            // CopyToolStrip
            // 
            resources.ApplyResources(this.CopyToolStrip, "CopyToolStrip");
            this.CopyToolStrip.Name = "CopyToolStrip";
            this.CopyToolStrip.Click += new System.EventHandler(this.CopyToolStrip_Click);
            // 
            // PasteToolStrip
            // 
            this.PasteToolStrip.Name = "PasteToolStrip";
            resources.ApplyResources(this.PasteToolStrip, "PasteToolStrip");
            this.PasteToolStrip.Click += new System.EventHandler(this.PasteToolStrip_Click);
            // 
            // DeleteStripTool
            // 
            resources.ApplyResources(this.DeleteStripTool, "DeleteStripTool");
            this.DeleteStripTool.Name = "DeleteStripTool";
            this.DeleteStripTool.Click += new System.EventHandler(this.DeleteStripTool_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            resources.ApplyResources(this.toolStripMenuItem9, "toolStripMenuItem9");
            // 
            // SelectAllToolStrip
            // 
            resources.ApplyResources(this.SelectAllToolStrip, "SelectAllToolStrip");
            this.SelectAllToolStrip.Name = "SelectAllToolStrip";
            this.SelectAllToolStrip.Click += new System.EventHandler(this.SelectAllToolStrip_Click);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.richNotepad);
            this.Controls.Add(this.WriteTextBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.RichTextBox WriteText;
        private System.Windows.Forms.ToolStripSeparator saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator timeDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeDateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStripMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenStripMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem SaveStripMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveAsStripMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem PageSetupStripMenu;
        private System.Windows.Forms.ToolStripMenuItem PrintStripMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem ExitStripMenu;
        private System.Windows.Forms.ToolStripMenuItem EditMenu;
        private System.Windows.Forms.ToolStripMenuItem UndoMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem CutMenu;
        private System.Windows.Forms.ToolStripMenuItem CopyMenu;
        private System.Windows.Forms.ToolStripMenuItem PasteMenu;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem SelectAllMenu;
        private System.Windows.Forms.ToolStripMenuItem TimeAndDateMenu;
        private System.Windows.Forms.ToolStripMenuItem formatMenu;
        private System.Windows.Forms.ToolStripMenuItem wordWrap;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewMenu;
        private System.Windows.Forms.ToolStripMenuItem StatusBarItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.RichTextBox WriteTextBox;
        private System.Windows.Forms.RichTextBox richNotepad;
        private System.Windows.Forms.ToolStripStatusLabel Line;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UndoToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem CutToolStrip;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStrip;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStrip;
        private System.Windows.Forms.ToolStripMenuItem DeleteStripTool;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem SelectAllToolStrip;
    }
}

