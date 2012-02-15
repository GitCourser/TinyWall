﻿namespace PKSoft
{
    partial class ConnectionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionsForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuUnblock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloseProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.IconList = new System.Windows.Forms.ImageList(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.chkShowListen = new System.Windows.Forms.CheckBox();
            this.chkShowActive = new System.Windows.Forms.CheckBox();
            this.chkShowBlocked = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // list
            // 
            resources.ApplyResources(this.list, "list");
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.list.ContextMenuStrip = this.contextMenuStrip1;
            this.list.FullRowSelect = true;
            this.list.GridLines = true;
            this.list.Name = "list";
            this.list.ShowItemToolTips = true;
            this.list.SmallImageList = this.IconList;
            this.list.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.list_ColumnClick);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // columnHeader6
            // 
            resources.ApplyResources(this.columnHeader6, "columnHeader6");
            // 
            // columnHeader7
            // 
            resources.ApplyResources(this.columnHeader7, "columnHeader7");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUnblock,
            this.mnuCloseProcess});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // mnuUnblock
            // 
            this.mnuUnblock.Image = global::PKSoft.Resources.Icons.executable;
            this.mnuUnblock.Name = "mnuUnblock";
            resources.ApplyResources(this.mnuUnblock, "mnuUnblock");
            this.mnuUnblock.Click += new System.EventHandler(this.mnuUnblock_Click);
            // 
            // mnuCloseProcess
            // 
            this.mnuCloseProcess.Image = global::PKSoft.Resources.Icons.exit;
            this.mnuCloseProcess.Name = "mnuCloseProcess";
            resources.ApplyResources(this.mnuCloseProcess, "mnuCloseProcess");
            this.mnuCloseProcess.Click += new System.EventHandler(this.mnuCloseProcess_Click);
            // 
            // IconList
            // 
            this.IconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.IconList, "IconList");
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnRefresh
            // 
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // chkShowListen
            // 
            resources.ApplyResources(this.chkShowListen, "chkShowListen");
            this.chkShowListen.Name = "chkShowListen";
            this.chkShowListen.UseVisualStyleBackColor = true;
            this.chkShowListen.CheckedChanged += new System.EventHandler(this.chkShowListen_CheckedChanged);
            // 
            // chkShowActive
            // 
            resources.ApplyResources(this.chkShowActive, "chkShowActive");
            this.chkShowActive.Checked = true;
            this.chkShowActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowActive.Name = "chkShowActive";
            this.chkShowActive.UseVisualStyleBackColor = true;
            this.chkShowActive.CheckedChanged += new System.EventHandler(this.chkShowActive_CheckedChanged);
            // 
            // chkShowBlocked
            // 
            resources.ApplyResources(this.chkShowBlocked, "chkShowBlocked");
            this.chkShowBlocked.Name = "chkShowBlocked";
            this.chkShowBlocked.UseVisualStyleBackColor = true;
            this.chkShowBlocked.CheckedChanged += new System.EventHandler(this.chkShowBlocked_CheckedChanged);
            // 
            // ConnectionsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkShowBlocked);
            this.Controls.Add(this.chkShowActive);
            this.Controls.Add(this.chkShowListen);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.list);
            this.Controls.Add(this.btnClose);
            this.Name = "ConnectionsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnectionsForm_FormClosing);
            this.Load += new System.EventHandler(this.ConnectionsForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ImageList IconList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.CheckBox chkShowListen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseProcess;
        private System.Windows.Forms.CheckBox chkShowActive;
        private System.Windows.Forms.CheckBox chkShowBlocked;
        private System.Windows.Forms.ToolStripMenuItem mnuUnblock;
    }
}