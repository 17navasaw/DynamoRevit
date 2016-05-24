﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dynamo.Applications
{
    /// <summary>
    /// Interaction logic for AssemblyLoadWarning.xaml
    /// </summary>
    public partial class AssemblyLoadWarning : Window
    {
        private readonly AssemblyName assemblyLoading;
        private readonly AssemblyName alreadyLoadedAssembly;
        public bool doNotShowNextTime { get; set; }

        public AssemblyLoadWarning(AssemblyName assemblyLoading, AssemblyName alreadyLoadedAssembly)
        {
            this.assemblyLoading = assemblyLoading;
            this.alreadyLoadedAssembly = alreadyLoadedAssembly;
            InitializeComponent();
        }

        private void ShowDetails_ButtonClick(object sender, RoutedEventArgs e)
        {
            Details.Text = string.Format(Properties.Resources.MismatchedAssemblyVersion, assemblyLoading.FullName, alreadyLoadedAssembly.FullName);
            if(Details.Visibility == Visibility.Collapsed)
            {
                Details.Visibility = Visibility.Visible;
            }
            else
            {
                Details.Visibility = Visibility.Collapsed;
            }
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = this.doNotShowNextTime;
            this.Close();
        }

       
    }
}
