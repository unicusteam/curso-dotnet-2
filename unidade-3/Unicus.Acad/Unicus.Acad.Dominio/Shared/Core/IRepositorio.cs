using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Unicus.Acad.Dominio.Shared.Core
{
    public interface IRepositorio<TEntidade, TId>
        where TEntidade : Entidade<TId>
    {
        TEntidade Obter(TId id);
        IList<TEntidade> ObterTodos(Expression<Func<TEntidade, bool>> predicado = null, int quantidadeRegistros = 20, int pagina = 1);
        void Salvar(TEntidade entidade);
        void Excluir(TId id);
    }
}
