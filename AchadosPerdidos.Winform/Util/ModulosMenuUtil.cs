using AchadosPerdidos.Winform.Business;
using AchadosPerdidos.Winform.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AchadosPerdidos.Winform.Util
{
    public class ModulosMenuUtil
    {

        private fHome _fhome;
        public static void ModulosBloqueados(fHome home)
        {
            var menuStrip = home.ContextMenuStrip;
            menuStrip.Items.Clear();

        }


        public bool Permissao()
        {
            var tipoUsuario = UsuarioSecao.GetUsername();
            var Id = UsuarioSecao.GetIsAdmin();

            if (Id == 1)
            {
                // Mostrar o botão ou permitir acesso ao módulo
                btnModuloXPTO.Visible = true;
            }
            else
            {
                // Ocultar o botão ou bloquear acesso ao módulo
                btnModuloXPTO.Visible = false;
            }
        }
    }



