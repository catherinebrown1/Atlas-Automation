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

namespace UAT2.Modules
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The IndustryMedReportValidationUAT2 recording.
    /// </summary>
    [TestModule("abf64066-9d5f-457c-b8dd-517dd95c3fd2", ModuleType.Recording, 1)]
    public partial class IndustryMedReportValidationUAT2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::UAT2.UAT2Repository repository.
        /// </summary>
        public static global::UAT2.UAT2Repository repo = global::UAT2.UAT2Repository.Instance;

        static IndustryMedReportValidationUAT2 instance = new IndustryMedReportValidationUAT2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public IndustryMedReportValidationUAT2()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static IndustryMedReportValidationUAT2 Instance
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.Flight_Expand' at Center.", repo.JobWindow.Flight_ExpandInfo, new RecordItemIndex(2));
            repo.JobWindow.Flight_Expand.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'JobWindow.Flight_Count'.", repo.JobWindow.Flight_CountInfo, new RecordItemIndex(3));
            Validate.Exists(repo.JobWindow.Flight_CountInfo);
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "Flight Count Metric", repo.JobWindow.Flight_Count_Row, false, new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.Traffic_Expand' at Center.", repo.JobWindow.Traffic_ExpandInfo, new RecordItemIndex(5));
            repo.JobWindow.Traffic_Expand.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'JobWindow.Traffic'.", repo.JobWindow.TrafficInfo, new RecordItemIndex(6));
            Validate.Exists(repo.JobWindow.TrafficInfo);
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "Traffic Metric", repo.JobWindow.Traffic_Row, false, new RecordItemIndex(7));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.Close_Window' at Center.", repo.JobWindow.Close_WindowInfo, new RecordItemIndex(8));
            repo.JobWindow.Close_Window.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(9));
            Delay.Duration(3000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
