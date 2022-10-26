using System;

using R5T.T0143;


namespace R5T.T0150
{
    /// <summary>
    /// Attribute indicating a type is a strong type. (A strongly-typed wrapper around a C# language built in type. For example, it's not a string, it's an AWS S3 Bucket Name.)
    /// A draft strong type is a quickly created type that should be reviewed and relocated, and thus become a regular, non-draft strong type.
    /// The marker attribute is useful for surveying for draft strong types and building a catalogue of draft strong types as a kind of TODO list.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class DraftStrongTypeMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zDraftIsStrongType;
        /// <summary>
        /// Allows specifying that a type is *not* a draft strong type.
        /// This is useful for marking interfaces that end up canonical draft strong type code file locations, but are not draft strong types.
        /// </summary>
        public bool IsDraftStrongType
        {
            get
            {
                return this.zDraftIsStrongType;
            }
        }


        public DraftStrongTypeMarkerAttribute(
            bool isDraftStrongType = true)
        {
            this.zDraftIsStrongType = isDraftStrongType;
        }
    }
}
