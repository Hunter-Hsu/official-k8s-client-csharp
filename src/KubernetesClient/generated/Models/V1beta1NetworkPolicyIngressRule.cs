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
    /// DEPRECATED 1.9 - This group version of NetworkPolicyIngressRule is
    /// deprecated by networking/v1/NetworkPolicyIngressRule. This
    /// NetworkPolicyIngressRule matches traffic if and only if the traffic
    /// matches both ports AND from.
    /// </summary>
    public partial class V1beta1NetworkPolicyIngressRule
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1NetworkPolicyIngressRule
        /// class.
        /// </summary>
        public V1beta1NetworkPolicyIngressRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1NetworkPolicyIngressRule
        /// class.
        /// </summary>
        /// <param name="fromProperty">List of sources which should be able to
        /// access the pods selected for this rule. Items in this list are
        /// combined using a logical OR operation. If this field is empty or
        /// missing, this rule matches all sources (traffic not restricted by
        /// source). If this field is present and contains at least one item,
        /// this rule allows traffic only if the traffic matches at least one
        /// item in the from list.</param>
        /// <param name="ports">List of ports which should be made accessible
        /// on the pods selected for this rule. Each item in this list is
        /// combined using a logical OR. If this field is empty or missing,
        /// this rule matches all ports (traffic not restricted by port). If
        /// this field is present and contains at least one item, then this
        /// rule allows traffic only if the traffic matches at least one port
        /// in the list.</param>
        public V1beta1NetworkPolicyIngressRule(IList<V1beta1NetworkPolicyPeer> fromProperty = default(IList<V1beta1NetworkPolicyPeer>), IList<V1beta1NetworkPolicyPort> ports = default(IList<V1beta1NetworkPolicyPort>))
        {
            FromProperty = fromProperty;
            Ports = ports;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of sources which should be able to access the
        /// pods selected for this rule. Items in this list are combined using
        /// a logical OR operation. If this field is empty or missing, this
        /// rule matches all sources (traffic not restricted by source). If
        /// this field is present and contains at least one item, this rule
        /// allows traffic only if the traffic matches at least one item in the
        /// from list.
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public IList<V1beta1NetworkPolicyPeer> FromProperty { get; set; }

        /// <summary>
        /// Gets or sets list of ports which should be made accessible on the
        /// pods selected for this rule. Each item in this list is combined
        /// using a logical OR. If this field is empty or missing, this rule
        /// matches all ports (traffic not restricted by port). If this field
        /// is present and contains at least one item, then this rule allows
        /// traffic only if the traffic matches at least one port in the list.
        /// </summary>
        [JsonProperty(PropertyName = "ports")]
        public IList<V1beta1NetworkPolicyPort> Ports { get; set; }

    }
}
