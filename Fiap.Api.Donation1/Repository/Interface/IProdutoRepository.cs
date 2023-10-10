using Fiap.Api.Donation1.Models;

namespace Fiap.Api.Donation1.Repository.Interface
{
    public interface IProdutoRepository
    {

        public Task<IList<ProdutoModel>> FindAll();

        public Task<IList<ProdutoModel>> FindByNome(string nome);

        public Task<ProdutoModel> FindById(int id);

        public Task<int> Insert(ProdutoModel produtoModel);

        public void Update(ProdutoModel produtoModel);

        public void Delete(ProdutoModel produtoModel);

        public void Delete(int id);

    }
}
