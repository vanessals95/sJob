using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace SearchJobWeb.Areas.Privada.Util
{
    public enum SessionKeys { NOME, USUARIO }

    public static class SessionHelper
    {
        public static T Get<T>(ISession sessao, SessionKeys chave)
        {
            string chaveString = Enum.GetName(typeof(SessionKeys), chave);
            var valor = sessao.GetString(chaveString);
            return (valor == null) ? default(T) : JsonConvert.DeserializeObject<T>(valor);
        }

        public static void Set<T>(ISession sessao, SessionKeys chave, T valor)
        {
            string chaveString = Enum.GetName(typeof(SessionKeys), chave);
            sessao.SetString(chaveString, JsonConvert.SerializeObject(valor));
        }
    }
}
