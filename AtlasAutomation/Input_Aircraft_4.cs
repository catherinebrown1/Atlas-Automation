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
    ///The Input_Aircraft_4 recording.
    /// </summary>
    [TestModule("afefea4a-4f5d-4579-8538-e0a240c851c5", ModuleType.Recording, 1)]
    public partial class Input_Aircraft_4 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static Input_Aircraft_4 instance = new Input_Aircraft_4();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Input_Aircraft_4()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Input_Aircraft_4 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.TC_04.Aircraft_Expand' at Center.", repo.JobWindow.TC_04.Aircraft_ExpandInfo, new RecordItemIndex(0));
            repo.JobWindow.TC_04.Aircraft_Expand.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 100ms.", new RecordItemIndex(1));
            Delay.Duration(100, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.TC_04.Aircraft_Togggle' at 17;14.", repo.JobWindow.TC_04.Aircraft_TogggleInfo, new RecordItemIndex(2));
            repo.JobWindow.TC_04.Aircraft_Togggle.Click("17;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 100ms.", new RecordItemIndex(3));
            Delay.Duration(100, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.S23MASTERAircraftSeatSubfleetAligned' at 39;17.", repo.SkySuiteEasyJetUAT2.S23MASTERAircraftSeatSubfleetAlignedInfo, new RecordItemIndex(4));
            repo.SkySuiteEasyJetUAT2.S23MASTERAircraftSeatSubfleetAligned.Click("39;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 100ms.", new RecordItemIndex(5));
            Delay.Duration(100, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.TC_04.Aircraft_Collapse' at Center.", repo.JobWindow.TC_04.Aircraft_CollapseInfo, new RecordItemIndex(6));
            repo.JobWindow.TC_04.Aircraft_Collapse.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 100ms.", new RecordItemIndex(7));
            Delay.Duration(100, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
