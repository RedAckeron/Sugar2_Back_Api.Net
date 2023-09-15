using Bll.Models;
using DAL.Models;


namespace DAL.Mapper
{
	public static class CustomerBllMapper
	{
	public static CustomerDal CustomerBllToCustomerDal(CustomerBll custBll)
		{
			return new CustomerDal()
			{
				FirstName = custBll.FirstName,
				LastName = custBll.LastName,
				Email = custBll.Email,
				Call1 = custBll.Call1,
				Call2= custBll.Call2,
                AddByUser = custBll.AddByUser
            };
		}

    public static CustomerBll CustomerDalToCustomerBll(CustomerDal custDal)
		{
			return new CustomerBll()
			{
				Id = custDal.Id,
				FirstName = custDal.FirstName,
				LastName = custDal.LastName,
				Email = custDal.Email,
				Call1 = custDal.Call1,
				Call2 = custDal.Call2,
				DtIn = custDal.DtIn,
				AddByUser = custDal.AddByUser
			};
		}


        public static List<CustomerBll> CustomerDalToCustomerBll(List<CustomerDal> custDal)
        {
            List<CustomerBll> custBlls = new List<CustomerBll>();

            foreach (CustomerDal item in custDal)
            {
                custBlls.Add(new CustomerBll()
                {
					Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Email = item.Email,
                    Call1 = item.Call1,
                    Call2 = item.Call2,
                    DtIn = item.DtIn,
                    AddByUser = item.AddByUser
                });
            }
            return custBlls;

        }


    }
}