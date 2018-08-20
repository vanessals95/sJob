using System.Collections.Generic;
using System.Linq;
using Model.Models;

namespace Persistence.Persistence
{
    public class UsuarioPersistence
    {
        private static List<Usuario> usuarios;

        static UsuarioPersistence()
        {
            if (usuarios == null)
                usuarios = new List<Usuario>();
        }

        public void Adicionar(Usuario u)
        {
            u.Id = usuarios.Count + 1;
            usuarios.Add(u);
        }

        public void Editar(Usuario u)
        {
            int idx = usuarios.FindIndex(e => e.Id == u.Id);
            usuarios[idx] = u;
        }

        public void Remover(int? id)
        {
            int idx = usuarios.FindIndex(e => e.Id == id);
            usuarios.RemoveAt(idx);
        }

        public List<Usuario> ObterTodos()
        {
            
            return usuarios;
        }

        public Usuario ObterById(int? id)
        {
            return (id.HasValue) ? usuarios.Find(p => p.Id == id) : null;
        }
    }
}