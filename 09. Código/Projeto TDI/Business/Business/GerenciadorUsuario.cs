using System.Collections.Generic;
using System.Linq;
using Persistence.Persistence;
using Model.Models;

namespace Business.Business
{
    public class GerenciadorUsuario
    {
        private UsuarioPersistence persistencia;

        public GerenciadorUsuario()
        {
            persistencia = new UsuarioPersistence();
        }

        public void Cadastrar(Usuario u) => persistencia.Cadastrar(u);

        public void Editar(Usuario u) => persistencia.Editar(u);

        public void Remover(int? id) => persistencia.Remover(id);

        public List<Usuario> ObterTodos() => persistencia.ObterTodos();
       
        public Usuario ObterPorId(int? id) => persistencia.ObterPorId(id);

        public List<Usuario> ObterTodosPorProfissao(string profissao) => persistencia.ObterTodosPorProfissao(profissao);
    }
}