﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApi.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Class1
    {
        Knight,
        Mege,
        Cleric

    }
}
