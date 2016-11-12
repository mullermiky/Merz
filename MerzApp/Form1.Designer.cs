namespace MerzApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.listOfFiles = new System.Windows.Forms.ListView();
            this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sequence = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLoad,
            this.menuQuit});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(37, 20);
            this.menu.Text = "File";
            // 
            // menuLoad
            // 
            this.menuLoad.Name = "menuLoad";
            this.menuLoad.Size = new System.Drawing.Size(152, 22);
            this.menuLoad.Text = "Load";
            this.menuLoad.Click += new System.EventHandler(this.menuLoad_Click);
            // 
            // menuQuit
            // 
            this.menuQuit.Name = "menuQuit";
            this.menuQuit.Size = new System.Drawing.Size(152, 22);
            this.menuQuit.Text = "Quit";
            this.menuQuit.Click += new System.EventHandler(this.menuQuit_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // listOfFiles
            // 
            this.listOfFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileName,
            this.sequence});
            this.listOfFiles.GridLines = true;
            this.listOfFiles.Location = new System.Drawing.Point(12, 27);
            this.listOfFiles.Name = "listOfFiles";
            this.listOfFiles.Size = new System.Drawing.Size(260, 104);
            this.listOfFiles.TabIndex = 1;
            this.listOfFiles.UseCompatibleStateImageBehavior = false;
            this.listOfFiles.View = System.Windows.Forms.View.Details;
            // 
            // fileName
            // 
            this.fileName.Text = "File Name";
            this.fileName.Width = 200;
            // 
            // sequence
            // 
            this.sequence.Text = "Sequence";
            this.sequence.Width = 80;
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(12, 137);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(260, 229);
            this.mediaPlayer.TabIndex = 2;
            this.mediaPlayer.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.mediaPlayer_OpenStateChange);
            this.mediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.mediaPlayer_PlayStateChange);
            this.mediaPlayer.MediaError += new AxWMPLib._WMPOCXEvents_MediaErrorEventHandler(this.mediaPlayer_MediaError);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 378);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.listOfFiles);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem menuLoad;
        private System.Windows.Forms.ToolStripMenuItem menuQuit;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.ListView listOfFiles;
        private System.Windows.Forms.ColumnHeader fileName;
        private System.Windows.Forms.ColumnHeader sequence;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
    }
}

