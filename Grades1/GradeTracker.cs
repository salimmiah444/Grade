using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades1
{
    public abstract class GradeTracker
    {
        public abstract void AddGrade(float grade);
        public abstract GradeStatistics ComuteStatistics();
        public abstract void WriteGuides(TextWriter textWriter);

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("name can not be null or empty");
                }
                if (_name != value)
                {
                    var oldValue = _name;
                    _name = value;
                    if (NameChanged != null)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.OldValue = oldValue;
                        args.Newvalue = value;
                        NameChanged(this, args);
                    }
                }
            }

            //    get;
            //     set;

            //get
            //{
            //    return _name;

            //}
            //set
            //{
            //    if(!string.IsNullOrEmpty(value))
            //    {
            //        _name = value;
            //    }
            //}
        }

        public event NamedChangedDeligate NameChanged;

        private string _name;   
    }
}
