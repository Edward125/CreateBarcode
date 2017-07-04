namespace CreateBarcode
{
    partial class frmMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSaveImg = new System.Windows.Forms.Button();
            this.btnOther = new System.Windows.Forms.Button();
            this.picCode128 = new System.Windows.Forms.PictureBox();
            this.pic2D = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCode128)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2D)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pic2D);
            this.groupBox1.Location = new System.Drawing.Point(12, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2D BarCode(DATA_MATRIX)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picCode128);
            this.groupBox2.Location = new System.Drawing.Point(366, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 348);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "1D BarCode(CODE128)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnOther);
            this.groupBox4.Controls.Add(this.btnSaveImg);
            this.groupBox4.Controls.Add(this.btnCreate);
            this.groupBox4.Controls.Add(this.txtInput);
            this.groupBox4.Location = new System.Drawing.Point(12, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(702, 77);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(9, 25);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(427, 27);
            this.txtInput.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(447, 19);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 41);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSaveImg
            // 
            this.btnSaveImg.Location = new System.Drawing.Point(525, 19);
            this.btnSaveImg.Name = "btnSaveImg";
            this.btnSaveImg.Size = new System.Drawing.Size(75, 41);
            this.btnSaveImg.TabIndex = 3;
            this.btnSaveImg.Text = "SaveImg";
            this.btnSaveImg.UseVisualStyleBackColor = true;
            // 
            // btnOther
            // 
            this.btnOther.Location = new System.Drawing.Point(604, 19);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(75, 41);
            this.btnOther.TabIndex = 4;
            this.btnOther.Text = "Other...";
            this.btnOther.UseVisualStyleBackColor = true;
            // 
            // picCode128
            // 
            this.picCode128.Location = new System.Drawing.Point(14, 21);
            this.picCode128.Name = "picCode128";
            this.picCode128.Size = new System.Drawing.Size(321, 321);
            this.picCode128.TabIndex = 0;
            this.picCode128.TabStop = false;
            // 
            // pic2D
            // 
            this.pic2D.Location = new System.Drawing.Point(10, 20);
            this.pic2D.Name = "pic2D";
            this.pic2D.Size = new System.Drawing.Size(321, 321);
            this.pic2D.TabIndex = 1;
            this.pic2D.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 469);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCode128)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2D)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.Button btnSaveImg;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.PictureBox pic2D;
        private System.Windows.Forms.PictureBox picCode128;
    }
}

