﻿using System;
using Microsoft.Owin;

namespace Microsoft.IdentityModel.Protocols
{
    public class SamlMessage : AuthenticationProtocolMessage
    {
        private IFormCollection form;
        private IHeaderDictionary headers;
        private QueryString queryString;

        public SamlMessage()
        {

        }
        public SamlMessage(IFormCollection form) : this()
        {
            this.form = form;
        }

        public SamlMessage(IFormCollection form, IHeaderDictionary headers, QueryString queryString) : this(form)
        {
            this.headers = headers;
            this.queryString = queryString;
        }

        public string Reply { get; internal set; }

        public bool IsSignInMessage()
        {
            throw new NotImplementedException();
        }

        internal string GetToken()
        {
            throw new NotImplementedException();
        }

        public override string BuildRedirectUrl()
        {
            return base.BuildRedirectUrl(); // See Saml20SignonHandler.cs, line 591
        }

        public override string BuildFormPost()
        {
            return base.BuildFormPost(); // See Saml20SignonHandler.cs, line 591 (post binding)
        }
    }
}