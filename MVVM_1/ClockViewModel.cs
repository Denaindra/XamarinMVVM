using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace MVVM_1
{
	public class ClockViewModel : INotifyPropertyChanged
	{
		private DateTime dateTime;

		public event PropertyChangedEventHandler PropertyChanged;

		public ClockViewModel()
		{
			this.dateTime = DateTime.Now;
			Device.StartTimer(TimeSpan.FromSeconds(1), () =>
			{
				this.dateTime = DateTime.Now;
				return true;
			});
		}

		public DateTime DateTime
		{
			get
			{
				return dateTime;
			}
			set
			{
				if (dateTime != value)
				{
					dateTime = value;

					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs("DateTime"));
					}
				}
			}
		}

	}
}
