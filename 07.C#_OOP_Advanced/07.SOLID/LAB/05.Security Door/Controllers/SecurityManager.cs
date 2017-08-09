﻿namespace _05.Security_Door
{
    using System;

    public class SecurityManager
    {
        private IAccessProvider accessProvider;

        public SecurityManager(IAccessProvider accessProvider)
        {
            this.accessProvider = accessProvider;
        }

        public void Check()
        {
            this.accessProvider.ValidateUser();
        }
    }
}