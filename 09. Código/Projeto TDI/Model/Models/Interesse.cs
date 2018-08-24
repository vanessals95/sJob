using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Model.Models;

namespace Model.Models
{
    public class Interesse
    {
        public int IdInteresse { get; set; }
        public Usuario Contratante { get; set; }
        public Usuario Contratado { get; set; }
        public int Status { get; set; }
        public DateTime Data { get; set; }
    }
}
