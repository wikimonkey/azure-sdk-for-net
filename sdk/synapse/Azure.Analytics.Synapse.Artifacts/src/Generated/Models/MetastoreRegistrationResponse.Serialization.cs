// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(MetastoreRegistrationResponseConverter))]
    public partial class MetastoreRegistrationResponse
    {
        internal static MetastoreRegistrationResponse DeserializeMetastoreRegistrationResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<RequestStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new RequestStatus(property.Value.GetString());
                    continue;
                }
            }
            return new MetastoreRegistrationResponse(Optional.ToNullable(status));
        }

        internal partial class MetastoreRegistrationResponseConverter : JsonConverter<MetastoreRegistrationResponse>
        {
            public override void Write(Utf8JsonWriter writer, MetastoreRegistrationResponse model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override MetastoreRegistrationResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMetastoreRegistrationResponse(document.RootElement);
            }
        }
    }
}
