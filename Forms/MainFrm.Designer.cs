namespace LibraryLoader
{
    partial class MainFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            ProcessGroupBx = new System.Windows.Forms.GroupBox();
            StatusLbl = new System.Windows.Forms.Label();
            LoadBtn = new System.Windows.Forms.Button();
            AutoBx = new System.Windows.Forms.CheckBox();
            DelayBx = new System.Windows.Forms.NumericUpDown();
            DelayLbl = new System.Windows.Forms.Label();
            BrowseBtn = new System.Windows.Forms.Button();
            FileBx = new System.Windows.Forms.TextBox();
            FileLbl = new System.Windows.Forms.Label();
            RefreshBtn = new System.Windows.Forms.Button();
            PIDBx = new System.Windows.Forms.NumericUpDown();
            ProcessBx = new System.Windows.Forms.ComboBox();
            ProcessLbl = new System.Windows.Forms.Label();
            DelayTmr = new System.Windows.Forms.Timer(components);
            ProcessTmr = new System.Windows.Forms.Timer(components);
            ProcessGroupBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DelayBx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PIDBx).BeginInit();
            SuspendLayout();
            // 
            // ProcessGroupBx
            // 
            ProcessGroupBx.Controls.Add(StatusLbl);
            ProcessGroupBx.Controls.Add(LoadBtn);
            ProcessGroupBx.Controls.Add(AutoBx);
            ProcessGroupBx.Controls.Add(DelayBx);
            ProcessGroupBx.Controls.Add(DelayLbl);
            ProcessGroupBx.Controls.Add(BrowseBtn);
            ProcessGroupBx.Controls.Add(FileBx);
            ProcessGroupBx.Controls.Add(FileLbl);
            ProcessGroupBx.Controls.Add(RefreshBtn);
            ProcessGroupBx.Controls.Add(PIDBx);
            ProcessGroupBx.Controls.Add(ProcessBx);
            ProcessGroupBx.Controls.Add(ProcessLbl);
            ProcessGroupBx.Location = new System.Drawing.Point(19, 14);
            ProcessGroupBx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ProcessGroupBx.Name = "ProcessGroupBx";
            ProcessGroupBx.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ProcessGroupBx.Size = new System.Drawing.Size(707, 226);
            ProcessGroupBx.TabIndex = 0;
            ProcessGroupBx.TabStop = false;
            ProcessGroupBx.Text = "Process";
            // 
            // StatusLbl
            // 
            StatusLbl.BackColor = System.Drawing.Color.Transparent;
            StatusLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            StatusLbl.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            StatusLbl.Location = new System.Drawing.Point(371, 188);
            StatusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            StatusLbl.Name = "StatusLbl";
            StatusLbl.Size = new System.Drawing.Size(321, 42);
            StatusLbl.TabIndex = 20;
            StatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoadBtn
            // 
            LoadBtn.Enabled = false;
            LoadBtn.Location = new System.Drawing.Point(371, 137);
            LoadBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new System.Drawing.Size(321, 42);
            LoadBtn.TabIndex = 18;
            LoadBtn.Text = "Load File";
            LoadBtn.UseVisualStyleBackColor = true;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // AutoBx
            // 
            AutoBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            AutoBx.Location = new System.Drawing.Point(171, 188);
            AutoBx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            AutoBx.Name = "AutoBx";
            AutoBx.Size = new System.Drawing.Size(193, 42);
            AutoBx.TabIndex = 19;
            AutoBx.Text = "Auto load file";
            AutoBx.UseVisualStyleBackColor = true;
            AutoBx.CheckedChanged += AutoBx_CheckedChanged;
            // 
            // DelayBx
            // 
            DelayBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            DelayBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            DelayBx.Location = new System.Drawing.Point(171, 137);
            DelayBx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            DelayBx.Maximum = new decimal(new int[] { 60000, 0, 0, 0 });
            DelayBx.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            DelayBx.Name = "DelayBx";
            DelayBx.Size = new System.Drawing.Size(193, 33);
            DelayBx.TabIndex = 18;
            DelayBx.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            DelayBx.ValueChanged += DelayBx_ValueChanged;
            // 
            // DelayLbl
            // 
            DelayLbl.BackColor = System.Drawing.Color.Transparent;
            DelayLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            DelayLbl.Location = new System.Drawing.Point(7, 137);
            DelayLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DelayLbl.Name = "DelayLbl";
            DelayLbl.Size = new System.Drawing.Size(157, 42);
            DelayLbl.TabIndex = 18;
            DelayLbl.Text = "Auto Delay:";
            DelayLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BrowseBtn
            // 
            BrowseBtn.Location = new System.Drawing.Point(550, 83);
            BrowseBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BrowseBtn.Name = "BrowseBtn";
            BrowseBtn.Size = new System.Drawing.Size(143, 42);
            BrowseBtn.TabIndex = 17;
            BrowseBtn.Text = "Browse";
            BrowseBtn.UseVisualStyleBackColor = true;
            BrowseBtn.Click += BrowseBtn_Click;
            // 
            // FileBx
            // 
            FileBx.BackColor = System.Drawing.Color.WhiteSmoke;
            FileBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            FileBx.Enabled = false;
            FileBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FileBx.Location = new System.Drawing.Point(171, 85);
            FileBx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            FileBx.Name = "FileBx";
            FileBx.ReadOnly = true;
            FileBx.Size = new System.Drawing.Size(371, 33);
            FileBx.TabIndex = 16;
            // 
            // FileLbl
            // 
            FileLbl.BackColor = System.Drawing.Color.Transparent;
            FileLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            FileLbl.Location = new System.Drawing.Point(7, 83);
            FileLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            FileLbl.Name = "FileLbl";
            FileLbl.Size = new System.Drawing.Size(157, 42);
            FileLbl.TabIndex = 15;
            FileLbl.Text = "Selected File:";
            FileLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RefreshBtn
            // 
            RefreshBtn.Location = new System.Drawing.Point(550, 33);
            RefreshBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new System.Drawing.Size(143, 42);
            RefreshBtn.TabIndex = 14;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // PIDBx
            // 
            PIDBx.BackColor = System.Drawing.Color.White;
            PIDBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PIDBx.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            PIDBx.ForeColor = System.Drawing.Color.Black;
            PIDBx.Location = new System.Drawing.Point(451, 33);
            PIDBx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            PIDBx.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            PIDBx.Name = "PIDBx";
            PIDBx.Size = new System.Drawing.Size(91, 33);
            PIDBx.TabIndex = 13;
            PIDBx.Value = new decimal(new int[] { 1, 0, 0, 0 });
            PIDBx.KeyUp += PIDBx_KeyUp;
            // 
            // ProcessBx
            // 
            ProcessBx.BackColor = System.Drawing.Color.White;
            ProcessBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ProcessBx.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            ProcessBx.ForeColor = System.Drawing.Color.Black;
            ProcessBx.FormattingEnabled = true;
            ProcessBx.Location = new System.Drawing.Point(171, 33);
            ProcessBx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ProcessBx.Name = "ProcessBx";
            ProcessBx.Size = new System.Drawing.Size(267, 36);
            ProcessBx.TabIndex = 12;
            ProcessBx.SelectedValueChanged += ProcessBx_SelectedValueChanged;
            // 
            // ProcessLbl
            // 
            ProcessLbl.BackColor = System.Drawing.Color.Transparent;
            ProcessLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            ProcessLbl.Location = new System.Drawing.Point(7, 33);
            ProcessLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ProcessLbl.Name = "ProcessLbl";
            ProcessLbl.Size = new System.Drawing.Size(157, 42);
            ProcessLbl.TabIndex = 11;
            ProcessLbl.Text = "Process/PID:";
            ProcessLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DelayTmr
            // 
            DelayTmr.Interval = 10000;
            DelayTmr.Tick += DelayTmr_Tick;
            // 
            // ProcessTmr
            // 
            ProcessTmr.Interval = 1500;
            ProcessTmr.Tick += ProcessTmr_Tick;
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(746, 252);
            Controls.Add(ProcessGroupBx);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "MainFrm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "imattas's Library Loader";
            Load += MainFrm_Load;
            ProcessGroupBx.ResumeLayout(false);
            ProcessGroupBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DelayBx).EndInit();
            ((System.ComponentModel.ISupportInitialize)PIDBx).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox ProcessGroupBx;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.NumericUpDown PIDBx;
        private System.Windows.Forms.ComboBox ProcessBx;
        private System.Windows.Forms.Label ProcessLbl;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.TextBox FileBx;
        private System.Windows.Forms.Label FileLbl;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.CheckBox AutoBx;
        private System.Windows.Forms.NumericUpDown DelayBx;
        private System.Windows.Forms.Label DelayLbl;
        private System.Windows.Forms.Timer DelayTmr;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Timer ProcessTmr;
        private System.Windows.Forms.PictureBox FileImg;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
