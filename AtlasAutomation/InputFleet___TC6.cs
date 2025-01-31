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
    ///The InputFleet___TC6 recording.
    /// </summary>
    [TestModule("f0537f3f-8d9e-4b00-afef-387a794bf7c7", ModuleType.Recording, 1)]
    public partial class InputFleet___TC6 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static InputFleet___TC6 instance = new InputFleet___TC6();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InputFleet___TC6()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InputFleet___TC6 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.TC_06.Aircraft_Expand' at 17;18.", repo.JobWindow.TC_06.Aircraft_ExpandInfo, new RecordItemIndex(0));
            repo.JobWindow.TC_06.Aircraft_Expand.Click("17;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.TC_06.Fleet_Size_Toggle' at 10;9.", repo.JobWindow.TC_06.Fleet_Size_ToggleInfo, new RecordItemIndex(2));
            repo.JobWindow.TC_06.Fleet_Size_Toggle.Click("10;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(3));
            Delay.Duration(1000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.LoadFromDatabase' at Center.", repo.SkySuiteEasyJetUAT2.LoadFromDatabaseInfo, new RecordItemIndex(4));
            //repo.SkySuiteEasyJetUAT2.LoadFromDatabase.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AddDatasetFromDatabase' at Center.", repo.AddDatasetFromDatabase.SelfInfo, new RecordItemIndex(5));
            //repo.AddDatasetFromDatabase.Self.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AddDatasetFromDatabase.AnyPeriod' at Center.", repo.AddDatasetFromDatabase.AnyPeriodInfo, new RecordItemIndex(6));
            //repo.AddDatasetFromDatabase.AnyPeriod.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(7));
            //Delay.Duration(1000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'AddDatasetFromDatabase.LOWFleetSizeV1V1' at Center.", repo.AddDatasetFromDatabase.LOWFleetSizeV1V1Info, new RecordItemIndex(8));
            //repo.AddDatasetFromDatabase.LOWFleetSizeV1V1.DoubleClick();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.FleetSize1AS23TC09020524' at Center.", repo.SkySuiteEasyJetUAT2.FleetSize1AS23TC09020524Info, new RecordItemIndex(9));
            repo.SkySuiteEasyJetUAT2.FleetSize1AS23TC09020524.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(10));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.TC_06.Aircraft_Expand' at 18;19.", repo.JobWindow.TC_06.Aircraft_ExpandInfo, new RecordItemIndex(11));
            repo.JobWindow.TC_06.Aircraft_Expand.Click("18;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(12));
            Delay.Duration(1000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
