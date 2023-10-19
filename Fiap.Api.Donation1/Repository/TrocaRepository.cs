﻿using Fiap.Api.Donation1.Data;
using Fiap.Api.Donation1.Models;
using Fiap.Api.Donation1.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Api.Donation1.Repository
{
    public class TrocaRepository : ITrocaRepository
    {

        private readonly DataContext dataContext;

        public TrocaRepository(DataContext context)
        {
            this.dataContext = context;
        }


        public Guid Insert(Models.TrocaModel trocaModel)
        {
            dataContext.Trocas.Add(trocaModel);
            dataContext.SaveChanges();

            return trocaModel.TrocaId;
        }

        public TrocaModel FindById(Guid id)
        {
            var troca = dataContext.Trocas
                    .Include( t => t.ProdutoModel1 )
                    .Include( t => t.ProdutoModel2 )
                .FirstOrDefault( t => t.TrocaId == id);

            return troca;
        }


    }
}
