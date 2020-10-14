using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Unicus.Acad.Dominio.Shared;

namespace Unicus.Acad.Aplicacao.Shared
{
    public interface IAppServico<TEntidade, TId>
        where TEntidade : Entidade<TId>
    {
        TEntidade Obter(TId id);
        IList<TEntidade> ObterTodos(Expression<Func<TEntidade, bool>> predicado = null, int quantidadeRegistros = 20, int pagina = 1);
        IList<ValidationResult> Salvar(TEntidade entidade);
        void Excluir(TId id);
    }
}
