﻿using DataModel.DataManager;
using EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRule
{
    public class VentaBR
    {
        public static List<VentaModel> ObtenerVentas(VentaModel venta)
        {
            return VentaManager.ObtenerVentas(venta);
        }

        public static VentaModel CrearEditarVenta(VentaModel Venta)
        {
            return VentaManager.CrearEditarVenta(Venta);
        }
    }
}
