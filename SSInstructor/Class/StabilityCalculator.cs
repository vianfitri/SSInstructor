using System;
using System.IO;
using System.Text;

public static class StabilityCalculator {

    #region "Hydrostatic Data"
    static double[] dspData_BC; // Kolom 1  = Displacement Weight (kgf) // used
    static double[] drfData_BC; // Kolom 2  = Draft, T (mm) // used	            
    static double[] kbtData_BC; // Kolom 7  = KBT (mm)	// used       
    static double[] kmtData_BC; // Kolom 8  = KMT (mm)	// used  
    static double[] lbtData_BC; // Kolom 10 = LCB (mm), at transversal mode // used      
    static double[] lflData_BC; // Kolom 11 = LCF (mm), at longitudinal mode // used	     
    static double[] wtiData_BC; // Kolom 12 = WTI (kgf/cm) // used  
    static double[] cobData_BC; // Kolom 23 = Cb // used	   
    static double[] copData_BC; // Kolom 24 = Cp // used	 

    static double[] disp_KMT_BC = new double[16] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80 };
    //double[] heel_KMT_BC = new double[13] { 0, 5, 10, 15, 20, 25, 30, 40, 50, 60, 70, 80, 90 };
    static double[] heel_KMT_BC = new double[28] { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90 }; // 20160113

    // trim angle (deg), new Bulk Carrier model scale 1:87, 20150827
    static double[] trim_KML_BC = new double[11] { -10, -8, -6, -4, -2, 0, 2, 4, 6, 8, 10 };

    // new data, new Bulk Carrier model scale 1:87, 20150827
    //double KG_BC_LS = 110;    // mm, light-ship KG (INCLINING TEST DATA, 20151230); 
    //double KG_BC_REAL = 110;  // mm from Keel (INCLINING TEST DATA, 20160102); 
    //double KG_BC_LS = 100;    // mm, light-ship KG (INCLINING TEST DATA, 20151230); 
    //double KG_BC_REAL = 100;  // mm from Keel (INCLINING TEST DATA, 20160102); 
    static double LCG_BC = 1096.5;   // mm from AP = X0 (CATIA DATA, 20160102); 
    static double KG_BC_ORCA3D = 0;  // mm from Keel (vertical position of Zero point in ORCA3D, 20160102); 

    // knt = KN at Transversal Mode
    // lookup table data : kntData(row, column), new Bulk Carrier model scale 1:87, 20160107
    // row   = heel_KMT_BC
    // colum = disp_KMT_BC
    static double[,] kntData_2D_BC;

    // tbt = Tranverse CB at Tranversal Mode, ORCA3D = TCB
    // lookup table data : tbtData(row, column), new Bulk Carrier model scale 1:87, 20150827
    // row   = heel_KMT_BC
    // colum = disp_KMT_BC
    static double[,] tbtData_2D_BC;

    // vbt = Vertical CB at Tranversal Mode, ORCA3D = VCB
    // lookup table data : vbtData(row, column), new Bulk Carrier model scale 1:87, 20150827
    // row   = heel_KMT_BC
    // colum = disp_KMT_BC
    static double[,] vbtData_2D_BC;

    // kbt = KB at Tranversal Mode
    // lookup table data : kbtData(row, column), new Bulk Carrier model scale 1:87, 20150827
    // row   = heel_KMT_BC
    // colum = disp_KMT_BC
    static double[,] kbtData_2D_BC;

    // kmt = KM at Tranversal Mode 
    // lookup table data : kmtData(row, column), new Bulk Carrier model scale 1:87, 20150827
    // row   = heel_KMT_BC
    // colum = disp_KMT_BC
    static double[,] kmtData_2D_BC;

    // bmt = BM at Tranversal Mode 
    // lookup table data : kmtData(row, column), new Bulk Carrier model scale 1:87, 20150827
    // row   = heel_KMT_BC
    // colum = disp_KMT_BC
    static double[,] bmtData_2D_BC;

    // lbt = LCB at Tranversal Mode
    // lookup table data : lbtData(row, column), new Bulk Carrier model scale 1:87, 20150827
    // row   = heel_KMT_BC
    // colum = disp_KMT_BC
    static double[,] lbtData_2D_BC;


    // lbl = LCB at Longitudinal Mode
    // lookup table data : lbtData(row, column), new Bulk Carrier model scale 1:87, 20150827
    // row   = trim_KML_BC
    // colum = disp_KMT_BC
    static double[,] lblData_2D_BC;

    // kbl = KB at Longitudinal Mode 
    // lookup table data : kblData(row, column), new Bulk Carrier model scale 1:87, 20150827
    // row   = trim_KML_BC
    // colum = disp_KMT_BC
    static double[,] kblData_2D_BC;

    // vbl = Vertical CB at Longitudinal Mode, ORCA3D = VCB
    // lookup table data : vblData(row, column), new Bulk Carrier model scale 1:87, 20150827
    // row   = trim_KML_BC
    // colum = disp_KMT_BC
    static double[,] vblData_2D_BC;

    // kml = KM at Longitudinal Mode 
    // lookup table data : kmlData(row, column), new Bulk Carrier model scale 1:87, 20150827
    // row   = trim_KML_BC
    // colum = disp_KMT_BC
    static double[,] kmlData_2D_BC;

    // bml = BM at Longitudinal Mode 
    // lookup table data : kmlData(row, column), new Bulk Carrier model scale 1:87, 20150827
    // row   = trim_KML_BC
    // colum = disp_KMT_BC
    static double[,] bmlData_2D_BC;

    // lfl = LCF at Longitudinal Mode
    // lookup table data : lflData(row, column), new Bulk Carrier model scale 1:87, 20150827
    // row   = trim_KML_BC
    // colum = disp_KMT_BC
    static double[,] lflData_2D_BC;

    // kfl = KF at Longitudinal Mode 
    // lookup table data : kflData(row, column), new Bulk Carrier model scale 1:87, 20150827
    // row   = trim_KML_BC
    // colum = disp_KMT_BC
    static double[,] kflData_2D_BC;

    // Other Data
    //double[,] T2D_gztData;  // GZT table, transversal GZ, 2D look-up table 
    static double[,] T2D_kntData;  // KNT table, transversal KN, 2D look-up table 
    static double[,] T2D_tbtData;  // TCB table, transversal CB, 2D look-up table
    static double[,] T2D_lblData;  // LCB table, longitudinal CB, 2D look-up table
                                   //double[,] T2D_kbtData;  // KBT table, transversal KB, 2D look-up table
    static double[,] T2D_vbtData;  // VCB table, vertical CB, lateral mode, 2D look-up table
                                   //double[,] T2D_kblData;  // KBL table, longitudinal KB, 2D look-up table
    static double[,] T2D_vblData;  // VCB table, vertical CB, longitudinal mode, 2D look-up table
    static double[,] T2D_kmtData;  // KMT table, transversal KM, 2D look-up table
    static double[,] T2D_bmtData;  // BMT table, transversal BM, 2D look-up table
    static double[,] T2D_kmlData;  // KML table, longitudinal KM, 2D look-up table
    static double[,] T2D_bmlData;  // BML table, longitudinal BM, 2D look-up table
    static double[,] T2D_kflData;  // KCF table, longitudinal KF, 2D look-tup table
    static double[,] T2D_lflData;  // LCF table, longitudinal CF, 2D look-up table
    static double[] T1D_drfData;  // draught (draft), 1D look-up table (1D Table = Vector)
    static double[] T1D_dspData;  // displacement, 1D look-up table (1D Table = Vector)
    static double[] T1D_helData;  // heel angle, 1D look-up table (1D Table = Vector)
    static double[] T1D_trmData;  // trim angle, 1D look-up table (1D Table = Vector)
    static double[] T1D_wtiData;  // Weight To Immerse, Ton Per Centimeter, 1D look-up table (1D Table = Vector)
    static double[] T1D_mttData;  // Moment To Trim, Moment to Change Trim, 1D look-up table (1D Table = Vector)
    static double[] T1D_cobData;  // Coefficient of Block, Cb, 1D look-up table (1D Table = Vector)
    static double[] T1D_copData;  // Coefficient of Prismatic, Cp, 1D look-up table (1D Table = Vector)

    //double kgDataOrca3D; // KG Data at ORCA3D,  
    // kgDataOrca3D is vertical position of Zero Point at ORCA3D measured from Keel
    // this is the center point of rotation
    //double kgDataReal;   // KG Data real, the real G point of ship

    static double dDispVal = 0;   // displacement value in kgf
    static double dHeelVal = 0;   // heel angle in deg
    static double dTrimVal = 0;   // trim angle in deg, 20150822
    static double dGZVal = 0;     // GZ value in mm
                                  //double dGZCorVal = 0;  // GZ corrected value in mm
    static double dKNVal = 0;     // KN value in mm
    static double dKBTVal = 0;    // KB transversal value in mm
    static double dKMTVal = 0;    // KM transversal value in mm
    static double dBMTVal = 0;    // BM transversal value in mm
    static double dTCBVal = 0;    // CB transversal value in mm
    static double dVCBVal = 0;    // VCB transversal value in mm
    static double dDraftVal = 0;  // draft value in mm
    static double dInputVal = 0;  // Input value = Displacement or Draft
    static double dOutputVal = 0; // Output value = Displacement or Draft

    static double dWTIVal = 0;   // Weight To Immerse value in kgf/cm, 20150901
    static double dMTTVal = 0;   // Moment To Trim value in kgf.m/cm, 20150901
    static double dCOBVal = 0;   // Coefficient of Block, 20150907
    static double dCOPVal = 0;   // Coefficient of Prismatic, 20150907

    //double dKBLVal = 0;    // KB longitudinal value in mm
    static double dVBLVal = 0;    // VCB longitudinal value in mm
    static double dKMLVal = 0;    // KM longitudinal value in mm
    static double dBMLVal = 0;    // BM longitudinal value in mm
    static double dLBLVal = 0;    // CB longitudinal value in mm
    static double dLFLVal = 0;    // LCF longitudinal value in mm 
    static double dVFLVal = 0;    // VCF longitudinal value in mm 
    static double dX0Val = 0;     // X0, x position of origin point (analysis frame), from AP (after perpendiculat)


    static double dDispVal_Real = 0;   // displacement value in kgf
                                       //double dHeelVal_Real = 0;   // heel angle in deg
                                       //double dTrimVal_Real = 0;   // trim angle in deg, 20150822
    static double dGZVal_Real = 0;     // GZ value in mm
                                       //double dGZCorVal_Real = 0;  // GZ corrected value in mm
    static double dKNVal_Real = 0;     // KN value in mm
    static double dKGVal_Real = 0;     // KG value in mm
    static double dKBTVal_Real = 0;    // KB transversal value in mm
    static double dVCBVal_Real = 0;    // CB vertical value in mm
    static double dKMTVal_Real = 0;    // KM transversal value in mm
    static double dBMTVal_Real = 0;    // BM transversal value in mm
    static double dTCBVal_Real = 0;    // CB transversal value in mm
    static double dDraftVal_Real = 0;  // draft value in mm
    static double dInputVal_Real = 0;  // Input value = Displacement or Draft
    static double dOutputVal_Real = 0; // Output value = Displacement or Draft

    static double dWTIVal_Real = 0;   // Weight To Immerse value in kgf/cm, 20150901
    static double dMTTVal_Real = 0;   // Moment To Trim value in kgf.m/cm, 20150901
    static double dCOBVal_Real = 0;   // Coefficient of Block, 20150907
    static double dCOPVal_Real = 0;   // Coefficient of Prismatic, 20150907

    static double dKBLVal_Real = 0;    // KB longitudinal value in mm
    static double dKMLVal_Real = 0;    // KM longitudinal value in mm
    static double dBMLVal_Real = 0;    // BM longitudinal value in mm
    static double dLBLVal_Real = 0;    // CB longitudinal value in mm
    static double dLFLVal_Real = 0;    // LCF longitudinal value in mm 
    static double dVFLVal_Real = 0;    // KCF longitudinal value in mm 
    static double dX0Val_Real = 0;     // X0, x position of origin point (analysis frame), from AP (after perpendiculat)
    #endregion

    #region "Method"
    
    // function for interpolate lookup table 2D
    public static double Interpolate2D(double xs, double ys, double[] x, double[] y, double[,] z)
    {
        int N = x.Length;
        int M = y.Length;

        int k;
        int i;
        // first check for input x
        if (xs < x[0])  // case 0
        {
            i = 0;
        }
        else if (xs > x[N - 1]) // case 1
        {
            i = N - 2;
        }
        else // case 2
        {
            for (k = 0; k < N - 1; k++)
            {
                if (xs < x[k])
                {
                    break;
                }
            }
            i = k - 1;
        }

        int j;

        // first check for input y
        if (ys < y[0])  // case 0
        {
            j = 0;
        }
        else if (ys > y[M - 1]) // case 1
        {
            j = M - 2;
        }
        else // case 2
        {
            for (k = 0; k < M - 1; k++)
            {
                if (ys < y[k])
                {
                    break;
                }
            }
            j = k - 1;
        }

        double zA = z[i, j];
        double zB = z[i, j + 1];
        double zC = z[i + 1, j + 1];
        double zD = z[i + 1, j];

        double dx = xs - x[i];
        double dy = ys - y[j];
        double delx = x[i + 1] - x[i];
        double dely = y[j + 1] - y[j];

        double zs = zA + dy / dely * (zB - zA) + dx / delx * (zD - zA) + dx / delx * dy / dely * (zA + zC - zB - zD);

        return zs;
    }

    // function for interpolate lookup table 1D
    public static double Interpolate1D(double xs, double[] x, double[] z)
    {
        int N = x.Length;

        int k; 
        int i;
        // first check for input x
        if (xs < x[0])  // case 0
        {
            i = 0;
        }
        else if (xs > x[N - 1]) // case 1
        {
            i = N - 2;
        }
        else // case 2
        {
            for (k = 0; k < N - 1; k++)
            {
                if (xs < x[k])
                {
                    break;
                }
            }
            i = k - 1;
        }

        double zA = z[i];
        double zB = z[i + 1];

        double dx = xs - x[i];
        double delx = x[i + 1] - x[i];

        double zs = zA + dx / delx * (zB - zA);

        return zs;
    }

    public static void rotate_point(ref double px, ref double py, double cx, double cy, double angle_deg)
    {
        double s = Math.Sin(angle_deg * Math.PI / 180);
        double c = Math.Cos(angle_deg * Math.PI / 180);

        // translate point back to origin:
        px -= cx;
        py -= cy;

        // rotate point
        double xnew = px * c - py * s;
        double ynew = px * s + py * c;

        // translate point back:
        px = xnew + cx;
        py = ynew + cy;
    }

    // Calculation Heel And Trim At Given Displacement and CG
    public static void CalculationHeelAndTrim(double Disp, double Gx, double Gy, double Gz, ref double outHeel, ref double outTrim)
    {
        double heeldeg = 0, trimdeg = 0;
        double heelrad = 0, trimrad = 0;

        double heelleftdeg, heelleftrad, heelrightdeg, heelrightrad;
        double trimleftdeg, trimleftrad, trimrightdeg, trimrightrad;

        double Mx, MxLeft, MxRight, dMx, My, MyLeft, MyRight, dMy, Mz, MzLeft, MzRight, dMz;
        double Bx, BxLeft, BxRight, By, ByLeft, ByRight, Bz, BzLeft, BzRight;

        double heelradold = 0, trimradold = 0;
        double deltaphi = 1, deltatheta = 1;
        double f_phi, df_phi, f_theta, df_theta;
        int iCount = 0;
        double errHeel = 0.001; // define error in radians
        double errTrim = 0.001; // define error in radians

        double dKNValLeft, dKNValRight, dKMTValLeft, dKMTValRight, dKMLValLeft, dKMLValRight;

        for (iCount = 0; iCount < 50; iCount++) // heel iteration
        {
            heelleftdeg = heeldeg - 0.1;
            heelrightdeg = heeldeg + 0.1;
            heelleftrad = heelleftdeg * Math.PI / 180;
            heelrightrad = heelrightdeg * Math.PI / 180;

            By = Math.Sign(heeldeg) * Interpolate2D(Math.Abs(heeldeg), Disp, T1D_helData, T1D_dspData, T2D_tbtData);
            Bz = Interpolate2D(Math.Abs(heeldeg), Disp, T1D_helData, T1D_dspData, T2D_vbtData);
            dKMTVal = Interpolate2D(Math.Abs(heeldeg), Disp, T1D_helData, T1D_dspData, T2D_kmtData);

            ByLeft = Math.Sign(heelleftdeg) * Interpolate2D(Math.Abs(heelleftdeg), Disp, T1D_helData, T1D_dspData, T2D_tbtData);
            BzLeft = Interpolate2D(Math.Abs(heelleftdeg), Disp, T1D_helData, T1D_dspData, T2D_vbtData);
            dKMTValLeft = Interpolate2D(Math.Abs(heelleftdeg), Disp, T1D_helData, T1D_dspData, T2D_kmtData);

            ByRight = Math.Sign(heelrightdeg) * Interpolate2D(Math.Abs(heelrightdeg), Disp, T1D_helData, T1D_dspData, T2D_tbtData);
            BzRight = Interpolate2D(Math.Abs(heelrightdeg), Disp, T1D_helData, T1D_dspData, T2D_vbtData);
            dKMTValRight = Interpolate2D(Math.Abs(heelrightdeg), Disp, T1D_helData, T1D_dspData, T2D_kmtData);

            dKNVal = By * Math.Cos(-heelrad) + Bz * Math.Sin(-heelrad);
            dKNValLeft = ByLeft * Math.Cos(-heelleftrad) + BzLeft * Math.Sin(-heelleftrad);
            dKNValRight = ByRight * Math.Cos(-heelrightrad) + BzRight * Math.Sin(-heelrightrad);

            My = dKNVal * Math.Cos(-heelrad) - dKMTVal * Math.Sin(-heelrad);
            Mz = dKNVal * Math.Sin(-heelrad) + dKMTVal * Math.Cos(-heelrad);

            MyLeft = dKNValLeft * Math.Cos(-heelleftrad) - dKNValLeft * Math.Sin(-heelleftrad);
            MzLeft = -dKNValLeft * Math.Sin(-heelleftrad) + dKNValLeft * Math.Cos(-heelleftrad);

            MyRight = dKNValRight * Math.Cos(-heelrightrad) - dKNValRight * Math.Sin(-heelrightrad);
            MzRight = -dKNValRight * Math.Sin(-heelrightrad) + dKNValRight * Math.Cos(-heelrightrad);

            dMy = (MyRight - MyLeft) / 0.2;
            dMz = (MzRight - MzLeft) / 0.2;

            double u = Gy - My;
            double v = Gz - Mz;

            f_phi = Math.Tan(heelrad) - u / v;
            df_phi = 1 / (Math.Cos(heelrad) * Math.Cos(heelrad)) + (dMy * v - u * dMz) / (v * v);
            heelradold = heelrad;
            heelrad = heelradold - f_phi / df_phi;
            heeldeg = heelrad * 180 / Math.PI;
            deltaphi = Math.Abs(heelrad - heelradold);
            if (deltaphi <= errHeel)
            {
                break;
            }
        } // end of heel iteration

        for (iCount = 0; iCount < 50; iCount++) // trim iteration
        {
            trimleftdeg = trimdeg - 0.1;
            trimrightdeg = trimdeg + 0.1;
            trimleftrad = trimleftdeg * Math.PI / 180;
            trimrightrad = trimrightdeg * Math.PI / 180;

            Bx = Interpolate2D(trimdeg, Disp, T1D_trmData, T1D_dspData, T2D_lblData);
            Bz = Interpolate2D(trimdeg, Disp, T1D_trmData, T1D_dspData, T2D_vblData);
            dKMLVal = Interpolate2D(trimdeg, Disp, T1D_trmData, T1D_dspData, T2D_kmlData);

            BxLeft = Interpolate2D(trimleftdeg, Disp, T1D_trmData, T1D_dspData, T2D_lblData);
            BzLeft = Interpolate2D(trimleftdeg, Disp, T1D_trmData, T1D_dspData, T2D_vblData);
            dKMLValLeft = Interpolate2D(trimleftdeg, Disp, T1D_trmData, T1D_dspData, T2D_kmlData);

            BxRight = Interpolate2D(trimrightdeg, Disp, T1D_trmData, T1D_dspData, T2D_lblData);
            BzRight = Interpolate2D(trimrightdeg, Disp, T1D_trmData, T1D_dspData, T2D_vblData);
            dKMLValRight = Interpolate2D(trimrightdeg, Disp, T1D_trmData, T1D_dspData, T2D_kmlData);

            dKNVal = Bx * Math.Cos(trimrad) + Bz * Math.Sin(trimrad);
            dKNValLeft = BxLeft * Math.Cos(trimleftrad) + BzLeft * Math.Sin(trimleftrad);
            dKNValRight = BxRight * Math.Cos(trimrightrad) + BzRight * Math.Sin(trimrightrad);

            Mx = dKNVal * Math.Cos(trimrad) - dKMLVal * Math.Sin(trimrad);
            Mz = dKNVal * Math.Sin(trimrad) + dKMLVal * Math.Cos(trimrad);

            MxLeft = dKNValLeft * Math.Cos(trimleftrad) - dKMLValLeft * Math.Sin(trimleftrad);
            MzLeft = dKNValLeft * Math.Sin(trimleftrad) + dKMLValLeft * Math.Cos(trimleftrad);

            MxRight = dKNValRight * Math.Cos(trimrightrad) - dKMLValRight * Math.Sin(trimrightrad);
            MzRight = dKNValRight * Math.Sin(trimrightrad) + dKMLValRight * Math.Cos(trimrightrad);

            dMx = (MxRight - MxLeft) / 0.2;
            dMz = (MzRight - MzLeft) / 0.2;

            double u = Gx - Mx;
            double v = Gz - Mz;

            f_theta = Math.Tan(trimrad) + u / v;
            df_theta = 1 / (Math.Cos(trimrad) * Math.Cos(trimrad)) + (dMx * v - u * dMz) / (v * v);
            trimradold = trimrad;
            trimrad = trimradold - f_theta / df_theta;
            trimdeg = trimrad * 180 / Math.PI;
            deltatheta = Math.Abs(trimrad - trimradold);
            if (deltatheta <= errTrim)
            {
                break;
            }
        } // end of trim iteration

        outHeel = heeldeg;
        outTrim = trimdeg;
    }

    // Calculation CG
    #endregion
}