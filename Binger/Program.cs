﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binger
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			NativeMethods.EnableDpiAwareness();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			using (var mainForm = new BingerUI())
			{
				Application.Run(mainForm);
			}
		}
	}
}
