using Domain;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SubjectsManager : AbstractManager
    {
        public Subject Create(long id, string name, string code, int espb, Professor professor)
        {
            try
            {
                Connect();
                var query = @"insert into subject (Id, Name, Code, Espb, ProfessorId)
                              values (@id, @name, @code, @espb, @professorId)";
                var cmd = new SqlCommand(query, _sqlConnection);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("code", code);
                cmd.Parameters.AddWithValue("espb", espb);
                cmd.Parameters.AddWithValue("professorId", professor.Id);
                cmd.ExecuteNonQuery();

                return new Subject(id, name, code, espb, professor);
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

        public List<Subject> FindAll()
        {
            var subjects = new List<Subject>();
            try
            {
                Connect();
                var query = @"select subject.id, name, code, espb, professorId, firstName, lastName, userEmail, title
                              from subject
                              join professor on (subject.professorId = professor.id)";
                var cmd = new SqlCommand(query, _sqlConnection);
                var rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    long id = (long)rdr["id"];
                    string name = (string)rdr["name"];
                    string code = (string)rdr["code"];
                    int espb = (int)rdr["espb"];

                    long professorId = (long)rdr["professorId"];
                    string firstName = (string)rdr["firstName"];
                    string lastName = (string)rdr["lastName"];
                    string userEmail = (string)rdr["userEmail"];
                    ProfessorTitle title = (ProfessorTitle)rdr["title"];

                    var professor = new Professor(professorId, firstName, lastName, userEmail, title);
                    var subject = new Subject(id, name, code, espb, professor);
                    subjects.Add(subject);
                }

                return subjects;

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

        public void Remove(long selected)
        {
            try
            {
                Connect();

                var query = "delete from subject where id=@id";
                var cmd = new SqlCommand(query, _sqlConnection);
                cmd.Parameters.AddWithValue("id", selected);

                cmd.ExecuteNonQuery();
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
