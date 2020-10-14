using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Unicus.Acad.Dominio.Shared;
using Unicus.Acad.Dominio.Shared.Core;

namespace Unicus.Acad.Infraestrutura.Repositorios
{
    public abstract class Repositorio<TEntidade, TId> : IRepositorio<TEntidade, TId>
        where TEntidade : Entidade<TId>
    {
        protected ISession sessao;

        protected Repositorio()
        {
            sessao = NhibernateHelper.AbrirSessao();
        }

        public void Excluir(TId id)
        {
            sessao.Delete(sessao.Load<TEntidade>(id));
        }

        public TEntidade Obter(TId id)
        {
            return sessao.Get<TEntidade>(id);
        }

        public IList<TEntidade> ObterTodos(Expression<Func<TEntidade, bool>> predicado = null, int quantidadeRegistros = 20, int pagina = 1)
        {
            var query = predicado != null ? 
                sessao.Query<TEntidade>().Where(predicado) : 
                sessao.Query<TEntidade>();

            return query
                .Skip((pagina - 1) * quantidadeRegistros)
                .Take(quantidadeRegistros)
                .ToList();
        }

        public void Salvar(TEntidade entidade)
        {            
            sessao.SaveOrUpdate(entidade);
        }
    }
}
