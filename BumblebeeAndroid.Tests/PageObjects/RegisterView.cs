﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Bumblebee.Implementation;
using Bumblebee.Interfaces;
using Bumblebee.Setup;
using BumblebeeAndroid.Implementation;
using Bumblebee.Extensions;
using OpenQA.Selenium;

namespace BumblebeeAndroid.Tests.PageObjects
{
    public class RegisterView : AppiumDroidBlock
    {
        public RegisterView(Session session) : base(session)
        {
        }

        public ISelectBox<RegisterView> LanguageSelect
        {
            get
            {
                return new AndroidRadioSpinner<RegisterView>(this, ByAndroid.AndroidClass("android.widget.Spinner"));
            }
        }
    }
}
