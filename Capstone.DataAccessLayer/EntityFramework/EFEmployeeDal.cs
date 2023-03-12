using Capstone.DataAccessLayer.Abstract;
using Capstone.DataAccessLayer.Concrete;
using Capstone.DataAccessLayer.Repository;
using Capstone.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.DataAccessLayer.EntityFramework
{
    public class EFEmployeeDal : GenericRepository<Employee>, IEmployeeDal
    {
        public void ChangeEmployeStatusToFalse(int id)
        {
            using(var context = new Context())
            {
                var values = context.Employees.Find(id);
                values.EmployeStatus = false;
                context.SaveChanges();
            }
            
        }

        public void ChangeEmployeStatusToTrue(int id)
        {
           using(var context = new Context())
            {
                var values = context.Employees.Find(id);
                values.EmployeStatus = true;
                context.SaveChanges();
            }
        }

        public List<Employee> GetEmployeesByCategory()
        {
            using var context = new Context();
            return context.Employees.Include(x => x.Category).ToList();
        }
    }
}
