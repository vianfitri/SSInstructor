using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSInstructor.Class
{
    public class SSReport
    {
        #region "Fields"
        private PreviewPrintController oPrevPrintCtrl = new PreviewPrintController();
        private PrintDocument oPrintDoc = new PrintDocument();
        private PrintPreviewDialog oPrintPrevDlg = new PrintPreviewDialog();
        private PageSettings oStoredPageSettings = new PageSettings();

        private Bitmap oReportLogo;
        private Icon oIcon;
        private Image oImage;
        #endregion

        #region "Constructor"
        public SSReport()
        {
            // Change Date Time Regional
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            // Add event handler
            oPrintDoc.PrintPage += PrintPage;

            // set document paper size
            oStoredPageSettings = new PageSettings();
            PaperSize PSize = null;

            foreach(PaperSize PaperSizeContained in oPrintDoc.PrinterSettings.PaperSizes)
            {
                if(PaperSizeContained.RawKind == (int)PaperKind.A4)
                {
                    PSize = PaperSizeContained;
                    break;
                }
            }

            if(PSize == null)
            {
                MessageBox.Show("Oops! Can't find A4 paper for this printer.", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // store paper setting
                oStoredPageSettings.PaperSize = PSize; // <- this is the issue
                oStoredPageSettings.Landscape = false;
                oPrintDoc.DefaultPageSettings = oStoredPageSettings;
            }
        }
        #endregion

        #region "Properties"
        #endregion

        #region "Method"
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            MemoryStream stream = new MemoryStream();
           
            oImage.Save(stream, ImageFormat.Bmp);
            Bitmap bmp = new Bitmap(stream);

            e.Graphics.DrawImage(bmp, 20, 40, e.PageBounds.Right - 40, e.PageBounds.Bottom - 80);
        }

        public void ShowReport()
        {
            oPrintDoc.DefaultPageSettings = oStoredPageSettings;

            // Draw report page
            // DrawReport();

            try
            {
                // Show Preview
                if(oIcon != null)
                {
                    oPrintPrevDlg.Icon = oIcon;
                }
                oPrintPrevDlg.Document = oPrintDoc;
                oPrintPrevDlg.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveReport(object sender, PrintEventArgs e)
        {
            PreviewPageInfo[] ppi;
            float percentResize = 0.8f;

            ppi = oPrevPrintCtrl.GetPreviewPageInfo();

            for(int x = 0; x < ppi.Length - 1; x++)
            {
                Bitmap bm = new Bitmap(ppi[x].Image);

                if(bm == null)
                {
                    continue;
                }

                int width = (int)(bm.Width - (bm.Width * percentResize)); // image width
                int height = (int)(bm.Height - (bm.Height * percentResize)); // image height
                Bitmap thumb = new Bitmap(width, height);
                Graphics g = Graphics.FromImage(thumb);

                g.InterpolationMode = InterpolationMode.HighQualityBilinear;
                g.DrawImage(bm, new Rectangle(0, 0, width, height), new Rectangle(0, 0, bm.Width, bm.Height), GraphicsUnit.Pixel);

                thumb.Save("", ImageFormat.Tiff);

                g.Dispose();
                thumb.Dispose();
                bm.Dispose();
            }
        }
        #endregion
    }
}
