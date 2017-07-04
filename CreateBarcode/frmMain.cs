using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZXing;
using Edward;
using ZXing.Common;

namespace CreateBarcode
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            loadUI();
        }

        private void loadUI()
        {
            txtInput.SetWatermark("Input what you want to create barcode...");
        }


        /// <summary>
        /// 一维码生成
        /// </summary>
        /// <param name="contents"></param>
        public static string CreateBarCode128(string contents, string tempPath,int width,int height)
        {

            EncodingOptions options = null;
            BarcodeWriter writer = null;
            options = new EncodingOptions
            {
                Width = width ,
                Height = height 
            };
            writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.CODE_128;
            writer.Options = options;
            Bitmap bitmap = writer.Write(contents);
            string fileName = Guid.NewGuid().ToString() + ".png";
            bitmap.Save(tempPath + fileName);
            return fileName;


        }

        /// <summary>
        /// 一维码生成
        /// </summary>
        /// <param name="contents"></param>
        public static Bitmap  CreateBarCode(string contents,int width,int height)
        {

            EncodingOptions options = null;
            BarcodeWriter writer = null;
            options = new EncodingOptions
            {
                Width = width ,
                Height = height 
            };
            writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.CODE_128;
            writer.Options = options;
            Bitmap bitmap = writer.Write(contents);
            return bitmap;                        
        }



        /// <summary>
        /// 一维码生成
        /// </summary>
        /// <param name="contents"></param>
        public static Bitmap CreateBarCode(string contents, BarcodeFormat format,int width, int height)
        {

            EncodingOptions options = null;
            BarcodeWriter writer = null;
            options = new EncodingOptions
            {
                Width = width,
                Height = height
            };
            writer = new BarcodeWriter();
            writer.Format = format;
            writer.Options = options;
            Bitmap bitmap = writer.Write(contents);
            return bitmap;
        }




        /// <summary>
        /// 一维码生成
        /// </summary>
        /// <param name="contents"></param>
        public static Bitmap CreateBarCode(string contents, BarcodeFormat format,PictureBox pic)
        {

            EncodingOptions options = null;
            BarcodeWriter writer = null;
            options = new EncodingOptions
            {
                Width = pic.Width ,
                Height = pic.Height 
            };
            writer = new BarcodeWriter();
            writer.Format = format;
            writer.Options = options;
            Bitmap bitmap = writer.Write(contents);
            return bitmap;
        }



        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text.Trim()))
                return;
            picCode128.Image = CreateBarCode(txtInput.Text.Trim(), BarcodeFormat.CODE_128, picCode128);
            pic2D.Image = CreateBarCode(txtInput.Text.Trim(), BarcodeFormat.DATA_MATRIX, pic2D);            
        }
    }
}
