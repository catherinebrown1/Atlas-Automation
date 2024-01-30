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
    ///The FilloutScenarioDetails recording.
    /// </summary>
    [TestModule("e26b1c17-4430-48bf-a0db-7e3611d6770d", ModuleType.Recording, 1)]
    public partial class FilloutScenarioDetails : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static FilloutScenarioDetails instance = new FilloutScenarioDetails();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FilloutScenarioDetails()
        {
            Jb1_Name = "Demo_IB";
            ScName = "Demo_IB";
            Dates_Med = "18Sep2023 to 24Sep2023";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FilloutScenarioDetails Instance
        {
            get { return instance; }
        }

#region Variables

        string _Jb1_Name;

        /// <summary>
        /// Gets or sets the value of variable Jb1_Name.
        /// </summary>
        [TestVariable("0933a35d-c702-402a-828a-751c7a015205")]
        public string Jb1_Name
        {
            get { return _Jb1_Name; }
            set { _Jb1_Name = value; }
        }

        string _ScName;

        /// <summary>
        /// Gets or sets the value of variable ScName.
        /// </summary>
        [TestVariable("ef8a5b07-c4cd-4eb7-b47b-6d47d7cbb0b0")]
        public string ScName
        {
            get { return _ScName; }
            set { _ScName = value; }
        }

        string _Dates_Med;

        /// <summary>
        /// Gets or sets the value of variable Dates_Med.
        /// </summary>
        [TestVariable("54f5d2b5-d8d9-4087-8c0f-79289445f518")]
        public string Dates_Med
        {
            get { return _Dates_Med; }
            set { _Dates_Med = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewScenario.SomeContainer.ScNameTB' at 184;14.", repo.NewScenario.SomeContainer.ScNameTBInfo, new RecordItemIndex(0));
            repo.NewScenario.SomeContainer.ScNameTB.Click("184;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ScName' with focus on 'NewScenario.SomeContainer.ScNameTB'.", repo.NewScenario.SomeContainer.ScNameTBInfo, new RecordItemIndex(1));
            repo.NewScenario.SomeContainer.ScNameTB.PressKeys(ScName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewScenario.JbNameTB' at 180;13.", repo.NewScenario.JbNameTBInfo, new RecordItemIndex(2));
            repo.NewScenario.JbNameTB.Click("180;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Jb1_Name' with focus on 'NewScenario.JbNameTB'.", repo.NewScenario.JbNameTBInfo, new RecordItemIndex(3));
            repo.NewScenario.JbNameTB.PressKeys(Jb1_Name);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewScenario.SomeContainer.jobType' at 10;6.", repo.NewScenario.SomeContainer.jobTypeInfo, new RecordItemIndex(4));
            repo.NewScenario.SomeContainer.jobType.Click("10;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.Forecast' at 44;12.", repo.SkySuiteEasyJetUAT2.ForecastInfo, new RecordItemIndex(5));
            repo.SkySuiteEasyJetUAT2.Forecast.Click("44;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewScenario.SomeContainer.jobDates' at 4;14.", repo.NewScenario.SomeContainer.jobDatesInfo, new RecordItemIndex(6));
            repo.NewScenario.SomeContainer.jobDates.Click("4;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Dates_Med' with focus on 'NewScenario.SomeContainer.jobDates'.", repo.NewScenario.SomeContainer.jobDatesInfo, new RecordItemIndex(7));
            repo.NewScenario.SomeContainer.jobDates.PressKeys(Dates_Med);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewScenario.Create' at Center.", repo.NewScenario.CreateInfo, new RecordItemIndex(8));
            repo.NewScenario.Create.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
