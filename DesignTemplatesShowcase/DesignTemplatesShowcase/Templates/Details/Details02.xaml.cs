﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Telerik.DesignTemplates.WP.ViewModels;

namespace Telerik.DesignTemplates.WP.Templates.Details
{
    public partial class Details02 : UserControl
    {
        public Details02()
        {
            InitializeComponent();
            this.ItemDetailsPanel.DataContext = new DataItemViewModel()
            {
                Title = "Title",
                Information = "Information"
            };
        }
    }
}
