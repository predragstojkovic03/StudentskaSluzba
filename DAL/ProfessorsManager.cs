using Domain;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProfessorsManager
    {
        private SqlConnection _sqlConnection;

        public ProfessorsManager()
        {
            _sqlConnection = new SqlConnection(@"
                Data Source=Predrag\SQLEXPRESS;
                Initial Catalog=StudentskaSluzba;
                Integrated Security=True;
                Connect Timeout=30;
                Encrypt=True;
                Trust Server Certificate=True;
                Application Intent=ReadWrite;
                Multi Subnet Failover=False");
        }

        private void Connect()
        {
            _sqlConnection.Open();
        }

        private void Disconnect()
        {
            _sqlConnection.Close();
        }

        public Professor CreateProfessor(string firstName, string lastName, ProfessorTitle title, string userEmail)
        {
            try
            {
                Connect();
                var query = @"insert into professor (FirstName, LastName, UserEmail, Title)
                              output inserted.Id
                              values (@firstName, @lastName, @userEmail, @title)";
                var cmd = new SqlCommand(query, _sqlConnection);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@userEmail", userEmail);
                cmd.Parameters.AddWithValue("@title", title);

                long id = (long)cmd.ExecuteScalar();

                return new Professor(id, firstName, lastName, userEmail, title);
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

        public BindingList<Professor> FindAll()
        {
            var professors = new BindingList<Professor>();
            try
            {
                Connect();
                var query = @"select id, firstName, lastName, userEmail, title
                              from professor";
                var cmd = new SqlCommand(query, _sqlConnection);
                var rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    long id = (long)rdr["id"];
                    string firstName = (string)rdr["firstName"];
                    string lastName = (string)rdr["lastName"];
                    string userEmail = (string)rdr["userEmail"];
                    ProfessorTitle title = (ProfessorTitle)rdr["title"];

                    professors.Add(new Professor(id, firstName, lastName, userEmail, title));
                }

                return professors;

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
