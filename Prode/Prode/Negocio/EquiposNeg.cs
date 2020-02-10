using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prode.Entidades;
using Prode.Dao;
using System.Windows.Forms;

namespace Prode.Negocio
{
    public class EquiposNeg
    {
        public static bool EditarEquipo(Equipos _equipo)
        {
            bool exito = false;
            try
            {
                ValidarDatos(_equipo);
                exito = EquipoDao.EditarEquipo(_equipo);
            }
            catch (Exception ex)
            {

            }
            return exito;
        }
        public static bool GurdarEquipo(Equipos _equipo)
        {
            bool exito = false;
            try
            {
                ValidarDatos(_equipo);
                bool UsuarioExistente = ValidarEquipoExistente(_equipo.NombreEquipo);
                if (UsuarioExistente == true)
                {
                    const string message = "Ya existe un equipo registrado con el mismo nombre.";
                    const string caption = "Error";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                               MessageBoxIcon.Exclamation);
                    throw new Exception();
                }
                else
                {
                    exito = EquipoDao.InsertEquipo(_equipo);
                }
            }
            catch (Exception ex)
            {

            }
            return exito;
        }
        public static List<string> CargarComboEquipo()
        {
            List<string> lista = new List<string>();
            lista = EquipoDao.CargarComboEquipo();
            return lista;
        }
        public static List<string> CargarComboEstadios()
        {
            List<string> lista = new List<string>();
            lista = EquipoDao.CargarComboEstadios();
            return lista;
        }
        private static bool ValidarEquipoExistente(string nombreEquipo)
        {
            bool existe = EquipoDao.ValidarEquipoExistente(nombreEquipo);
            return existe;
        }
        private static void ValidarDatos(Equipos _equipo)
        {
            if (String.IsNullOrEmpty(_equipo.NombreEquipo))
            {
                const string message = "El campo Nombre Equipo es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
            if (String.IsNullOrEmpty(_equipo.NombreEstadio))
            {
                const string message = "El campo Nombre Estadio es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
        }
        public static List <PlantelActual> BuscarPlantelActual(int idEquipo)
        {
            List<PlantelActual> _plantel = new List<PlantelActual>();
            try
            {
                _plantel = EquipoDao.BuscarPlantelActual(idEquipo);
            }
            catch (Exception ex)
            {
                const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                throw new Exception();
            }
            return _plantel;
        }
        public static byte[] BuscarImagenEquipoLocal(string equipoLocal)
        {
            byte[] EscudoLocal = EquipoDao.BuscarImagenEquipoLocal(equipoLocal);
            return EscudoLocal;
        }
        public static string BuscarEstadioPorEquipoLocalSeleccionado(string equipoLocal)
        {
            string EstadioLocal = EquipoDao.BuscarEstadioPorEquipoLocalSeleccionado(equipoLocal);
            return EstadioLocal;
        }
        public static List<Equipos> BuscarEquipoPorNombre(string Nombre)
        {
            List<Equipos> _equipos = new List<Equipos>();
            try
            {
                _equipos = EquipoDao.BuscarEquipoPorNombre(Nombre);
            }
            catch (Exception ex)
            {
                const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                throw new Exception();
            }
            return _equipos;
        }
        public static bool AsignarJugarNuevoEquipo(int idJugador, int idEquipoSeleccionado)
        {
            bool Exito = false;
            bool JugadorYaAsignado = false;
            JugadorYaAsignado = EquipoDao.ValidarJugadorYaAsignadoAlEquipo(idJugador, idEquipoSeleccionado);
            if (JugadorYaAsignado == true)
            {
                const string message = "El jugador ya se encuentra asignado al equipo seleccionado.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
            else
            {
                Exito = EquipoDao.AsignarJugadorEquipo(idJugador, idEquipoSeleccionado);
            }

            return Exito;
        }
        public static bool EliminarEquipo(int idEquipo)
        {
            bool exito = false;
            try
            {
                exito = EquipoDao.EliminarEquipo(idEquipo);
            }
            catch (Exception ex)
            {

            }
            return exito;
        }
        public static bool CargaMasivaDeAsignaciones(List<int> listaId, int idEquipoSeleccionado)
        {
            bool exito = false;
            try
            {
                exito = EquipoDao.CargaMasivaDeAsignaciones(listaId, idEquipoSeleccionado);
            }
            catch (Exception ex)
            {

            }
            return exito;
        }
    }
}
