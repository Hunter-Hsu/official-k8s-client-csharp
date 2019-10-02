// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// SecurityContext holds security configuration that will be applied to a
    /// container. Some fields are present in both SecurityContext and
    /// PodSecurityContext.  When both are set, the values in SecurityContext
    /// take precedence.
    /// </summary>
    public partial class V1SecurityContext
    {
        /// <summary>
        /// Initializes a new instance of the V1SecurityContext class.
        /// </summary>
        public V1SecurityContext()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1SecurityContext class.
        /// </summary>
        /// <param name="allowPrivilegeEscalation">AllowPrivilegeEscalation
        /// controls whether a process can gain more privileges than its parent
        /// process. This bool directly controls if the no_new_privs flag will
        /// be set on the container process. AllowPrivilegeEscalation is true
        /// always when the container is: 1) run as Privileged 2) has
        /// CAP_SYS_ADMIN</param>
        /// <param name="capabilities">The capabilities to add/drop when
        /// running containers. Defaults to the default set of capabilities
        /// granted by the container runtime.</param>
        /// <param name="privileged">Run container in privileged mode.
        /// Processes in privileged containers are essentially equivalent to
        /// root on the host. Defaults to false.</param>
        /// <param name="procMount">procMount denotes the type of proc mount to
        /// use for the containers. The default is DefaultProcMount which uses
        /// the container runtime defaults for readonly paths and masked paths.
        /// This requires the ProcMountType feature flag to be enabled.</param>
        /// <param name="readOnlyRootFilesystem">Whether this container has a
        /// read-only root filesystem. Default is false.</param>
        /// <param name="runAsGroup">The GID to run the entrypoint of the
        /// container process. Uses runtime default if unset. May also be set
        /// in PodSecurityContext.  If set in both SecurityContext and
        /// PodSecurityContext, the value specified in SecurityContext takes
        /// precedence.</param>
        /// <param name="runAsNonRoot">Indicates that the container must run as
        /// a non-root user. If true, the Kubelet will validate the image at
        /// runtime to ensure that it does not run as UID 0 (root) and fail to
        /// start the container if it does. If unset or false, no such
        /// validation will be performed. May also be set in
        /// PodSecurityContext.  If set in both SecurityContext and
        /// PodSecurityContext, the value specified in SecurityContext takes
        /// precedence.</param>
        /// <param name="runAsUser">The UID to run the entrypoint of the
        /// container process. Defaults to user specified in image metadata if
        /// unspecified. May also be set in PodSecurityContext.  If set in both
        /// SecurityContext and PodSecurityContext, the value specified in
        /// SecurityContext takes precedence.</param>
        /// <param name="seLinuxOptions">The SELinux context to be applied to
        /// the container. If unspecified, the container runtime will allocate
        /// a random SELinux context for each container.  May also be set in
        /// PodSecurityContext.  If set in both SecurityContext and
        /// PodSecurityContext, the value specified in SecurityContext takes
        /// precedence.</param>
        /// <param name="windowsOptions">The Windows specific settings applied
        /// to all containers. If unspecified, the options from the
        /// PodSecurityContext will be used. If set in both SecurityContext and
        /// PodSecurityContext, the value specified in SecurityContext takes
        /// precedence.</param>
        public V1SecurityContext(bool? allowPrivilegeEscalation = default(bool?), V1Capabilities capabilities = default(V1Capabilities), bool? privileged = default(bool?), string procMount = default(string), bool? readOnlyRootFilesystem = default(bool?), long? runAsGroup = default(long?), bool? runAsNonRoot = default(bool?), long? runAsUser = default(long?), V1SELinuxOptions seLinuxOptions = default(V1SELinuxOptions), V1WindowsSecurityContextOptions windowsOptions = default(V1WindowsSecurityContextOptions))
        {
            AllowPrivilegeEscalation = allowPrivilegeEscalation;
            Capabilities = capabilities;
            Privileged = privileged;
            ProcMount = procMount;
            ReadOnlyRootFilesystem = readOnlyRootFilesystem;
            RunAsGroup = runAsGroup;
            RunAsNonRoot = runAsNonRoot;
            RunAsUser = runAsUser;
            SeLinuxOptions = seLinuxOptions;
            WindowsOptions = windowsOptions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets allowPrivilegeEscalation controls whether a process
        /// can gain more privileges than its parent process. This bool
        /// directly controls if the no_new_privs flag will be set on the
        /// container process. AllowPrivilegeEscalation is true always when the
        /// container is: 1) run as Privileged 2) has CAP_SYS_ADMIN
        /// </summary>
        [JsonProperty(PropertyName = "allowPrivilegeEscalation")]
        public bool? AllowPrivilegeEscalation { get; set; }

        /// <summary>
        /// Gets or sets the capabilities to add/drop when running containers.
        /// Defaults to the default set of capabilities granted by the
        /// container runtime.
        /// </summary>
        [JsonProperty(PropertyName = "capabilities")]
        public V1Capabilities Capabilities { get; set; }

        /// <summary>
        /// Gets or sets run container in privileged mode. Processes in
        /// privileged containers are essentially equivalent to root on the
        /// host. Defaults to false.
        /// </summary>
        [JsonProperty(PropertyName = "privileged")]
        public bool? Privileged { get; set; }

        /// <summary>
        /// Gets or sets procMount denotes the type of proc mount to use for
        /// the containers. The default is DefaultProcMount which uses the
        /// container runtime defaults for readonly paths and masked paths.
        /// This requires the ProcMountType feature flag to be enabled.
        /// </summary>
        [JsonProperty(PropertyName = "procMount")]
        public string ProcMount { get; set; }

        /// <summary>
        /// Gets or sets whether this container has a read-only root
        /// filesystem. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "readOnlyRootFilesystem")]
        public bool? ReadOnlyRootFilesystem { get; set; }

        /// <summary>
        /// Gets or sets the GID to run the entrypoint of the container
        /// process. Uses runtime default if unset. May also be set in
        /// PodSecurityContext.  If set in both SecurityContext and
        /// PodSecurityContext, the value specified in SecurityContext takes
        /// precedence.
        /// </summary>
        [JsonProperty(PropertyName = "runAsGroup")]
        public long? RunAsGroup { get; set; }

        /// <summary>
        /// Gets or sets indicates that the container must run as a non-root
        /// user. If true, the Kubelet will validate the image at runtime to
        /// ensure that it does not run as UID 0 (root) and fail to start the
        /// container if it does. If unset or false, no such validation will be
        /// performed. May also be set in PodSecurityContext.  If set in both
        /// SecurityContext and PodSecurityContext, the value specified in
        /// SecurityContext takes precedence.
        /// </summary>
        [JsonProperty(PropertyName = "runAsNonRoot")]
        public bool? RunAsNonRoot { get; set; }

        /// <summary>
        /// Gets or sets the UID to run the entrypoint of the container
        /// process. Defaults to user specified in image metadata if
        /// unspecified. May also be set in PodSecurityContext.  If set in both
        /// SecurityContext and PodSecurityContext, the value specified in
        /// SecurityContext takes precedence.
        /// </summary>
        [JsonProperty(PropertyName = "runAsUser")]
        public long? RunAsUser { get; set; }

        /// <summary>
        /// Gets or sets the SELinux context to be applied to the container. If
        /// unspecified, the container runtime will allocate a random SELinux
        /// context for each container.  May also be set in PodSecurityContext.
        /// If set in both SecurityContext and PodSecurityContext, the value
        /// specified in SecurityContext takes precedence.
        /// </summary>
        [JsonProperty(PropertyName = "seLinuxOptions")]
        public V1SELinuxOptions SeLinuxOptions { get; set; }

        /// <summary>
        /// Gets or sets the Windows specific settings applied to all
        /// containers. If unspecified, the options from the PodSecurityContext
        /// will be used. If set in both SecurityContext and
        /// PodSecurityContext, the value specified in SecurityContext takes
        /// precedence.
        /// </summary>
        [JsonProperty(PropertyName = "windowsOptions")]
        public V1WindowsSecurityContextOptions WindowsOptions { get; set; }

    }
}
