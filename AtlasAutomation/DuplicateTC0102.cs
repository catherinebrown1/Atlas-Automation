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
    ///The DuplicateTC0102 recording.
    /// </summary>
    [TestModule("81a35962-db57-4acd-8885-075ae49b6fff", ModuleType.Recording, 1)]
    public partial class DuplicateTC0102 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static DuplicateTC0102 instance = new DuplicateTC0102();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DuplicateTC0102()
        {
            jb3Name = "TC_03";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DuplicateTC0102 Instance
        {
            get { return instance; }
        }

#region Variables

        string _jb3Name;

        /// <summary>
        /// Gets or sets the value of variable jb3Name.
        /// </summary>
        [TestVariable("23f7bfcb-7347-4611-acf2-4535eaefee81")]
        public string jb3Name
        {
            get { return _jb3Name; }
            set { _jb3Name = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuite' at 1498;35.", repo.SkySuite.SelfInfo, new RecordItemIndex(0));
            repo.SkySuite.Self.Click("1498;35");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SkySuite.job103' at Center.", repo.SkySuite.job103Info, new RecordItemIndex(1));
            repo.SkySuite.job103.Click(System.Windows.Forms.MouseButtons.Right);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(2));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.DUplicate' at 55;3.", repo.SkySuiteEasyJetUAT2.DUplicateInfo, new RecordItemIndex(3));
            repo.SkySuiteEasyJetUAT2.DUplicate.Click("55;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(4));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.ToCurrentScenario' at 37;16.", repo.SkySuiteEasyJetUAT2.ToCurrentScenarioInfo, new RecordItemIndex(5));
            repo.SkySuiteEasyJetUAT2.ToCurrentScenario.Click("37;16");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
