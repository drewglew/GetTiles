namespace GetTiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonUpload = new System.Windows.Forms.Button();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxLocalFolder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownZ = new System.Windows.Forms.NumericUpDown();
            this.checkBoxXEnabled = new System.Windows.Forms.CheckBox();
            this.checkBoxYEnabled = new System.Windows.Forms.CheckBox();
            this.checkBoxZEnabled = new System.Windows.Forms.CheckBox();
            this.listBoxIssues = new System.Windows.Forms.ListBox();
            this.labelIssues = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(657, 420);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(75, 23);
            this.buttonUpload.TabIndex = 0;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(97, 44);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(635, 20);
            this.textBoxUrl.TabIndex = 1;
            this.textBoxUrl.Text = "https://www.hostedtiles.com/styles/basic/{0}/{1}/{2}.png?key=secret";
            this.textBoxUrl.Enter += new System.EventHandler(this.textBoxUrl_Enter);
            this.textBoxUrl.Leave += new System.EventHandler(this.textBoxUrl1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "WebSite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "X (Zoom Level)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y (Column)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Z (Row)";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelStatus.Location = new System.Drawing.Point(14, 430);
            this.labelStatus.MaximumSize = new System.Drawing.Size(400, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 9;
            this.labelStatus.Text = "Status";
            // 
            // textBoxLocalFolder
            // 
            this.textBoxLocalFolder.Location = new System.Drawing.Point(97, 73);
            this.textBoxLocalFolder.Name = "textBoxLocalFolder";
            this.textBoxLocalFolder.Size = new System.Drawing.Size(634, 20);
            this.textBoxLocalFolder.TabIndex = 10;
            this.textBoxLocalFolder.Text = "C:\\tiles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Local Folder";
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(97, 119);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownX.TabIndex = 12;
            this.numericUpDownX.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownX.ValueChanged += new System.EventHandler(this.numericUpDownX_ValueChanged);
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Location = new System.Drawing.Point(97, 150);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownY.TabIndex = 13;
            // 
            // numericUpDownZ
            // 
            this.numericUpDownZ.Location = new System.Drawing.Point(97, 177);
            this.numericUpDownZ.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericUpDownZ.Name = "numericUpDownZ";
            this.numericUpDownZ.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownZ.TabIndex = 14;
            // 
            // checkBoxXEnabled
            // 
            this.checkBoxXEnabled.AutoSize = true;
            this.checkBoxXEnabled.Checked = true;
            this.checkBoxXEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxXEnabled.Enabled = false;
            this.checkBoxXEnabled.Location = new System.Drawing.Point(151, 120);
            this.checkBoxXEnabled.Name = "checkBoxXEnabled";
            this.checkBoxXEnabled.Size = new System.Drawing.Size(15, 14);
            this.checkBoxXEnabled.TabIndex = 15;
            this.checkBoxXEnabled.UseVisualStyleBackColor = true;
            // 
            // checkBoxYEnabled
            // 
            this.checkBoxYEnabled.AutoSize = true;
            this.checkBoxYEnabled.Location = new System.Drawing.Point(151, 150);
            this.checkBoxYEnabled.Name = "checkBoxYEnabled";
            this.checkBoxYEnabled.Size = new System.Drawing.Size(15, 14);
            this.checkBoxYEnabled.TabIndex = 16;
            this.checkBoxYEnabled.UseVisualStyleBackColor = true;
            // 
            // checkBoxZEnabled
            // 
            this.checkBoxZEnabled.AutoSize = true;
            this.checkBoxZEnabled.Location = new System.Drawing.Point(151, 177);
            this.checkBoxZEnabled.Name = "checkBoxZEnabled";
            this.checkBoxZEnabled.Size = new System.Drawing.Size(15, 14);
            this.checkBoxZEnabled.TabIndex = 17;
            this.checkBoxZEnabled.UseVisualStyleBackColor = true;
            // 
            // listBoxIssues
            // 
            this.listBoxIssues.ForeColor = System.Drawing.Color.Red;
            this.listBoxIssues.FormattingEnabled = true;
            this.listBoxIssues.Location = new System.Drawing.Point(97, 229);
            this.listBoxIssues.Name = "listBoxIssues";
            this.listBoxIssues.Size = new System.Drawing.Size(632, 186);
            this.listBoxIssues.TabIndex = 18;
            // 
            // labelIssues
            // 
            this.labelIssues.AutoSize = true;
            this.labelIssues.Location = new System.Drawing.Point(15, 229);
            this.labelIssues.Name = "labelIssues";
            this.labelIssues.Size = new System.Drawing.Size(53, 13);
            this.labelIssues.TabIndex = 19;
            this.labelIssues.Text = "Issue Log";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(191, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(341, 52);
            this.label6.TabIndex = 20;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 455);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelIssues);
            this.Controls.Add(this.listBoxIssues);
            this.Controls.Add(this.checkBoxZEnabled);
            this.Controls.Add(this.checkBoxYEnabled);
            this.Controls.Add(this.checkBoxXEnabled);
            this.Controls.Add(this.numericUpDownZ);
            this.Controls.Add(this.numericUpDownY);
            this.Controls.Add(this.numericUpDownX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxLocalFolder);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.buttonUpload);
            this.Name = "MainForm";
            this.Text = "MapTiler Upload Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxLocalFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.NumericUpDown numericUpDownZ;
        private System.Windows.Forms.CheckBox checkBoxXEnabled;
        private System.Windows.Forms.CheckBox checkBoxYEnabled;
        private System.Windows.Forms.CheckBox checkBoxZEnabled;
        private System.Windows.Forms.ListBox listBoxIssues;
        private System.Windows.Forms.Label labelIssues;
        private System.Windows.Forms.Label label6;
    }
}

