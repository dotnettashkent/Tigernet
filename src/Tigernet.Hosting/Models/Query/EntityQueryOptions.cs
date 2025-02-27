﻿using Tigernet.Hosting.Models.Common;

namespace Tigernet.Hosting.Models.Query;

/// <summary>
/// Represents queryable entities source query options
/// </summary>
/// <typeparam name="TEntity"></typeparam>
public class EntityQueryOptions<TEntity> : QueryOptions<TEntity>, IEntityQueryOptions<TEntity> where TEntity : class, IQueryableEntity
{
    public IncludeOptions<TEntity>? IncludeOptions { get; set; }
}