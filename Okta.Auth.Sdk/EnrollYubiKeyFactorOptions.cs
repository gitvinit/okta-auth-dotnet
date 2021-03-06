﻿// <copyright file="EnrollYubiKeyFactorOptions.cs" company="Okta, Inc">
// Copyright (c) 2018 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

namespace Okta.Auth.Sdk
{
    /// <summary>
    /// This class contains all the request parameters for performing an enroll Yubikey factor request
    /// </summary>
    public class EnrollYubiKeyFactorOptions
    {
        /// <summary>
        /// Gets or sets the state token
        /// </summary>
        /// <value>The state token</value>
        public string StateToken { get; set; }

        /// <summary>
        /// Gets or sets the provider
        /// </summary>
        /// <value>The provider</value>
        public string Provider { get; set; } = OktaDefaults.YubiKeyProvider;

        /// <summary>
        /// Gets or sets the pass code
        /// </summary>
        /// <value>The pass code</value>
        public string PassCode { get; set; }
    }
}
