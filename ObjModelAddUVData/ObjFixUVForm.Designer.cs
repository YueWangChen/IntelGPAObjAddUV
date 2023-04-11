
namespace ObjModelAddUVData
{
    partial class ObjFixUVForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjFixUVForm));
            this.label_Tip = new System.Windows.Forms.Label();
            this.Tt_ObjPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_BrowObjFile = new System.Windows.Forms.Button();
            this.Btn_BrowCsvFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Tt_CsvPath = new System.Windows.Forms.TextBox();
            this.Btn_FixedUVData = new System.Windows.Forms.Button();
            this.cb_isUVFloat4 = new System.Windows.Forms.CheckBox();
            this.cb_Add1ToUVCount = new System.Windows.Forms.CheckBox();
            this.cb_flipUV_Y = new System.Windows.Forms.CheckBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Tip
            // 
            this.label_Tip.AutoSize = true;
            this.label_Tip.BackColor = System.Drawing.Color.Transparent;
            this.label_Tip.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.label_Tip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(16)))), ((int)(((byte)(77)))));
            this.label_Tip.Location = new System.Drawing.Point(283, 414);
            this.label_Tip.Name = "label_Tip";
            this.label_Tip.Size = new System.Drawing.Size(503, 20);
            this.label_Tip.TabIndex = 0;
            this.label_Tip.Text = "提示：因obj格式模型只支持一套UV，多UV及有顶点色模型请不要使用此工具。";
            // 
            // Tt_ObjPath
            // 
            this.Tt_ObjPath.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.Tt_ObjPath.Location = new System.Drawing.Point(363, 261);
            this.Tt_ObjPath.Name = "Tt_ObjPath";
            this.Tt_ObjPath.Size = new System.Drawing.Size(324, 24);
            this.Tt_ObjPath.TabIndex = 1;
            this.Tt_ObjPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(16)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(284, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "OBJ路径:";
            // 
            // Btn_BrowObjFile
            // 
            this.Btn_BrowObjFile.BackColor = System.Drawing.Color.Transparent;
            this.Btn_BrowObjFile.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.Btn_BrowObjFile.Location = new System.Drawing.Point(693, 259);
            this.Btn_BrowObjFile.Name = "Btn_BrowObjFile";
            this.Btn_BrowObjFile.Size = new System.Drawing.Size(82, 28);
            this.Btn_BrowObjFile.TabIndex = 3;
            this.Btn_BrowObjFile.Text = "浏览OBJ";
            this.Btn_BrowObjFile.UseVisualStyleBackColor = false;
            this.Btn_BrowObjFile.Click += new System.EventHandler(this.Btn_BrowObjFile_Click);
            // 
            // Btn_BrowCsvFile
            // 
            this.Btn_BrowCsvFile.BackColor = System.Drawing.Color.Transparent;
            this.Btn_BrowCsvFile.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.Btn_BrowCsvFile.Location = new System.Drawing.Point(693, 303);
            this.Btn_BrowCsvFile.Name = "Btn_BrowCsvFile";
            this.Btn_BrowCsvFile.Size = new System.Drawing.Size(82, 28);
            this.Btn_BrowCsvFile.TabIndex = 6;
            this.Btn_BrowCsvFile.Text = "浏览CSV";
            this.Btn_BrowCsvFile.UseVisualStyleBackColor = false;
            this.Btn_BrowCsvFile.Click += new System.EventHandler(this.Btn_BrowCsvFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(16)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(284, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "CSV路径:";
            // 
            // Tt_CsvPath
            // 
            this.Tt_CsvPath.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.Tt_CsvPath.Location = new System.Drawing.Point(363, 305);
            this.Tt_CsvPath.Name = "Tt_CsvPath";
            this.Tt_CsvPath.Size = new System.Drawing.Size(324, 24);
            this.Tt_CsvPath.TabIndex = 4;
            this.Tt_CsvPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_FixedUVData
            // 
            this.Btn_FixedUVData.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.Btn_FixedUVData.Location = new System.Drawing.Point(540, 373);
            this.Btn_FixedUVData.Name = "Btn_FixedUVData";
            this.Btn_FixedUVData.Size = new System.Drawing.Size(235, 38);
            this.Btn_FixedUVData.TabIndex = 7;
            this.Btn_FixedUVData.Text = "修复OBJ模型的UV数据";
            this.Btn_FixedUVData.UseVisualStyleBackColor = true;
            this.Btn_FixedUVData.Click += new System.EventHandler(this.Btn_FixedUVData_Click);
            // 
            // cb_isUVFloat4
            // 
            this.cb_isUVFloat4.AutoSize = true;
            this.cb_isUVFloat4.BackColor = System.Drawing.Color.Transparent;
            this.cb_isUVFloat4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.cb_isUVFloat4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(16)))), ((int)(((byte)(77)))));
            this.cb_isUVFloat4.Location = new System.Drawing.Point(288, 342);
            this.cb_isUVFloat4.Name = "cb_isUVFloat4";
            this.cb_isUVFloat4.Size = new System.Drawing.Size(144, 25);
            this.cb_isUVFloat4.TabIndex = 8;
            this.cb_isUVFloat4.Text = "UV是否为float4";
            this.cb_isUVFloat4.UseVisualStyleBackColor = false;
            // 
            // cb_Add1ToUVCount
            // 
            this.cb_Add1ToUVCount.AutoSize = true;
            this.cb_Add1ToUVCount.BackColor = System.Drawing.Color.Transparent;
            this.cb_Add1ToUVCount.Checked = true;
            this.cb_Add1ToUVCount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Add1ToUVCount.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.cb_Add1ToUVCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(16)))), ((int)(((byte)(77)))));
            this.cb_Add1ToUVCount.Location = new System.Drawing.Point(461, 342);
            this.cb_Add1ToUVCount.Name = "cb_Add1ToUVCount";
            this.cb_Add1ToUVCount.Size = new System.Drawing.Size(125, 25);
            this.cb_Add1ToUVCount.TabIndex = 9;
            this.cb_Add1ToUVCount.Text = "UV索引增加1";
            this.cb_Add1ToUVCount.UseVisualStyleBackColor = false;
            // 
            // cb_flipUV_Y
            // 
            this.cb_flipUV_Y.AutoSize = true;
            this.cb_flipUV_Y.BackColor = System.Drawing.Color.Transparent;
            this.cb_flipUV_Y.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.cb_flipUV_Y.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(16)))), ((int)(((byte)(77)))));
            this.cb_flipUV_Y.Location = new System.Drawing.Point(628, 342);
            this.cb_flipUV_Y.Name = "cb_flipUV_Y";
            this.cb_flipUV_Y.Size = new System.Drawing.Size(147, 25);
            this.cb_flipUV_Y.TabIndex = 10;
            this.cb_flipUV_Y.Text = "是否翻转UV Y轴";
            this.cb_flipUV_Y.UseVisualStyleBackColor = false;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btn_Reset.Location = new System.Drawing.Point(287, 374);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(235, 37);
            this.btn_Reset.TabIndex = 11;
            this.btn_Reset.Text = "重置";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // ObjFixUVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::ObjModelAddUVData.Properties.Resources._96fbdaaa699551799e5dd6b9566aed2e;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(788, 443);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.cb_flipUV_Y);
            this.Controls.Add(this.cb_Add1ToUVCount);
            this.Controls.Add(this.cb_isUVFloat4);
            this.Controls.Add(this.Btn_FixedUVData);
            this.Controls.Add(this.Btn_BrowCsvFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tt_CsvPath);
            this.Controls.Add(this.Btn_BrowObjFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tt_ObjPath);
            this.Controls.Add(this.label_Tip);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ObjFixUVForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPA截帧Obj模型修正UV数据 BetaVersion:0.01 by：YXJ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Tip;
        private System.Windows.Forms.TextBox Tt_ObjPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_BrowObjFile;
        private System.Windows.Forms.Button Btn_BrowCsvFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tt_CsvPath;
        private System.Windows.Forms.Button Btn_FixedUVData;
        private System.Windows.Forms.CheckBox cb_isUVFloat4;
        private System.Windows.Forms.CheckBox cb_Add1ToUVCount;
        private System.Windows.Forms.CheckBox cb_flipUV_Y;
        private System.Windows.Forms.Button btn_Reset;
    }
}

