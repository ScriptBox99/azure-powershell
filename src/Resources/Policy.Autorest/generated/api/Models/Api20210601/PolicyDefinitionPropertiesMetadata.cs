// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Extensions;

    /// <summary>
    /// The policy definition metadata. Metadata is an open ended object and is typically a collection of key value pairs.
    /// </summary>
    public partial class PolicyDefinitionPropertiesMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IPolicyDefinitionPropertiesMetadata,
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IPolicyDefinitionPropertiesMetadataInternal
    {

        /// <summary>Creates an new <see cref="PolicyDefinitionPropertiesMetadata" /> instance.</summary>
        public PolicyDefinitionPropertiesMetadata()
        {

        }
    }
    /// The policy definition metadata. Metadata is an open ended object and is typically a collection of key value pairs.
    public partial interface IPolicyDefinitionPropertiesMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.IAssociativeArray<global::System.Object>
    {

    }
    /// The policy definition metadata. Metadata is an open ended object and is typically a collection of key value pairs.
    internal partial interface IPolicyDefinitionPropertiesMetadataInternal

    {

    }
}