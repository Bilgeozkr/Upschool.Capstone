using Capstone.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.BusinessLayer.Abstract
{
    public interface IEmployeeService:IGenericService<Employee>
    {
        List<Employee> TGetEmployeesByCategory();
        void TChangeEmployeStatusToTrue(int id);
        void TChangeEmployeStatusToFalse(int id);
    }
}
