using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.DAO
{
    public static class DAORol
    {
        public static int getAllRoles(DataGridView dg)
        {

            return SqlConnector.retrieveDT("get_roles", dg);
        }
        public static List<String> getAllFuncionalidades()
        {

            return SqlConnector.retrieveList("get_all_funcionalidades", "fun_descripcion");
        }

        public static List<String> getFuncionalidadesQueNoTiene(Model.Rol rol)
        {
            return SqlConnector.retrieveList("get_funcionalidades_que_no_tiene", "fun_descripcion", rol.nombre);
        }

        public static int getFuncionalidadesRol(Model.Rol rol, DataGridView dg)
        {
            return SqlConnector.retrieveDT("get_funcionalidades", dg, rol.nombre);
        }

        public static int getIdFuncionalidad(String func) {
            return SqlConnector.executeProcedure("get_id_funcionalidad", func);
        }


        public static int agregarFuncionalidad(Model.Rol rol, String funcionalidad)
        {
            return SqlConnector.executeProcedure("asignar_funcionalidad_a_rol", rol.nombre, funcionalidad);
        }

        public static int eliminarFuncionalidad(Model.Rol rol, String funcionalidad)
        {
            return SqlConnector.executeProcedure("borrar_funcionalidad", rol.nombre, funcionalidad);
        }

        public static int cambiarEstadoRol(Model.Rol rol)
        {
            if (rol.habilitado)
            {
                return SqlConnector.executeProcedure("habilitar_rol", rol.nombre);
            }
            return SqlConnector.executeProcedure("bajar_rol", rol.nombre);
        }

        public static int modificarNombreRol(Model.Rol rol, String nuevoNombre)
        {

            return SqlConnector.executeProcedure("modificar_nombre_rol", rol.nombre, nuevoNombre);
        }

        public static int yaExisteRol(String nombre_nuevo)
        {

            return SqlConnector.executeProcedure("existe_rol", nombre_nuevo);
        }

        public static void crearNuevoRol(Model.Rol rol, DataGridView dg)
        {

            SqlConnector.executeProcedure("crear_rol", rol.nombre, rol.habilitado? 1 : 0);
            foreach (DataGridViewRow row in dg.Rows)
            {
                agregarFuncionalidad(rol, (String)row.Cells["col_funcionalidades"].Value);
            }


        }
    }
}
