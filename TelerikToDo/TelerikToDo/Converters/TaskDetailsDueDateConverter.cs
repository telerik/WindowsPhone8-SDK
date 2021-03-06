﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Data;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace TelerikToDo
{
	public class TaskDetailsDueDateConverter : IValueConverter
	{
		#region IValueConverter Members

		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			DateTime? dueDate = (DateTime?)value;
			if (!dueDate.HasValue)
			{
				return "NO DUE DATE";
			}
			else if (dueDate.Value.Date == DateTime.Now.Date)
			{
				return "TODAY, " + dueDate.Value.ToShortTimeString();
			}
			else if (dueDate.Value.Date == DateTime.Now.Date.AddDays(1))
			{
				return "TOMORROW, " + dueDate.Value.ToShortTimeString();
			}
			else
			{
				return dueDate.Value.Date.ToShortDateString();
			}
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
