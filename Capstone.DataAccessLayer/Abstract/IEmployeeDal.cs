using Capstone.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.DataAccessLayer.Abstract
{
    public interface IEmployeeDal:IGenericDal<Employee>
    {
        List<Employee> GetEmployeesByCategory();
        void ChangeEmployeStatusToTrue(int id);
        void ChangeEmployeStatusToFalse(int id);
    }
}
