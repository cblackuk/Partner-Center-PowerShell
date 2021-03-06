﻿// -----------------------------------------------------------------------
// <copyright file="PSOneTimeInvoiceLineItem.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Microsoft.Store.PartnerCenter.PowerShell.Models.Invoices
{
    using System;
    using PartnerCenter.Models.Invoices;

    /// <summary>
    /// Represents an invoice billing line item for OneTime purchases.
    /// </summary>
    public class PSOneTimeInvoiceLineItem : PSInvoiceLineItem
    {
        /// <summary>
        /// Gets or sets the availability unique identifier.
        /// </summary>
        public string AvailabilityId { get; set; }

        /// <summary>
        /// Gets the billing provider.
        /// </summary>
        public override BillingProvider BillingProvider => BillingProvider.OneTime;

        /// <summary>
        /// Gets or sets the type of charge.
        /// Examples: Purchase Fee, Cycle Fee, Prorate Fees when Purchase.
        /// </summary>
        /// <remarks>
        /// Examples: Purchase Fee, Cycle Fee, Prorate Fees when Purchase.
        /// </remarks>
        public string ChargeType { get; set; }

        /// <summary>
        /// Gets or sets the currency used for this line item.
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the customer's country.
        /// </summary>
        public string CustomerCountry { get; set; }

        /// <summary>
        /// Gets or sets the customer domain name.
        /// </summary>
        public string CustomerDomainName { get; set; }

        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the customer name.
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the discount details associated with this purchase.
        /// </summary>
        public string DiscountDetails { get; set; }

        /// <summary>
        /// Gets the the type of invoice line item.
        /// </summary>
        public override InvoiceLineItemType InvoiceLineItemType => InvoiceLineItemType.BillingLineItems;

        /// <summary>
        /// Gets or sets the invoice number.
        /// </summary>
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Gets or sets the MPN identifier associated to this line item.
        /// </summary>
        public string MpnId { get; set; }

        /// <summary>
        /// Gets or sets the date when order created.
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Gets or sets the order unique identifier.
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or sets the partner identifier.
        /// </summary>
        public string PartnerId { get; set; }

        /// <summary>
        /// Gets or sets the product unique identifier.
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// Gets or sets the product name.
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or sets the number of units associated with this line item.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the Reseller MPN identifier of the indirect reseller associated to this line item.
        /// </summary>
        public int ResellerMpnId { get; set; }

        /// <summary>
        /// Gets or sets the SKU unique identifier.
        /// </summary>
        public string SkuId { get; set; }

        /// <summary>
        /// Gets or sets the SKU name.
        /// </summary>
        public string SkuName { get; set; }

        /// <summary>
        /// Gets or sets the amount after discount.
        /// </summary>
        public decimal Subtotal { get; set; }

        /// <summary>
        /// Gets or sets the taxes charged.
        /// </summary>
        public decimal TaxTotal { get; set; }

        /// <summary>
        /// Gets or sets the total amount after discount and tax.
        /// </summary>
        public decimal TotalForCustomer { get; set; }

        /// <summary>
        /// Gets or sets the unit price.
        /// </summary>
        public decimal UnitPrice { get; set; }
    }
}