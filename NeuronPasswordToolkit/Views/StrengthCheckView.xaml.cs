﻿using System;
using System.Collections.Generic;
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
    /// Interaction logic for StrengthCheckView.xaml
    /// </summary>
    public partial class StrengthCheckView : UserControl
    {
        public static string ViewName = "Password Strength Checker";

        public StrengthCheckView()
        {
            InitializeComponent();
        }
    }
}
