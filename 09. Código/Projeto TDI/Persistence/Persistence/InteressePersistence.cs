using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Model.Models;

namespace Persistence.Persistence
{
    public class InteressePersistence
    {
        private static List<Interesse> interesses;

        static InteressePersistence()
        {
            if (interesses == null)
                interesses = new List<Interesse>();
        }

        public void CadastrarInteresse(Interesse i)
        {
            i.IdInteresse = interesses.Count + 1;
            interesses.Add(i);
        }

        public void Remover(int? id)
        {
            int idx = interesses.FindIndex(e => e.IdInteresse == id);
            interesses.RemoveAt(idx);
        }

        public Interesse ObterInteresses(Func<Interesse, bool> where)
        {
            return interesses.Where(where).FirstOrDefault();
        }

        public List<Interesse> ObterTodosInteresses()
        {
            return interesses;
        }

        public Interesse ObterInteressePorId(int? id)
        {
            return (id.HasValue) ? interesses.Find(p => p.IdInteresse == id) : null;
        }

        public int VerificarInteresse(int status)
        {
            return status;
        }
    }
}
