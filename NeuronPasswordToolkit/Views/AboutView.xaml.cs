﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NeuronPasswordToolkit.Views
{
    /// <summary>
    /// Interaction logic for AboutView.xaml
    /// </summary>
    public partial class AboutView : UserControl
    {
        public static string ViewName = "About";

        public AboutView()
        {
            InitializeComponent();
            versionText.Text = "Application Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }
}
