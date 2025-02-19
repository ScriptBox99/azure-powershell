// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using System.Linq;

    /// <summary>
    /// Properties for MaterializedViewsBuilderServiceResource.
    /// </summary>
    [Newtonsoft.Json.JsonObject("MaterializedViewsBuilder")]
    public partial class MaterializedViewsBuilderServiceResourceProperties : ServiceResourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the MaterializedViewsBuilderServiceResourceProperties class.
        /// </summary>
        public MaterializedViewsBuilderServiceResourceProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MaterializedViewsBuilderServiceResourceProperties class.
        /// </summary>

        /// <param name="additionalProperties">Services response resource.
        /// </param>

        /// <param name="creationTime">Time of the last state change (ISO-8601 format).
        /// </param>

        /// <param name="instanceSize">Instance type for the service.
        /// Possible values include: 'Cosmos.D4s', 'Cosmos.D8s', 'Cosmos.D16s'</param>

        /// <param name="instanceCount">Instance count for the service.
        /// </param>

        /// <param name="status">Describes the status of a service.
        /// Possible values include: 'Creating', 'Running', 'Updating', 'Deleting',
        /// 'Error', 'Stopped'</param>

        /// <param name="locations">An array that contains all of the locations for the service.
        /// </param>
        public MaterializedViewsBuilderServiceResourceProperties(System.Collections.Generic.IDictionary<string, object> additionalProperties = default(System.Collections.Generic.IDictionary<string, object>), System.DateTime? creationTime = default(System.DateTime?), string instanceSize = default(string), int? instanceCount = default(int?), string status = default(string), System.Collections.Generic.IList<MaterializedViewsBuilderRegionalServiceResource> locations = default(System.Collections.Generic.IList<MaterializedViewsBuilderRegionalServiceResource>))

        : base(additionalProperties, creationTime, instanceSize, instanceCount, status)
        {
            this.Locations = locations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets an array that contains all of the locations for the service.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "locations")]
        public System.Collections.Generic.IList<MaterializedViewsBuilderRegionalServiceResource> Locations {get; private set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();

        }
    }
}