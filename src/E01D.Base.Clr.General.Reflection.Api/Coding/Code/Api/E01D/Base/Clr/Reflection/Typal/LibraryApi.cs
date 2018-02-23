using System;
using System.Collections.Generic;

namespace Root.Coding.Code.Api.E01D.Base.Clr.Reflection.Typal
{
    public class LibraryApi
    {
        //public List<ClassSymbol> GetImplementingClasses(Type type)
        //{
        //    TypalContextHost_I context = _.ContextAs<TypalContextHost_I>();

        //    if (!context.Typal.Library.Symbols.Interfaces.TryGetValue(type.TypeHandle, out InterfaceSymbol symbol))
        //    {
        //        return new List<ClassSymbol>();
        //    }

        //    return symbol.ImplementingClasses.Values.ToList();
        //}

        //public Typa_I GetTypa(Type type)
        //{
        //    TypalContextHost_I contextHost = _.ContextAs<TypalContextHost_I>();

        //    if (!contextHost.Typal.Library.Typas.ByTypeHandle.TryGetValue(type.TypeHandle, out Typa_I typa))
        //    {
        //        typa = AddTypa(contextHost, type);
        //    }

        //    return typa;
        //}

        //public Typa_I AddTypa(Type type)
        //{
        //    TypalContextHost_I contextHost = _.ContextAs<TypalContextHost_I>();

        //    return AddTypa(contextHost, type);
        //}

        //[TransactionBoundary]
        //public Typa_I AddTypa(TypalContextHost_I contextHost, Type type)
        //{
        //    // Should be injected if possible by detecting [TransactionBoundary] - it could also go with the collection logic and should be setup anything entering is a transaction. 
        //    return _.PerformDataOperation<Typa, AddResult_I<Typa>>((opContext) =>
        //    {
        //        Typa fullTypa;

        //        if (contextHost.Typal.Typa != null)
        //        {
        //            // System Op Start
        //            fullTypa = new Typa
        //            {
        //                Id = _.IssueId(),
        //                VersionId = _.IssueId(),
        //                TypaId = contextHost.Typal.Typa.TypaId,
        //                AssemblyQualifiedName = type.AssemblyQualifiedName,
        //                Name = type.Name,
        //                FullName = type.FullName
        //            };
        //        }
        //        else if (type == typeof(Typa))
        //        {
        //            // System Op Start
        //            fullTypa = new Typa
        //            {
        //                Id = _.IssueId(),
        //                VersionId = _.IssueId(),
        //                TypaId = _.IssueId(),
        //                AssemblyQualifiedName = type.AssemblyQualifiedName,
        //                Name = type.Name,
        //                FullName = type.FullName

        //            };
        //        }
        //        else
        //        {
        //            throw new System.Exception("Not creating typa for typa and the typa typa is null.");
        //        }

        //        contextHost.Typal.Library.Typas.ByTypeHandle.Add(type.TypeHandle, fullTypa);

                
        //        // It is possible that the data sub system is not available yet at this point, and thus XData.Add should not be called.
        //        if (XData.IsInitialized())
        //        {
        //            // Should be combined with adding the item to the collection.  The collection system should be accessed by XLogic and the logic figuring out it needs to 
        //            // add an item to the collection.
        //            var result = XData.Add(opContext, fullTypa);
        //        }

        //        return new AddResult<Typa>()
        //        {
        //            Successful = true,
        //            Data = fullTypa
        //        };
        //    });

            
        //}


        //public Typa_I[] GetAll()
        //{
        //    TypalContextHost_I contextHost = _.ContextAs<TypalContextHost_I>();

        //    var x = contextHost.Typal.Library.Typas.ByTypeHandle.Values.ToArray();

        //    return x;
        //}

        //public List<AttributedClassSymbol> GetAttributedClasses(Type type)
        //{
        //    TypalContextHost_I context = _.ContextAs<TypalContextHost_I>();

        //    if (!context.Typal.Library.Symbols.Attributes.TryGetValue(type.TypeHandle, out AttributeSymbol symbol))
        //    {
        //        return new List<AttributedClassSymbol>();
        //    }

        //    return symbol.ImplementingClasses.Values.ToList();
        //}
    }
}
