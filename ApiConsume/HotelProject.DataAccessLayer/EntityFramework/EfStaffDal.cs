using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrate;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        public EfStaffDal(Context context) : base(context)
        {
            
        }
    }
}
