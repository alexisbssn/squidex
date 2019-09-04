// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschraenkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Squidex.Infrastructure.Commands;
using Squidex.Infrastructure.Plugins;

namespace Squidex.Extensions.BusinessLogic
{
    public class BusinessLogicPlugin : IPlugin
    {
        public void ConfigureServices(IServiceCollection services, IConfiguration config)
        {
            services.AddTransientAs<CustomCommandMiddleware>().As<ICustomCommandMiddleware>();
        }
    }
}
