using DAL;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ProfessorsService
    {
        private ProfessorsManager _professorsManager;

        public ProfessorsService()
        {
            _professorsManager = new ProfessorsManager();
        }

        public Professor CreateProfessor(string firstName, string lastName, ProfessorTitle title, string email)
        {
            return _professorsManager.CreateProfessor(firstName, lastName, title, email);
        }

        public BindingList<Professor> FindAll()
        {
            return _professorsManager.FindAll();
        }
    }
}
