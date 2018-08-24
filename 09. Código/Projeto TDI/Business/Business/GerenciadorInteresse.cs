using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Persistence.Persistence;
using Model.Models;

namespace Business.Business
{
    public class GerenciadorInteresse
    {
        private InteressePersistence persistencia;

        public GerenciadorInteresse()
        {
            persistencia = new InteressePersistence();
        }

        public void CadastrarInteresse(Interesse i) => persistencia.CadastrarInteresse(i);

        public void Remover(int? id) => persistencia.Remover(id);

        public List<Interesse> ObterTodosInteresses() => persistencia.ObterTodosInteresses();

        public Interesse ObterInteressePorId(int? id) => persistencia.ObterInteressePorId(id);

        public int VerificarInteresseAceitar(int status) => persistencia.VerificarInteresse(status);

        public int VerificarInteresseRecusar(int status) => persistencia.VerificarInteresse(status);
    }
}
