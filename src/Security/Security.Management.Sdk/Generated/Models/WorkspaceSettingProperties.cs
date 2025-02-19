// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Security.Models
{
    using System.Linq;

    /// <summary>
    /// Workspace setting data
    /// </summary>
    public partial class WorkspaceSettingProperties
    {
        /// <summary>
        /// Initializes a new instance of the WorkspaceSettingProperties class.
        /// </summary>
        public WorkspaceSettingProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkspaceSettingProperties class.
        /// </summary>

        /// <param name="workspaceId">The full Azure ID of the workspace to save the data in
        /// </param>

        /// <param name="scope">All the VMs in this scope will send their security data to the mentioned
        /// workspace unless overridden by a setting with more specific scope
        /// </param>
        public WorkspaceSettingProperties(string workspaceId, string scope)

        {
            this.WorkspaceId = workspaceId;
            this.Scope = scope;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the full Azure ID of the workspace to save the data in
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "workspaceId")]
        public string WorkspaceId {get; set; }

        /// <summary>
        /// Gets or sets all the VMs in this scope will send their security data to the
        /// mentioned workspace unless overridden by a setting with more specific scope
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "scope")]
        public string Scope {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.WorkspaceId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "WorkspaceId");
            }
            if (this.Scope == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Scope");
            }


        }
    }
}