// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Core.Models
{
    /// <summary> Class of base event message properties. </summary>
    public partial class MessageBase
    {
        /// <summary> Initializes a new instance of MessageBase. </summary>
        internal MessageBase()
        {
        }

        /// <summary> Initializes a new instance of MessageBase. </summary>
        /// <param name="merchantId"> Merchant id. </param>
        /// <param name="targets"> . </param>
        /// <param name="authToken"> Token used in request, which generates the event. </param>
        /// <param name="published"> Date time when the event was published. </param>
        /// <param name="messageId"> Message id for better identification. </param>
        internal MessageBase(int? merchantId, MessageTargets targets, string authToken, DateTimeOffset? published, string messageId)
        {
            MerchantId = merchantId;
            Targets = targets;
            AuthToken = authToken;
            Published = published;
            MessageId = messageId;
        }

        /// <summary> Merchant id. </summary>
        public int? MerchantId { get; }
        public MessageTargets Targets { get; }
        /// <summary> Token used in request, which generates the event. </summary>
        public string AuthToken { get; }
        /// <summary> Date time when the event was published. </summary>
        public DateTimeOffset? Published { get; }
        /// <summary> Message id for better identification. </summary>
        public string MessageId { get; }
    }
}
