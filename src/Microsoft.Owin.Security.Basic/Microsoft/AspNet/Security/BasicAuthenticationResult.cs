﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Security.Principal;

namespace Microsoft.AspNet.Security
{
    /// <summary></summary>
    public class BasicAuthenticationResult : IBasicAuthenticationResult
    {
        private readonly IBasicAuthenticationError _error;
        private readonly IPrincipal _principal;

        /// <summary></summary>
        /// <param name="principal"></param>
        public BasicAuthenticationResult(IPrincipal principal)
        {
            if (principal == null)
            {
                throw new ArgumentNullException("principal");
            }

            _principal = principal;
        }

        /// <summary></summary>
        /// <param name="error"></param>
        public BasicAuthenticationResult(IBasicAuthenticationError error)
        {
            if (error == null)
            {
                throw new ArgumentNullException("error");
            }

            _error = error;
        }

        /// <summary></summary>
        public IPrincipal Principal
        {
            get { return _principal; }
        }

        /// <summary></summary>
        public IBasicAuthenticationError ErrorResult
        {
            get { return _error; }
        }
    }
}