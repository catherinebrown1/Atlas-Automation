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
    ///The Import_Schedule recording.
    /// </summary>
    [TestModule("16ae0c26-7e6e-4237-b917-44cd424ce098", ModuleType.Recording, 1)]
    public partial class Import_Schedule : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static Import_Schedule instance = new Import_Schedule();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Import_Schedule()
        {
            Sch_Search = "amadeus";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Import_Schedule Instance
        {
            get { return instance; }
        }

#region Variables

        string _Sch_Search;

        /// <summary>
        /// Gets or sets the value of variable Sch_Search.
        /// </summary>
        [TestVariable("c8fbc78c-5ca6-46da-adf0-1a745691b3d1")]
        public string Sch_Search
        {
            get { return _Sch_Search; }
            set { _Sch_Search = value; }
        }

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuite.ScheduLes' at 49;2.", repo.SkySuite.ScheduLesInfo, new RecordItemIndex(0));
            repo.SkySuite.ScheduLes.Click("49;2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuite.SchedulesTabToolbarImportScheduleButton' at 33;18.", repo.SkySuite.SchedulesTabToolbarImportScheduleButtonInfo, new RecordItemIndex(1));
            repo.SkySuite.SchedulesTabToolbarImportScheduleButton.Click("33;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(2));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Open'.", repo.Open.SelfInfo, new RecordItemIndex(3));
            Validate.Exists(repo.Open.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "File explorer opened", repo.Open.Self, false, new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open' at 744;809.", repo.Open.SelfInfo, new RecordItemIndex(5));
            repo.Open.Self.Click("744;809");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.Documents' at 57;25.", repo.Open.DocumentsInfo, new RecordItemIndex(6));
            repo.Open.Documents.Click("57;25");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.SearchEditBox' at Center.", repo.Open.SearchEditBoxInfo, new RecordItemIndex(7));
            repo.Open.SearchEditBox.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(8));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Sch_Search' with focus on 'Open'.", repo.Open.SelfInfo, new RecordItemIndex(9));
            repo.Open.Self.EnsureVisible();
            Keyboard.Press(Sch_Search);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(10));
            Delay.Duration(5000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.ExecuteNow' at 18;17.", repo.Open.ExecuteNowInfo, new RecordItemIndex(11));
            //repo.Open.ExecuteNow.Click("18;17");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(12));
            //Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.ListItem0' at 491;4.", repo.Open.ListItem0Info, new RecordItemIndex(13));
            repo.Open.ListItem0.Click("491;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.ButtonOpen' at 71;24.", repo.Open.ButtonOpenInfo, new RecordItemIndex(14));
            repo.Open.ButtonOpen.Click("71;24");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(15));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ImportSchedule' at 949;30.", repo.ImportSchedule.SelfInfo, new RecordItemIndex(16));
            repo.ImportSchedule.Self.Click("949;30");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ImportSchedule.ImportScheduleFormImportButton' at 11;17.", repo.ImportSchedule.ImportScheduleFormImportButtonInfo, new RecordItemIndex(17));
            repo.ImportSchedule.ImportScheduleFormImportButton.Click("11;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(18));
            Delay.Duration(10000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
