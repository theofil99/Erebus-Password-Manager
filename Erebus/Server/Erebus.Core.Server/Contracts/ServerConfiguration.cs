﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erebus.Core.Server.Contracts
{
    public class ServerConfiguration
    {
        public bool DisableSSLRequirement { get; set; }
        public string VaultsFolder { get; set; }
        public string Language { get; set; }
        public string BackupFolder { get; set; }
        public int SessionTimeoutMinutes { get; set; }
        //public SmtpSettings SmtpSettings { get; set; }
    }

    //public class SmtpSettings
    //{
    //    public string SenderAddress { get; set; }
    //    public string Host { get; set; }
    //    public int Port { get; set; }
    //    public bool UseSSL { get; set; }
    //}
}
