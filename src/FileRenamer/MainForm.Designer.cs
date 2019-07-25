namespace FileRenamer
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
            this.fbdSource = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSource = new System.Windows.Forms.Button();
            this.tbxSource = new System.Windows.Forms.TextBox();
            this.lvwSource = new System.Windows.Forms.ListView();
            this.chdFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbxRegex = new System.Windows.Forms.TextBox();
            this.lblRegex = new System.Windows.Forms.Label();
            this.lblReplace = new System.Windows.Forms.Label();
            this.tbxReplacement = new System.Windows.Forms.TextBox();
            this.lvwPreview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGo = new System.Windows.Forms.Button();
            this.tlpLists = new System.Windows.Forms.TableLayoutPanel();
            this.erpGeneral = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlpLists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(12, 12);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(128, 20);
            this.btnSource.TabIndex = 0;
            this.btnSource.Text = "Folder...";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.BtnSource_Click);
            // 
            // tbxSource
            // 
            this.tbxSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSource.Location = new System.Drawing.Point(146, 13);
            this.tbxSource.Name = "tbxSource";
            this.tbxSource.Size = new System.Drawing.Size(592, 20);
            this.tbxSource.TabIndex = 1;
            // 
            // lvwSource
            // 
            this.lvwSource.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chdFilePath});
            this.lvwSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwSource.Location = new System.Drawing.Point(3, 3);
            this.lvwSource.Name = "lvwSource";
            this.lvwSource.Size = new System.Drawing.Size(358, 440);
            this.lvwSource.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwSource.TabIndex = 2;
            this.lvwSource.UseCompatibleStateImageBehavior = false;
            this.lvwSource.View = System.Windows.Forms.View.Details;
            // 
            // chdFilePath
            // 
            this.chdFilePath.Text = "Path";
            this.chdFilePath.Width = 1000;
            // 
            // tbxRegex
            // 
            this.tbxRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRegex.Location = new System.Drawing.Point(146, 48);
            this.tbxRegex.Name = "tbxRegex";
            this.tbxRegex.Size = new System.Drawing.Size(592, 20);
            this.tbxRegex.TabIndex = 3;
            this.tbxRegex.TextChanged += new System.EventHandler(this.TbxRegex_TextChanged);
            // 
            // lblRegex
            // 
            this.lblRegex.AutoSize = true;
            this.lblRegex.Location = new System.Drawing.Point(90, 48);
            this.lblRegex.Name = "lblRegex";
            this.lblRegex.Size = new System.Drawing.Size(38, 13);
            this.lblRegex.TabIndex = 4;
            this.lblRegex.Text = "Regex";
            this.lblRegex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(58, 79);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(70, 13);
            this.lblReplace.TabIndex = 6;
            this.lblReplace.Text = "Replacement";
            this.lblReplace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxReplacement
            // 
            this.tbxReplacement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxReplacement.Location = new System.Drawing.Point(146, 79);
            this.tbxReplacement.Name = "tbxReplacement";
            this.tbxReplacement.Size = new System.Drawing.Size(592, 20);
            this.tbxReplacement.TabIndex = 5;
            this.tbxReplacement.TextChanged += new System.EventHandler(this.TbxReplacement_TextChanged);
            // 
            // lvwPreview
            // 
            this.lvwPreview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvwPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwPreview.Location = new System.Drawing.Point(367, 3);
            this.lvwPreview.Name = "lvwPreview";
            this.lvwPreview.Size = new System.Drawing.Size(359, 440);
            this.lvwPreview.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwPreview.TabIndex = 7;
            this.lvwPreview.UseCompatibleStateImageBehavior = false;
            this.lvwPreview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Path";
            this.columnHeader1.Width = 1000;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGo.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGo.Location = new System.Drawing.Point(15, 589);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(128, 51);
            this.btnGo.TabIndex = 8;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // tlpLists
            // 
            this.tlpLists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLists.ColumnCount = 2;
            this.tlpLists.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLists.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLists.Controls.Add(this.lvwPreview, 1, 0);
            this.tlpLists.Controls.Add(this.lvwSource, 0, 0);
            this.tlpLists.Location = new System.Drawing.Point(12, 137);
            this.tlpLists.Name = "tlpLists";
            this.tlpLists.RowCount = 1;
            this.tlpLists.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLists.Size = new System.Drawing.Size(729, 446);
            this.tlpLists.TabIndex = 10;
            // 
            // erpGeneral
            // 
            this.erpGeneral.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 652);
            this.Controls.Add(this.tlpLists);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.tbxReplacement);
            this.Controls.Add(this.lblRegex);
            this.Controls.Add(this.tbxRegex);
            this.Controls.Add(this.tbxSource);
            this.Controls.Add(this.btnSource);
            this.Name = "MainForm";
            this.Text = "File Renamer";
            this.tlpLists.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdSource;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.TextBox tbxSource;
        private System.Windows.Forms.ListView lvwSource;
        private System.Windows.Forms.ColumnHeader chdFilePath;
        private System.Windows.Forms.TextBox tbxRegex;
        private System.Windows.Forms.Label lblRegex;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.TextBox tbxReplacement;
        private System.Windows.Forms.ListView lvwPreview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TableLayoutPanel tlpLists;
        private System.Windows.Forms.ErrorProvider erpGeneral;
    }
}

