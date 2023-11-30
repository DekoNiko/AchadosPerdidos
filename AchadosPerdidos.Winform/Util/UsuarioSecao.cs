using AchadosPerdidos.Winform.Business;
using AchadosPerdidos.Winform.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosPerdidos.Winform.Util
{
    public static class UsuarioSecao
    {
        private static UsuarioModel secao;

        public static void LogarUsuario(UsuarioModel model)
        {
            secao = model;
        }

        public static void DeslogarUsuario()
        {
            secao = null;
        }

        public static bool SecaoAtiva()
        {
            if (secao is null)
                return false;
            else
                return true;
        }

        public static string GetUsername()
        {
            return secao.Username;
        }

        public static int GetIsAdmin()
        {
            return secao.IsAdmin;
        }

    }
}
