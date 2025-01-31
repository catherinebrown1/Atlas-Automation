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
    ///The DuplicateTC04___TC5 recording.
    /// </summary>
    [TestModule("d24e45cf-a680-496a-abcd-82ca80d47249", ModuleType.Recording, 1)]
    public partial class DuplicateTC04___TC5 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static DuplicateTC04___TC5 instance = new DuplicateTC04___TC5();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DuplicateTC04___TC5()
        {
            jb5Name = "Eval_Peak";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DuplicateTC04___TC5 Instance
        {
            get { return instance; }
        }

#region Variables

        string _jb5Name;

        /// <summary>
        /// Gets or sets the value of variable jb5Name.
        /// </summary>
        [TestVariable("13e59bfd-2759-4bdd-8172-44d93a2b1c4f")]
        public string jb5Name
        {
            get { return _jb5Name; }
            set { _jb5Name = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuite' at 1390;32.", repo.SkySuite.SelfInfo, new RecordItemIndex(0));
            repo.SkySuite.Self.Click("1390;32");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuite.workbenchView' at Center.", repo.SkySuite.workbenchViewInfo, new RecordItemIndex(1));
            repo.SkySuite.workbenchView.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuite.evaluationJobs' at 15;13.", repo.SkySuite.evaluationJobsInfo, new RecordItemIndex(2));
            repo.SkySuite.evaluationJobs.Click("15;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SkySuite.evalMed' at 43;18.", repo.SkySuite.evalMedInfo, new RecordItemIndex(3));
            repo.SkySuite.evalMed.Click(System.Windows.Forms.MouseButtons.Right, "43;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.DUplicate' at 44;14.", repo.SkySuiteEasyJetUAT2.DUplicateInfo, new RecordItemIndex(4));
            repo.SkySuiteEasyJetUAT2.DUplicate.Click("44;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.ToCurrentScenario' at 27;14.", repo.SkySuiteEasyJetUAT2.ToCurrentScenarioInfo, new RecordItemIndex(5));
            repo.SkySuiteEasyJetUAT2.ToCurrentScenario.Click("27;14");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
