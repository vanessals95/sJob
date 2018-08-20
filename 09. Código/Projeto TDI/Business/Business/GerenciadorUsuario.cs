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

        public void Adicionar(Usuario u) => persistencia.Adicionar(u);

        public void Editar(Usuario u) => persistencia.Editar(u);

        public void Remover(int? id) => persistencia.Remover(id);

        public List<Usuario> ObterTodos()
        {
            return persistencia.ObterTodos();
        }

        public Usuario ObterById(int? id) => persistencia.ObterById(id);

        public List<Usuario> ObterTodosByEmprego(string profissao)
        {
            return persistencia.ObterTodos().Where(e => e.NomeProfissao.ToLowerInvariant().Contains(profissao.ToLowerInvariant())).ToList();
        }
    }
}