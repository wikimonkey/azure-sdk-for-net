// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;

namespace Azure.Communication.CallAutomation
{
    /// <summary>
    /// Options for the Create Call Request.
    /// </summary>
    public class CreateGroupCallOptions
    {
        /// <summary>
        /// Summary
        /// </summary>
        /// <param name="targets"></param>
        /// <param name="callbackUri"></param>
        public CreateGroupCallOptions(IEnumerable<CommunicationIdentifier> targets, Uri callbackUri)
        {
            Targets = (IReadOnlyList<CommunicationIdentifier>)targets;
            CallbackUri = callbackUri;
            RepeatabilityHeaders = new RepeatabilityHeaders();
        }

        /// <summary>
        /// The targets of the call.
        /// </summary>
        public IReadOnlyList<CommunicationIdentifier> Targets { get; }

        /// <summary>
        /// The callback Uri.
        /// </summary>
        public Uri CallbackUri { get; }

        /// <summary>
        /// DisplayName
        /// </summary>
        public string SourceDisplayName { get; set; }

        /// <summary>
        /// TODO: Combine this with SourceIdentifier
        /// </summary>
        /// <value></value>
        public PhoneNumberIdentifier SourceCallerIdNumber { get; set; }

        /// <summary>
        /// headers
        /// </summary>
        /// <value></value>
        public IDictionary<string, string> SIPHeaders { get; }

        /// <summary>
        /// headers
        /// </summary>
        /// <value></value>
        public IDictionary<string, string> VoIPHeaders { get; }

        /// <summary>
        /// The Operation context.
        /// </summary>
        public string OperationContext { get; set; }

        /// <summary>
        /// Media Streaming Configuration.
        /// </summary>
        public MediaStreamingOptions MediaStreamingOptions { get; set; }

        /// <summary>
        /// Repeatability Headers.
        /// </summary>
        internal RepeatabilityHeaders RepeatabilityHeaders { get; set; }

        /// <summary>
        /// The endpoint URL of the Azure Cognitive Services resource attached
        /// </summary>
        public Uri AzureCognitiveServicesEndpointUrl { get; set; }
    }
}
