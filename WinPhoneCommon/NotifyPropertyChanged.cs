﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using WinPhoneCommon.Properties;

namespace WinPhoneCommon
{
	public class NotifyPropertyChanged:INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null)
				handler(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
