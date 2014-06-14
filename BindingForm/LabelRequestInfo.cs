using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace BindingForm
{
    public class LabelRequestInfo : INotifyPropertyChanged
    {
        private ConsignmentIdentity m_ConsignmentIdentity;
        public ConsignmentIdentity ConsignmentIdentity
        {
            get
            {
                return m_ConsignmentIdentity;
            }
            set
            {
                m_ConsignmentIdentity = value;
                NotifyPropertyChanged("ConsignmentIdentity");
            }
        }
        public DateTime CollectionDateTime { get; set; }
        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion


    }

    public class ConsignmentIdentity : INotifyPropertyChanged
    {
        private int m_ConsignmentNumber;
        public int ConsignmentNumber
        {
            get
            {
                return m_ConsignmentNumber;
            }
            set
            {
                m_ConsignmentNumber = value;
                NotifyPropertyChanged("ConsignmentNumber");
            }
        }
        private string m_CustomerReference;
        public string CustomerReference
        {
            get
            {
                return m_CustomerReference;
            }
            set
            {
                m_CustomerReference = value;
                NotifyPropertyChanged("CustomerReference");
            }
        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
