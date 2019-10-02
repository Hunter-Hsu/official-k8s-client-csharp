// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// ConfigMap holds configuration data for pods to consume.
    /// </summary>
    public partial class V1ConfigMap
    {
        /// <summary>
        /// Initializes a new instance of the V1ConfigMap class.
        /// </summary>
        public V1ConfigMap()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1ConfigMap class.
        /// </summary>
        /// <param name="apiVersion">APIVersion defines the versioned schema of
        /// this representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</param>
        /// <param name="binaryData">BinaryData contains the binary data. Each
        /// key must consist of alphanumeric characters, '-', '_' or '.'.
        /// BinaryData can contain byte sequences that are not in the UTF-8
        /// range. The keys stored in BinaryData must not overlap with the ones
        /// in the Data field, this is enforced during validation process.
        /// Using this field will require 1.10+ apiserver and kubelet.</param>
        /// <param name="data">Data contains the configuration data. Each key
        /// must consist of alphanumeric characters, '-', '_' or '.'. Values
        /// with non-UTF-8 byte sequences must use the BinaryData field. The
        /// keys stored in Data must not overlap with the keys in the
        /// BinaryData field, this is enforced during validation
        /// process.</param>
        /// <param name="kind">Kind is a string value representing the REST
        /// resource this object represents. Servers may infer this from the
        /// endpoint the client submits requests to. Cannot be updated. In
        /// CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</param>
        /// <param name="metadata">Standard object's metadata. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</param>
        public V1ConfigMap(string apiVersion = default(string), IDictionary<string, byte[]> binaryData = default(IDictionary<string, byte[]>), IDictionary<string, string> data = default(IDictionary<string, string>), string kind = default(string), V1ObjectMeta metadata = default(V1ObjectMeta))
        {
            ApiVersion = apiVersion;
            BinaryData = binaryData;
            Data = data;
            Kind = kind;
            Metadata = metadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets aPIVersion defines the versioned schema of this
        /// representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or sets binaryData contains the binary data. Each key must
        /// consist of alphanumeric characters, '-', '_' or '.'. BinaryData can
        /// contain byte sequences that are not in the UTF-8 range. The keys
        /// stored in BinaryData must not overlap with the ones in the Data
        /// field, this is enforced during validation process. Using this field
        /// will require 1.10+ apiserver and kubelet.
        /// </summary>
        [JsonProperty(PropertyName = "binaryData")]
        public IDictionary<string, byte[]> BinaryData { get; set; }

        /// <summary>
        /// Gets or sets data contains the configuration data. Each key must
        /// consist of alphanumeric characters, '-', '_' or '.'. Values with
        /// non-UTF-8 byte sequences must use the BinaryData field. The keys
        /// stored in Data must not overlap with the keys in the BinaryData
        /// field, this is enforced during validation process.
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public IDictionary<string, string> Data { get; set; }

        /// <summary>
        /// Gets or sets kind is a string value representing the REST resource
        /// this object represents. Servers may infer this from the endpoint
        /// the client submits requests to. Cannot be updated. In CamelCase.
        /// More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets standard object's metadata. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public V1ObjectMeta Metadata { get; set; }

    }
}
