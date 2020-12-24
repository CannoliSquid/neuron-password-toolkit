using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;

namespace NeuronPasswordToolkit
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
		//public string AppVersion;

		//This is if you want to instantiate everything from codebehind. Not Needed.
		private void Application_Startup(object sender, StartupEventArgs e)
		{
			/*// Create the startup window
			MainWindow wnd = new MainWindow();
			// Do stuff here, e.g. to the window
			wnd.Title = "Neuron Password Toolkit";
			// Show the window
			wnd.Show();*/

			//AppVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
		}
	}
}
