﻿using System;
using System.Collections.Generic;
using System.Data;
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
        private PrintDialog printDlg = new PrintDialog();
        private PageSettings oStoredPageSettings = new PageSettings();

        private DataTable tableScore;

        private Bitmap oReportLogo;
        private Icon oIcon;
        private Image oImage;
        private int rowId = 0;
        private int vesselType = 0;
        private string scenName = "";
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
        public Bitmap ReportLogo
        {
            set { oReportLogo = value; }
        }

        public Icon PrintingIcon
        {
            set { oIcon = value; }
        }

        public int RowId
        {
            set { rowId = value; }
        }

        public DataTable TableScore
        {
            set { tableScore = value; }
        }

        public int TypeVessel
        {
            set { vesselType = value; }
        }

        public string ScenName
        {
            set { scenName = value; }
        }
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
            DrawReport();

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

        public void PrintReport()
        {
            oPrintDoc.DefaultPageSettings = oStoredPageSettings;

            // Draw report
            DrawReport();

            try
            {
                oPrintDoc.DocumentName = "ShipStability Report";
                printDlg.Document = oPrintDoc;
                printDlg.AllowSelection = true;
                printDlg.AllowSomePages = true;

                if(printDlg.ShowDialog() == DialogResult.OK)
                {
                    oPrintDoc.Print();
                }
            }
            catch (Exception ex)
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

                string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filename = "Rep_" + DateTime.Now.ToString("yyyyMMdd") + "_" + x.ToString() + ".tiff";
                string filepath = mydocpath + filename;
                thumb.Save(filepath, ImageFormat.Tiff);

                g.Dispose();
                thumb.Dispose();
                bm.Dispose();
            }
        }

        private bool DrawReport()
        {
            Bitmap mybitmap = new Bitmap(1240, 1754);
            Pen pPen;
            Rectangle pBox;
            Point pLine1, pLine2;

            Font pFont;
            Rectangle layoutRect = new Rectangle();
            StringFormat stringFormat = new StringFormat();
            PointF stringPos = new PointF();
            SizeF stringSize = new SizeF();

            string teks;
            bool stat = true;

            try
            {
                Rectangle rect = new Rectangle(0, 0, mybitmap.Width, mybitmap.Height);
                Graphics displayGraphics = Graphics.FromImage(mybitmap);
                Brush pBrush = Brushes.White;

                oImage = new Bitmap(rect.Width, rect.Height, displayGraphics);
                Graphics imageGraphics = Graphics.FromImage(oImage);

                imageGraphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                imageGraphics.FillRectangle(pBrush, rect);

                // Print Box and Line
                pPen = new Pen(Color.White, 1);
                pBox = new Rectangle(rect.Left + 1, rect.Top + 1, rect.Width - 2, rect.Height - 2);
                imageGraphics.DrawRectangle(pPen, pBox);

                // Header Underline
                pPen = new Pen(Color.Black, 2);
                pLine1 = new Point(pBox.Left + 50, pBox.Top + 200);
                pLine2 = new Point(pBox.Right - 50, pBox.Top + 200);
                imageGraphics.DrawLine(pPen, pLine1, pLine2);

                // Value Table
                pPen = new Pen(Color.Black, 3);
                pBox = new Rectangle(50, pBox.Top + 620, pBox.Right - 100, 335);
                imageGraphics.DrawRectangle(pPen, pBox);

                // Value Table Header Line
                pPen = new Pen(Color.Black, 3);
                pLine1 = new Point(pBox.Left, pBox.Top + 35);
                pLine2 = new Point(pBox.Right, pBox.Top + 35);
                imageGraphics.DrawLine(pPen, pLine1, pLine2);

                pPen = new Pen(Color.Black, 2);
                pLine1 = new Point(pBox.Left, pBox.Top + 35 + 50);
                pLine2 = new Point(pBox.Right, pBox.Top + 35 + 50);
                imageGraphics.DrawLine(pPen, pLine1, pLine2);

                pLine1 = new Point(pBox.Left, pBox.Top + 35 + 100);
                pLine2 = new Point(pBox.Right, pBox.Top + 35 + 100);
                imageGraphics.DrawLine(pPen, pLine1, pLine2);

                pLine1 = new Point(pBox.Left, pBox.Top + 35 + 150);
                pLine2 = new Point(pBox.Right, pBox.Top + 35 + 150);
                imageGraphics.DrawLine(pPen, pLine1, pLine2);

                pLine1 = new Point(pBox.Left, pBox.Top + 35 + 200);
                pLine2 = new Point(pBox.Right, pBox.Top + 35 + 200);
                imageGraphics.DrawLine(pPen, pLine1, pLine2);

                pLine1 = new Point(pBox.Left, pBox.Top + 35 + 250);
                pLine2 = new Point(pBox.Right, pBox.Top + 35 + 250);
                imageGraphics.DrawLine(pPen, pLine1, pLine2);
                //for(int i = 2; i < 20; i++)
                //{
                //    if(i % 2 == 0)
                //    {
                //        pLine1 = new Point(pBox.Left, pBox.Top + 35 + (35 * i));
                //        pLine2 = new Point(pBox.Right, pBox.Top + 35 + (35 * i));
                //        imageGraphics.DrawLine(pPen, pLine1, pLine2);
                //    }
                //}

                // colum separator
                pLine1 = new Point(pBox.Left + 80, pBox.Top);
                pLine2 = new Point(pBox.Left + 80, pBox.Bottom);
                imageGraphics.DrawLine(pPen, pLine1, pLine2);

                // colum separator
                //pLine1 = new Point(pBox.Left + 450, pBox.Top);
                //pLine2 = new Point(pBox.Left + 450, pBox.Bottom);
                //imageGraphics.DrawLine(pPen, pLine1, pLine2);
                pLine1 = new Point(pBox.Left + 950, pBox.Top);
                pLine2 = new Point(pBox.Left + 950, pBox.Bottom);
                imageGraphics.DrawLine(pPen, pLine1, pLine2);

                // colum separator
                //pLine1 = new Point(pBox.Left + 1020, pBox.Top);
                //pLine2 = new Point(pBox.Left + 1020, pBox.Bottom);
                //imageGraphics.DrawLine(pPen, pLine1, pLine2);

                //pPen = new Pen(Color.Red, 3);
                //pLine1 = new Point(pBox.Left + 40, pBox.Top);
                //pLine2 = new Point(pBox.Left + 40, pBox.Top + 35);
                //imageGraphics.DrawLine(pPen, pLine1, pLine2);

                //pLine1 = new Point(pBox.Left + 450, pBox.Top);
                //pLine2 = new Point(pBox.Left + 450, pBox.Top + 35);
                //imageGraphics.DrawLine(pPen, pLine1, pLine2);

                //pLine1 = new Point(pBox.Left + 1020, pBox.Top);
                //pLine2 = new Point(pBox.Left + 1020, pBox.Top + 35);
                //imageGraphics.DrawLine(pPen, pLine1, pLine2);


                // Print String and Data
                pBox = new Rectangle(rect.Left + 1, rect.Top + 1, rect.Width - 2, rect.Height - 2);

                if (oReportLogo != null) {
                    Rectangle pPicBox = new Rectangle(rect.Left + 45, rect.Top + 37, 155, 138);
                    imageGraphics.DrawImage(oReportLogo, pPicBox);
                }

                pFont = new Font("Microsoft Sans Serif", 22, FontStyle.Bold);
                teks = "Laboratorium Ship Stability Simulator";
                //stringSize = imageGraphics.MeasureString(teks, pFont)
                stringPos = new Point(300, pBox.Top + 30);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, stringPos);
                pFont = new Font("Times New Roman", 18, FontStyle.Bold);
                teks = "JURUSAN NAUTIKA - PIP SEMARANG";
                //stringSize = imageGraphics.MeasureString(teks, pFont)
                stringPos = new Point(300, pBox.Top + 75);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, stringPos);
                teks = "POLITEKNIK ILMU PELAYARAN SEMARANG";
                //stringSize = imageGraphics.MeasureString(teks, pFont)
                stringPos = new Point(300, pBox.Top + 110);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, stringPos);
                teks = "Jl. Singosari No. 2A, Kota Semarang, Jawa Tengah, Indonesia 50242";
                //stringSize = imageGraphics.MeasureString(teks, pFont)
                stringPos = new Point(300, pBox.Top + 145);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, stringPos);

                pFont = new Font("Microsoft Sans Serif", 18, FontStyle.Bold | FontStyle.Underline);
                teks = "NILAI UJIAN SHIP STABILITY";
                stringSize = imageGraphics.MeasureString(teks, pFont);
                stringPos = new Point((int)(pBox.Right - stringSize.Width) / 2, pBox.Top + 250);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, stringPos);


                pFont = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
                teks = "NIT";
                stringPos = new Point(50, pBox.Top + 370);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, stringPos);
                teks = ":";
                stringPos = new Point(305, pBox.Top + 370);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, stringPos);
                //teks = "12345678/N";
                teks = tableScore.Rows[rowId]["id_number"].ToString();
                stringPos = new Point(325, pBox.Top + 370);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, stringPos);

                teks = "Trainee Name";
                stringPos = new Point(50, pBox.Top + 405);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, stringPos);
                teks = ":";
                stringPos = new Point(305, pBox.Top + 405);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, stringPos);
                //teks = "Student1";
                teks = tableScore.Rows[rowId]["first_name"].ToString();
                stringPos = new Point(325, pBox.Top + 405);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, stringPos);

                teks = "Scenario Name";
                stringPos = new Point(50, pBox.Top + 440);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, stringPos);
                teks = ":";
                stringPos = new Point(305, pBox.Top + 440);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, stringPos);
                teks = scenName;
                stringPos = new Point(325, pBox.Top + 440);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, stringPos);

                teks = "Vessel Type";
                stringPos = new Point(50, pBox.Top + 475);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, stringPos);
                teks = ":";
                stringPos = new Point(305, pBox.Top + 475);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, stringPos);
                if(vesselType == 0) { teks = "Bulk Carrier 50000 DWT"; }
                else if(vesselType == 1) { teks = "General Cargo 3650 DWT"; }
                else if(vesselType == 2) { teks = "Container 4180 DWT"; }
                stringPos = new Point(325, pBox.Top + 475);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, stringPos);


                pFont = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
                teks = "ASPEK PENILAIAN";
                //stringSize = imageGraphics.MeasureString(teks, pFont)
                stringPos = new Point(50, pBox.Top + 580);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, stringPos);

                teks = "Tgl.  " + DateTime.Now.ToString("dd / MM / yyyy");
                stringSize = imageGraphics.MeasureString(teks, pFont);
                stringPos = new Point((int)(pBox.Right - 50 - stringSize.Width), pBox.Top + 580);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, stringPos);

                pBox = new Rectangle(50, pBox.Top + 620, pBox.Right - 120, 335);

                pFont = new Font("Arial", 12, FontStyle.Bold);

                stringFormat.FormatFlags = StringFormatFlags.LineLimit;
                stringFormat.Trimming = StringTrimming.EllipsisCharacter;
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                teks = "No.";
                layoutRect = new Rectangle(pBox.Left + 18, pBox.Top, 40, 37);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, layoutRect, stringFormat);

                teks = "A S P E K";
                layoutRect = new Rectangle(pBox.Left + 80, pBox.Top, 870, 37);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, layoutRect, stringFormat);

                //teks = "M A L F U N G S I";
                //layoutRect = new Rectangle(pBox.Left + 450, pBox.Top, 570, 37);
                //imageGraphics.DrawString(teks, pFont, Brushes.Black, layoutRect, stringFormat);

                //teks = "N I L A I";
                //layoutRect = new Rectangle(pBox.Left + 1020, pBox.Top, pBox.Right - (pBox.Left + 1000), 37);
                //imageGraphics.DrawString(teks, pFont, Brushes.Black, layoutRect, stringFormat);

                teks = "N I L A I";
                layoutRect = new Rectangle(pBox.Left + 950, pBox.Top, pBox.Right - (pBox.Left + 930), 37);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, layoutRect, stringFormat);

                // Calculate Score
                //-----------------------------------------------------
                // calculate score
                float objPayloadPos_score = 0;
                float WeightBalance_score = 0;
                float RollPitch_score = 0;
                float accomplished_score = 0;
                float decisioMaking_score = 0;
                float vol_dim_score = 0;
                float final_score = 0;
                string status = "Failed";

                float heel = float.Parse(tableScore.Rows[rowId]["angle_heel"].ToString());
                float trim = float.Parse(tableScore.Rows[rowId]["angle_trim"].ToString());

                // Obj Payload Pos Score
                if (Math.Abs(heel) < 1 && Math.Abs(trim) < 1)
                {
                    objPayloadPos_score = 100;
                }
                else if (Math.Abs(heel) >= 1 && Math.Abs(heel) < 2 && Math.Abs(trim) >= 1 && Math.Abs(trim) < 2)
                {
                    objPayloadPos_score = 60;
                }
                else if (Math.Abs(heel) >= 2 && Math.Abs(heel) < 3 && Math.Abs(trim) >= 2 && Math.Abs(trim) < 3)
                {
                    objPayloadPos_score = 40;
                }
                else
                {
                    objPayloadPos_score = 0;
                }

                // Weight balance score
                if (Math.Abs(heel) < 1 && Math.Abs(trim) < 1)
                {
                    WeightBalance_score = 100;
                }
                else if (Math.Abs(heel) >= 1 && Math.Abs(heel) < 2 && Math.Abs(trim) >= 1 && Math.Abs(trim) < 2)
                {
                    WeightBalance_score = 60;
                }
                else if (Math.Abs(heel) >= 2 && Math.Abs(heel) < 3 && Math.Abs(trim) >= 2 && Math.Abs(trim) < 3)
                {
                    WeightBalance_score = 40;
                }
                else
                {
                    WeightBalance_score = 0;
                }

                // Roll Pitch Score
                float angle_heel_score = float.Parse(tableScore.Rows[rowId]["angle_heel_score"].ToString());
                float angle_trim_score = float.Parse(tableScore.Rows[rowId]["angle_trim_score"].ToString());

                RollPitch_score = (angle_heel_score + angle_trim_score) / 2;

                // accomplished score
                if (bool.Parse(tableScore.Rows[rowId]["is_accomplished"].ToString()) == true)
                {
                    accomplished_score = 100;
                }

                // decision making score
                decisioMaking_score = float.Parse(tableScore.Rows[rowId]["time_elapsed_score"].ToString());

                // voldim score
                float drAftScr = float.Parse(tableScore.Rows[rowId]["draft_aft_score"].ToString());
                float drFwdScr = float.Parse(tableScore.Rows[rowId]["draft_fwd_score"].ToString());
                vol_dim_score = (drAftScr + drFwdScr) / 2;

                // final score
                final_score = (objPayloadPos_score + WeightBalance_score + RollPitch_score + accomplished_score + decisioMaking_score + vol_dim_score) / 6;
                //-----------------------------------------------------

                // Aspek nilai

                pFont = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
                teks = "NILAI AKHIR   : ";
                stringSize = imageGraphics.MeasureString(teks, pFont);
                stringPos = new Point(pBox.Left, pBox.Bottom + 35);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, stringPos);

                pPen = new Pen(Color.Black, 1);
                pBox = new Rectangle(230, pBox.Bottom + 25, 150, 50);
                Console.WriteLine(pBox.Left + stringSize.Width + 15);
                imageGraphics.DrawRectangle(pPen, pBox);

                pFont = new Font("Arial", 20, FontStyle.Bold);
                teks = final_score.ToString("F1");
                layoutRect = pBox;
                imageGraphics.DrawString(teks, pFont, Brushes.Black, layoutRect, stringFormat);

                pFont = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
                teks = "STATUS        : ";
                stringSize = imageGraphics.MeasureString(teks, pFont);
                stringPos = new Point(50, pBox.Bottom + 35);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, stringPos);

                pPen = new Pen(Color.Black, 1);
                pBox = new Rectangle(230, pBox.Bottom + 25, 150, 50);
                imageGraphics.DrawRectangle(pPen, pBox);

                pFont = new Font("Arial", 20, FontStyle.Bold);
                Brush brush = Brushes.Red;
                teks = "FAILED";
                if (final_score >= 70)
                {
                    if (bool.Parse(tableScore.Rows[rowId]["is_accomplished"].ToString()) == true)
                    {
                        brush = Brushes.Green;
                        teks = "PASSED";
                    }
                    else
                    {
                        brush = Brushes.Red;
                        teks = "FAILED";
                    }
                }
                layoutRect = pBox;
                imageGraphics.DrawString(teks, pFont, brush, layoutRect, stringFormat);


                pBox = new Rectangle(rect.Left + 1, rect.Top + 1, rect.Width - 2, rect.Height - 2);
                pBox = new Rectangle(50, pBox.Top + 620, pBox.Right - 120, (35 * 21));

                pFont = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
                teks = "Semarang, " + DateTime.Now.ToString("d  MMMM  yyyy", new System.Globalization.CultureInfo("Id-ID"));
                layoutRect = new Rectangle(pBox.Right - 330, pBox.Bottom + 100, 330, 37);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, layoutRect, stringFormat);

                teks = "";
                layoutRect = new Rectangle(pBox.Right - 330, pBox.Bottom + 263, 330, 37);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, layoutRect, stringFormat);

                pPen = new Pen(Color.Black, 1);
                imageGraphics.DrawLine(pPen, pBox.Right - 330, pBox.Bottom + 300, pBox.Right, pBox.Bottom + 300);

                teks = "I n s t r u k t u r";
                layoutRect = new Rectangle(pBox.Right - 330, pBox.Bottom + 300, 330, 37);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, layoutRect, stringFormat);

                // Data
                pFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

                teks = "1.";
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                layoutRect = new Rectangle(pBox.Left, pBox.Top + 35, 58, 49);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, layoutRect, stringFormat);

                teks = "2.";
                layoutRect = new Rectangle(pBox.Left, pBox.Top + 35 + 50, 58, 49);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, layoutRect, stringFormat);

                teks = "3.";
                layoutRect = new Rectangle(pBox.Left, pBox.Top + 35 + 100, 58, 49);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, layoutRect, stringFormat);

                teks = "4.";
                layoutRect = new Rectangle(pBox.Left, pBox.Top + 35 + 150, 58, 49);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, layoutRect, stringFormat);

                teks = "5.";
                layoutRect = new Rectangle(pBox.Left, pBox.Top + 35 + 200, 58, 49);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, layoutRect, stringFormat);

                teks = "6.";
                layoutRect = new Rectangle(pBox.Left, pBox.Top + 35 + 250, 58, 49);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, layoutRect, stringFormat);

                teks = "object Payload Positioning";
                stringFormat.Alignment = StringAlignment.Near;
                stringFormat.LineAlignment = StringAlignment.Center;
                layoutRect = new Rectangle(pBox.Left + 100, pBox.Top + 35, 850, 49);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, layoutRect, stringFormat);

                teks = "Weight and Balance";
                layoutRect = new Rectangle(pBox.Left + 100, pBox.Top + 35 + 50, 850, 49);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, layoutRect, stringFormat);

                teks = "Stability on Rolling and Pitching";
                layoutRect = new Rectangle(pBox.Left + 100, pBox.Top + 35 + 100, 850, 49);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, layoutRect, stringFormat);

                teks = "Simulation Accomplishing";
                layoutRect = new Rectangle(pBox.Left + 100, pBox.Top + 35 + 150, 850, 49);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, layoutRect, stringFormat);

                teks = "Decision Making of Object Payload Positioning";
                layoutRect = new Rectangle(pBox.Left + 100, pBox.Top + 35 + 200, 850, 49);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, layoutRect, stringFormat);

                teks = "Volume and Dimension";
                layoutRect = new Rectangle(pBox.Left + 100, pBox.Top + 35 + 250, 850, 49);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, layoutRect, stringFormat);

                
                // Nilai
                pFont = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
                teks = objPayloadPos_score.ToString("F1");
                stringFormat.Alignment = StringAlignment.Center;
                layoutRect = new Rectangle(pBox.Left + 970, pBox.Top + 35, pBox.Right - (pBox.Left + 950), 49);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, layoutRect, stringFormat);

                teks = WeightBalance_score.ToString("F1");
                stringFormat.Alignment = StringAlignment.Center;
                layoutRect = new Rectangle(pBox.Left + 970, pBox.Top + 35 + 50, pBox.Right - (pBox.Left + 950), 49);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, layoutRect, stringFormat);

                teks = RollPitch_score.ToString("F1");
                stringFormat.Alignment = StringAlignment.Center;
                layoutRect = new Rectangle(pBox.Left + 970, pBox.Top + 35 + 100, pBox.Right - (pBox.Left + 950), 49);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, layoutRect, stringFormat);

                teks = accomplished_score.ToString("F1");
                stringFormat.Alignment = StringAlignment.Center;
                layoutRect = new Rectangle(pBox.Left + 970, pBox.Top + 35 + 150, pBox.Right - (pBox.Left + 950), 49);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, layoutRect, stringFormat);

                teks = decisioMaking_score.ToString("F1");
                stringFormat.Alignment = StringAlignment.Center;
                layoutRect = new Rectangle(pBox.Left + 970, pBox.Top + 35 + 200, pBox.Right - (pBox.Left + 950), 49);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, layoutRect, stringFormat);

                teks = vol_dim_score.ToString("F1");
                stringFormat.Alignment = StringAlignment.Center;
                layoutRect = new Rectangle(pBox.Left + 970, pBox.Top + 35 + 250, pBox.Right - (pBox.Left + 950), 49);
                imageGraphics.DrawString(teks, pFont, Brushes.Black, layoutRect, stringFormat);

                imageGraphics.Dispose();
                displayGraphics.Dispose();
            }
            catch(Exception ex)
            {
                stat = false;
                MessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return stat;
        }
        #endregion
    }
}
