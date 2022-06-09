using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ViControls
{
    public class ViPanel : Panel
    {
        #region Fields
        private int mMatrixRound = 8;
        private Color mBack;
        #endregion

        #region Constructor
        public ViPanel()
        {
            this.Size = new Size(200, 100);
        }
        #endregion

        #region Properties
        public int MMatrixRound {
            get { return mMatrixRound; }
            set { mMatrixRound = value; }
        }
        public Color MBack {
            get { return mBack; }
            set { mBack = value; }
        }
        #endregion

        #region Override Method
        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            base.Refresh();
        }
        #endregion


    }
}
