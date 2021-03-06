﻿// -----------------------------------------------------------------------
// <copyright file="PSOrderLineItem.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Microsoft.Store.PartnerCenter.PowerShell.Models.Orders
{
    using System.Collections.Generic;
    using Common;
    using PartnerCenter.Models.Orders;

    /// <summary>
    /// An order line item associates order information to a specific offer of a product.
    /// </summary>
    public sealed class PSOrderLineItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PSOrderLineItem" /> class.
        /// </summary>
        public PSOrderLineItem()
        {
            ProvisioningContext = new Dictionary<string, string>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PSOrderLineItem" /> class.
        /// </summary>
        /// <param name="orderLineItem">The base order line item for this instance.</param>
        public PSOrderLineItem(OrderLineItem orderLineItem)
        {
            this.CopyFrom(orderLineItem);
        }

        /// <summary>
        /// Gets or sets the friendly name for the result contract (subscription).
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the line item number.
        /// </summary>
        public int LineItemNumber { get; set; }

        /// <summary>
        /// Gets or sets the offer identifier.
        /// </summary>
        public string OfferId { get; set; }

        /// <summary>
        /// Gets or sets the partner identifier on record.
        /// </summary>
        public string PartnerIdOnRecord { get; set; }

        /// <summary>
        /// Gets or sets the parent subscription identifier.
        /// </summary>
        /// <remarks>
        /// This parameter should only be set for add-on offer purchase. This applies to Order updates only.
        /// </remarks>
        public string ParentSubscriptionId { get; set; }

        /// <summary>
        /// Gets the provisioning context for the offer.
        /// </summary>
        public Dictionary<string, string> ProvisioningContext { get; }

        /// <summary>
        /// Gets or sets the product quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the resulting subscription identifier.
        /// </summary>
        public string SubscriptionId { get; set; }
    }
}