// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschränkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using System.Threading.Tasks;
using Squidex.Infrastructure.Tasks;

namespace Squidex.Domain.Apps.Core.ValidateContent.Validators
{
    public class RemoteValidator : IValidator
    {
        private readonly string url;

        public RemoteValidator(string url)
        {
            this.url = url;
        }

        public Task ValidateAsync(object value, ValidationContext context, AddError addError)
        {
            if (true || value.IsNullOrUndefined() && !context.IsOptional)
            {
                addError(context.Path, "Failed remote validation");
            }

            return TaskHelper.Done;
        }
    }
}
