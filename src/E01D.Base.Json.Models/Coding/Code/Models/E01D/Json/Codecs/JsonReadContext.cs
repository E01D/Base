using System.Collections.Generic;
using System.Globalization;
using Root.Coding.Code.Attributes.E01D.Json;
using Root.Coding.Code.Enums.E01D.Json;

namespace Root.Coding.Code.Models.E01D.Json.Codecs
{
    public class JsonReadContext
    {
        

       

        public bool HasExceededMaxDepth { get; set; }

        /// <summary>
        /// Gets the type of the current JSON token. 
        /// </summary>
        public JsonToken TokenType { get; set; }

        /// <summary>
        /// Gets the text value of the current JSON token.
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Gets the current reader state.
        /// </summary>
        /// <value>The current reader state.</value>
        public JsonReadMode CurrentState { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the source should be closed when this reader is closed.
        /// </summary>
        /// <value>
        /// <c>true</c> to close the source when this reader is closed; otherwise <c>false</c>. The default is <c>true</c>.
        /// </value>
        public bool CloseInput { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether multiple pieces of JSON content can
        /// be read from a continuous stream without erroring.
        /// </summary>
        /// <value>
        /// <c>true</c> to support reading multiple pieces of JSON content; otherwise <c>false</c>.
        /// The default is <c>false</c>.
        /// </value>
        public bool SupportMultipleContent { get; set; }

        /// <summary>
        /// Gets the quotation mark character used to enclose the value of a string.
        /// </summary>
        public virtual char QuoteChar { get; set; }

        /// <summary>
        /// Gets or sets how custom date formatted strings are parsed when reading JSON.
        /// </summary>
        public string DateFormatString { get; set; }


        
      

        
       

        
        

        public CultureInfo InternalCulture { get; set; }
        public Root.Coding.Code.Enums.E01D.Core.DateTimes.DateTimeZoneHandling InternalDateTimeZoneHandling { get; set; }
        public Root.Coding.Code.Enums.E01D.Core.DateTimes.DateParseHandling InternalDateParseHandling { get; set; }
        public FloatParseHandling InternalFloatParseHandling { get; set; }

        public int? InternalMaxDepth { get; set; }

        public List<JsonPosition> Stack { get; set; }
        

        public JsonPosition CurrentPosition;
    }
}
