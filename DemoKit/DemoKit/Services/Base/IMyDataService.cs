using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DemoKit.Services.Base
{
	public interface IMyDataService
	{
			string GetMessage();
		ObservableCollection<string> GetListNames();
	}
}
