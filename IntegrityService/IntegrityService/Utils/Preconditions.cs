/*
 * Created by Ranorex
 * User: skawatra
 * Date: 5/9/2017
 * Time: 5:23 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using System.Configuration;

namespace IntegrityService
{
	/// <summary>
	/// Description of Preconditions.
	/// </summary>
	public static class Preconditions
	{
		public static void Init()
		{
			Mouse.DefaultMoveTime = Convert.ToInt16(ConfigurationManager.AppSettings["DefaultMoveTime"]);
			Keyboard.DefaultKeyPressTime = Convert.ToInt16(ConfigurationManager.AppSettings["DefaultKeyPressTime"]);
			Delay.SpeedFactor = Convert.ToDouble(ConfigurationManager.AppSettings["SpeedFactor"]);
		}
	}
	
	/// <summary>
	/// Class for Loading the Delay timers
	/// </summary>
	public static class DelayTime
    {
        public static int PageConstructor = Convert.ToInt16(ConfigurationManager.AppSettings["DelayPageLoading"]);
        public static int Element = Convert.ToInt16(ConfigurationManager.AppSettings["DelayElement"]);
        public static int Action = Convert.ToInt16(ConfigurationManager.AppSettings["DelayAction"]);
        public static int Visible = Convert.ToInt16(ConfigurationManager.AppSettings["DelayVisible"]);
        public static int Enable = Convert.ToInt16(ConfigurationManager.AppSettings["DelayEnable"]);
    }
}
