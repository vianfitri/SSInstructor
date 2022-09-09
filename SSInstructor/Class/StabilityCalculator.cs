using System;

public static class StabilityCalculator {
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
}