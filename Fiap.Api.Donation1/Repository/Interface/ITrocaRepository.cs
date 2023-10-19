﻿using Fiap.Api.Donation1.Models;

namespace Fiap.Api.Donation1.Repository.Interface
{
    public interface ITrocaRepository
    {

        public Guid Insert(Models.TrocaModel trocaModel);

        public TrocaModel FindById(Guid id);

    }
}
