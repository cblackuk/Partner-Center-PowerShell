﻿// -----------------------------------------------------------------------
// <copyright file="PSConfigurationPolicy.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// --------------

namespace Microsoft.Store.PartnerCenter.PowerShell.Models
{
    using System;
    using System.Collections.Generic;
    using Common;
    using PartnerCenter.Models.DevicesDeployment;

    public sealed class PSConfigurationPolicy
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PSConfigurationPolicy" /> class.
        /// </summary>
        public PSConfigurationPolicy()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PSConfigurationPolicy" /> class.
        /// </summary>
        /// <param name="configurationPolicy">The base configuration policy for this instance.</param>
        public PSConfigurationPolicy(ConfigurationPolicy configurationPolicy)
        {
            this.CopyFrom(configurationPolicy, CloneAdditionalOperations);
        }

        //
        // Summary:
        //     Gets or sets the policy unique identifier.
        public string PolicyId { get; set; }
        //
        // Summary:
        //     Gets or sets the name associated with the policy.
        public string Name { get; set; }
        //
        // Summary:
        //     Gets or sets the category of the policy.
        public PolicyCategory Category { get; set; }
        //
        // Summary:
        //     Gets or sets the description for a policy.
        public string Description { get; set; }
        //
        // Summary:
        //     Gets or sets the number of devices assigned to a policy.
        public int DevicesAssignedCount { get; set; }
        //
        // Summary:
        //     Gets or sets the settings for a policy.
        public IEnumerable<PolicySettingsType> PolicySettings { get; set; }
        //
        // Summary:
        //     Gets or sets the date the policy was created.
        public DateTime CreatedDate { get; set; }
        //
        // Summary:
        //     Gets or sets the date the policy was modified.
        public DateTime LastModifiedDate { get; set; }

        /// <summary>
        /// Addtional operations to be performed when cloning an instance of <see cref="ConfigurationPolicy" /> to an instance of <see cref="PSConfigurationPolicy" />. 
        /// </summary>
        /// <param name="customer">The customer being cloned.</param>
        private void CloneAdditionalOperations(ConfigurationPolicy configurationPolicy)
        {
            PolicyId = configurationPolicy.Id;
        }
    }
}