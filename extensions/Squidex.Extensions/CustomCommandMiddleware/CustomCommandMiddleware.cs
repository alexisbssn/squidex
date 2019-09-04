// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschraenkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using System;
using System.Threading.Tasks;
using Squidex.Domain.Apps.Entities.Contents.Commands;
using Squidex.Infrastructure.Commands;

namespace Squidex.Extensions.BusinessLogic
{
    public class CustomCommandMiddleware : ICustomCommandMiddleware
    {
        public async Task HandleAsync(CommandContext context, Func<Task> next)
        {
            /*if (context.Command is CreateContent command)
            {
                int i = 0;
            }*/

            await next();
        }
    }
}
