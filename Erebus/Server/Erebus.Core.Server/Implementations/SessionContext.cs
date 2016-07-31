﻿using Erebus.Core.Server.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Security;
using Erebus.Core.Contracts;

namespace Erebus.Core.Server
{
    public class SessionContext : ISessionContext
    {
        private IHttpContextAccessor HttpContextAccessor;
        private ISecureStringBinarySerializer SecureStringBinarySerializer;

        public SessionContext(IHttpContextAccessor httpContextAccessor, ISecureStringBinarySerializer secureStringBinarySerializer)
        {
            this.HttpContextAccessor = httpContextAccessor;
            this.SecureStringBinarySerializer = secureStringBinarySerializer;
        }

        public string GetCurrentVault()
        {
            return this.HttpContextAccessor.HttpContext.Session.GetString(Constants.CURRENT_VAULT_DESSION_KEY);
        }

        public SecureString GetMasterPassword()
        {
            var bytes = this.HttpContextAccessor.HttpContext.Session.Get(Constants.MASTER_PASSWORD_SESSION_KEY);
            if (bytes == null) return null;

            return SecureStringBinarySerializer.FromByteArray(bytes);
        }

        public void SetCurrentVault(string currentVaultName)
        {
            this.HttpContextAccessor.HttpContext.Session.SetString(Constants.CURRENT_VAULT_DESSION_KEY, currentVaultName);
        }

        public void SetMasterPassword(SecureString masterPassword)
        {
            this.HttpContextAccessor.HttpContext.Session.Set(Constants.MASTER_PASSWORD_SESSION_KEY, SecureStringBinarySerializer.ToByteArray(masterPassword));
        }
    }
}