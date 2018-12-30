using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MefPoc
{
    public abstract class ModelViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raise a PropertyChanged event whenever a property changes
        /// </summary>
        /// <param name="target">The property that changed</param>
        protected void RaisePropertyChangedEvent(object target)
        {
            // Check for event listeners
            if(PropertyChanged != null)
            {
                //Fire the event
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(target)));
            }
        }
    }
}
