using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class UnifiedRoleScheduleInstanceBase : Entity, IParsable {
        /// <summary>Read-only property with details of the app-specific scope when the assignment or role eligibility is scoped to an app. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public Microsoft.Graph.Models.AppScope? AppScope {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AppScope?>("appScope"); }
            set { BackingStore?.Set("appScope", value); }
        }
#else
        public Microsoft.Graph.Models.AppScope AppScope {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AppScope>("appScope"); }
            set { BackingStore?.Set("appScope", value); }
        }
#endif
        /// <summary>Identifier of the app-specific scope when the assignment or role eligibility is scoped to an app. The scope of an assignment or role eligibility determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? AppScopeId {
            get { return BackingStore?.Get<string?>("appScopeId"); }
            set { BackingStore?.Set("appScopeId", value); }
        }
#else
        public string AppScopeId {
            get { return BackingStore?.Get<string>("appScopeId"); }
            set { BackingStore?.Set("appScopeId", value); }
        }
#endif
        /// <summary>The directory object that is the scope of the assignment or role eligibility. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public DirectoryObject? DirectoryScope {
            get { return BackingStore?.Get<DirectoryObject?>("directoryScope"); }
            set { BackingStore?.Set("directoryScope", value); }
        }
#else
        public DirectoryObject DirectoryScope {
            get { return BackingStore?.Get<DirectoryObject>("directoryScope"); }
            set { BackingStore?.Set("directoryScope", value); }
        }
#endif
        /// <summary>Identifier of the directory object representing the scope of the assignment or role eligibility. The scope of an assignment or role eligibility determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? DirectoryScopeId {
            get { return BackingStore?.Get<string?>("directoryScopeId"); }
            set { BackingStore?.Set("directoryScopeId", value); }
        }
#else
        public string DirectoryScopeId {
            get { return BackingStore?.Get<string>("directoryScopeId"); }
            set { BackingStore?.Set("directoryScopeId", value); }
        }
#endif
        /// <summary>The principal that&apos;s getting a role assignment or role eligibility through the request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public DirectoryObject? Principal {
            get { return BackingStore?.Get<DirectoryObject?>("principal"); }
            set { BackingStore?.Set("principal", value); }
        }
#else
        public DirectoryObject Principal {
            get { return BackingStore?.Get<DirectoryObject>("principal"); }
            set { BackingStore?.Set("principal", value); }
        }
#endif
        /// <summary>Identifier of the principal that has been granted the role assignment or that&apos;s eligible for a role.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? PrincipalId {
            get { return BackingStore?.Get<string?>("principalId"); }
            set { BackingStore?.Set("principalId", value); }
        }
#else
        public string PrincipalId {
            get { return BackingStore?.Get<string>("principalId"); }
            set { BackingStore?.Set("principalId", value); }
        }
#endif
        /// <summary>Detailed information for the roleDefinition object that is referenced through the roleDefinitionId property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public UnifiedRoleDefinition? RoleDefinition {
            get { return BackingStore?.Get<UnifiedRoleDefinition?>("roleDefinition"); }
            set { BackingStore?.Set("roleDefinition", value); }
        }
#else
        public UnifiedRoleDefinition RoleDefinition {
            get { return BackingStore?.Get<UnifiedRoleDefinition>("roleDefinition"); }
            set { BackingStore?.Set("roleDefinition", value); }
        }
#endif
        /// <summary>Identifier of the unifiedRoleDefinition object that is being assigned to the principal or that the principal is eligible for.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? RoleDefinitionId {
            get { return BackingStore?.Get<string?>("roleDefinitionId"); }
            set { BackingStore?.Set("roleDefinitionId", value); }
        }
#else
        public string RoleDefinitionId {
            get { return BackingStore?.Get<string>("roleDefinitionId"); }
            set { BackingStore?.Set("roleDefinitionId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UnifiedRoleScheduleInstanceBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.unifiedRoleAssignmentScheduleInstance" => new UnifiedRoleAssignmentScheduleInstance(),
                "#microsoft.graph.unifiedRoleEligibilityScheduleInstance" => new UnifiedRoleEligibilityScheduleInstance(),
                _ => new UnifiedRoleScheduleInstanceBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appScope", n => { AppScope = n.GetObjectValue<Microsoft.Graph.Models.AppScope>(Microsoft.Graph.Models.AppScope.CreateFromDiscriminatorValue); } },
                {"appScopeId", n => { AppScopeId = n.GetStringValue(); } },
                {"directoryScope", n => { DirectoryScope = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"directoryScopeId", n => { DirectoryScopeId = n.GetStringValue(); } },
                {"principal", n => { Principal = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"principalId", n => { PrincipalId = n.GetStringValue(); } },
                {"roleDefinition", n => { RoleDefinition = n.GetObjectValue<UnifiedRoleDefinition>(UnifiedRoleDefinition.CreateFromDiscriminatorValue); } },
                {"roleDefinitionId", n => { RoleDefinitionId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Models.AppScope>("appScope", AppScope);
            writer.WriteStringValue("appScopeId", AppScopeId);
            writer.WriteObjectValue<DirectoryObject>("directoryScope", DirectoryScope);
            writer.WriteStringValue("directoryScopeId", DirectoryScopeId);
            writer.WriteObjectValue<DirectoryObject>("principal", Principal);
            writer.WriteStringValue("principalId", PrincipalId);
            writer.WriteObjectValue<UnifiedRoleDefinition>("roleDefinition", RoleDefinition);
            writer.WriteStringValue("roleDefinitionId", RoleDefinitionId);
        }
    }
}
