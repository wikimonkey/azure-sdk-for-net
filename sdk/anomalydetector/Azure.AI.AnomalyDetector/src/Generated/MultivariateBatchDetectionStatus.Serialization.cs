// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.AnomalyDetector
{
    internal static partial class MultivariateBatchDetectionStatusExtensions
    {
        public static string ToSerialString(this MultivariateBatchDetectionStatus value) => value switch
        {
            MultivariateBatchDetectionStatus.Created => "CREATED",
            MultivariateBatchDetectionStatus.Running => "RUNNING",
            MultivariateBatchDetectionStatus.Ready => "READY",
            MultivariateBatchDetectionStatus.Failed => "FAILED",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MultivariateBatchDetectionStatus value.")
        };

        public static MultivariateBatchDetectionStatus ToMultivariateBatchDetectionStatus(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "CREATED")) return MultivariateBatchDetectionStatus.Created;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "RUNNING")) return MultivariateBatchDetectionStatus.Running;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "READY")) return MultivariateBatchDetectionStatus.Ready;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "FAILED")) return MultivariateBatchDetectionStatus.Failed;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MultivariateBatchDetectionStatus value.");
        }
    }
}
