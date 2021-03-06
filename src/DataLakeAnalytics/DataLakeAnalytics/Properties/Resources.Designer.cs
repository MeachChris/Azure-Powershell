//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.DataLakeAnalytics.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.DataLakeAnalytics.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot perform the requested operation because the specified account &apos;{0}&apos; does not exist..
        /// </summary>
        internal static string AccountDoesNotExist {
            get {
                return ResourceManager.GetString("AccountDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adding the Data Lake Analytics firewall rule: &apos;{0}&apos; ....
        /// </summary>
        internal static string AddDataLakeFirewallRule {
            get {
                return ResourceManager.GetString("AddDataLakeFirewallRule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} jobs do not support the inclusion of additional information. This is currently only supported for SQL-IP jobs. The -Include parameter will be ignored for this job..
        /// </summary>
        internal static string AdditionalDataNotSupported {
            get {
                return ResourceManager.GetString("AdditionalDataNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only one of -Script or -ScriptPath can be specified, and exactly one of them must be specified..
        /// </summary>
        internal static string AmbiguousScriptParameter {
            get {
                return ResourceManager.GetString("AmbiguousScriptParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data Lake Analytics account with name &apos;{0}&apos; already exists..
        /// </summary>
        internal static string DataLakeAnalyticsAccountExists {
            get {
                return ResourceManager.GetString("DataLakeAnalyticsAccountExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At least one data source parameter must be populated in order to add or remove data sources from the Data Lake Analytics account..
        /// </summary>
        internal static string DataSourceNotSpecified {
            get {
                return ResourceManager.GetString("DataSourceNotSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified default Azure account &apos;{0}&apos; does not exist in the {1} dictionary. Ensure that the specified default account is a valid Azure storage account and part of the {1} dictionary..
        /// </summary>
        internal static string DefaultDataSourceNotInCollection {
            get {
                return ResourceManager.GetString("DefaultDataSourceNotInCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid empty catalog path. A catalog path is required unless listing databases and must be in the following format with no empty internal elements: &lt;FirstPart&gt;.&lt;OptionalSecondPart&gt;.&lt;OptionalThirdPart&gt;.&lt;OptionalFourthPart&gt;. For example: Master.dbo.tableName.tableStatisticsName.
        /// </summary>
        internal static string EmptyCatalogPath {
            get {
                return ResourceManager.GetString("EmptyCatalogPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find account: &apos;{0}&apos; in any resource group in the currently selected subscription: {1}. Please ensure this account exists and that the current user has access to it..
        /// </summary>
        internal static string FailedToDiscoverResourceGroup {
            get {
                return ResourceManager.GetString("FailedToDiscoverResourceGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The firewall is currently disabled for account: {0}. Updates to firewall rules will not take affect until the firewall is enabled..
        /// </summary>
        internal static string FirewallDisabledWarning {
            get {
                return ResourceManager.GetString("FirewallDisabledWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified firewall rule &apos;{0}&apos; does not exist..
        /// </summary>
        internal static string FirewallRuleNotFound {
            get {
                return ResourceManager.GetString("FirewallRuleNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The output type defined for this cmdlet is incorrect and will be updated to reflect what is actually returned (and defined in the help) in a future release..
        /// </summary>
        internal static string IncorrectOutputTypeWarning {
            get {
                return ResourceManager.GetString("IncorrectOutputTypeWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Zero and negative values will no longer be defaulted to one, nor will they be accepted, in a future release for -AnalyticsUnits. Please adjust your scripts to pass in a value greater than zero.
        /// </summary>
        internal static string InvalidAnalyticsUnits {
            get {
                return ResourceManager.GetString("InvalidAnalyticsUnits", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid catalog path: &apos;{0}&apos;. A catalog path must be in the following format with no empty internal elements: &lt;FirstPart&gt;.&lt;OptionalSecondPart&gt;.&lt;OptionalThirdPart&gt;.&lt;OptionalFourthPart&gt;. For example: Master.dbo.tableName.tableStatisticsName.
        /// </summary>
        internal static string InvalidCatalogPath {
            get {
                return ResourceManager.GetString("InvalidCatalogPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data Lake Store Accounts can only be modified by indicating that they are now the Default Data Lake Store account. Otherwise only Add and Remove are supported for Data Lake Store accounts associated with a Data Lake Analytics account..
        /// </summary>
        internal static string InvalidDataLakeStoreAccountModificationAttempt {
            get {
                return ResourceManager.GetString("InvalidDataLakeStoreAccountModificationAttempt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No default subscription has been designated. Use Select-AzSubscription -Default &lt;subscriptionName&gt; to set the default subscription..
        /// </summary>
        internal static string InvalidDefaultSubscription {
            get {
                return ResourceManager.GetString("InvalidDefaultSubscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid JobType selected. Please select -USql when submitting a job.
        /// </summary>
        internal static string InvalidJobType {
            get {
                return ResourceManager.GetString("InvalidJobType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; is an unsupported script parameter type.  Please check the list of supported types by using Get-Help on the cmdlet with the -detailed flag..
        /// </summary>
        internal static string InvalidScriptParameterType {
            get {
                return ResourceManager.GetString("InvalidScriptParameterType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to U-SQL Secrets and credentials can only be returned by specific database and secret/credential name combination. There is no list support..
        /// </summary>
        internal static string InvalidUSqlSecretRequest {
            get {
                return ResourceManager.GetString("InvalidUSqlSecretRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to U-SQL Types can only be returned in a list of all types within a database and schema combination..
        /// </summary>
        internal static string InvalidUSqlTypeRequest {
            get {
                return ResourceManager.GetString("InvalidUSqlTypeRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data Lake Analytics account operation failed with the following error code: {0} and message: {1}.
        /// </summary>
        internal static string LongRunningOperationFailed {
            get {
                return ResourceManager.GetString("LongRunningOperationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid empty catalog path. A catalog path is required when listing or updating ACLs for catalog item..
        /// </summary>
        internal static string MissingCatalogPathForAclOperation {
            get {
                return ResourceManager.GetString("MissingCatalogPathForAclOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -MaxAnalyticsUnitsPerJob or -MinPriorityPerJob or both must be specified when creating or updating a compute policy..
        /// </summary>
        internal static string MissingComputePolicyField {
            get {
                return ResourceManager.GetString("MissingComputePolicyField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -ObjectId must be specified when updating or removing ACLs..
        /// </summary>
        internal static string MissingPrincipalId {
            get {
                return ResourceManager.GetString("MissingPrincipalId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More than {0} jobs exist in the account. Specify -Top with a larger value to retrieve more jobs. Note that large values of -Top will take time to retrieve all items..
        /// </summary>
        internal static string MoreJobsToGetWarning {
            get {
                return ResourceManager.GetString("MoreJobsToGetWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating Data Lake Analytics catalog credential &apos;{0}&apos; in database &apos;{1}&apos; ....
        /// </summary>
        internal static string NewDataLakeCatalogCredential {
            get {
                return ResourceManager.GetString("NewDataLakeCatalogCredential", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating Data Lake Analytics compute policy &apos;{0}&apos; with the following rules: {1}{2}....
        /// </summary>
        internal static string NewDataLakeComputePolicy {
            get {
                return ResourceManager.GetString("NewDataLakeComputePolicy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A port was not specified for host &apos;{0}&apos;. The default port will be used..
        /// </summary>
        internal static string NoPortSpecified {
            get {
                return ResourceManager.GetString("NoPortSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No subscription found in the context.  Please ensure that the credentials you provided are authorized to access an Azure subscription, then run Connect-AzAccount to login..
        /// </summary>
        internal static string NoSubscriptionInContext {
            get {
                return ResourceManager.GetString("NoSubscriptionInContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find principal using the specified object id.
        /// </summary>
        internal static string PrincipalNotFound {
            get {
                return ResourceManager.GetString("PrincipalNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing Data Lake Analytics account &apos;{0}&apos; ....
        /// </summary>
        internal static string RemoveDataLakeAnalyticsAccount {
            get {
                return ResourceManager.GetString("RemoveDataLakeAnalyticsAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing Data Lake Analytics Azure Blob account &apos;{0}&apos; ....
        /// </summary>
        internal static string RemoveDataLakeAnalyticsBlobAccount {
            get {
                return ResourceManager.GetString("RemoveDataLakeAnalyticsBlobAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing Data Lake Analytics catalog ACL for &apos;{0}&apos; ....
        /// </summary>
        internal static string RemoveDataLakeAnalyticsCatalogAcl {
            get {
                return ResourceManager.GetString("RemoveDataLakeAnalyticsCatalogAcl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing Data Lake Analytics catalog credential &apos;{0}&apos; ....
        /// </summary>
        internal static string RemoveDataLakeAnalyticsCatalogCredential {
            get {
                return ResourceManager.GetString("RemoveDataLakeAnalyticsCatalogCredential", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing Data Lake Analytics catalog credential &apos;{0}&apos;  and ALL resources dependent on it....
        /// </summary>
        internal static string RemoveDataLakeAnalyticsCatalogCredentialCascade {
            get {
                return ResourceManager.GetString("RemoveDataLakeAnalyticsCatalogCredentialCascade", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing Data Lake Analytics catalog ACL at path: &apos;{0}&apos; ....
        /// </summary>
        internal static string RemoveDataLakeAnalyticsCatalogItemAcl {
            get {
                return ResourceManager.GetString("RemoveDataLakeAnalyticsCatalogItemAcl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing Data Lake Analytics catalog secret &apos;{0}&apos; ....
        /// </summary>
        internal static string RemoveDataLakeAnalyticsCatalogSecret {
            get {
                return ResourceManager.GetString("RemoveDataLakeAnalyticsCatalogSecret", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing ALL Data Lake Analytics catalog secrets in database &apos;{0}&apos; ....
        /// </summary>
        internal static string RemoveDataLakeAnalyticsCatalogSecrets {
            get {
                return ResourceManager.GetString("RemoveDataLakeAnalyticsCatalogSecrets", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing Data Lake Analytics compute policy: &apos;{0}&apos; ....
        /// </summary>
        internal static string RemoveDataLakeAnalyticsComputePolicy {
            get {
                return ResourceManager.GetString("RemoveDataLakeAnalyticsComputePolicy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing Data Lake Analytics Data Lake Store account &apos;{0}&apos; ....
        /// </summary>
        internal static string RemoveDataLakeAnalyticsDataLakeStore {
            get {
                return ResourceManager.GetString("RemoveDataLakeAnalyticsDataLakeStore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing Data Lake Analytics firewall rule: &apos;{0}&apos; ....
        /// </summary>
        internal static string RemoveDataLakeAnalyticsFirewallRule {
            get {
                return ResourceManager.GetString("RemoveDataLakeAnalyticsFirewallRule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove Data Lake Analytics account &apos;{0}&apos;?.
        /// </summary>
        internal static string RemovingDataLakeAnalyticsAccount {
            get {
                return ResourceManager.GetString("RemovingDataLakeAnalyticsAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove Data Lake Analytics Azure Blob account &apos;{0}&apos;?.
        /// </summary>
        internal static string RemovingDataLakeAnalyticsBlobAccount {
            get {
                return ResourceManager.GetString("RemovingDataLakeAnalyticsBlobAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove Data Lake Analytics catalog ACL for &apos;{0}&apos;?.
        /// </summary>
        internal static string RemovingDataLakeAnalyticsCatalogAcl {
            get {
                return ResourceManager.GetString("RemovingDataLakeAnalyticsCatalogAcl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove Data Lake Analytics catalog credential &apos;{0}&apos;?.
        /// </summary>
        internal static string RemovingDataLakeAnalyticsCatalogCredential {
            get {
                return ResourceManager.GetString("RemovingDataLakeAnalyticsCatalogCredential", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove Data Lake Analytics catalog credential &apos;{0}&apos; and ALL resources dependent on it?.
        /// </summary>
        internal static string RemovingDataLakeAnalyticsCatalogCredentialCascade {
            get {
                return ResourceManager.GetString("RemovingDataLakeAnalyticsCatalogCredentialCascade", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove Data Lake Analytics catalog secret &apos;{0}&apos;?.
        /// </summary>
        internal static string RemovingDataLakeAnalyticsCatalogSecret {
            get {
                return ResourceManager.GetString("RemovingDataLakeAnalyticsCatalogSecret", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove ALL Data Lake Analytics catalog secrets in database &apos;{0}&apos;?.
        /// </summary>
        internal static string RemovingDataLakeAnalyticsCatalogSecrets {
            get {
                return ResourceManager.GetString("RemovingDataLakeAnalyticsCatalogSecrets", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove Data Lake Analytics Data Lake Store account &apos;{0}&apos;?.
        /// </summary>
        internal static string RemovingDataLakeAnalyticsDataLakeStore {
            get {
                return ResourceManager.GetString("RemovingDataLakeAnalyticsDataLakeStore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the Data Lake Analytics firewall rule: &apos;{0}&apos;?.
        /// </summary>
        internal static string RemovingDataLakeAnalyticsFirewallRule {
            get {
                return ResourceManager.GetString("RemovingDataLakeAnalyticsFirewallRule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The script file at path &apos;{0}&apos; does not exist or the current user does not have permission to it. Please ensure the path exists and is accessible..
        /// </summary>
        internal static string ScriptFilePathDoesNotExist {
            get {
                return ResourceManager.GetString("ScriptFilePathDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The script parameter value for &apos;{0}&apos; is null..
        /// </summary>
        internal static string ScriptParameterValueIsNull {
            get {
                return ResourceManager.GetString("ScriptParameterValueIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setting Data Lake Analytics catalog ACL entry for &apos;{0}&apos; ... .
        /// </summary>
        internal static string SetDataLakeCatalogAclEntry {
            get {
                return ResourceManager.GetString("SetDataLakeCatalogAclEntry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating Data Lake Analytics catalog credential &apos;{0}&apos; in database &apos;{1}&apos; ....
        /// </summary>
        internal static string SetDataLakeCatalogCredential {
            get {
                return ResourceManager.GetString("SetDataLakeCatalogCredential", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setting Data Lake Analytics catalog item ACL entry at path: &apos;{0}&apos;  ....
        /// </summary>
        internal static string SetDataLakeCatalogItemAclEntry {
            get {
                return ResourceManager.GetString("SetDataLakeCatalogItemAclEntry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setting the Data Lake Analytics firewall rule: &apos;{0}&apos; ....
        /// </summary>
        internal static string SetDataLakeFirewallRule {
            get {
                return ResourceManager.GetString("SetDataLakeFirewallRule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to update Data Lake Analytics catalog credential &apos;{0}&apos; in database &apos;{1}&apos;?.
        /// </summary>
        internal static string SettingDataLakeCatalogCredential {
            get {
                return ResourceManager.GetString("SettingDataLakeCatalogCredential", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stopping Data Lake Analytics job with Id: &apos;{0}&apos; ....
        /// </summary>
        internal static string StopDataLakeAnalyticsJob {
            get {
                return ResourceManager.GetString("StopDataLakeAnalyticsJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to stop Data Lake Analytics job with Id: &apos;{0}&apos;?.
        /// </summary>
        internal static string StoppingDataLakeAnalyticsJob {
            get {
                return ResourceManager.GetString("StoppingDataLakeAnalyticsJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update Data Lake Analytics compute policy &apos;{0}&apos; with the following rules: {1}{2}....
        /// </summary>
        internal static string UpdateDataLakeComputePolicy {
            get {
                return ResourceManager.GetString("UpdateDataLakeComputePolicy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job is not yet done. Current job state: &apos;{0}&apos;.
        /// </summary>
        internal static string WaitJobState {
            get {
                return ResourceManager.GetString("WaitJobState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data Lake Analytics Job with ID: {0} has not completed in {1} seconds. Check job runtime or increase the value of -TimeoutInSeconds.
        /// </summary>
        internal static string WaitJobTimeoutExceeded {
            get {
                return ResourceManager.GetString("WaitJobTimeoutExceeded", resourceCulture);
            }
        }
    }
}
