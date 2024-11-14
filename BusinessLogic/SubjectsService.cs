using DAL;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class SubjectsService
    {
        SubjectsManager _subjectsManager;

        public SubjectsService()
        {
            _subjectsManager = new SubjectsManager();
        }

        public Subject CreateSubject(long id, string name, string code, int espb, Professor professor)
        {
            return _subjectsManager.Create(id, name, code, espb, professor);
        }

        public List<Subject> FindAll()
        {
            return _subjectsManager.FindAll();
        }

        public List<Subject> FindByProfessor(long professorId)
        {
            return _subjectsManager
                .FindAll()
                .Where(subject => subject.Professor.Id == professorId)
                .ToList();
        }

        public void Remove(long selected)
        {
            _subjectsManager.Remove(selected);
        }
    }
}
