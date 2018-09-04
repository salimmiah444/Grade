using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades1
{
    public interface IGradeTracker : IEnumerable
    {
        void AddGrade(float grade);
        GradeStatistics ComuteStatistics();
        void WriteGuides(TextWriter textWriter);
        string Name { get; set; }
        event NamedChangedDeligate NameChanged;
        void DoSomething();

    }

    public abstract class GradeTracker : IGradeTracker
    {
        public abstract void AddGrade(float grade);
        public abstract GradeStatistics ComuteStatistics();
        public abstract void WriteGuides(TextWriter textWriter);
        public abstract IEnumerator GetEnumerator();

        public abstract void DoSomething();


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
