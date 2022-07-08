using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uppgift1VC.Models;
using uppgift1VC.Models.POCO;

namespace uppgift1VC.Models
{
    public interface IErrandRepository
    {
        //Read
        IQueryable<Errand> Errands { get; }
        Errand GetErrand(int id);

        IQueryable<Department> Departments { get; }

        IQueryable<ErrandStatus> ErrandStatuses { get; }

        IQueryable<Employee> Employees { get; }
        IQueryable<Sequence> Sequence { get; }
        IQueryable<Sample> Samples { get; }

        IQueryable<Picture> Pictures { get; }

        //create and update
        string SaveErrand(Errand errand);

        //Delete
        Errand DeleteErrand(int id);

        Task<Errand> GetErrandInfo(int id);

        int GetSequence();


    }

}
