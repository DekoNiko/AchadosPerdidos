﻿using AchadosPerdidos.Winform.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AchadosPerdidos.Winform.View
{
	public partial class ImagemPerdidoView : UserControl
	{
		public ImagemPerdidoView()
		{
			if (!UsuarioSecao.SecaoAtiva())
				new LoginUserView().Show();
			InitializeComponent();
		}
	}
}
