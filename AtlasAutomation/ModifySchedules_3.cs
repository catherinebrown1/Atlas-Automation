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
    ///The ModifySchedules_3 recording.
    /// </summary>
    [TestModule("57c348b0-fe58-4612-bbd2-68079dd65115", ModuleType.Recording, 1)]
    public partial class ModifySchedules_3 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static ModifySchedules_3 instance = new ModifySchedules_3();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ModifySchedules_3()
        {
            Dates_Low = "15May2023 to 21May2023";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ModifySchedules_3 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Dates_Low;

        /// <summary>
        /// Gets or sets the value of variable Dates_Low.
        /// </summary>
        [TestVariable("ef883969-cac5-4e30-b3f4-207c968bd9c4")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.Job_Inputs.JobInputsBusyIndicator' at 791;19.", repo.JobWindow.Job_Inputs.JobInputsBusyIndicatorInfo, new RecordItemIndex(0));
            repo.JobWindow.Job_Inputs.JobInputsBusyIndicator.Click("791;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.Job_Inputs.Schedule_Expand' at 19;20.", repo.JobWindow.Job_Inputs.Schedule_ExpandInfo, new RecordItemIndex(1));
            repo.JobWindow.Job_Inputs.Schedule_Expand.Click("19;20");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(2));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.TC_03.OA_Dates' at 108;15.", repo.JobWindow.TC_03.OA_DatesInfo, new RecordItemIndex(3));
            repo.JobWindow.TC_03.OA_Dates.Click("108;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Dates_Low' with focus on 'JobWindow.TC_03.OA_Dates'.", repo.JobWindow.TC_03.OA_DatesInfo, new RecordItemIndex(4));
            repo.JobWindow.TC_03.OA_Dates.PressKeys(Dates_Low);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.TC_03.Replacement_Dates' at 21;22.", repo.JobWindow.TC_03.Replacement_DatesInfo, new RecordItemIndex(5));
            repo.JobWindow.TC_03.Replacement_Dates.Click("21;22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Dates_Low' with focus on 'JobWindow.TC_03.Replacement_Dates'.", repo.JobWindow.TC_03.Replacement_DatesInfo, new RecordItemIndex(6));
            repo.JobWindow.TC_03.Replacement_Dates.PressKeys(Dates_Low);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.Job_Inputs.Schedule_Expand' at Center.", repo.JobWindow.Job_Inputs.Schedule_ExpandInfo, new RecordItemIndex(7));
            repo.JobWindow.Job_Inputs.Schedule_Expand.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(8));
            Delay.Duration(1000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
