﻿namespace EditTools.TaskPane
{
    partial class Comments
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comments));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvComments = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbApplyAll = new System.Windows.Forms.ToolStripButton();
            this.tsbRemoveAll = new System.Windows.Forms.ToolStripButton();
            this.tsbImport = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "comment.png");
            this.imageList1.Images.SetKeyName(1, "book_open.png");
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dgvComments, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(650, 750);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // dgvComments
            // 
            this.dgvComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComments.Location = new System.Drawing.Point(3, 38);
            this.dgvComments.Name = "dgvComments";
            this.dgvComments.Size = new System.Drawing.Size(644, 709);
            this.dgvComments.TabIndex = 5;
            this.dgvComments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComments_CellContentClick);
            this.dgvComments.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComments_CellEnter);
            this.dgvComments.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComments_CellLeave);
            this.dgvComments.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvComments_CellPainting);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbApplyAll,
            this.tsbRemoveAll,
            this.tsbImport,
            this.tsbExport});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(5, 5);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(645, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tsbSave.Size = new System.Drawing.Size(55, 22);
            this.tsbSave.Text = "Save";
            this.tsbSave.ToolTipText = "Save the Add-In settings";
            this.tsbSave.Visible = false;
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbApplyAll
            // 
            this.tsbApplyAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbApplyAll.Image")));
            this.tsbApplyAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbApplyAll.Name = "tsbApplyAll";
            this.tsbApplyAll.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tsbApplyAll.Size = new System.Drawing.Size(79, 22);
            this.tsbApplyAll.Text = "Apply All";
            this.tsbApplyAll.ToolTipText = "Apply all matching comments in the active document";
            this.tsbApplyAll.Click += new System.EventHandler(this.tsbApplyAll_Click);
            // 
            // tsbRemoveAll
            // 
            this.tsbRemoveAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemoveAll.Image")));
            this.tsbRemoveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveAll.Name = "tsbRemoveAll";
            this.tsbRemoveAll.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tsbRemoveAll.Size = new System.Drawing.Size(91, 22);
            this.tsbRemoveAll.Text = "Remove All";
            this.tsbRemoveAll.ToolTipText = "Remove all the comments from the active document";
            this.tsbRemoveAll.Click += new System.EventHandler(this.tsbRemoveAll_Click);
            // 
            // tsbImport
            // 
            this.tsbImport.Image = ((System.Drawing.Image)(resources.GetObject("tsbImport.Image")));
            this.tsbImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImport.Name = "tsbImport";
            this.tsbImport.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tsbImport.Size = new System.Drawing.Size(67, 22);
            this.tsbImport.Text = "Import";
            this.tsbImport.Click += new System.EventHandler(this.tsbImport_Click);
            // 
            // tsbExport
            // 
            this.tsbExport.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport.Image")));
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tsbExport.Size = new System.Drawing.Size(64, 22);
            this.tsbExport.Text = "Export";
            this.tsbExport.Click += new System.EventHandler(this.tsbExport_Click);
            // 
            // Comments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Comments";
            this.Size = new System.Drawing.Size(650, 750);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvComments;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbApplyAll;
        private System.Windows.Forms.ToolStripButton tsbRemoveAll;
        private System.Windows.Forms.ToolStripButton tsbImport;
        private System.Windows.Forms.ToolStripButton tsbExport;
    }
}
