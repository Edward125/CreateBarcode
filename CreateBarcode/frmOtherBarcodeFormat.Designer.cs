namespace CreateBarcode
{
    partial class frmOtherBarcodeFormat
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.comboFormate = new System.Windows.Forms.ComboBox();
            this.picBar = new System.Windows.Forms.PictureBox();
            this.grbOther = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBar)).BeginInit();
            this.grbOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Controls.Add(this.comboFormate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(488, 13);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(67, 36);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(154, 23);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(328, 25);
            this.txtInput.TabIndex = 1;
            // 
            // comboFormate
            // 
            this.comboFormate.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFormate.FormattingEnabled = true;
            this.comboFormate.Location = new System.Drawing.Point(17, 23);
            this.comboFormate.Name = "comboFormate";
            this.comboFormate.Size = new System.Drawing.Size(131, 25);
            this.comboFormate.TabIndex = 0;
            this.comboFormate.SelectedIndexChanged += new System.EventHandler(this.comboFormate_SelectedIndexChanged);
            // 
            // picBar
            // 
            this.picBar.Location = new System.Drawing.Point(6, 21);
            this.picBar.Name = "picBar";
            this.picBar.Size = new System.Drawing.Size(560, 339);
            this.picBar.TabIndex = 1;
            this.picBar.TabStop = false;
            this.picBar.DoubleClick += new System.EventHandler(this.picBar_DoubleClick);
            // 
            // grbOther
            // 
            this.grbOther.Controls.Add(this.picBar);
            this.grbOther.Location = new System.Drawing.Point(12, 73);
            this.grbOther.Name = "grbOther";
            this.grbOther.Size = new System.Drawing.Size(572, 366);
            this.grbOther.TabIndex = 2;
            this.grbOther.TabStop = false;
            // 
            // frmOtherBarcodeFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 451);
            this.Controls.Add(this.grbOther);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmOtherBarcodeFormat";
            this.Text = "frmOtherBarcodeFormat";
            this.Load += new System.EventHandler(this.frmOtherBarcodeFormat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBar)).EndInit();
            this.grbOther.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picBar;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ComboBox comboFormate;
        private System.Windows.Forms.GroupBox grbOther;
    }
}