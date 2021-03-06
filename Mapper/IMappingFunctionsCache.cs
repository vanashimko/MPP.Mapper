﻿using System;

namespace Mapper
{
    public interface IMappingFunctionsCache
    {
        void AddToCache<TSource, TDestination>(MappingTypesPair mappingEntryInfo, Func<TSource, TDestination> mappingFunction);
        Func<TSource, TDestination> GetCacheFor<TSource, TDestination>(MappingTypesPair mappingEntryInfo);
        bool HasCacheFor(MappingTypesPair mappingEntryInfo);
    }
}