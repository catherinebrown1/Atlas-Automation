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
    ///The AdaptReportValidationUAT2 recording.
    /// </summary>
    [TestModule("0ddd72ec-3d91-4f2f-a45a-060cf5bcfe06", ModuleType.Recording, 1)]
    public partial class AdaptReportValidationUAT2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::AtlasAutomation.AtlasAutomationRepository repository.
        /// </summary>
        public static global::AtlasAutomation.AtlasAutomationRepository repo = global::AtlasAutomation.AtlasAutomationRepository.Instance;

        static AdaptReportValidationUAT2 instance = new AdaptReportValidationUAT2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AdaptReportValidationUAT2()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AdaptReportValidationUAT2 Instance
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
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'JobWindow.Report_Tab.AdaptMedSchedule'.", repo.JobWindow.Report_Tab.AdaptMedScheduleInfo, new RecordItemIndex(1));
            Validate.Exists(repo.JobWindow.Report_Tab.AdaptMedScheduleInfo);
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "Adapt Schedule", repo.JobWindow.Report_Tab.AdaptMedSchedule, false, new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'JobWindow.Report_Tab.ExportJobReportButton'.", repo.JobWindow.Report_Tab.ExportJobReportButtonInfo, new RecordItemIndex(3));
            Validate.Exists(repo.JobWindow.Report_Tab.ExportJobReportButtonInfo);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "Export Job Report Button", repo.JobWindow.Report_Tab.ExportJobReportButton, false, new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=42,Height=36}) on item 'JobWindow.Report_Tab.EditJob'.", repo.JobWindow.Report_Tab.EditJobInfo, new RecordItemIndex(5));
            Validate.CompareImage(repo.JobWindow.Report_Tab.EditJobInfo, EditJob_Screenshot1, EditJob_Screenshot1_Options);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "Edit Job Button", repo.JobWindow.Report_Tab.EditJob, false, new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=42,Height=36}) on item 'JobWindow.Report_Tab.Duplicate_Job_Button'.", repo.JobWindow.Report_Tab.Duplicate_Job_ButtonInfo, new RecordItemIndex(7));
            Validate.CompareImage(repo.JobWindow.Report_Tab.Duplicate_Job_ButtonInfo, Duplicate_Job_Button_Screenshot1, Duplicate_Job_Button_Screenshot1_Options);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "Duplicate Job Button", repo.JobWindow.Report_Tab.Duplicate_Job_Button, false, new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=42,Height=36}) on item 'JobWindow.Report_Tab.NewJobButton'.", repo.JobWindow.Report_Tab.NewJobButtonInfo, new RecordItemIndex(9));
            Validate.CompareImage(repo.JobWindow.Report_Tab.NewJobButtonInfo, NewJobButton_Screenshot1, NewJobButton_Screenshot1_Options);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "New Job Button", repo.JobWindow.Report_Tab.NewJobButton, false, new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=2254,Height=1400}) on item 'JobWindow.Report_Tab.Report_Page'.", repo.JobWindow.Report_Tab.Report_PageInfo, new RecordItemIndex(11));
            Validate.CompareImage(repo.JobWindow.Report_Tab.Report_PageInfo, Report_Page_Screenshot1, Report_Page_Screenshot1_Options);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "Report Page generated successfully", repo.JobWindow.Report_Tab.Report_Page, false, new RecordItemIndex(12));
            
        }

#region Image Feature Data
        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage EditJob_Screenshot1
        { get { return repo.JobWindow.Report_Tab.EditJobInfo.GetScreenshot1(new Rectangle(0, 0, 42, 36)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions EditJob_Screenshot1_Options
        { get { return Imaging.FindOptions.Parse("0.98;None;0,0,42,36;True;10000000;0ms"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage Duplicate_Job_Button_Screenshot1
        { get { return repo.JobWindow.Report_Tab.Duplicate_Job_ButtonInfo.GetScreenshot1(new Rectangle(0, 0, 42, 36)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions Duplicate_Job_Button_Screenshot1_Options
        { get { return Imaging.FindOptions.Parse("0.98;None;0,0,42,36;True;10000000;0ms"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage NewJobButton_Screenshot1
        { get { return repo.JobWindow.Report_Tab.NewJobButtonInfo.GetScreenshot1(new Rectangle(0, 0, 42, 36)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions NewJobButton_Screenshot1_Options
        { get { return Imaging.FindOptions.Parse("0.98;None;0,0,42,36;True;10000000;0ms"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage Report_Page_Screenshot1
        { get { return repo.JobWindow.Report_Tab.Report_PageInfo.GetScreenshot1(new Rectangle(0, 0, 2254, 1400)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions Report_Page_Screenshot1_Options
        { get { return Imaging.FindOptions.Parse("0.97;None;0,0,2254,1400;True;10000000;0ms"); } }

#endregion
    }
#pragma warning restore 0436
}
