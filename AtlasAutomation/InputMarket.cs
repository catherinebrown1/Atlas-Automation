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
    ///The InputMarket recording.
    /// </summary>
    [TestModule("6bc4b5f2-5a89-42a8-86d5-0f86e4d80766", ModuleType.Recording, 1)]
    public partial class InputMarket : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static InputMarket instance = new InputMarket();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InputMarket()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InputMarket Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.TC_01.Market_Expand' at Center.", repo.JobWindow.TC_01.Market_ExpandInfo, new RecordItemIndex(0));
            repo.JobWindow.TC_01.Market_Expand.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.TC_01.Market_Size_Toggle' at Center.", repo.JobWindow.TC_01.Market_Size_ToggleInfo, new RecordItemIndex(2));
            repo.JobWindow.TC_01.Market_Size_Toggle.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(3));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.A1MarketSizeS22Med' at 42;11.", repo.SkySuiteEasyJetUAT2.A1MarketSizeS22MedInfo, new RecordItemIndex(4));
            repo.SkySuiteEasyJetUAT2.A1MarketSizeS22Med.Click("42;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(5));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.TC_01.Passenger_Toggle' at Center.", repo.JobWindow.TC_01.Passenger_ToggleInfo, new RecordItemIndex(6));
            repo.JobWindow.TC_01.Passenger_Toggle.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(7));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.A1GlobalPassengerType' at 38;8.", repo.SkySuiteEasyJetUAT2.A1GlobalPassengerTypeInfo, new RecordItemIndex(8));
            repo.SkySuiteEasyJetUAT2.A1GlobalPassengerType.Click("38;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(9));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.TC_01.Market_Collapse' at Center.", repo.JobWindow.TC_01.Market_CollapseInfo, new RecordItemIndex(10));
            repo.JobWindow.TC_01.Market_Collapse.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(11));
            Delay.Duration(1000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
