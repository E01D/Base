﻿using Root.Coding.Code.Enums.E01D.Json;

namespace Root.Coding.Code.Models.E01D.Json.Conversion
{
    public abstract class JsonConverter
    {
        public abstract JsonConverterKind Kind { get; }
    }
}
