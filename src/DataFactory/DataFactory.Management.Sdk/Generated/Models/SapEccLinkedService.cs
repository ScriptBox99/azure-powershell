// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Linked service for SAP ERP Central Component(SAP ECC).
    /// </summary>
    [Newtonsoft.Json.JsonObject("SapEcc")]
    [Rest.Serialization.JsonTransformation]
    public partial class SapEccLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the SapEccLinkedService class.
        /// </summary>
        public SapEccLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SapEccLinkedService class.
        /// </summary>
        /// <param name="url">The URL of SAP ECC OData API. For example,
        /// '[https://hostname:port/sap/opu/odata/sap/servicename/]'. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="parameters">Parameters for linked service.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the linked service.</param>
        /// <param name="username">The username for Basic authentication. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="password">The password for Basic
        /// authentication.</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Either encryptedCredential or
        /// username/password must be provided. Type: string.</param>
        public SapEccLinkedService(object url, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), IList<object> annotations = default(IList<object>), object username = default(object), SecretBase password = default(SecretBase), string encryptedCredential = default(string))
            : base(additionalProperties, connectVia, description, parameters, annotations)
        {
            Url = url;
            Username = username;
            Password = password;
            EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URL of SAP ECC OData API. For example,
        /// '[https://hostname:port/sap/opu/odata/sap/servicename/]'. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.url")]
        public object Url { get; set; }

        /// <summary>
        /// Gets or sets the username for Basic authentication. Type: string
        /// (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.username")]
        public object Username { get; set; }

        /// <summary>
        /// Gets or sets the password for Basic authentication.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.password")]
        public SecretBase Password { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Either encryptedCredential or username/password must be
        /// provided. Type: string.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public string EncryptedCredential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Url == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Url");
            }
        }
    }
}
