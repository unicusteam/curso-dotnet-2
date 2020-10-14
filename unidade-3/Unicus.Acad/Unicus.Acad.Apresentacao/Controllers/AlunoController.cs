using System;
using Unicus.Acad.Aplicacao;
using Unicus.Acad.Aplicacao.Shared;
using Unicus.Acad.Dominio;
using Unicus.Acad.Dominio.Shared;

namespace Unicus.Acad.Apresentacao.Controllers
{
    public class AlunoController : Controller<Aluno, AlunoAppServico, int>
    {
        protected override Aluno SolicitarDadosCadastro()
        {
            var aluno = new Aluno();
            Console.Write("Nome:");
            aluno.Nome = Console.ReadLine();
            return aluno;
        }
    }

    public abstract class Controller<TEntidade, TAppServico, TId>
        where TEntidade : Entidade<TId>
        where TAppServico : IAppServico<TEntidade, TId>, new()
    {
        private TAppServico appServico;

        public Controller()
        {
            appServico = new TAppServico();
        }

        public void Cadastrar()
        {
            TEntidade entidade = SolicitarDadosCadastro();
            appServico.Salvar(entidade);
        }

        protected abstract TEntidade SolicitarDadosCadastro();
    }
}
