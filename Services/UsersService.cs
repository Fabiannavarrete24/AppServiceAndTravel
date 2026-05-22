namespace AppServiceAndTravel.Services
{
    public class UsersService
    {
        //public LoginVM SetRegistrarUsuario(string usuario, string nombre, string clave, string correo, string cargo, int administrador, string token)
        //{
        //    var result = new LoginVM();
        //    try
        //    {
        //       var user = ApplicationUser{
        //           userName = usuario,
        //       };
        //        using (FbConnection con = new FbConnection(_context.Database.GetConnectionString()))
        //        {
        //            con.Open();
        //            using (var transaction = con.BeginTransaction())
        //            {
        //                FbCommand cmd = new FbCommand
        //                {
        //                    Connection = con,
        //                    Transaction = transaction,
        //                    CommandText = "SELECT Valid, message FROM PROC_SET_USUARIO(@USUARIO,@NOMBRE,@CLAVE,@CORREO,@CARGO,@ADMINISTRADOR,@TOKEN)"
        //                };

        //                cmd.Parameters.Add("@USUARIO", FbDbType.Integer).Value = usuario;
        //                cmd.Parameters.Add("@NOMBRE", FbDbType.Integer).Value = nombre;
        //                cmd.Parameters.Add("@CLAVE", FbDbType.Integer).Value = clave;
        //                cmd.Parameters.Add("@CORREO", FbDbType.Integer).Value = correo;
        //                cmd.Parameters.Add("@CARGO", FbDbType.Integer).Value = cargo;
        //                cmd.Parameters.Add("@ADMINISTRADOR", FbDbType.Integer).Value = administrador;
        //                cmd.Parameters.Add("@TOKEN", FbDbType.Integer).Value = token;

        //                using (var reader = cmd.ExecuteReader())
        //                {
        //                    if (reader.Read())
        //                    {
        //                        result.valid = reader.IsDBNull(reader.GetOrdinal("Valido")) ? 0 : reader.GetInt32(reader.GetOrdinal("Valido"));
        //                        result.message = reader.IsDBNull(reader.GetOrdinal("message")) ? null : reader.GetString(reader.GetOrdinal("message"));
        //                    }
        //                }
        //                transaction.Commit();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _utilities.RegistrarLog($"Se presento un error; {ex.Message}", "setRegitrarUsuario", "PROC_GET_LOGIN");
        //        result.valid = 0;
        //        result.message = "Error interno del servidor: " + ex.Message;
        //    }
        //    _utilities.RegistrarLog($"Se ejecuto correctamente", "setRegitrarUsuario", "PROC_GET_LOGIN");
        //    return result;
        //}
    }
}
