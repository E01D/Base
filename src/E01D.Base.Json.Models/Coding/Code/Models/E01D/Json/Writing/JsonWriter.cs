using System;
using System.Collections.Generic;
using Root.Coding.Code.Enums.E01D.Core.DateTimes;
using Root.Coding.Code.Enums.E01D.Json;

namespace Root.Coding.Code.Models.E01D.Json.Writing
{
    public abstract class JsonWriter
    {
        // array that gives a new state based on the current state an the token being written
        public JsonWriterState[][] StateArray;

        

        /// <summary>
        /// Gets or sets a value indicating whether the JSON should be auto-completed when this writer is closed.
        /// </summary>
        /// <value>
        /// <c>true</c> to auto-complete the JSON when this writer is closed; otherwise <c>false</c>. The default is <c>true</c>.
        /// </value>
        public bool AutoCompleteOnClose { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the destination should be closed when this writer is closed.
        /// </summary>
        /// <value>
        /// <c>true</c> to close the destination when this writer is closed; otherwise <c>false</c>. The default is <c>true</c>.
        /// </value>
        public bool CloseOutput { get; set; }

        
        public JsonPosition CurrentPosition { get; set; }
        public JsonWriterState CurrentState { get; set; }
        

        

        public List<JsonPosition> Stack { get; set; }
        public DateFormatHandling DateFormatHandling { get; set; }

        /// <summary>
        /// Gets or sets how <see cref="DateTime"/> and <see cref="DateTimeOffset"/> values are formatted when writing JSON text.
        /// </summary>
        public string DateFormatString { get; set; }

        public abstract JsonWriterKind Kind { get; }
    }
}
