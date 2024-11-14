using Domain;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class UsersManager : AbstractManager
    {
        public User FindUserByEmail(string email)
        {
            string upit = $"select id, firstname, lastname, email, password from [user] where email=@email";
            var cmd = new SqlCommand(upit, _sqlConnection);
            cmd.Parameters.AddWithValue("email", email);

            try
            {
                Connect();
                var rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    long id = (long)rdr["Id"];
                    string firstName = (string)rdr["FirstName"];
                    string lastName = (string)rdr["LastName"];
                    string password = (string)rdr["Password"];

                    return new User(id, firstName, lastName, email, password);
                }
                else
                {
                    throw new Exception("User with provided email not found.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            } 
            finally
            {
                Disconnect();
            }
        }
    }
}


