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
    ///The InputBalance recording.
    /// </summary>
    [TestModule("b7d33a0e-cb9f-4d72-988d-570f28d9c5f0", ModuleType.Recording, 1)]
    public partial class InputBalance : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static InputBalance instance = new InputBalance();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InputBalance()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InputBalance Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.TC_05.Airport_Expand' at 17;23.", repo.JobWindow.TC_05.Airport_ExpandInfo, new RecordItemIndex(0));
            repo.JobWindow.TC_05.Airport_Expand.Click("17;23");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.TC_05.Balance_Toggle' at 15;9.", repo.JobWindow.TC_05.Balance_ToggleInfo, new RecordItemIndex(2));
            repo.JobWindow.TC_05.Balance_Toggle.Click("15;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(3));
            Delay.Duration(1000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.PEAKRONBalanceV1' at 43;7.", repo.SkySuiteEasyJetUAT2.PEAKRONBalanceV1Info, new RecordItemIndex(4));
            //repo.SkySuiteEasyJetUAT2.PEAKRONBalanceV1.Click("43;7");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.RONBalance1AS23TC08020524' at Center.", repo.SkySuiteEasyJetUAT2.RONBalance1AS23TC08020524Info, new RecordItemIndex(5));
            repo.SkySuiteEasyJetUAT2.RONBalance1AS23TC08020524.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(6));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.TC_05.Airport_Expand' at 17;23.", repo.JobWindow.TC_05.Airport_ExpandInfo, new RecordItemIndex(7));
            repo.JobWindow.TC_05.Airport_Expand.Click("17;23");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
