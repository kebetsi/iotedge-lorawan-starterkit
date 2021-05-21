﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace LoRaWan.NetworkServer.BasicStation.Models
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using LoRaTools.Regions;

    class LnsConfigReply
    {
        public LnsConfigReply(NetworkServerConfiguration configuration)
        {
            // access DR etc... configuration.Region.DRtoConfiguration[0].datarate
        }

        [JsonPropertyName("freq_range")]
        public List<int> FrequencyRange { get; set; } = new List<int>
        {
            863000000,
            870000000,
        };

        [JsonPropertyName("msgtype")]
        public string Msgtype { get; set; } = "router_config";

        public List<List<ulong>> JoinEUI { get; set; } = new List<List<ulong>>
        {
            new List<ulong>
            { 13725282814365013217, 13725282814365013219 }
        };

        public List<int> NetID { get; set; } = new List<int> { 1 };

        [JsonPropertyName("DRs")]
        public List<List<int>> DRs { get; set; } = new List<List<int>>
        {
            new List<int> { 12, 125, 0, },
            new List<int> { 11, 125, 0, },
            new List<int> { 10, 125, 0, },
            new List<int> { 9, 125, 0, },
            new List<int> { 8, 125, 0, },
            new List<int> { 7, 125, 0, },
            new List<int> { 7, 250, 0, }
        };

        [JsonPropertyName("hwspec")]
        public string Hwspec { get; set; } = "sx1301/1";

        [JsonPropertyName("region")]
        public string Region { get; set; } = "EU863";

        [JsonPropertyName("nocca")]
        public bool Nocca { get; set; } = true;

        [JsonPropertyName("nodc")]
        public bool Nodc { get; set; } = true;

        [JsonPropertyName("nodwell")]
        public bool Nodwell { get; set; } = true;

        [JsonPropertyName("sx1301_conf")]
        public List<Sx1301Config> Sx1301_conf { get; set; }
    }
}
