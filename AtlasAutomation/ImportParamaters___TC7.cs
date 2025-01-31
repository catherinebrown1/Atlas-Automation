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
    ///The ImportParamaters___TC7 recording.
    /// </summary>
    [TestModule("dbb55a37-78f0-4361-a26e-5a394e9a7a6e", ModuleType.Recording, 1)]
    public partial class ImportParamaters___TC7 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static ImportParamaters___TC7 instance = new ImportParamaters___TC7();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ImportParamaters___TC7()
        {
            paramSearch7 = "TC_07_Adapt_Med_OPT_Adapt_Def_Param";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ImportParamaters___TC7 Instance
        {
            get { return instance; }
        }

#region Variables

        string _paramSearch7;

        /// <summary>
        /// Gets or sets the value of variable paramSearch7.
        /// </summary>
        [TestVariable("4a15a1bd-deea-493e-806b-6111ffda5113")]
        public string paramSearch7
        {
            get { return _paramSearch7; }
            set { _paramSearch7 = value; }
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.Documents' at Center.", repo.Open.DocumentsInfo, new RecordItemIndex(3));
            repo.Open.Documents.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.SearchEditBox' at Center.", repo.Open.SearchEditBoxInfo, new RecordItemIndex(4));
            repo.Open.SearchEditBox.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(5));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$paramSearch7' with focus on 'Open.SearchEditBox'.", repo.Open.SearchEditBoxInfo, new RecordItemIndex(6));
            repo.Open.SearchEditBox.PressKeys(paramSearch7);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(7));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.ShellView.TC_04_PreCalibration' at Center.", repo.Open.ShellView.TC_04_PreCalibrationInfo, new RecordItemIndex(8));
            repo.Open.ShellView.TC_04_PreCalibration.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.ButtonOpen' at Center.", repo.Open.ButtonOpenInfo, new RecordItemIndex(9));
            repo.Open.ButtonOpen.Click();
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "Parameters Imported", repo.ImportParameters.Self, false, new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ImportParameters.TextOK' at Center.", repo.ImportParameters.TextOKInfo, new RecordItemIndex(11));
            repo.ImportParameters.TextOK.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
