using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SSInstructor.Class;

namespace SSInstructor.Forms
{
    public partial class fLoadPos : Form
    {
        #region "Graph Algoritm"
        // create series
        Series lat_shipform_series = new Series();   // for showing ship form (amidship)
        Series lat_initshipform_series = new Series();  // for showing ship form (initial, static), lateral plane
        Series wtrline_series = new Series();    // for showing waterline 
        Series kmtline_series = new Series();    // for showing KMT line, including G
        Series bmtline_series = new Series();    // for showing BMT line
        Series gztline_series = new Series();    // for showing GZT line, 20140822 
        Series kntline_series = new Series();    // for showing KNT line, 20140823 
        Series clpline_series = new Series();    // for showing CLP line, 20160217 

        Series gpoint_series = new Series();     // for showing point G = G1 (G total ship)
        Series zpoint_series = new Series();     // for showing point Z, 20140822 
        Series bpoint_series = new Series();     // for showing point B 
        Series mpoint_series = new Series();     // for showing point M 
        Series kpoint_series = new Series();     // for showing point K, 20140823 
        Series npoint_series = new Series();     // for showing point N, 20140823 
        Series g0point_series = new Series();    // for showing point G0, G lightship, 20150827
        Series gmpoint_series = new Series();    // for showing point Gm, G total muatan, 20150827

        Series lon_shipform_series = new Series();    // for showing ship form, longitudinal plane
        Series lon_wtrline_series = new Series();     // for showing waterline longitudinal
        Series lon_initwtrline_series = new Series(); // for showing waterline longitudinal, rotatable waterline
        Series lon_kmtline_series = new Series();     // for showing ship form, longitudinal plane
        Series lon_bmtline_series = new Series();     // for showing waterline longitudinal
        Series lon_gpoint_series = new Series();      // for showing point G = G1 (G total ship)
        Series lon_bpoint_series = new Series();      // for showing point B 
        Series lon_mpoint_series = new Series();      // for showing point M 
        Series lon_cofpoint_series = new Series();    // for showing point COF 

        Series lon_g0point_series = new Series();       // for showing point G0 (G lightship), 20150827
        Series lon_gmpoint_series = new Series();       // for showing point Gm (G total muatan), 20150827

        Series lon_initshipform_series = new Series();  // for showing ship form (initial, static), longitudinal plane
        Series loadline_series = new Series();          // for showing load distribution 
        Series shearline_series = new Series();         // for showing shear force 
        Series bmomentline_series = new Series();       // for showing bending moment 

        Series topview_lat_shipform_series = new Series();  // for showing ship form, top view plane

        Series[] gzcrosscurve_series;
        Series[] gzcrosspoint_series;
        Series[] kncrosscurve_series;
        Series[] kncrosspoint_series;

        Series tmmb_xy_point_series = new Series();
        Series tmmb_xz_point_series = new Series();
        Series tmmb_yz_point_series = new Series();
        Series tmmd_xy_point_series = new Series();
        Series tmmd_xz_point_series = new Series();
        Series tmmd_yz_point_series = new Series();
        Series tkk_xy_point_series = new Series();
        Series tkk_xz_point_series = new Series();
        Series tkk_yz_point_series = new Series();
        Series tnt_xy_point_series = new Series();
        Series tnt_xz_point_series = new Series();
        Series tnt_yz_point_series = new Series();

        #endregion

        public fLoadPos()
        {
            InitializeComponent();
        }

        private void fLoadPos_Load(object sender, EventArgs e)
        {

        }
    }
}
