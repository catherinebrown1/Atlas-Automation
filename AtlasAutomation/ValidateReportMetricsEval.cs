﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace AtlasAutomation
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ValidateReportMetricsEval recording.
    /// </summary>
    [TestModule("fbcaae69-d1b1-437d-96a4-9370041f562a", ModuleType.Recording, 1)]
    public partial class ValidateReportMetricsEval : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static ValidateReportMetricsEval instance = new ValidateReportMetricsEval();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateReportMetricsEval()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateReportMetricsEval Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.Report_Tab.Report_Page' at Center.", repo.JobWindow.Report_Tab.Report_PageInfo, new RecordItemIndex(0));
            repo.JobWindow.Report_Tab.Report_Page.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.Report_Tab.Eval_Report_Metrics.Financial_Expand' at Center.", repo.JobWindow.Report_Tab.Eval_Report_Metrics.Financial_ExpandInfo, new RecordItemIndex(2));
            repo.JobWindow.Report_Tab.Eval_Report_Metrics.Financial_Expand.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Total Revenue') on item 'JobWindow.Report_Tab.Eval_Report_Metrics.TotalRevenue'.", repo.JobWindow.Report_Tab.Eval_Report_Metrics.TotalRevenueInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.JobWindow.Report_Tab.Eval_Report_Metrics.TotalRevenueInfo, "Text", "Total Revenue");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "Revenue", repo.JobWindow.Report_Tab.Eval_Report_Metrics.Revenue_Row, false, new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Load Factor (%)') on item 'JobWindow.Report_Tab.Eval_Report_Metrics.LoadFactorPercent'.", repo.JobWindow.Report_Tab.Eval_Report_Metrics.LoadFactorPercentInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.JobWindow.Report_Tab.Eval_Report_Metrics.LoadFactorPercentInfo, "Text", "Load Factor (%)");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "Load Factor", repo.JobWindow.Report_Tab.Eval_Report_Metrics.Load_Factor_Row, false, new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.Report_Tab.Eval_Report_Metrics.Flights_Expand' at Center.", repo.JobWindow.Report_Tab.Eval_Report_Metrics.Flights_ExpandInfo, new RecordItemIndex(7));
            repo.JobWindow.Report_Tab.Eval_Report_Metrics.Flights_Expand.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Total Flights') on item 'JobWindow.Report_Tab.Eval_Report_Metrics.TotalFlights'.", repo.JobWindow.Report_Tab.Eval_Report_Metrics.TotalFlightsInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.JobWindow.Report_Tab.Eval_Report_Metrics.TotalFlightsInfo, "Text", "Total Flights");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "Flight Count", repo.JobWindow.Report_Tab.Eval_Report_Metrics.Flights_Row, false, new RecordItemIndex(9));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.Close_Window' at Center.", repo.JobWindow.Close_WindowInfo, new RecordItemIndex(10));
            repo.JobWindow.Close_Window.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(11));
            Delay.Duration(3000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
