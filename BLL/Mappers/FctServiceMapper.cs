using BLL.Models;
using DAL.Models;

namespace BLL.Mappers
{
    public static class FctServiceMapper
    {
		public static FctBll FctDalToFctBll(FctDal fctDal)
		{
            return new FctBll()
            {

            Id = fctDal.Id,
            AddByUser= fctDal.AddByUser,
            IdCustomer= fctDal.IdCustomer,
            DtIn= fctDal.DtIn,
            Basket= fctDal.Basket
            };
		}
        public static FctDal FctBllToFctDal(FctBll fctBll)
        {
            return new FctDal()
            {
                Id = fctBll.Id,
                AddByUser = fctBll.AddByUser,
                IdCustomer = fctBll.IdCustomer,
                DtIn = fctBll.DtIn,
                Basket = fctBll.Basket
            };
        }
    }
}