using System;

using R5T.T0143;


namespace R5T.T0150
{
    /// <summary>
    /// Attribute indicating a type is a strong type (default implementation methods on an interface). (A strongly-typed wrapper around a C# language built in type. For example, it's not a string, it's an AWS S3 Bucket Name.)
    /// The marker attribute is useful for surveying strong types and building a catalogue of strong types.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class StrongTypeMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zIsStrongType;
        /// <summary>
        /// Allows specifying that a type is *not* a strong type.
        /// This is useful for marking interfaces that end up in canonical strong type code file locations, but are not strong types.
        /// </summary>
        public bool IsStrongType
        {
            get
            {
                return this.zIsStrongType;
            }
        }


        public StrongTypeMarkerAttribute(
            bool isStrongType = true)
        {
            this.zIsStrongType = isStrongType;
        }
    }
}
