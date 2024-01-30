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
    ///The Import_Parameter_8 recording.
    /// </summary>
    [TestModule("a64cc6cb-99c8-4862-945a-03db726e768b", ModuleType.Recording, 1)]
    public partial class Import_Parameter_8 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static Import_Parameter_8 instance = new Import_Parameter_8();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Import_Parameter_8()
        {
            Param_Search8 = "TC_08_Adapt_Peak_OPT_Adapt_Def_Param";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Import_Parameter_8 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Param_Search8;

        /// <summary>
        /// Gets or sets the value of variable Param_Search8.
        /// </summary>
        [TestVariable("46223b9d-a31c-497f-a210-f57befccbe32")]
        public string Param_Search8
        {
            get { return _Param_Search8; }
            set { _Param_Search8 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.Parameters.Parameter_Toggle' at Center.", repo.JobWindow.Parameters.Parameter_ToggleInfo, new RecordItemIndex(0));
            repo.JobWindow.Parameters.Parameter_Toggle.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.File' at Center.", repo.SkySuiteEasyJetUAT2.FileInfo, new RecordItemIndex(1));
            repo.SkySuiteEasyJetUAT2.File.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open' at Center.", repo.Open.SelfInfo, new RecordItemIndex(2));
            repo.Open.Self.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(3));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.Documents' at Center.", repo.Open.DocumentsInfo, new RecordItemIndex(4));
            repo.Open.Documents.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.SearchEditBox' at Center.", repo.Open.SearchEditBoxInfo, new RecordItemIndex(5));
            repo.Open.SearchEditBox.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Param_Search8' with focus on 'Open.SearchEditBox'.", repo.Open.SearchEditBoxInfo, new RecordItemIndex(6));
            repo.Open.SearchEditBox.PressKeys(Param_Search8);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(7));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.ShellView.TC_04_PreCalibration' at Center.", repo.Open.ShellView.TC_04_PreCalibrationInfo, new RecordItemIndex(8));
            repo.Open.ShellView.TC_04_PreCalibration.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.ButtonOpen' at Center.", repo.Open.ButtonOpenInfo, new RecordItemIndex(9));
            repo.Open.ButtonOpen.Click();
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.ImportParameters.Self, false, new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ImportParameters.ButtonOK' at Center.", repo.ImportParameters.ButtonOKInfo, new RecordItemIndex(11));
            repo.ImportParameters.ButtonOK.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
