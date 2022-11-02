﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSInstructor.Class
{
    public static class ExerciseController
    {
        #region "Enum"
        public enum ExerciseMode
        {
            Training=0,
            Test=1,
        }
        #endregion

        #region "Fields"
        static ExerciseMode eMode;
        static string currScenUC;
        static int vessel_type = 0; // 0 = bulk carrier, 1=general cargo, 2=container
        #endregion

        #region "Properties"
        public static ExerciseMode EMode
        {
            get { return eMode; }
            set { eMode = value; }
        }

        public static string CurrentUCScen
        {
            get { return currScenUC; }
            set { currScenUC = value; }
        }

        public static int VesselType
        {
            get { return vessel_type; }
            set { vessel_type = value; }
        }
        #endregion

        #region "Method"
        #endregion
    }
}
