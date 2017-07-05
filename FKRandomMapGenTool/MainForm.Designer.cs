namespace FKRandomMapGenTool
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MapImageBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.RHeightCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.seedBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nLloydBox = new System.Windows.Forms.TextBox();
            this.nSitesBox = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.MapPanel = new System.Windows.Forms.Panel();
            this.GenRandomSeedBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MapImageBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.MapPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MapImageBox
            // 
            this.MapImageBox.Location = new System.Drawing.Point(2, 3);
            this.MapImageBox.Name = "MapImageBox";
            this.MapImageBox.Size = new System.Drawing.Size(600, 600);
            this.MapImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MapImageBox.TabIndex = 1;
            this.MapImageBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GenRandomSeedBtn);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.RHeightCheck);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.seedBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nLloydBox);
            this.panel1.Controls.Add(this.nSitesBox);
            this.panel1.Controls.Add(this.CreateButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 54);
            this.panel1.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(522, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 39);
            this.SaveButton.TabIndex = 1005;
            this.SaveButton.Text = "地图截屏";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // RHeightCheck
            // 
            this.RHeightCheck.AutoSize = true;
            this.RHeightCheck.Checked = true;
            this.RHeightCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RHeightCheck.Location = new System.Drawing.Point(210, 25);
            this.RHeightCheck.Name = "RHeightCheck";
            this.RHeightCheck.Size = new System.Drawing.Size(96, 16);
            this.RHeightCheck.TabIndex = 1004;
            this.RHeightCheck.Tag = "Adds random elevation to give a different possibly better appearance";
            this.RHeightCheck.Text = "细节随机加强";
            this.RHeightCheck.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1006;
            this.label3.Text = "随机种子";
            // 
            // seedBox
            // 
            this.seedBox.Location = new System.Drawing.Point(11, 25);
            this.seedBox.Name = "seedBox";
            this.seedBox.Size = new System.Drawing.Size(92, 21);
            this.seedBox.TabIndex = 1002;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1007;
            this.label2.Text = "Lloyd:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1008;
            this.label1.Text = "顶点数";
            // 
            // nLloydBox
            // 
            this.nLloydBox.Location = new System.Drawing.Point(164, 23);
            this.nLloydBox.Name = "nLloydBox";
            this.nLloydBox.Size = new System.Drawing.Size(40, 21);
            this.nLloydBox.TabIndex = 1001;
            this.nLloydBox.Text = "2";
            // 
            // nSitesBox
            // 
            this.nSitesBox.Location = new System.Drawing.Point(109, 24);
            this.nSitesBox.Name = "nSitesBox";
            this.nSitesBox.Size = new System.Drawing.Size(49, 21);
            this.nSitesBox.TabIndex = 1000;
            this.nSitesBox.Text = "6000";
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CreateButton.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.CreateButton.Location = new System.Drawing.Point(441, 5);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 39);
            this.CreateButton.TabIndex = 1;
            this.CreateButton.Text = "创建地图";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // MapPanel
            // 
            this.MapPanel.AutoScroll = true;
            this.MapPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MapPanel.Controls.Add(this.MapImageBox);
            this.MapPanel.Location = new System.Drawing.Point(12, 73);
            this.MapPanel.Name = "MapPanel";
            this.MapPanel.Size = new System.Drawing.Size(605, 605);
            this.MapPanel.TabIndex = 3;
            // 
            // GenRandomSeedBtn
            // 
            this.GenRandomSeedBtn.Location = new System.Drawing.Point(77, 23);
            this.GenRandomSeedBtn.Name = "GenRandomSeedBtn";
            this.GenRandomSeedBtn.Size = new System.Drawing.Size(26, 23);
            this.GenRandomSeedBtn.TabIndex = 1009;
            this.GenRandomSeedBtn.Text = "随";
            this.GenRandomSeedBtn.UseVisualStyleBackColor = true;
            this.GenRandomSeedBtn.Click += new System.EventHandler(this.GenRandomSeedBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 691);
            this.Controls.Add(this.MapPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "随机地图生成器";
            ((System.ComponentModel.ISupportInitialize)(this.MapImageBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MapPanel.ResumeLayout(false);
            this.MapPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MapImageBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.CheckBox RHeightCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox seedBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nLloydBox;
        private System.Windows.Forms.TextBox nSitesBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Panel MapPanel;
        private System.Windows.Forms.Button GenRandomSeedBtn;
    }
}

