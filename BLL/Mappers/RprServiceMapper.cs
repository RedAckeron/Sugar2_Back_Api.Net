using BLL.Models;
using DAL.Models;

namespace BLL.Mappers
{
    public static class RprServiceMapper
    {
		public static RprBll RprDalToRprBll(RprDal rprDal)
		{
            return new RprBll()
            {

            Id = rprDal.Id,
            AddByUser= rprDal.AddByUser,
            IdCustomer= rprDal.IdCustomer,
            DtIn= rprDal.DtIn,
            };
		}
        public static RprDal RprBllToRprDal(RprBll rprBll)
        {
            return new RprDal()
            {
                Id = rprBll.Id,
                AddByUser = rprBll.AddByUser,
                IdCustomer = rprBll.IdCustomer,
                DtIn = rprBll.DtIn,
            };
        }
    }
}