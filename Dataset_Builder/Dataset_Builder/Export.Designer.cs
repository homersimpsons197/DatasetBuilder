namespace Dataset_Builder
{
    partial class Export
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
            this.pnlHeader_ = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnx = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnldgv = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxext = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblcount = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnsave = new System.Windows.Forms.Button();
            this.lblclear = new System.Windows.Forms.Label();
            this.pnlHeader_.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnldgv.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader_
            // 
            this.pnlHeader_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.pnlHeader_.Controls.Add(this.pnlHeader);
            this.pnlHeader_.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader_.Name = "pnlHeader_";
            this.pnlHeader_.Size = new System.Drawing.Size(800, 37);
            this.pnlHeader_.TabIndex = 2;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Black;
            this.pnlHeader.Controls.Add(this.btnx);
            this.pnlHeader.Location = new System.Drawing.Point(1, 1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(798, 35);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnx
            // 
            this.btnx.BackgroundImage = global::Dataset_Builder.Properties.Resources.x;
            this.btnx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnx.Location = new System.Drawing.Point(765, 5);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(25, 25);
            this.btnx.TabIndex = 0;
            this.btnx.UseVisualStyleBackColor = true;
            this.btnx.Click += new System.EventHandler(this.btnx_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.label,
            this.text});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(1, 1);
            this.dgv.Margin = new System.Windows.Forms.Padding(0);
            this.dgv.MaximumSize = new System.Drawing.Size(782, 318);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv.Size = new System.Drawing.Size(780, 25);
            this.dgv.TabIndex = 3;
            this.dgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
            // 
            // label
            // 
            this.label.HeaderText = "Label";
            this.label.MinimumWidth = 50;
            this.label.Name = "label";
            this.label.ReadOnly = true;
            this.label.Width = 50;
            // 
            // text
            // 
            this.text.HeaderText = "Text";
            this.text.MinimumWidth = 725;
            this.text.Name = "text";
            this.text.ReadOnly = true;
            this.text.Width = 725;
            // 
            // pnldgv
            // 
            this.pnldgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.pnldgv.Controls.Add(this.dgv);
            this.pnldgv.Location = new System.Drawing.Point(5, 50);
            this.pnldgv.MaximumSize = new System.Drawing.Size(782, 320);
            this.pnldgv.Name = "pnldgv";
            this.pnldgv.Padding = new System.Windows.Forms.Padding(1);
            this.pnldgv.Size = new System.Drawing.Size(782, 27);
            this.pnldgv.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Export to";
            // 
            // cboxext
            // 
            this.cboxext.FormattingEnabled = true;
            this.cboxext.Items.AddRange(new object[] {
            ".txt",
            ".csv",
            ".tsv"});
            this.cboxext.Location = new System.Drawing.Point(74, 6);
            this.cboxext.Name = "cboxext";
            this.cboxext.Size = new System.Drawing.Size(80, 23);
            this.cboxext.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(30, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nb of lines:";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.panel9.Location = new System.Drawing.Point(20, 395);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(755, 1);
            this.panel9.TabIndex = 12;
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.BackColor = System.Drawing.Color.Transparent;
            this.lblcount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.lblcount.Location = new System.Drawing.Point(105, 375);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(13, 15);
            this.lblcount.TabIndex = 14;
            this.lblcount.Text = "0";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(0, 408);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 42);
            this.panel5.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.btnsave);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.cboxext);
            this.panel6.Location = new System.Drawing.Point(1, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(798, 40);
            this.panel6.TabIndex = 0;
            // 
            // btnsave
            // 
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnsave.Location = new System.Drawing.Point(715, 5);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 30);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // lblclear
            // 
            this.lblclear.AutoSize = true;
            this.lblclear.BackColor = System.Drawing.Color.Transparent;
            this.lblclear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.lblclear.Location = new System.Drawing.Point(725, 375);
            this.lblclear.Name = "lblclear";
            this.lblclear.Size = new System.Drawing.Size(42, 15);
            this.lblclear.TabIndex = 16;
            this.lblclear.Text = "CLEAR";
            this.lblclear.Click += new System.EventHandler(this.lblclear_Click);
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblclear);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.pnldgv);
            this.Controls.Add(this.pnlHeader_);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Export";
            this.Text = "Export";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Export_FormClosing);
            this.Load += new System.EventHandler(this.Export_Load);
            this.pnlHeader_.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnldgv.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlHeader_;
        private Panel pnlHeader;
        public Button btnx;
        public DataGridView dgv;
        private DataGridViewTextBoxColumn label;
        private DataGridViewTextBoxColumn text;
        public Panel pnldgv;
        private Label label1;
        private ComboBox cboxext;
        private Label label3;
        private Panel panel9;
        private Label lblcount;
        private Panel panel5;
        private Panel panel6;
        public Button btnsave;
        private Label lblclear;
    }
}