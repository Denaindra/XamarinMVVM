using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace MVVM_1
{
	public class HslViewModel : INotifyPropertyChanged
	{
		private double hue, saturation, luminosity;
		private Color color;

		public event PropertyChangedEventHandler PropertyChanged;

		public HslViewModel()
		{

		}

		public double Hue
		{
			get
			{
				return hue;
			}
			set
			{
				if (hue != value)
				{
					hue = value;
					OnPropertyChanged("Hue");
					SetNewColor();
				}
			}
		}
		public double Saturation
		{
			set
			{
				if (saturation != value)
				{
					saturation = value;
					OnPropertyChanged("Saturation");
					SetNewColor();
				}
			}
			get
			{
				return saturation;
			}
		}
		public double Luminosity
		{
			set
			{
				if (luminosity != value)
				{
					luminosity = value;
					OnPropertyChanged("Luminosity");
					SetNewColor();
				}
			}
			get
			{
				return luminosity;
			}
		}
		public Color Color
		{
			set
			{
				if (color != value)
				{
					color = value;
					OnPropertyChanged("Color");

					this.Hue = value.Hue;
					this.Saturation = value.Saturation;
					this.Luminosity = value.Luminosity;
				}
			}
			get
			{
				return color;
			}
		}

		void SetNewColor()
		{
			this.Color = Color.FromHsla(this.Hue,
									   this.Saturation,
									   this.Luminosity);
		}

		void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this,
					new PropertyChangedEventArgs(propertyName));
			}
		}

	}
}
