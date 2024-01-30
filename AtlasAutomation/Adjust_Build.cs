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
    ///The Adjust_Build recording.
    /// </summary>
    [TestModule("82a846b1-2e7d-4471-a4c2-120a5ef1e8e4", ModuleType.Recording, 1)]
    public partial class Adjust_Build : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static Adjust_Build instance = new Adjust_Build();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Adjust_Build()
        {
            Dates_Low = "15May2023 to 21May2023";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Adjust_Build Instance
        {
            get { return instance; }
        }

#region Variables

        string _Dates_Low;

        /// <summary>
        /// Gets or sets the value of variable Dates_Low.
        /// </summary>
        [TestVariable("7d71d56e-cbc5-497b-b395-d3ef9bf79a53")]
        public string Dates_Low
        {
            get { return _Dates_Low; }
            set { _Dates_Low = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.Job_Details.Adjust_Job_Type' at Center.", repo.JobWindow.Job_Details.Adjust_Job_TypeInfo, new RecordItemIndex(0));
            repo.JobWindow.Job_Details.Adjust_Job_Type.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.Adapt' at Center.", repo.SkySuiteEasyJetUAT2.AdaptInfo, new RecordItemIndex(1));
            repo.SkySuiteEasyJetUAT2.Adapt.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(2));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.Job_Details.Planning_Period' at Center.", repo.JobWindow.Job_Details.Planning_PeriodInfo, new RecordItemIndex(3));
            repo.JobWindow.Job_Details.Planning_Period.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Dates_Low' with focus on 'JobWindow.Job_Details.Planning_Period'.", repo.JobWindow.Job_Details.Planning_PeriodInfo, new RecordItemIndex(4));
            repo.JobWindow.Job_Details.Planning_Period.PressKeys(Dates_Low);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
