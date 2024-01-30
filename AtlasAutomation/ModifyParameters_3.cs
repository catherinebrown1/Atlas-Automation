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
    ///The ModifyParameters_3 recording.
    /// </summary>
    [TestModule("ad6399c3-8f53-4672-b0db-e785a2404efe", ModuleType.Recording, 1)]
    public partial class ModifyParameters_3 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static ModifyParameters_3 instance = new ModifyParameters_3();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ModifyParameters_3()
        {
            Param_Search_3 = "TC_03_PreCalibration_IB_Low_FOR_IndustryBuild_Def_Param";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ModifyParameters_3 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Param_Search_3;

        /// <summary>
        /// Gets or sets the value of variable Param_Search_3.
        /// </summary>
        [TestVariable("e490bc6c-4828-4fea-8f67-303b278172a0")]
        public string Param_Search_3
        {
            get { return _Param_Search_3; }
            set { _Param_Search_3 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.Indicator' at 364;12.", repo.JobWindow.IndicatorInfo, new RecordItemIndex(0));
            repo.JobWindow.Indicator.Click("364;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.Parameters.Parameter_Toggle' at 40;11.", repo.JobWindow.Parameters.Parameter_ToggleInfo, new RecordItemIndex(1));
            repo.JobWindow.Parameters.Parameter_Toggle.Click("40;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.File' at 26;5.", repo.SkySuiteEasyJetUAT2.FileInfo, new RecordItemIndex(2));
            repo.SkySuiteEasyJetUAT2.File.Click("26;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open' at 135;770.", repo.Open.SelfInfo, new RecordItemIndex(3));
            repo.Open.Self.Click("135;770");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.Documents' at 42;8.", repo.Open.DocumentsInfo, new RecordItemIndex(4));
            repo.Open.Documents.Click("42;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.SearchEditBox' at 90;15.", repo.Open.SearchEditBoxInfo, new RecordItemIndex(5));
            repo.Open.SearchEditBox.Click("90;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(6));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Param_Search_3' with focus on 'Open'.", repo.Open.SelfInfo, new RecordItemIndex(7));
            repo.Open.Self.EnsureVisible();
            Keyboard.Press(Param_Search_3);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(8));
            Delay.Duration(5000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.ExecuteNow' at Center.", repo.Open.ExecuteNowInfo, new RecordItemIndex(9));
            //repo.Open.ExecuteNow.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(10));
            //Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.ShellView.TC_03_PreCalibration' at Center.", repo.Open.ShellView.TC_03_PreCalibrationInfo, new RecordItemIndex(11));
            repo.Open.ShellView.TC_03_PreCalibration.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.ButtonOpen' at 51;27.", repo.Open.ButtonOpenInfo, new RecordItemIndex(12));
            repo.Open.ButtonOpen.Click("51;27");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ImportParameters' at 319;25.", repo.ImportParameters.SelfInfo, new RecordItemIndex(13));
            repo.ImportParameters.Self.Click("319;25");
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.ImportParameters.Self, false, new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ImportParameters.ButtonOK' at Center.", repo.ImportParameters.ButtonOKInfo, new RecordItemIndex(15));
            repo.ImportParameters.ButtonOK.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
