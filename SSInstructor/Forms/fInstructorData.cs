﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSInstructor.Class;

namespace SSInstructor.Forms
{
    public partial class fInstructorData : Form
    {
        public fInstructorData()
        {
            InitializeComponent();
        }

        private void fInstructorData_Load(object sender, EventArgs e)
        {
            dummyInstructorData();
        }

        private void dummyInstructorData()
        {
            bdgv_Instructor.Rows.Add(
                new object[]
                {
                    1,
                    "789648399",
                    "Dodi Sudrajat",
                    "-",
                    null,
                    null
                }
            );
            bdgv_Instructor.Rows.Add(
                new object[]
                {
                    2,
                    "5647366647",
                    "Heru Herlambang",
                    "-",
                    null,
                    null
                }
            );
            bdgv_Instructor.Rows.Add(
                new object[]
                {
                    3,
                    "9837638899",
                    "Elvin Mudhita",
                    "-",
                    null,
                    null
                }
            );
            bdgv_Instructor.Rows.Add(
                new object[]
                {
                    4,
                    "87736527726",
                    "Bayu Sudjatmiko",
                    "-",
                    null,
                    null
                }
            );
        }

        private void btnAddInstructor_Click(object sender, EventArgs e)
        {
            Form fInstAdd = new fAddInstructor();
            fInstAdd.StartPosition = FormStartPosition.CenterParent;
            fInstAdd.ShowDialog();
        }

        // Merge Column Action
        /*
        private void bdgv_Instructor_Paint(object sender, PaintEventArgs e)
        {
            //Offsets to adjust the position of the merged Header.
            int heightOffset = -1;
            int widthOffset = -1;
            int xOffset = 0;
            int yOffset = 1;

            //Index of Header column from where the merging will start.
            int columnIndex = 4;

            //Number of Header columns to be merged.
            int columnCount = 2;

            //Get the position of the Header Cell.
            Rectangle headerCellRectangle = bdgv_Instructor.GetCellDisplayRectangle(columnIndex, 0, true);

            //X coordinate of the merged Header Column.
            int xCord = headerCellRectangle.Location.X + xOffset;

            //Y coordinate of the merged Header Column.
            int yCord = headerCellRectangle.Location.Y - headerCellRectangle.Height + yOffset;

            //Calculate Width of merged Header Column by adding the widths of all Columns to be merged.
            int mergedHeaderWidth = bdgv_Instructor.Columns[columnIndex].Width + bdgv_Instructor.Columns[columnIndex + columnCount - 1].Width + widthOffset;

            //Generate the merged Header Column Rectangle.
            Rectangle mergedHeaderRect = new Rectangle(xCord, yCord, mergedHeaderWidth, headerCellRectangle.Height + heightOffset);

            //Draw the merged Header Column Rectangle.
            e.Graphics.FillRectangle(new SolidBrush(bdgv_Instructor.ColumnHeadersDefaultCellStyle.BackColor), mergedHeaderRect);

            //Draw the merged Header Column Text.
            e.Graphics.DrawString("Action", bdgv_Instructor.ColumnHeadersDefaultCellStyle.Font, Brushes.Black, xCord + 2, yCord + 3);

        }
        */

    }
}
