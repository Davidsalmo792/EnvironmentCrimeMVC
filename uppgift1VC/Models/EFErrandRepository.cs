using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using uppgift1VC.Models.POCO;

namespace uppgift1VC.Models
{
    public class EFErrandRepository : IErrandRepository
    {
        private ApplicationDBContext context;


        public EFErrandRepository(ApplicationDBContext ctx)
        {
            context = ctx;

        }

        public IQueryable<Department> Departments => context.Departments;
        public IQueryable<ErrandStatus> ErrandStatuses => context.ErrandStatuses;
        public IQueryable<Employee> Employees => context.Employees;
        public IQueryable<Sequence> Sequences => context.Sequences;
        public IQueryable<Sample> Samples => context.Samples;
        public IQueryable<Picture> Pictures => context.Pictures;
        public IQueryable<Errand> Errands => context.Errands;
        public IQueryable<Sequence> Sequence => context.Sequences;



        public Errand DeleteErrand(int id)
        {
            throw new System.NotImplementedException();
        }
        public Errand GetErrand(int id)
        {
            throw new System.NotImplementedException();
        }

        public string SaveErrand(Errand errand)
        {
            string value = null;

            if (errand.ErrandID == 0)
            {
                var sequence = Sequences.Where(s => s.Id == 1).First();
                int currentValue = sequence.CurrentValue;

                value = "2022-45-" + currentValue;

                errand.RefNumber = value;
                errand.StatusId = "S_A";

                context.Errands.Add(errand);

                sequence.CurrentValue++;
            }
            context.SaveChanges();

            return value;
        }

        public Task<Errand> GetErrandInfo(int id)
        {
            return Task.Run(() =>
            {
                var errandInfo = Errands.Where(x => x.ErrandID == id).First();
                return errandInfo;
            });
        }


        public void GetSequence()
        {

        }

        int IErrandRepository.GetSequence()
        {
            throw new NotImplementedException();
        }
    }
}
