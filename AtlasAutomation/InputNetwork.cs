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
    ///The InputNetwork recording.
    /// </summary>
    [TestModule("47b6d959-6f19-41cc-b358-872552cc8ea3", ModuleType.Recording, 1)]
    public partial class InputNetwork : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static InputNetwork instance = new InputNetwork();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InputNetwork()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InputNetwork Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable JbWindow_Title.
        /// </summary>
        [TestVariable("adf59c56-3149-4ee6-bffd-8a261f7a9b4c")]
        public string JbWindow_Title
        {
            get { return repo.JbWindow_Title; }
            set { repo.JbWindow_Title = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow1.SomeContainer.Network_Expand' at 4;4.", repo.JobWindow1.SomeContainer.Network_ExpandInfo, new RecordItemIndex(0));
            repo.JobWindow1.SomeContainer.Network_Expand.Click("4;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow1.SomeContainer.Copy_of_Alliance_Toggle' at 15;17.", repo.JobWindow1.SomeContainer.Copy_of_Alliance_ToggleInfo, new RecordItemIndex(2));
            repo.JobWindow1.SomeContainer.Copy_of_Alliance_Toggle.Click("15;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(3));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.A1GlobalAlliances' at 38;10.", repo.SkySuiteEasyJetUAT2.A1GlobalAlliancesInfo, new RecordItemIndex(4));
            repo.SkySuiteEasyJetUAT2.A1GlobalAlliances.Click("38;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(5));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow1.SomeContainer.Min_Connection_Time_Toggle' at 11;14.", repo.JobWindow1.SomeContainer.Min_Connection_Time_ToggleInfo, new RecordItemIndex(6));
            repo.JobWindow1.SomeContainer.Min_Connection_Time_Toggle.Click("11;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(7));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.A1GlobalMinConnectionTime' at 43;11.", repo.SkySuiteEasyJetUAT2.A1GlobalMinConnectionTimeInfo, new RecordItemIndex(8));
            repo.SkySuiteEasyJetUAT2.A1GlobalMinConnectionTime.Click("43;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(9));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow1.SomeContainer.Multi_Airport_Toggle' at Center.", repo.JobWindow1.SomeContainer.Multi_Airport_ToggleInfo, new RecordItemIndex(10));
            repo.JobWindow1.SomeContainer.Multi_Airport_Toggle.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(11));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.A1GlobalMultiAirportCity' at 31;15.", repo.SkySuiteEasyJetUAT2.A1GlobalMultiAirportCityInfo, new RecordItemIndex(12));
            repo.SkySuiteEasyJetUAT2.A1GlobalMultiAirportCity.Click("31;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(13));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow1.SomeContainer.Partnership_Toggle' at 13;15.", repo.JobWindow1.SomeContainer.Partnership_ToggleInfo, new RecordItemIndex(14));
            repo.JobWindow1.SomeContainer.Partnership_Toggle.Click("13;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(15));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.A1GlobalPartnership' at 59;15.", repo.SkySuiteEasyJetUAT2.A1GlobalPartnershipInfo, new RecordItemIndex(16));
            repo.SkySuiteEasyJetUAT2.A1GlobalPartnership.Click("59;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(17));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow1.SomeContainer.Network_Collapse' at 4;4.", repo.JobWindow1.SomeContainer.Network_CollapseInfo, new RecordItemIndex(18));
            repo.JobWindow1.SomeContainer.Network_Collapse.Click("4;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(19));
            Delay.Duration(1000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
