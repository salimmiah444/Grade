using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades1
{
    public class NameChangedEventArgs : EventArgs 
    {
        public string OldValue { get; set; }
        public string  Newvalue { get; set; }
    }
}
