using Capstone.DataAccessLayer.Abstract;
using Capstone.DataAccessLayer.Repository;
using Capstone.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.DataAccessLayer.EntityFramework
{
    public class EFCustomerDal:GenericRepository<Customer>,ICustomerDal
    {
    }
}
