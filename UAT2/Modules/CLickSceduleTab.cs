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

namespace UAT2.Modules
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CLickSceduleTab recording.
    /// </summary>
    [TestModule("78ae0ead-741a-4515-ad0e-b5c5cb4e72d9", ModuleType.Recording, 1)]
    public partial class CLickSceduleTab : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::UAT2.UAT2Repository repository.
        /// </summary>
        public static global::UAT2.UAT2Repository repo = global::UAT2.UAT2Repository.Instance;

        static CLickSceduleTab instance = new CLickSceduleTab();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CLickSceduleTab()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CLickSceduleTab Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuite.ScheduLes' at Center.", repo.SkySuite.ScheduLesInfo, new RecordItemIndex(0));
            repo.SkySuite.ScheduLes.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuite.ScheduLes' at Center.", repo.SkySuite.ScheduLesInfo, new RecordItemIndex(1));
            repo.SkySuite.ScheduLes.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 120 units.", new RecordItemIndex(2));
            Mouse.ScrollWheel(120);
            Delay.Milliseconds(300);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
