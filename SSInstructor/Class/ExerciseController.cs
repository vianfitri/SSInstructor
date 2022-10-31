using System;
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
        #endregion

        #region "Properties"
        public static ExerciseMode EMode
        {
            get { return eMode; }
            set { eMode = value; }
        }
        #endregion

        #region "Method"
        #endregion
    }
}
