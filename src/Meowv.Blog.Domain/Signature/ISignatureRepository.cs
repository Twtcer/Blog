﻿using System;
using Volo.Abp.Domain.Repositories;

namespace Meowv.Blog.Domain.Signature
{
    /// <summary>
    /// ISignatureRepository
    /// </summary>
    public interface ISignatureRepository : IRepository<Signature, Guid>
    {
    }
}