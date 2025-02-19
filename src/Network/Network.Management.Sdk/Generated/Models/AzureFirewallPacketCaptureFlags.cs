// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties of the AzureFirewallRCAction.
    /// </summary>
    public partial class AzureFirewallPacketCaptureFlags
    {
        /// <summary>
        /// Initializes a new instance of the AzureFirewallPacketCaptureFlags
        /// class.
        /// </summary>
        public AzureFirewallPacketCaptureFlags()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureFirewallPacketCaptureFlags
        /// class.
        /// </summary>
        /// <param name="type">Flags to capture. Possible values include:
        /// 'fin', 'syn', 'rst', 'push', 'ack', 'urg'</param>
        public AzureFirewallPacketCaptureFlags(string type = default(string))
        {
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets flags to capture. Possible values include: 'fin',
        /// 'syn', 'rst', 'push', 'ack', 'urg'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
