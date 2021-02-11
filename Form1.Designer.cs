namespace final_3_hopefullylast03
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshUpdateListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importSongToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.resumeToolStripMenuItem,
            this.removeSongToolStripMenuItem,
            this.randomSongToolStripMenuItem,
            this.refreshUpdateListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(128, 427);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importSongToolStripMenuItem
            // 
            this.importSongToolStripMenuItem.Name = "importSongToolStripMenuItem";
            this.importSongToolStripMenuItem.Size = new System.Drawing.Size(115, 19);
            this.importSongToolStripMenuItem.Text = "Import Song";
            this.importSongToolStripMenuItem.Click += new System.EventHandler(this.importSongToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(115, 19);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // resumeToolStripMenuItem
            // 
            this.resumeToolStripMenuItem.Name = "resumeToolStripMenuItem";
            this.resumeToolStripMenuItem.Size = new System.Drawing.Size(115, 19);
            this.resumeToolStripMenuItem.Text = "Play/Resume";
            this.resumeToolStripMenuItem.Click += new System.EventHandler(this.resumeToolStripMenuItem_Click);
            // 
            // removeSongToolStripMenuItem
            // 
            this.removeSongToolStripMenuItem.Name = "removeSongToolStripMenuItem";
            this.removeSongToolStripMenuItem.Size = new System.Drawing.Size(115, 19);
            this.removeSongToolStripMenuItem.Text = "Remove Song";
            this.removeSongToolStripMenuItem.Click += new System.EventHandler(this.removeSongToolStripMenuItem_Click);
            // 
            // randomSongToolStripMenuItem
            // 
            this.randomSongToolStripMenuItem.Name = "randomSongToolStripMenuItem";
            this.randomSongToolStripMenuItem.Size = new System.Drawing.Size(115, 19);
            this.randomSongToolStripMenuItem.Text = "Random Song";
            this.randomSongToolStripMenuItem.Click += new System.EventHandler(this.randomSongToolStripMenuItem_Click);
            // 
            // refreshUpdateListToolStripMenuItem
            // 
            this.refreshUpdateListToolStripMenuItem.Name = "refreshUpdateListToolStripMenuItem";
            this.refreshUpdateListToolStripMenuItem.Size = new System.Drawing.Size(115, 19);
            this.refreshUpdateListToolStripMenuItem.Text = "Refresh/Update List";
            this.refreshUpdateListToolStripMenuItem.Click += new System.EventHandler(this.refreshUpdateListToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(131, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(446, 300);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(131, 296);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(446, 131);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 65);
            this.button2.TabIndex = 5;
            this.button2.Text = "HOW TO :";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(577, 427);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(593, 466);
            this.MinimumSize = new System.Drawing.Size(593, 466);
            this.Name = "Form1";
            this.Text = "Issolation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSongToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ToolStripMenuItem randomSongToolStripMenuItem;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem refreshUpdateListToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

