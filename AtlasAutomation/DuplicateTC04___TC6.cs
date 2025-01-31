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
    ///The DuplicateTC04___TC6 recording.
    /// </summary>
    [TestModule("0a2398c0-c4b7-4f73-87a4-c23533c1e570", ModuleType.Recording, 1)]
    public partial class DuplicateTC04___TC6 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static DuplicateTC04___TC6 instance = new DuplicateTC04___TC6();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DuplicateTC04___TC6()
        {
            jb6Name = "Eval_Low";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DuplicateTC04___TC6 Instance
        {
            get { return instance; }
        }

#region Variables

        string _jb6Name;

        /// <summary>
        /// Gets or sets the value of variable jb6Name.
        /// </summary>
        [TestVariable("5874f551-af5f-4b9f-ae88-3133b7be326c")]
        public string jb6Name
        {
            get { return _jb6Name; }
            set { _jb6Name = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuite' at 1261;28.", repo.SkySuite.SelfInfo, new RecordItemIndex(0));
            repo.SkySuite.Self.Click("1261;28");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SkySuite.evalMed2' at Center.", repo.SkySuite.evalMed2Info, new RecordItemIndex(1));
            repo.SkySuite.evalMed2.Click(System.Windows.Forms.MouseButtons.Right);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.DUplicate' at 18;7.", repo.SkySuiteEasyJetUAT2.DUplicateInfo, new RecordItemIndex(2));
            repo.SkySuiteEasyJetUAT2.DUplicate.Click("18;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuite.scenarioTreeListView' at 558;222.", repo.SkySuite.scenarioTreeListViewInfo, new RecordItemIndex(3));
            repo.SkySuite.scenarioTreeListView.Click("558;222");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
