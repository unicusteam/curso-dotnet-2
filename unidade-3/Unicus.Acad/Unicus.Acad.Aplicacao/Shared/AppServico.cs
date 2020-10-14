using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using Unicus.Acad.Dominio.Shared;
using Unicus.Acad.Dominio.Shared.Core;

namespace Unicus.Acad.Aplicacao.Shared
{
    public abstract class AppServico<TEntidade, TRepositorio, TId> : IAppServico<TEntidade, TId>
        where TEntidade : Entidade<TId>
        where TRepositorio : IRepositorio<TEntidade, TId>
    {
        protected TRepositorio repositorio;

        protected AppServico()
        {
            Initicializar();
        }

        public TEntidade Obter(TId id)
        {
            return repositorio.Obter(id);
        }

        public IList<TEntidade> ObterTodos(Expression<Func<TEntidade, bool>> predicado = null, int quantidadeRegistros = 20, int pagina = 1)
        {
            return repositorio.ObterTodos(predicado, quantidadeRegistros, pagina);
        }

        public IList<ValidationResult> Salvar(TEntidade entidade)
        {
            var result = entidade.Validar();

            if (!result.Any())
            {
                repositorio.Salvar(entidade);
            }

            return result;
        }

        public void Excluir(TId id)
        {
            repositorio.Excluir(id);
        }

        protected abstract void Initicializar();
    }
}
