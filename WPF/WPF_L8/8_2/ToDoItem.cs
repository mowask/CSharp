using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_L8_2
{
    internal class ToDoItem : INotifyPropertyChanged
    {
        public string Title { get; set; }
        private int _completion;
        public int Completion
        {
            get
            {
                return _completion;
            }
            set
            {
                //Math.Clamp()
                //_completion = Math.Min(100, Math.Max(0, value));
                if(value > 100)
                {
                    _completion = 100;
                }
                else if(value < 0)
                {
                    _completion = 0;
                }
                else
                {
                    _completion = value;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void onPropertyChanged( string prop)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
