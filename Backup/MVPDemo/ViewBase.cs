﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.ComponentModel;

namespace MVPDemo
{
    public class ViewBase: Form
    {
        private object _presenter;

        public ViewBase()
        {
            _presenter = this.CreatePresenter();
        }

        protected virtual object CreatePresenter()
        {
            if (LicenseManager.CurrentContext.UsageMode == LicenseUsageMode.Designtime)
            {
                return null;
            }
            else
            {
                throw new NotImplementedException(string.Format("{0} must override the CreatePresenter method.", this.GetType().FullName));
            }
        }       
    }
}