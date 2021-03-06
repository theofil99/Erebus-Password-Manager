﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;

namespace Erebus.Core.Server.Contracts
{
    public interface ISessionContext
    {
        SecureString GetMasterPassword();
        void SetMasterPassword(SecureString masterPassword);

        string GetCurrentVaultName();
        void SetCurrentVaultName(string currentVaultName);

        void ClearSession();

    }
}
