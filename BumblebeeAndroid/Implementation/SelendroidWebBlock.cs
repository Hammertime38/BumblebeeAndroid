﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bumblebee.Implementation;
using Bumblebee.Interfaces;
using Bumblebee.Setup;

namespace BumblebeeAndroid.Implementation
{
    public class SelendroidWebBlock: DroidBlock
    {
        public SelendroidWebBlock(Session session) : base(session)
        {
            Session.Driver.SwitchTo().Window("WEBVIEW");
        }
    }
}
