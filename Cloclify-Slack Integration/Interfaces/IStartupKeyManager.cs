﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloclify_Slack_Integration
{
    public interface IStartupKeyManager
    {
        bool InitializeApiKey();
        bool WriteApiKey(string apiKey);
        string ApiKey { get; }
    }
}
