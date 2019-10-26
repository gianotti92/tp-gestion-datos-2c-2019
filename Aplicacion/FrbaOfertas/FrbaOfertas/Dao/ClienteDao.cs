using FrbaOfertas.Entities;
using FrbaOfertas.Repository;

namespace FrbaOfertas.Dao
{
    public class ClienteDao : ClienteRepository
    {
        public void guardarCliente(Cliente cliente)
        {
          /*  SqlCommand cmd = new SqlCommand("dbo.SP_SAVE_CLIENTE", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@username", usuario.userName));
            cmd.Parameters.Add(new SqlParameter("@pass", usuario.contrasena));
            cmd.Parameters.Add(new SqlParameter("@tipo", usuario.tipoUsuario));

            cmd.ExecuteNonQuery();
            ConnectionQuery.cerrarConexion();*/
        }
    }
}