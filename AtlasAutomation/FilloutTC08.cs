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
    ///The FilloutTC08 recording.
    /// </summary>
    [TestModule("aa0e8975-7ed1-4c28-8b59-dcf7ecab248a", ModuleType.Recording, 1)]
    public partial class FilloutTC08 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static FilloutTC08 instance = new FilloutTC08();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FilloutTC08()
        {
            jb8Name = "Adapt_Peak";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FilloutTC08 Instance
        {
            get { return instance; }
        }

#region Variables

        string _jb8Name;

        /// <summary>
        /// Gets or sets the value of variable jb8Name.
        /// </summary>
        [TestVariable("35e87c20-258b-40c4-966d-8775a2c5d1d3")]
        public string jb8Name
        {
            get { return _jb8Name; }
            set { _jb8Name = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DuplicateJobToCurrentScenario.Job_Name' at CenterRight.", repo.DuplicateJobToCurrentScenario.Job_NameInfo, new RecordItemIndex(0));
            repo.DuplicateJobToCurrentScenario.Job_Name.Click(Location.CenterRight);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back 70}' with focus on 'DuplicateJobToCurrentScenario.Job_Name'.", repo.DuplicateJobToCurrentScenario.Job_NameInfo, new RecordItemIndex(1));
            repo.DuplicateJobToCurrentScenario.Job_Name.PressKeys("{Back 70}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$jb8Name' with focus on 'DuplicateJobToCurrentScenario.Job_Name'.", repo.DuplicateJobToCurrentScenario.Job_NameInfo, new RecordItemIndex(2));
            repo.DuplicateJobToCurrentScenario.Job_Name.PressKeys(jb8Name);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DuplicateJobToCurrentScenario.Create' at Center.", repo.DuplicateJobToCurrentScenario.CreateInfo, new RecordItemIndex(3));
            repo.DuplicateJobToCurrentScenario.Create.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(4));
            Delay.Duration(10000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
