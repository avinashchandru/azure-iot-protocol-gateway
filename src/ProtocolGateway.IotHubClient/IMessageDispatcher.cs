// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Azure.Devices.ProtocolGateway.IotHubClient
{
    using System.Threading.Tasks;
    using Microsoft.Azure.Devices.ProtocolGateway.Messaging;

    public interface IMessageDispatcher
    {
        Task<SendMessageOutcome> SendAsync(IMessage message);
    }
}