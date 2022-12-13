using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    static class HelpClass
        {
        public static string Remember
        {
            get { return remember; }
            set { remember = value; /*if (SomeEvent != null) SomeEvent(null, EventArgs.Empty); */}
        }
 
        static string remember;
 
        //public static event EventHandler SomeEvent;
        }
    }    

