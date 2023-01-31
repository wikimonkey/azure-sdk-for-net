// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Azure.Communication.CallAutomation
{
    /// <summary>
    /// Options for the Create Call Request.
    /// </summary>
    public class CreateCallOptions
    {
        /// <summary>
        /// Summary
        /// </summary>
        /// <param name="callInvite"></param>
        /// <param name="callbackUri"></param>
        public CreateCallOptions(CallInvite callInvite, Uri callbackUri)
        {
            CallInvite = callInvite;
            CallbackUri = callbackUri;
            // CallSource = new CommunicationUserIdentifier(Guid.NewGuid().ToString());
            Targets = new ReadOnlyCollection<CommunicationIdentifier>(new List<CommunicationIdentifier> { { callInvite.Target } });
            RepeatabilityHeaders = new RepeatabilityHeaders();
        }

        /// <summary>
        /// Creates a new CreateCallOptions object.
        /// </summary>
        /// <param name="targets"></param>
        /// <param name="callSource"></param>
        /// <param name="callbackUri"></param>
        internal CreateCallOptions(CommunicationUserIdentifier callSource, IEnumerable<CommunicationIdentifier> targets, Uri callbackUri)
        {
            // TODO!!! IS THIS REQUIRED?
            Targets = (IReadOnlyList<CommunicationIdentifier>)targets;
            var x = callSource;
            // CallSource = callSource;
            CallbackUri = callbackUri;
            RepeatabilityHeaders = new RepeatabilityHeaders();
        }

        /// <summary>
        /// Summary
        /// </summary>
        /// <value></value>
        public CallInvite CallInvite { get; }

        /// <summary>
        /// The targets of the call.
        /// TODO: might go away?
        /// </summary>
        internal IReadOnlyList<CommunicationIdentifier> Targets { get; }

        /// <summary>
        /// The callback Uri.
        /// </summary>
        public Uri CallbackUri { get; }

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
