using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SfChartLocalization
{
    public class Model : INotifyPropertyChanged
    {
		private string xValue;
		public string XValue
        {
            get
            {
                return this.xValue;
            }

            set
            {
                if (value != this.xValue)
                {
                    this.xValue = value;
                    OnPropertyChanged("XValue");
                }
            }
        }

        private double high;
        public double High
        {
            get
            {
                return this.high;
            }

            set
            {
                if (value != this.high)
                {
                    this.high = value;
                    OnPropertyChanged("High");
                }
            }
        }

        private double low;
        public double Low
        {
            get
            {
                return this.low;
            }

            set
            {
                if (value != this.low)
                {
                    this.low = value;
                    OnPropertyChanged("Low");
                }
            }
        }

		public Model(string xVal, double highValue, double lowValue)
        {
            this.XValue = xVal;
            this.High = highValue;
            this.Low = lowValue;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
