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
    ///The Duplicate_TC_04 recording.
    /// </summary>
    [TestModule("d24e45cf-a680-496a-abcd-82ca80d47249", ModuleType.Recording, 1)]
    public partial class Duplicate_TC_04 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static Duplicate_TC_04 instance = new Duplicate_TC_04();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Duplicate_TC_04()
        {
            Jb5_Name = "Eval_Peak";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Duplicate_TC_04 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Jb5_Name;

        /// <summary>
        /// Gets or sets the value of variable Jb5_Name.
        /// </summary>
        [TestVariable("13e59bfd-2759-4bdd-8172-44d93a2b1c4f")]
        public string Jb5_Name
        {
            get { return _Jb5_Name; }
            set { _Jb5_Name = value; }
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuite.Evaluation_Jobs' at 15;13.", repo.SkySuite.Evaluation_JobsInfo, new RecordItemIndex(1));
            repo.SkySuite.Evaluation_Jobs.Click("15;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SkySuite.Eval_med' at 43;18.", repo.SkySuite.Eval_medInfo, new RecordItemIndex(2));
            repo.SkySuite.Eval_med.Click(System.Windows.Forms.MouseButtons.Right, "43;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.DUplicate' at 44;14.", repo.SkySuiteEasyJetUAT2.DUplicateInfo, new RecordItemIndex(3));
            repo.SkySuiteEasyJetUAT2.DUplicate.Click("44;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.ToCurrentScenario' at 27;14.", repo.SkySuiteEasyJetUAT2.ToCurrentScenarioInfo, new RecordItemIndex(4));
            repo.SkySuiteEasyJetUAT2.ToCurrentScenario.Click("27;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DuplicateJobToCurrentScenario'.", repo.DuplicateJobToCurrentScenario.SelfInfo, new RecordItemIndex(5));
            Validate.Exists(repo.DuplicateJobToCurrentScenario.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.DuplicateJobToCurrentScenario.Self, false, new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DuplicateJobToCurrentScenario' at 357;28.", repo.DuplicateJobToCurrentScenario.SelfInfo, new RecordItemIndex(7));
            repo.DuplicateJobToCurrentScenario.Self.Click("357;28");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DuplicateJobToCurrentScenario.Job_Name' at CenterRight.", repo.DuplicateJobToCurrentScenario.Job_NameInfo, new RecordItemIndex(8));
            repo.DuplicateJobToCurrentScenario.Job_Name.Click(Location.CenterRight);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back 44}' with focus on 'DuplicateJobToCurrentScenario.Job_Name'.", repo.DuplicateJobToCurrentScenario.Job_NameInfo, new RecordItemIndex(9));
            repo.DuplicateJobToCurrentScenario.Job_Name.PressKeys("{Back 44}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Jb5_Name' with focus on 'DuplicateJobToCurrentScenario.Job_Name'.", repo.DuplicateJobToCurrentScenario.Job_NameInfo, new RecordItemIndex(10));
            repo.DuplicateJobToCurrentScenario.Job_Name.PressKeys(Jb5_Name);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DuplicateJobToCurrentScenario.Create1' at 79;16.", repo.DuplicateJobToCurrentScenario.Create1Info, new RecordItemIndex(11));
            repo.DuplicateJobToCurrentScenario.Create1.Click("79;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(12));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'JobWindow'.", repo.JobWindow.SelfInfo, new RecordItemIndex(13));
            Validate.Exists(repo.JobWindow.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.JobWindow.Self, false, new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow' at Center.", repo.JobWindow.SelfInfo, new RecordItemIndex(15));
            repo.JobWindow.Self.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
