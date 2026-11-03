using System.Windows.Controls;
#nullable disable
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Documents;
using Microsoft.Win32;
using Syncfusion.Windows.Shared;
namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public partial class __VIEW_NAME__ : Page
    {
        public __VIEW_NAME__()
        {
            InitializeComponent();
            Syncfusion.SfSkinManager.SfSkinManager.SetTheme(this, new Syncfusion.SfSkinManager.Theme("{{request.Theme}}"));
        }
    }
}
