// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschränkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using System;
using System.Collections.Generic;
using System.Linq;

namespace Squidex.Infrastructure.Shared
{
    public static class CollectionExtensions
    {
        public static TValue GetOrAdd<TKey, TContext, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TContext context, Func<TKey, TContext, TValue> creator)
        {
            if (!dictionary.TryGetValue(key, out var result))
            {
                result = creator(key, context);

                dictionary.Add(key, result);
            }

            return result;
        }
    }
}