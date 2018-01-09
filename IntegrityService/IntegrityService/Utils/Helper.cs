/*
 * Created by Ranorex
 * User: skawatra
 * Date: 5/9/2017
 * Time: 5:31 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using System.Configuration;
using System.Windows.Forms;
using System.IO;
using RanxForms = Ranorex.Form;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Controls;
using System.Diagnostics;

namespace IntegrityService
{
	/// <summary>
	/// Description of Helper.
	/// </summary>
	public static class Helper
	{
		#region VARIABLES
		private static WebDocument webDoc;
		private static Ranorex.Form form;
		public static bool found = false;
		public static WebElement RefElement = null;
		public static string testDomain =string.Empty;
		public static string testBrowser =string.Empty;
		public static string domString = string.Empty;
		public static string Clientname=".//span[#'IndexMenu_ClientID']";
		#endregion
		
		#region PROPERTIES
		public static WebDocument WebDoc
		{
			get
			{
				return webDoc;
			}
			set
			{
				webDoc = new WebDocument(value);
			}
		}
		public static Ranorex.Form CurrentForm
		{
			get
			{
				return form;
			}
			set
			{
				form = new Ranorex.Form(value);
			}
		}
		#endregion
		
		/// <summary>
		/// Method to fill the value into field
		/// </summary>
		/// <param name="element"></param>
		/// <param name="value"></param>
		public static void EnterText(string PageElement, string Value)
		{
			try
			{
				WaitForTimeInMilliSeconds(DelayTime.Action);
				var element = GetElement(PageElement);
				WaitForTimeInMilliSeconds(DelayTime.Action);
				if(!element.Visible)
				{
					ScrollToVisibleElement(element);
				}
				if(element.Visible)
				{
					FocusOnElement(element);
					if(string.IsNullOrEmpty(element.TagValue))
					{
						element.Click();
						Keyboard.Press(Value);
					}
					else
						element.PressKeys("{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}" + Value);
				}
				else
				{
					throw new ElementNotFoundException();
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error Message - " + ex.ToString());
			}
		}
		
		/// <summary>
		/// Method to wait for specific time in Milli Seconds
		/// </summary>
		/// <param name="time"></param>
		public static void WaitForTimeInMilliSeconds(int Time)
		{
			try
			{
				Delay.Milliseconds(Time);
			}
			catch (Exception ex)
			{
				throw new Exception("Error Message : " + ex.ToString());
			}
		}
		
		
		/// <summary>
		/// Method to move the mouse focus onto element
		/// </summary>
		/// <param name="ElementUnderTest"></param>
		public static void FocusOnElement(WebElement ElementUnderTest)
		{
			try
			{
				ElementUnderTest.MoveTo();
			}
			catch (Exception ex)
			{
				throw new Exception("Error Message - " + ex.ToString());
			}
			
		}
		
		/// <summary>
		/// Method to move the mouse focus onto element using rpath directly.
		/// </summary>
		/// <param name="ElementUnderTest"></param>
		public static WebElement GetElementAndFocus(string rPath,int? Delay = null)
		{
			try
			{
				if (Delay == null)
				{
					Delay = DelayTime.Element;
				}
				var element = WebDoc.FindSingle<WebElement>(rPath, Delay);
				
				element.MoveTo();
				
				return element;
			}
			catch (Exception ex)
			{
				throw new Exception("Error Message - " + ex.ToString());
			}
			
		}
		
		
		/// <summary>
		/// Method to select the element on page by single click
		/// </summary>
		/// <param name="ElementUnderTest"></param>
		public static void SelectElement_SingleClick(WebElement ElementUnderTest)
		{
			try
			{
				ElementUnderTest.MoveTo();
				ElementUnderTest.Focus();
				ElementUnderTest.Click();
		}
			catch (Exception ex)
			{
				throw new Exception("Error Message - " + ex.ToString());
			}
		}
		
		/// <summary>
		/// overloaded method to scroll to visible element
		/// </summary>
		/// <param name="PageElement"></param>
		public static void ScrollToVisibleElement(WebElement ElementUnderTest)
		{
			try
			{
				Report.Log(ReportLevel.Debug, "Scroll to element '" + ElementUnderTest.Id + "'");

				int Temp_delta_Y, delta_Y, LoopIteration = 1, MaxLoopIterations = 10;
				bool ContinueLooping = true;
				
				// Get WebElment and Mouse positions
				var elementPosition = ElementUnderTest.ScreenRectangle.Location;
				var mousePosition = Mouse.Position;

				// Get Delta Y
				delta_Y = mousePosition.Y - ElementUnderTest.ScreenRectangle.Location.Y;	// positive value forward;
				
				do{
					Temp_delta_Y = delta_Y;
					Mouse.ScrollWheel(delta_Y);
					Delay.Milliseconds(DelayTime.Action);
					ElementUnderTest = RefreshElement(ElementUnderTest);
					delta_Y = mousePosition.Y - ElementUnderTest.ScreenRectangle.Location.Y;
					if(delta_Y == Temp_delta_Y)
					{
						if (LoopIteration >= MaxLoopIterations)
							ContinueLooping = false;
						else
							LoopIteration++;
					}
				}while(delta_Y != 0 && (delta_Y * Temp_delta_Y) > 0 && !ElementUnderTest.Visible && ContinueLooping);
			}
			catch (Exception ex)
			{
				throw new Exception("Error Message - " + ex.ToString());
			}
		}
		
		/// <summary>
		/// Method to Click the element
		/// </summary>
		/// <param name="PageElement"></param>
		public static void ClickElement(string PageElement)
		{
			try
			{
				var element = GetElement(PageElement);
				WaitForTimeInMilliSeconds(DelayTime.Action);
				if(!element.Visible)
					ScrollToVisibleElement(PageElement);
				if(element.Visible)
				{
					FocusOnElement(element);
					SelectElement_SingleClick(element);
				}
				else
				{
					throw new ElementNotFoundException();
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error Message - " + ex.ToString());
			}
		}
		
		/// Method to highlight the element
		/// </summary>
		/// <param name="ElementToHighlight"></param>
		public static void HighlightElement(string ElementToHighlight)
		{
			try
			{
				Highlighter high = new Highlighter();
				Regex regReplace = new Regex(".");
				ElementToHighlight = regReplace.Replace(ElementToHighlight, "", 1);
				WebElement we = domString + ElementToHighlight;
				high.Hide();
				high.UpdateFromElement(we);
				high.Show(5);
				WaitForTimeInMilliSeconds(400);
				high.Hide();
			}
			catch (Exception ex)
			{
				throw new Exception("Error Message : " + ex.ToString());
			}
			
		}
		
		/// Method to refresh element
		/// </summary>
		/// <param name="element"></param>
		/// <returns></returns>
		public static WebElement RefreshElement(WebElement element)
		{
			string ElementPath = element.GetPath().ToString();
			WebElement RefreshedElement = null;
			try
			{
				RefreshedElement = GetElement(ElementPath);
			}
			catch
			{
				char[] Delimiters = new char[] { '/' };
				String[] PathSplit = ElementPath.Split(Delimiters,StringSplitOptions.RemoveEmptyEntries);
				string Relativepath = PathSplit[PathSplit.Length -1];
				RefreshedElement = GetElement(".//" + Relativepath,200);
			}
			return RefreshedElement;
		}
		

		/// <summary>
		/// Performs the playback of actions in this module.
		/// </summary>
		/// <remarks>You should not call this method directly, instead pass the module
		/// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
		/// that will in turn invoke this method.</remarks>
		public static bool IsUserAlreadyLoggedIn(string Element)
		{
			try
			{
				if(WebDoc.TryFindSingle<WebElement>(Element, DelayTime.Enable, out RefElement))
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error Message - " + ex.ToString());
			}
			
		}
		
		/// <summary>
		/// Method to close all browser before starting test
		/// </summary>
		public static void CloseBrowser()
		{
			try
			{
				Process[] AllProcesses = Process.GetProcesses();
				foreach (var process in AllProcesses)
				{
					string browserName = process.ProcessName.ToLower();
					if (browserName == "iexplore" || browserName == "iexplorer" || browserName == "chrome" || browserName == "firefox" )
						process.Kill();
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error Details - " + ex.ToString());
			}
		}
		
		/// <summary>
		// To close the current Tab.
		/// </summary>
		public static void CloseTab()
		{
			
			Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+W' Press.");
			Keyboard.Press(System.Windows.Forms.Keys.W | System.Windows.Forms.Keys.Control, 17, Keyboard.DefaultKeyPressTime, 1, true);
			
		}
		
		/// <summary>
		/// Method to Close the Server Instance
		/// </summary>
		public static void CloseInstance()
		{
			try
			{
				if (Host.Local.FindSingle<WebDocument>(domString).Enabled)
				{
					Host.Local.FindSingle<WebDocument>(domString).Close();
					Report.Log(ReportLevel.Info,"Closed the Instance.");
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error message : " + ex.ToString());
			}
		}
		
		/// <summary>
		/// Method to load the Browser, Domain and Dom string
		/// </summary>
		public static void LoadSettings(string Browser, string Domain)
		{
			testBrowser = Browser;
			testDomain = Domain;
			domString = "./dom[@domain~'" + testDomain + "' and @caption~'"+"ProMonitor" + "']";
		}
		
		/// <summary>
		/// Method to return the Ranorex Adapter element
		/// </summary>
		/// <param name="rPath"></param>
		/// <param name="delay"></param>
		/// <returns></returns>
		public static WebElement GetElement(string RPath, int? Delay = null)
		{
			try
			{
				if (Delay == null)
				{
					Delay = DelayTime.Element;
				}
				var element = WebDoc.FindSingle<WebElement>(RPath, Delay);
				return element;
			}
			catch (Exception ex)
			{
				throw new Exception("Can't get element with rPath '" + RPath + "'. Details: " + ex.Message.ToString());
			}
		}
		
		
		/// <summary>
		/// Method to Open the Server Instance
		/// </summary>
		public static void OpenLoginPage(string Url)
		{
			try
			{
				Host.Local.OpenBrowser(Url,testBrowser,false,true);
				Report.Log(ReportLevel.Info, "Opened Server Instance'" + Url + "' in browser '" + testBrowser + "'.");
				Report.Log(ReportLevel.Info,"Initialize Web Document"+ domString);
				InitializeWebDocument(domString);
				Report.Log(ReportLevel.Info,"Initialize Web Document"+ domString);
			}
			catch (Exception ex)
			{
				throw new Exception("Error Details - " + ex.ToString());
			}
		}
		
		/// <summary>
		/// Method to check Element visibility on page
		/// </summary>
		/// <param name="PageElement"></param>
		/// <returns></returns>
		public static bool IsElementVisible(string PageElement)
		{
			try
			{
								
				var element = GetElement(PageElement);
				WaitForTimeInMilliSeconds(DelayTime.Element);
												
				if(element.Visible)
				{
								
					FocusOnElement(element);			
					HighlightElement(PageElement);				
										
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error Message - " + ex.ToString());
			}
		}
		
		/// <summary>
		/// Method to verify inner element value
		/// </summary>
		/// <param name="FName"></param>
		/// <param name="LName"></param>
		/// <param name="Div"></param>
		/// <returns></returns>
		public static bool VerifyInnerHtmlValue(string ValueToCheck, string AreaToCheck)
		{
			try
			{   var area = GetElement(AreaToCheck);
				var innerHtml = area.GetInnerHtml();
				if (innerHtml.Contains(ValueToCheck))
				{
					return true;
				}
				else
				{
					return false;
				}
				
			}
			catch (Exception ex)
			{
				throw new Exception("Error Message - " + ex.ToString());
			}
		}
		
		/// <summary>
		/// Method to Print the Autopopulaion list in Report.
		/// </summary>
		public static void AutoPopulationVerification(string ElementUnderTest)
    	{
    		try
    		{
    		//	WaitForElementVisible(ElementUnderTest);
    			var allElements = GetElement(ElementUnderTest);
    			string elem = String.Empty;
    			bool flag = true;
    			int i =1;
    			while(flag)
    				{
    				elem = ElementUnderTest + "[" + i.ToString() + "]/div";
    				var webELem = GetElement(elem);
    				
    				if(webELem ==null)
    				{
    					flag = false;
    				}
    				else 
    					Report.Log(ReportLevel.Info,"Entered Search '" + webELem.InnerText + "'.");
    				
    				i++;
    			}
    			
    		//	int Start=0, End=0;
       		
    		}
    		
			catch (Exception ex)
			{
				throw new Exception("Error Message - " + ex.ToString());
			}
			
    	}
		
		/// <summary>
		/// Method to wait till Web Document is loaded
		/// </summary>
		public static void WaitTillPageIsLoaded()
		{
			try
			{
				WebDoc.WaitForDocumentLoaded(DelayTime.PageConstructor);
				WaitForTimeInMilliSeconds(DelayTime.Enable);
			}
			catch(Exception ex)
			{
				throw new Exception("Error Message : " + ex.ToString());
			}
		}
		
		/// <summary>
		/// Method to initialize the Web Document opened as a Browser
		/// </summary>
		public static void InitializeWebDocument(string DomString)
		{
			try
			{
				WebDoc = Host.Local.FindSingle<WebDocument>(DomString, DelayTime.Element);
			}
			
			catch(Exception ex)
				
			{
				Keyboard.Press(Keys.Enter);
				WebDoc = Host.Local.FindSingle<WebDocument>(DomString, DelayTime.Element);
			}
		}
		
		/// <summary>
		/// Get Page URL
		/// </summary>
		/// <returns></returns>
		public static string GetPageUrl()
		{
			try
			{
				return WebDoc.PageUrl.ToString();
			}
			catch (Exception ex)
			{
				throw new Exception("Error Message - " + ex.ToString());
			}
			
		}
		
		/// <summary>
		/// Method for waiting till element is visible
		/// </summary>
		/// <param name="element"></param>
		/// <param name="time"></param>
		public static void WaitForElementVisible(WebElement element, int time = 0)
		{
			try
			{
				for (var i = 0; i < (time == 0 ? DelayTime.Visible : time) / 2000; i++)
				{
					if (element.Visible)
						break;
					Report.Log(ReportLevel.Debug,"Waiting for visible element '" + element.Id + "': " + (i+1) +" seconds.");
					Delay.Seconds(5);
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error Message : " + ex.ToString());
			}
			
		}
		
		/// <summary>
		/// Get contents between controls
		/// </summary>
		/// <param name="content"></param>
		/// <param name="startString"></param>
		/// <param name="endString"></param>
		/// <returns></returns>
		public static string GetBetweenControl(string content, string startString, string endString)
    	{
	        int Start=0, End=0;
	        if (content.Contains(startString) && content.Contains(endString))
	        {
	            Start = content.IndexOf(startString, 0) + startString.Length;
	            End = content.IndexOf(endString, Start);
	            return content.Substring(Start, End - Start);
	        }
	        else
	            return string.Empty;
		}
		
		/// <summary>
		/// Set Log for entire application
		/// </summary>
		/// <param name="type"></param>
		/// <param name="log"></param>
		
		public static void SetReportLog(ReportLevel type,string log)
		{
			string strLog = "Date:"  + System.DateTime.Now.ToShortDateString() + "\n" + log;
			Report.Log(type,strLog);
		}
	
	
		
		public static string GetClientId()
	{
			var client_Element =Helper.GetElement(Clientname);
			var innerthtml = client_Element.GetInnerHtml();
		//	var innerthtml = client_Element.ToString();
    	//	var Client=innerthtml.Replace("{SpanTag:","").Replace("}","");
    		return (innerthtml);
	}
		
		public static string GetValueTxtField(string elements)
		{
		
			try
			{   var webelement1 =Helper.GetElement(elements);
				return webelement1.TagValue;		
			}
			catch(Exception ex)
			{
			return "";
			}
		}
	
		
		public static string[] GetDropdownvalue(string elements)
		{
			
			try
			{ 	var webelement2 =Helper.GetElement(elements);
				string[] arr = new string[5];
					for (int i=0;i <5;i++)
					{
						arr[i]=Convert.ToString(webelement2.Children[i]);
					}
				return arr;
					
		//	var drop =webelement2.GetInnerHtml;
		//	 string drop =webelement2[0].v
		//		return(drop);
			}
		catch(Exception ex)
			{
			return null;
			}
		}
	}
}
