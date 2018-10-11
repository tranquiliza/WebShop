﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.Models.Language;

namespace WebShop.Repositories.Interfaces
{
    public interface ILabelRepository
    {
        Task<ICollection<Label>> Get();

        Task<Label> Get(int id);
    }
}