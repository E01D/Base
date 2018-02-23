using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual.Elements;

namespace Root.Coding.Code.Api.E01D.Base.Cli.Metadata.Conceptual.Elements
{
    public class ConceptualMetadataApi
    {
        public bool IsAbstract(ConceptualMetadata_I metadata)
        {
            return (metadata.MetadataModifiers & Models.E01D.Base.Cli.Metadata.Conceptual.MetadataModifier.Abstract) > 0;
        }

        public bool IsAsync(ConceptualMetadata_I metadata)
        {
            return (metadata.MetadataModifiers & Models.E01D.Base.Cli.Metadata.Conceptual.MetadataModifier.Async) > 0;
        }

        public bool IsConst(ConceptualMetadata_I metadata)
        {
            return (metadata.MetadataModifiers & Models.E01D.Base.Cli.Metadata.Conceptual.MetadataModifier.Const) > 0;
        }

        public bool IsExtern(ConceptualMetadata_I metadata)
        {
            return (metadata.MetadataModifiers & Models.E01D.Base.Cli.Metadata.Conceptual.MetadataModifier.Extern) > 0;
        }

        public bool IsIn(ConceptualMetadata_I metadata)
        {
            return (metadata.MetadataModifiers & Models.E01D.Base.Cli.Metadata.Conceptual.MetadataModifier.In) > 0;
        }

        public bool IsInternal(ConceptualMetadata_I metadata)
        {
            return (metadata.MetadataModifiers & Models.E01D.Base.Cli.Metadata.Conceptual.MetadataModifier.Internal) > 0;
        }

        public bool IsNew(ConceptualMetadata_I metadata)
        {
            return (metadata.MetadataModifiers & Models.E01D.Base.Cli.Metadata.Conceptual.MetadataModifier.New) > 0;
        }

        public bool IsOut(ConceptualMetadata_I metadata)
        {
            return (metadata.MetadataModifiers & Models.E01D.Base.Cli.Metadata.Conceptual.MetadataModifier.Out) > 0;
        }

        public bool IsOverride(ConceptualMetadata_I metadata)
        {
            return (metadata.MetadataModifiers & Models.E01D.Base.Cli.Metadata.Conceptual.MetadataModifier.Override) > 0;
        }

        public bool IsPrivate(ConceptualMetadata_I metadata)
        {
            return (metadata.MetadataModifiers & Models.E01D.Base.Cli.Metadata.Conceptual.MetadataModifier.Private) > 0;
        }

        public bool IsProtected(ConceptualMetadata_I metadata)
        {
            return (metadata.MetadataModifiers & Models.E01D.Base.Cli.Metadata.Conceptual.MetadataModifier.Protected) > 0;
        }

        public bool IsPublic(ConceptualMetadata_I metadata)
        {
            return (metadata.MetadataModifiers & Models.E01D.Base.Cli.Metadata.Conceptual.MetadataModifier.Public) > 0;
        }

        public bool IsReadonly(ConceptualMetadata_I metadata)
        {
            return (metadata.MetadataModifiers & Models.E01D.Base.Cli.Metadata.Conceptual.MetadataModifier.ReadOnly) > 0;
        }

        public bool IsSealed(ConceptualMetadata_I metadata)
        {
            return (metadata.MetadataModifiers & Models.E01D.Base.Cli.Metadata.Conceptual.MetadataModifier.Sealed) > 0;
        }

        public bool IsStatic(ConceptualMetadata_I metadata)
        {
            return (metadata.MetadataModifiers & Models.E01D.Base.Cli.Metadata.Conceptual.MetadataModifier.Static) > 0;
        }

        public bool IsUnsafe(ConceptualMetadata_I metadata)
        {
            return (metadata.MetadataModifiers & Models.E01D.Base.Cli.Metadata.Conceptual.MetadataModifier.Unsafe) > 0;
        }

        public bool IsVirtual(ConceptualMetadata_I metadata)
        {
            return (metadata.MetadataModifiers & Models.E01D.Base.Cli.Metadata.Conceptual.MetadataModifier.Virtual) > 0;
        }

        public bool IsVolatile(ConceptualMetadata_I metadata)
        {
            return (metadata.MetadataModifiers & Models.E01D.Base.Cli.Metadata.Conceptual.MetadataModifier.Volatile) > 0;
        }



    }
}
