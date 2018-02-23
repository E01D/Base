using System.Runtime.Serialization;


namespace Root.Code.Models.E01D.Core.Collections
{
    public class DoubleLinkedListEnumerator<T>
    {
        public DoubleLinkedList<T> List { get; set; }
        public DoubleLinkedListNode<T> Node { get; set; }
        public int Version { get; set; }
        public T Current { get; set; }
        public int Index { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <notes>A temporary variable which we need during deserialization.</notes>
        public SerializationInfo SiInfo { get; set; } 
    }
}
