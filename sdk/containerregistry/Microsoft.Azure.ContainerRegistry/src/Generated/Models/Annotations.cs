// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Additional information provided through arbitrary metadata.
    /// </summary>
    public partial class Annotations
    {
        /// <summary>
        /// Initializes a new instance of the Annotations class.
        /// </summary>
        public Annotations()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Annotations class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="created">Date and time on which the image was built
        /// (string, date-time as defined by
        /// https://tools.ietf.org/html/rfc3339#section-5.6)</param>
        /// <param name="authors">Contact details of the people or organization
        /// responsible for the image.</param>
        /// <param name="url">URL to find more information on the
        /// image.</param>
        /// <param name="documentation">URL to get documentation on the
        /// image.</param>
        /// <param name="source">URL to get source code for building the
        /// image.</param>
        /// <param name="version">Version of the packaged software. The version
        /// MAY match a label or tag in the source code repository, may also be
        /// Semantic versioning-compatible</param>
        /// <param name="revision">Source control revision identifier for the
        /// packaged software.</param>
        /// <param name="vendor">Name of the distributing entity, organization
        /// or individual.</param>
        /// <param name="licenses">License(s) under which contained software is
        /// distributed as an SPDX License Expression.</param>
        /// <param name="name">Name of the reference for a target.</param>
        /// <param name="title">Human-readable title of the image</param>
        /// <param name="description">Human-readable description of the
        /// software packaged in the image</param>
        public Annotations(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), System.DateTime? created = default(System.DateTime?), string authors = default(string), string url = default(string), string documentation = default(string), string source = default(string), string version = default(string), string revision = default(string), string vendor = default(string), string licenses = default(string), string name = default(string), string title = default(string), string description = default(string))
        {
            AdditionalProperties = additionalProperties;
            Created = created;
            Authors = authors;
            Url = url;
            Documentation = documentation;
            Source = source;
            Version = version;
            Revision = revision;
            Vendor = vendor;
            Licenses = licenses;
            Name = name;
            Title = title;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets date and time on which the image was built (string,
        /// date-time as defined by
        /// https://tools.ietf.org/html/rfc3339#section-5.6)
        /// </summary>
        [JsonProperty(PropertyName = "org.opencontainers.image.created")]
        public System.DateTime? Created { get; set; }

        /// <summary>
        /// Gets or sets contact details of the people or organization
        /// responsible for the image.
        /// </summary>
        [JsonProperty(PropertyName = "org.opencontainers.image.authors")]
        public string Authors { get; set; }

        /// <summary>
        /// Gets or sets URL to find more information on the image.
        /// </summary>
        [JsonProperty(PropertyName = "org.opencontainers.image.url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets URL to get documentation on the image.
        /// </summary>
        [JsonProperty(PropertyName = "org.opencontainers.image.documentation")]
        public string Documentation { get; set; }

        /// <summary>
        /// Gets or sets URL to get source code for building the image.
        /// </summary>
        [JsonProperty(PropertyName = "org.opencontainers.image.source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets version of the packaged software. The version MAY
        /// match a label or tag in the source code repository, may also be
        /// Semantic versioning-compatible
        /// </summary>
        [JsonProperty(PropertyName = "org.opencontainers.image.version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets source control revision identifier for the packaged
        /// software.
        /// </summary>
        [JsonProperty(PropertyName = "org.opencontainers.image.revision")]
        public string Revision { get; set; }

        /// <summary>
        /// Gets or sets name of the distributing entity, organization or
        /// individual.
        /// </summary>
        [JsonProperty(PropertyName = "org.opencontainers.image.vendor")]
        public string Vendor { get; set; }

        /// <summary>
        /// Gets or sets license(s) under which contained software is
        /// distributed as an SPDX License Expression.
        /// </summary>
        [JsonProperty(PropertyName = "org.opencontainers.image.licenses")]
        public string Licenses { get; set; }

        /// <summary>
        /// Gets or sets name of the reference for a target.
        /// </summary>
        [JsonProperty(PropertyName = "org.opencontainers.image.ref.name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets human-readable title of the image
        /// </summary>
        [JsonProperty(PropertyName = "org.opencontainers.image.title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets human-readable description of the software packaged in
        /// the image
        /// </summary>
        [JsonProperty(PropertyName = "org.opencontainers.image.description")]
        public string Description { get; set; }

    }
}
