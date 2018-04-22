﻿// Copyright (c) Philipp Wagner. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json;

namespace FcmSharp.Requests
{
    public class ApsAlert
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("loc-key")]
        public string LocKey { get; set; }

        [JsonProperty("loc-args")]
        public string[] LocArgs { get; set; }

        [JsonProperty("title-loc-key")]
        public string TitleLocKey { get; set; }

        [JsonProperty("title-loc-args")]
        public string[] TitleLocArgs { get; set; }

        [JsonProperty("action-loc-key")]
        public string ActionLocKey { get; set; }

        [JsonProperty("launch-image")]
        public string LaunchImage { get; set; }
    }
}
