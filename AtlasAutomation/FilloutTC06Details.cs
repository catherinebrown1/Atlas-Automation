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
    ///The FilloutTC06Details recording.
    /// </summary>
    [TestModule("b879c32e-7905-4133-87d8-1c2ac451c79f", ModuleType.Recording, 1)]
    public partial class FilloutTC06Details : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static FilloutTC06Details instance = new FilloutTC06Details();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FilloutTC06Details()
        {
            Jb6_Name = "Eval_Low";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FilloutTC06Details Instance
        {
            get { return instance; }
        }

#region Variables

        string _Jb6_Name;

        /// <summary>
        /// Gets or sets the value of variable Jb6_Name.
        /// </summary>
        [TestVariable("af738f35-d6fa-45b0-bc73-22eba4519ba3")]
        public string Jb6_Name
        {
            get { return _Jb6_Name; }
            set { _Jb6_Name = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DuplicateJobToCurrentScenario.Job_Name' at 285;9.", repo.DuplicateJobToCurrentScenario.Job_NameInfo, new RecordItemIndex(0));
            repo.DuplicateJobToCurrentScenario.Job_Name.Click("285;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back 60}' with focus on 'DuplicateJobToCurrentScenario.Job_Name'.", repo.DuplicateJobToCurrentScenario.Job_NameInfo, new RecordItemIndex(1));
            repo.DuplicateJobToCurrentScenario.Job_Name.PressKeys("{Back 60}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Jb6_Name' with focus on 'DuplicateJobToCurrentScenario.Job_Name'.", repo.DuplicateJobToCurrentScenario.Job_NameInfo, new RecordItemIndex(2));
            repo.DuplicateJobToCurrentScenario.Job_Name.PressKeys(Jb6_Name);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DuplicateJobToCurrentScenario.Create' at 23;10.", repo.DuplicateJobToCurrentScenario.CreateInfo, new RecordItemIndex(3));
            repo.DuplicateJobToCurrentScenario.Create.Click("23;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(4));
            Delay.Duration(10000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
