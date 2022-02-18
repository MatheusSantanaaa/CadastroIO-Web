using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Business.Models.Validations;
using System;
using System.Threading.Tasks;

namespace DevIO.Business.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        private readonly IProdutosRepository _produtosRepository;

        public ProdutoService(IProdutosRepository produtosRepository,
                              INotificador notificador) : base(notificador)
        {
            _produtosRepository = produtosRepository;
        }
         
        public async Task Adicionar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            await _produtosRepository.Adicionar(produto);
        }

        public async Task Atualizar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            await _produtosRepository.Atualizar(produto);
        }


        public async Task Remover(Guid id)
        {
            await _produtosRepository.Remover(id);
        }

        public void Dispose()
        {
            _produtosRepository?.Dispose();
        }
    }
}
