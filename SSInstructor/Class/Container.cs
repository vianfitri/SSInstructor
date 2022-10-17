using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSInstructor.Class
{
    public class Container
    {
        #region "Fields"
        float weight = 0;
        float posx = 0;
        float posy = 0;
        float posz = 0;
        #endregion

        #region "Constructor"
        public Container() { }
        #endregion

        #region "Properties"
        public float Weight { 
            get => weight; 
            set => weight = value; 
        }

        public float Posx {
            get => posx; 
            set => posx = value; 
        }

        public float Posy { 
            get => posy; 
            set => posy = value; 
        }

        public float Posz { 
            get => posz; 
            set => posz = value; 
        }
        #endregion

        #region "Method"

        #endregion
    }
}
