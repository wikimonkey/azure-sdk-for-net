// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Azure.Communication.CallAutomation
{
    /// <summary>
    /// Call target class
    /// </summary>
    public class CallInvite
    {
        /// <summary>
        /// Summary
        /// </summary>
        /// <param name="targetPhoneNumberIdentity"></param>
        /// <param name="callerIdNumber"></param>
        /// <param name="sipHeaders"></param>
        public CallInvite(PhoneNumberIdentifier targetPhoneNumberIdentity, PhoneNumberIdentifier callerIdNumber, IDictionary<string, string> sipHeaders = null)
        {
            Target = targetPhoneNumberIdentity;
            SourceCallerIdNumber = callerIdNumber;
            SIPHeaders = sipHeaders;
        }

        /// <summary>
        /// Summary
        /// </summary>
        /// <param name="targetIdentity"></param>
        /// <param name="voipHeaders"></param>
        public CallInvite(CommunicationUserIdentifier targetIdentity, IDictionary<string, string> voipHeaders = null)
        {
            Target = targetIdentity;
            VoIPHeaders = voipHeaders;
        }

        /// <summary>
        /// Summary
        /// </summary>
        /// <param name="targetIdentity"></param>
        public CallInvite(MicrosoftTeamsUserIdentifier targetIdentity)
        {
            Target = targetIdentity;
        }

        /// <summary>
        /// Summary
        /// </summary>
        /// <param name="targetRawId"></param>
        public CallInvite(string targetRawId)
        {
            Target = CommunicationIdentifier.FromRawId(targetRawId);
        }

        /// <summary>
        /// Summary
        /// </summary>
        /// <value></value>
        public CommunicationIdentifier Target { get; }

        /// <summary>
        /// Combine this with SourceIdentifier
        /// </summary>
        /// <value></value>
        public PhoneNumberIdentifier SourceCallerIdNumber { get; }

        /// <summary>
        /// DisplayName
        /// </summary>
        public string SourceDisplayName { get; set; }

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
    }
}
