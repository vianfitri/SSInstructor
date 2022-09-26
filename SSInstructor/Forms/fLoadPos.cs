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

        #region "Hydrostatic Data of Bulk Carrier"
        double[] dspData_BC; // Kolom 1  = Displacement Weight (kgf) // used
        double[] drfData_BC; // Kolom 2  = Draft, T (mm) // used	            
        double[] gmlData_BC; // Kolom 3  = GML (mm)	             
        double[] bmlData_BC; // Kolom 4  = BML (mm)	    
        double[] lwlData_BC; // Kolom 5  = LWL (mm)	      
        double[] bwlData_BC; // Kolom 6  = BWL (mm)	    
        double[] kbtData_BC; // Kolom 7  = KBT (mm)	// used       
        double[] kmtData_BC; // Kolom 8  = KMT (mm)	// used  
        double[] gmtData_BC; // Kolom 9  = GMT (mm)	    
        double[] lbtData_BC; // Kolom 10 = LCB (mm), at transversal mode // used      
        double[] lflData_BC; // Kolom 11 = LCF (mm), at longitudinal mode // used	     
        double[] wtiData_BC; // Kolom 12 = WTI (kgf/cm) // used  
        double[] mttData_BC; // Kolom 13 = MTT (kgf.m/cm) // used	
        double[] fflData_BC; // Kolom 14 = FF/LWL	    
        double[] falData_BC; // Kolom 15 = FA/LWL	       
        double[] kmlData_BC; // Kolom 16 = KML (mm)	
        double[] tbtData_BC; // Kolom 17 = TCB (mm)	      
        double[] wtaData_BC; // Kolom 18 = Wet Area (m²) 
        double[] awpData_BC; // Kolom 19 = Awp (m²)	  
        double[] tcfData_BC; // Kolom 20 = TCF (mm)	     
        double[] vcfData_BC; // Kolom 21 = VCF (mm)	   
        double[] bmtData_BC; // Kolom 22 = BMt (mm)	  
        double[] cobData_BC; // Kolom 23 = Cb // used	   
        double[] copData_BC; // Kolom 24 = Cp // used	 
        double[] cwpData_BC; // Kolom 25 = Cwp	  
        double[] coxData_BC; // Kolom 26 = Cx	
        double[] cwsData_BC; // Kolom 27 = Cws	 
        double[] cvpData_BC; // Kolom 28 = Cvp    

        double[] disp_KMT_BC = new double[16] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80 };
        //double[] heel_KMT_BC = new double[13] { 0, 5, 10, 15, 20, 25, 30, 40, 50, 60, 70, 80, 90 };
        double[] heel_KMT_BC = new double[28] { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90 }; // 20160113


        // trim angle (deg), new Bulk Carrier model scale 1:87, 20150827
        double[] trim_KML_BC = new double[11] { -10, -8, -6, -4, -2, 0, 2, 4, 6, 8, 10 };

        // new data, new Bulk Carrier model scale 1:87, 20150827
        //double KG_BC_LS = 110;    // mm, light-ship KG (INCLINING TEST DATA, 20151230); 
        //double KG_BC_REAL = 110;  // mm from Keel (INCLINING TEST DATA, 20160102); 
        //double KG_BC_LS = 100;    // mm, light-ship KG (INCLINING TEST DATA, 20151230); 
        //double KG_BC_REAL = 100;  // mm from Keel (INCLINING TEST DATA, 20160102); 
        double LCG_BC = 1096.5;   // mm from AP = X0 (CATIA DATA, 20160102); 
        double KG_BC_ORCA3D = 0;  // mm from Keel (vertical position of Zero point in ORCA3D, 20160102); 

        // knt = KN at Transversal Mode
        // lookup table data : kntData(row, column), new Bulk Carrier model scale 1:87, 20160107
        // row   = heel_KMT_BC
        // colum = disp_KMT_BC
        double[,] kntData_2D_BC;

        // tbt = Tranverse CB at Tranversal Mode, ORCA3D = TCB
        // lookup table data : tbtData(row, column), new Bulk Carrier model scale 1:87, 20150827
        // row   = heel_KMT_BC
        // colum = disp_KMT_BC
        double[,] tbtData_2D_BC;

        // vbt = Vertical CB at Tranversal Mode, ORCA3D = VCB
        // lookup table data : vbtData(row, column), new Bulk Carrier model scale 1:87, 20150827
        // row   = heel_KMT_BC
        // colum = disp_KMT_BC
        double[,] vbtData_2D_BC;

        // kbt = KB at Tranversal Mode
        // lookup table data : kbtData(row, column), new Bulk Carrier model scale 1:87, 20150827
        // row   = heel_KMT_BC
        // colum = disp_KMT_BC
        double[,] kbtData_2D_BC;

        // kmt = KM at Tranversal Mode 
        // lookup table data : kmtData(row, column), new Bulk Carrier model scale 1:87, 20150827
        // row   = heel_KMT_BC
        // colum = disp_KMT_BC
        double[,] kmtData_2D_BC;

        // bmt = BM at Tranversal Mode 
        // lookup table data : kmtData(row, column), new Bulk Carrier model scale 1:87, 20150827
        // row   = heel_KMT_BC
        // colum = disp_KMT_BC
        double[,] bmtData_2D_BC;

        // lbt = LCB at Tranversal Mode
        // lookup table data : lbtData(row, column), new Bulk Carrier model scale 1:87, 20150827
        // row   = heel_KMT_BC
        // colum = disp_KMT_BC
        double[,] lbtData_2D_BC;


        // lbl = LCB at Longitudinal Mode
        // lookup table data : lbtData(row, column), new Bulk Carrier model scale 1:87, 20150827
        // row   = trim_KML_BC
        // colum = disp_KMT_BC
        double[,] lblData_2D_BC;

        // kbl = KB at Longitudinal Mode 
        // lookup table data : kblData(row, column), new Bulk Carrier model scale 1:87, 20150827
        // row   = trim_KML_BC
        // colum = disp_KMT_BC
        double[,] kblData_2D_BC;

        // vbl = Vertical CB at Longitudinal Mode, ORCA3D = VCB
        // lookup table data : vblData(row, column), new Bulk Carrier model scale 1:87, 20150827
        // row   = trim_KML_BC
        // colum = disp_KMT_BC
        double[,] vblData_2D_BC;

        // kml = KM at Longitudinal Mode 
        // lookup table data : kmlData(row, column), new Bulk Carrier model scale 1:87, 20150827
        // row   = trim_KML_BC
        // colum = disp_KMT_BC
        double[,] kmlData_2D_BC;

        // bml = BM at Longitudinal Mode 
        // lookup table data : kmlData(row, column), new Bulk Carrier model scale 1:87, 20150827
        // row   = trim_KML_BC
        // colum = disp_KMT_BC
        double[,] bmlData_2D_BC;

        // lfl = LCF at Longitudinal Mode
        // lookup table data : lflData(row, column), new Bulk Carrier model scale 1:87, 20150827
        // row   = trim_KML_BC
        // colum = disp_KMT_BC
        double[,] lflData_2D_BC;

        // kfl = KF at Longitudinal Mode 
        // lookup table data : kflData(row, column), new Bulk Carrier model scale 1:87, 20150827
        // row   = trim_KML_BC
        // colum = disp_KMT_BC
        double[,] kflData_2D_BC;
        #endregion

        #region "Read CSV"
        private void ReadCSV_HS_Data(string strFileName, int row)
        {
            var reader = new StreamReader(File.OpenRead(Application.StartupPath + "\\" + strFileName));
            dspData_BC = new double[row]; // Kolom 1  = Displacement Weight (kgf) 
            drfData_BC = new double[row]; // Kolom 2  = Draft, T (mm)	            
            gmlData_BC = new double[row]; // Kolom 3  = GML (mm)	             
            bmlData_BC = new double[row]; // Kolom 4  = BMl (mm)	    
            lwlData_BC = new double[row]; // Kolom 5  = LWL (mm)	      
            bwlData_BC = new double[row]; // Kolom 6  = BWL (mm)	    
            kbtData_BC = new double[row]; // Kolom 7  = KB (mm)	       
            kmtData_BC = new double[row]; // Kolom 8  = KMT (mm)	  
            gmtData_BC = new double[row]; // Kolom 9  = GMT (mm)	    
            lbtData_BC = new double[row]; // Kolom 10 = LCB (mm)	      
            lflData_BC = new double[row]; // Kolom 11 = LCF (mm)	     
            wtiData_BC = new double[row]; // Kolom 12 = WTI (kgf/cm)   
            mttData_BC = new double[row]; // Kolom 13 = MTT (kgf.m/cm)	
            fflData_BC = new double[row]; // Kolom 14 = FF/LWL	    
            falData_BC = new double[row]; // Kolom 15 = FA/LWL	       
            kmlData_BC = new double[row]; // Kolom 16 = KML (mm)	
            tbtData_BC = new double[row]; // Kolom 17 = TCB (mm)	      
            wtaData_BC = new double[row]; // Kolom 18 = Wet Area (m²) 
            awpData_BC = new double[row]; // Kolom 19 = Awp (m²)	  
            tcfData_BC = new double[row]; // Kolom 20 = TCF (mm)	     
            vcfData_BC = new double[row]; // Kolom 21 = VCF (mm)	   
            bmtData_BC = new double[row]; // Kolom 22 = BMt (mm)	  
            cobData_BC = new double[row]; // Kolom 23 = Cb	   
            copData_BC = new double[row]; // Kolom 24 = Cp	 
            cwpData_BC = new double[row]; // Kolom 25 = Cwp	  
            coxData_BC = new double[row]; // Kolom 26 = Cx	
            cwsData_BC = new double[row]; // Kolom 27 = Cws	 
            cvpData_BC = new double[row]; // Kolom 28 = Cvp    

            int i = 0;
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                if (values.Length >= 28)
                {
                    dspData_BC[i] = Convert.ToDouble(values[0]); // Kolom 1  = Displacement Weight (kgf) 
                    drfData_BC[i] = Convert.ToDouble(values[1]); // Kolom 2  = Draft, T (mm)	            
                    gmlData_BC[i] = Convert.ToDouble(values[2]); // Kolom 3  = GML (mm)	             
                    bmlData_BC[i] = Convert.ToDouble(values[3]); // Kolom 4  = BMl (mm)	    
                    lwlData_BC[i] = Convert.ToDouble(values[4]); // Kolom 5  = LWL (mm)	      
                    bwlData_BC[i] = Convert.ToDouble(values[5]); // Kolom 6  = BWL (mm)	    
                    kbtData_BC[i] = Convert.ToDouble(values[6]); // Kolom 7  = KB (mm)	       
                    kmtData_BC[i] = Convert.ToDouble(values[7]); // Kolom 8  = KMT (mm)	  
                    gmtData_BC[i] = Convert.ToDouble(values[8]); // Kolom 9  = GMT (mm)	    
                    lbtData_BC[i] = Convert.ToDouble(values[9]); // Kolom 10 = LCB (mm)	      
                    lflData_BC[i] = Convert.ToDouble(values[10]); // Kolom 11 = LCF (mm)	     
                    wtiData_BC[i] = Convert.ToDouble(values[11]); // Kolom 12 = WTI (kgf/cm)   
                    mttData_BC[i] = Convert.ToDouble(values[12]); // Kolom 13 = MTT (kgf.m/cm)	
                    fflData_BC[i] = Convert.ToDouble(values[13]); // Kolom 14 = FF/LWL	    
                    falData_BC[i] = Convert.ToDouble(values[14]); // Kolom 15 = FA/LWL	       
                    kmlData_BC[i] = Convert.ToDouble(values[15]); // Kolom 16 = KML (mm)	
                    tbtData_BC[i] = Convert.ToDouble(values[16]); // Kolom 17 = TCB (mm)	      
                    wtaData_BC[i] = Convert.ToDouble(values[17]); // Kolom 18 = Wet Area (m²) 
                    awpData_BC[i] = Convert.ToDouble(values[18]); // Kolom 19 = Awp (m²)	  
                    tcfData_BC[i] = Convert.ToDouble(values[19]); // Kolom 20 = TCF (mm)	     
                    vcfData_BC[i] = Convert.ToDouble(values[20]); // Kolom 21 = VCF (mm)	   
                    bmtData_BC[i] = Convert.ToDouble(values[21]); // Kolom 22 = BMt (mm)	  
                    cobData_BC[i] = Convert.ToDouble(values[22]); // Kolom 23 = Cb	   
                    copData_BC[i] = Convert.ToDouble(values[23]); // Kolom 24 = Cp	 
                    cwpData_BC[i] = Convert.ToDouble(values[24]); // Kolom 25 = Cwp	  
                    coxData_BC[i] = Convert.ToDouble(values[25]); // Kolom 26 = Cx	
                    cwsData_BC[i] = Convert.ToDouble(values[26]); // Kolom 27 = Cws	 
                    cvpData_BC[i] = Convert.ToDouble(values[27]); // Kolom 28 = Cvp    
                }
                i += 1;
            }
        }


        private void ReadCSV_2D_Data(string strFileName, int row, int col, ref double[,] z)
        {
            // correction 20160106, 
            // row    [13] = heel angle  , deg [0	5	10	15	20	25	30	40	50	60	70	80	90]
            // column [16] = displacement, kgf [5	10	15	20	25	30	35	40	45	50	55	60	65	70	75	80]
            z = new double[row, col];

            var reader = new StreamReader(File.OpenRead(Application.StartupPath + "\\" + strFileName));
            int i = 0;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values = line.Split(',');
                if (values.Length >= col)
                {
                    for (int j = 0; j < col; j++)
                    {
                        z[i, j] = Convert.ToDouble(values[j]);
                    }
                }
                i += 1;
            }
        }
        #endregion

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

        // point double value
        struct Point2D
        {
            public double x, y;
        }

        // point double value
        struct Point3D
        {
            public double x, y, z;
        }

        Point2D[] shippoints = new Point2D[26];
        Point2D[] shippoints_init = new Point2D[26];
        Point2D[] shippoints_BC = new Point2D[26]
        {
            new Point2D{x =  -57.5  ,   y =  459.8}, // point 0
            new Point2D{x = -80.5   ,   y =  390.8}, // point 1
            new Point2D{x = -143.7  ,   y =  390.8}, // point 2
            new Point2D{x = -143.7  ,   y =  344.8}, // point 3
            new Point2D{x = -114.9  ,   y =  333.3}, // point 4
            new Point2D{x = -114.9  ,   y =  203.4}, // point 5
            new Point2D{x = -182.1  ,   y =  203.4}, // point 6
            new Point2D{x = -182.1  ,   y =   22.4}, // point 7
            new Point2D{x = -179.9  ,   y =   14.9}, // point 8
            new Point2D{x = -176.4  ,   y =   10.0}, // point 9
            new Point2D{x = -171.0  ,   y =    3.5}, // point 10
            new Point2D{x = -158.0  ,   y =    0.0}, // point 11 
            new Point2D{x =  0.0    ,   y =    0.0}, // point 12
            new Point2D{x =  158.0  ,   y =    0.0}, // point 13
            new Point2D{x =  171.0  ,   y =    3.5}, // point 14
            new Point2D{x =  176.4  ,   y =   10.0}, // point 15
            new Point2D{x =  179.9  ,   y =   14.9}, // point 16
            new Point2D{x =  182.1  ,   y =   22.4}, // point 17
            new Point2D{x =  182.1  ,   y =  203.4}, // point 18
            new Point2D{x =  114.9  ,   y =  203.4}, // point 19
            new Point2D{x =  114.9  ,   y =  333.3}, // point 20
            new Point2D{x =  143.7  ,   y =  344.8}, // point 21 
            new Point2D{x =  143.7  ,   y =  390.8}, // point 22
            new Point2D{x =  80.5   ,   y =  390.8}, // point 23
            new Point2D{x =  57.5   ,   y =  459.8}, // point 24
            new Point2D{x = -57.5   ,   y =  459.8}  // point 25
        };

        Point2D[] shippointslon = new Point2D[33]; // longitudinal hull coordinate
        Point2D[] shippointslon_init = new Point2D[33];
        Point2D[] shippointslon_BC = new Point2D[33]  // Bulk Carrier
        {
            new Point2D{x = -1096.5,    y = 204.0}, // point 0
            new Point2D{x = -1096.5,    y = 128.3}, // point 1
            new Point2D{x =  -970.2,    y =  90.4}, // point 2
            new Point2D{x =  -970.2,    y =  23.1}, // point 3
            new Point2D{x =  -963.9,    y =  14.7}, // point 4
            new Point2D{x =  -953.4,    y =   6.3}, // point 5
            new Point2D{x =  -945.0,    y =   0.0}, // point 6
            new Point2D{x =   -35.6,    y =   0.0}, // point 7
            new Point2D{x =  1080.0,    y =   0.0}, // point 8
            new Point2D{x =  1109.5,    y =   8.4}, // point 9
            new Point2D{x =  1128.5,    y =  25.2}, // point 10
            new Point2D{x =  1145.3,    y =  42.1}, // point 11 
            new Point2D{x =  1151.6,    y =  67.3}, // point 12
            new Point2D{x =  1141.1,    y =  96.7}, // point 13
            new Point2D{x =  1092.7,    y = 136.7}, // point 14
            new Point2D{x =  1090.6,    y = 149.3}, // point 15
            new Point2D{x =  1092.7,    y = 155.6}, // point 16
            new Point2D{x =  1132.7,    y = 231.3}, // point 17
            new Point2D{x =   949.5,    y = 231.3}, // point 18
            new Point2D{x =   924.3,    y = 204.0}, // point 19
            new Point2D{x =  -610.3,    y = 204.0}, // point 20
            new Point2D{x =  -610.3,    y = 402.3}, // point 21
            new Point2D{x =  -667.8,    y = 402.3}, // point 22
            new Point2D{x =  -667.8,    y = 459.8}, // point 23
            new Point2D{x =  -782.7,    y = 459.8}, // point 24
            new Point2D{x =  -782.7,    y = 344.8}, // point 25
            new Point2D{x =  -840.2,    y = 344.8}, // point 26
            new Point2D{x =  -840.2,    y = 459.8}, // point 27
            new Point2D{x =  -897.7,    y = 459.8}, // point 28
            new Point2D{x =  -955.1,    y = 287.4}, // point 29
            new Point2D{x = -1012.6,    y = 287.4}, // point 30
            new Point2D{x = -1012.6,    y = 204.0}, // point 31 
            new Point2D{x = -1096.5,    y = 204.0}  // point 32
        };

        Point2D[] shippointsTopView_BC = new Point2D[30] {  // Bulk Carrier Scale 1:87, top view, 20151223
            new Point2D{x = -1096.5,    y =    0.0}, // point 0
            new Point2D{x = -1096.5,    y = -131.1}, // point 1
            new Point2D{x = -1023.4,    y = -149.9}, // point 2
            new Point2D{x =  -971.0,    y = -163.0}, // point 3
            new Point2D{x =  -903.5,    y = -170.5}, // point 4
            new Point2D{x =  -854.8,    y = -174.2}, // point 5
            new Point2D{x =   580.2,    y = -174.2}, // point 6
            new Point2D{x =   726.3,    y = -168.6}, // point 7
            new Point2D{x =   842.5,    y = -157.4}, // point 8
            new Point2D{x =   956.8,    y = -134.9}, // point 9
            new Point2D{x =   981.1,    y = -148.0}, // point 10
            new Point2D{x =  1044.8,    y = -123.6}, // point 11 
            new Point2D{x =  1091.7,    y =  -97.4}, // point 12
            new Point2D{x =  1127.2,    y =  -65.6}, // point 13
            new Point2D{x =  1151.6,    y =  -16.9}, // point 14
            new Point2D{x =  1151.6,    y =   16.9}, // point 15
            new Point2D{x =  1127.2,    y =   65.6}, // point 16
            new Point2D{x =  1091.7,    y =   97.4}, // point 17
            new Point2D{x =  1044.8,    y =  123.6}, // point 18
            new Point2D{x =   981.1,    y =  148.0}, // point 19
            new Point2D{x =   956.8,    y =  134.9}, // point 20
            new Point2D{x =   842.5,    y =  157.4}, // point 21
            new Point2D{x =   726.3,    y =  168.6}, // point 22
            new Point2D{x =   580.2,    y =  174.2}, // point 23
            new Point2D{x =  -854.8,    y =  174.2}, // point 24
            new Point2D{x =  -903.5,    y =  170.5}, // point 25
            new Point2D{x =  -971.0,    y =  163.0}, // point 26
            new Point2D{x = -1023.4,    y =  149.9}, // point 27
            new Point2D{x = -1096.5,    y =  131.1}, // point 28
            new Point2D{x = -1096.5,    y =    0.0}  // point 29
        };

        double dDispVal = 0;   // displacement value in kgf
        double dHeelVal = 0;   // heel angle in deg
        double dTrimVal = 0;   // trim angle in deg, 20150822
        double dGZVal = 0;     // GZ value in mm
        //double dGZCorVal = 0;  // GZ corrected value in mm
        double dKNVal = 0;     // KN value in mm
        double dKBTVal = 0;    // KB transversal value in mm
        double dKMTVal = 0;    // KM transversal value in mm
        double dBMTVal = 0;    // BM transversal value in mm
        double dTCBVal = 0;    // CB transversal value in mm
        double dVCBVal = 0;    // VCB transversal value in mm
        double dDraftVal = 0;  // draft value in mm
        double dInputVal = 0;  // Input value = Displacement or Draft
        double dOutputVal = 0; // Output value = Displacement or Draft

        double dWTIVal = 0;   // Weight To Immerse value in kgf/cm, 20150901
        double dMTTVal = 0;   // Moment To Trim value in kgf.m/cm, 20150901
        double dCOBVal = 0;   // Coefficient of Block, 20150907
        double dCOPVal = 0;   // Coefficient of Prismatic, 20150907

        //double dKBLVal = 0;    // KB longitudinal value in mm
        double dVBLVal = 0;    // VCB longitudinal value in mm
        double dKMLVal = 0;    // KM longitudinal value in mm
        double dBMLVal = 0;    // BM longitudinal value in mm
        double dLBLVal = 0;    // CB longitudinal value in mm
        double dLFLVal = 0;    // LCF longitudinal value in mm 
        double dVFLVal = 0;    // VCF longitudinal value in mm 
        double dX0Val = 0;     // X0, x position of origin point (analysis frame), from AP (after perpendiculat)


        double dDispVal_Real = 0;   // displacement value in kgf
        //double dHeelVal_Real = 0;   // heel angle in deg
        //double dTrimVal_Real = 0;   // trim angle in deg, 20150822
        double dGZVal_Real = 0;     // GZ value in mm
        //double dGZCorVal_Real = 0;  // GZ corrected value in mm
        double dKNVal_Real = 0;     // KN value in mm
        double dKGVal_Real = 0;     // KG value in mm
        double dKBTVal_Real = 0;    // KB transversal value in mm
        double dVCBVal_Real = 0;    // CB vertical value in mm
        double dKMTVal_Real = 0;    // KM transversal value in mm
        double dBMTVal_Real = 0;    // BM transversal value in mm
        double dTCBVal_Real = 0;    // CB transversal value in mm
        double dDraftVal_Real = 0;  // draft value in mm
        double dInputVal_Real = 0;  // Input value = Displacement or Draft
        double dOutputVal_Real = 0; // Output value = Displacement or Draft

        double dWTIVal_Real = 0;   // Weight To Immerse value in kgf/cm, 20150901
        double dMTTVal_Real = 0;   // Moment To Trim value in kgf.m/cm, 20150901
        double dCOBVal_Real = 0;   // Coefficient of Block, 20150907
        double dCOPVal_Real = 0;   // Coefficient of Prismatic, 20150907

        double dKBLVal_Real = 0;    // KB longitudinal value in mm
        double dKMLVal_Real = 0;    // KM longitudinal value in mm
        double dBMLVal_Real = 0;    // BM longitudinal value in mm
        double dLBLVal_Real = 0;    // CB longitudinal value in mm
        double dLFLVal_Real = 0;    // LCF longitudinal value in mm 
        double dVFLVal_Real = 0;    // KCF longitudinal value in mm 
        double dX0Val_Real = 0;     // X0, x position of origin point (analysis frame), from AP (after perpendiculat)


        Series[] gzcrosscurve_series;
        Series[] gzcrosspoint_series;
        Series[] kncrosscurve_series;
        Series[] kncrosspoint_series;

        // 20160102
        Point3D TMMB_Pos = new Point3D { x = 300, y = 0, z = 106 };
        Point3D TMMD_Pos = new Point3D { x = 1100, y = 0, z = 106 };
        Point3D TKK_Pos = new Point3D { x = 1100, y = 0, z = 275 };
        Point3D TNT_Pos = new Point3D { x = 1225, y = 0, z = 48 };
        Point3D TMMB_Pos_Real = new Point3D();
        Point3D TMMD_Pos_Real = new Point3D();
        Point3D TKK_Pos_Real = new Point3D();
        Point3D TNT_Pos_Real = new Point3D();


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
    }
}
