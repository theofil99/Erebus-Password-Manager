﻿using Erebus.Core.Server.Contracts;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erebus.Core.Server.Implementations
{
    public class ServerConfigurationProvider : IServerConfigurationProvider
    {
        private readonly IConfigurationRoot ConfigurationRoot;

        public ServerConfigurationProvider(IConfigurationRoot configurationRoot)
        {
            this.ConfigurationRoot = configurationRoot;
        }

        public ServerConfiguration GetConfiguration()
        {
            return new ServerConfiguration()
            {
                DisableSSLRequirement = bool.Parse(this.ConfigurationRoot["ServerConfiguration:DisableSSLRequirement"]),
                VaultsFolder = this.ConfigurationRoot["ServerConfiguration:VaultsFolder"]
                //SmtpSettings = new SmtpSettings()
                //{
                //    SenderAddress = this.ConfigurationRoot["ServerConfiguration:SmtpSettings:SenderAddress"],
                //    Host = this.ConfigurationRoot["ServerConfiguration:SmtpSettings:Host"],
                //    Port = int.Parse(this.ConfigurationRoot["ServerConfiguration:SmtpSettings:Port"]),
                //    UseSSL = bool.Parse(this.ConfigurationRoot["ServerConfiguration:SmtpSettings:UseSSL"])
                //}
            };
        }
    }
}