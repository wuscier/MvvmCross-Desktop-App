﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using MvvmCross.Core.ViewModels;
using MvvmCross.Wpf.Platform;
using MvvmCross.Wpf.Views;

namespace MvvmCross_Desktop_App
{
    public class Setup : MvxWpfSetup
    {
        public Setup(Dispatcher uiThreadDispatcher, IMvxWpfViewPresenter presenter) : base(uiThreadDispatcher, presenter)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new TipCalc.Core.App();
        }
    }
}
