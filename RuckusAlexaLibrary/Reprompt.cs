﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;

namespace RuckusAlexaLibrary
{
    public class Reprompt
    {
        [JsonProperty("outputSpeech", NullValueHandling = NullValueHandling.Ignore)]
        public IOutputSpeech OutputSpeech { get; set; }
    }
}
