// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

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
        public CallInvite(PhoneNumberIdentifier targetPhoneNumberIdentity, PhoneNumberIdentifier callerIdNumber)
        {
            Target = targetPhoneNumberIdentity;
            SourceCallerIdNumber = callerIdNumber;
        }

        /// <summary>
        /// Summary
        /// </summary>
        /// <param name="targetIdentity"></param>
        public CallInvite(CommunicationUserIdentifier targetIdentity)
        {
            Target = targetIdentity;
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

        /// <summary> Used by customer to pass in context to targets. </summary>
        public CustomContext CustomContext { get; set; }
    }
}
