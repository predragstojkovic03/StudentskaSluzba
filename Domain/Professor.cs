using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Professor
    {
        public Professor(long id, string firstName, string lastName, string userEmail, ProfessorTitle title)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            UserEmail = userEmail;
            Title = title;
        }

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserEmail { get; set; }
        public ProfessorTitle Title { get; set; }
    }
}
