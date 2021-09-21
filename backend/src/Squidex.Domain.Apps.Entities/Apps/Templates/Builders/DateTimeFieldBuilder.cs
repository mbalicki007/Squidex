﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschraenkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using Squidex.Domain.Apps.Core.Schemas;
using Squidex.Domain.Apps.Entities.Schemas.Commands;

namespace Squidex.Domain.Apps.Entities.Apps.Templates.Builders
{
    public sealed class DateTimeFieldBuilder : FieldBuilder<DateTimeFieldBuilder, DateTimeFieldProperties>
    {
        public DateTimeFieldBuilder(UpsertSchemaFieldBase field, DateTimeFieldProperties properties, CreateSchema schema)
            : base(field, properties, schema)
        {
        }
    }
}
