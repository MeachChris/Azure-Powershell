// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using Microsoft.Azure.Commands.Batch.Models;
using Microsoft.Azure.Commands.Batch.Properties;
using System.Management.Automation;
using Constants = Microsoft.Azure.Commands.Batch.Utils.Constants;

namespace Microsoft.Azure.Commands.Batch
{
    [Cmdlet("Remove", ResourceManager.Common.AzureRMConstants.AzurePrefix + "BatchCertificate", SupportsShouldProcess = true), OutputType(typeof(void))]
    public class RemoveBatchCertificateCommand : BatchObjectModelCmdletBase
    {
        [Parameter(Position = 0, Mandatory = true, ValueFromPipelineByPropertyName = true,
            HelpMessage = "The algorithm used to derive the Thumbprint parameter. This must be sha1.")]
        [ValidateNotNullOrEmpty]
        public string ThumbprintAlgorithm { get; set; }

        [Parameter(Position = 1, Mandatory = true, ValueFromPipelineByPropertyName = true,
            HelpMessage = "The thumbprint of the certificate to delete.")]
        [ValidateNotNullOrEmpty]
        public string Thumbprint { get; set; }

        protected override void ExecuteCmdletImpl()
        {
            CertificateOperationParameters parameters = new CertificateOperationParameters(this.BatchContext,
                this.ThumbprintAlgorithm, this.Thumbprint, this.AdditionalBehaviors);

            ConfirmAction(
                Resources.RemoveCertificate,
                this.Thumbprint,
                () => BatchClient.DeleteCertificate(parameters));
        }
    }
}
