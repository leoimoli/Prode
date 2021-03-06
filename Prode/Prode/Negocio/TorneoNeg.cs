﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prode.Entidades;
using Prode.Dao;
using System.Windows.Forms;

namespace Prode.Negocio
{
    public class TorneoNeg
    {
        public static bool GuardarTorneo(Torneo _torneo)
        {
            bool exito = false;
            try
            {
                ValidarDatos(_torneo);
                exito = TorneoDao.GuardarTorneo(_torneo);
            }
            catch (Exception ex)
            {

            }
            return exito;
        }

        private static void ValidarDatos(Torneo _torneo)
        {
            if (String.IsNullOrEmpty(_torneo.Temporada) || _torneo.Temporada == "Seleccione")
            {
                const string message = "El campo Temporada es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
            if (String.IsNullOrEmpty(_torneo.NombreTorneo))
            {
                const string message = "El campo Nombre de Torneo es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
            //if (_torneo.CantidadFechas == null || _torneo.CantidadFechas == 0)
            //{
            //    const string message = "El campo Cantidad de Fechas es obligatorio.";
            //    const string caption = "Error";
            //    var result = MessageBox.Show(message, caption,
            //                                 MessageBoxButtons.OK,
            //                               MessageBoxIcon.Exclamation);
            //    throw new Exception();
            //}

            if (String.IsNullOrEmpty(_torneo.Liga))
            {
                const string message = "El campo Liga es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
        }
        public static List<string> CargarComboTorneos(string Liga)
        {
            List<string> lista = new List<string>();
            lista = TorneoDao.CargarComboTorneos(Liga);
            return lista;
        }
        public static bool ValidarFecha(string fecha, string torneo, string temporada, string Liga)
        {
            bool fechaValida = TorneoDao.ValidarFecha(fecha, torneo, temporada, Liga);
            return fechaValida;
        }

        public static bool ValidarNroFechaExistente(string NroFecha, string torneo, string temporada, string Liga)
        {
            bool NroFechaValido = TorneoDao.ValidarNroFechaExistente(NroFecha, torneo, temporada, Liga);
            return NroFechaValido;
        }
        public static List<string> CargarComboLiga()
        {
            List<string> lista = new List<string>();
            lista = TorneoDao.CargarComboLiga();
            return lista;
        }
    }
}
