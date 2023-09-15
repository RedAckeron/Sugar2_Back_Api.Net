using ACTRL.Models;
using Bll.Models;


namespace DAL.Mapper
{
	public static class CustomerControllerMapper
	{
	public static CustomerBll CustomerFormToCustomerBll(CustomerForm custForm)
		{
			return new CustomerBll()
			{
				FirstName = custForm.FirstName,
				LastName = custForm.LastName,
				Email = custForm.Email,
				Call1 = custForm.Call1,
				Call2= custForm.Call2,
                AddByUser = custForm.AddByUser
            };
		}

    public static CustomerForm CustomerBllToCustomerForm(CustomerBll custBll)
		{
			return new CustomerForm()
			{
				FirstName = custBll.FirstName,
				LastName = custBll.LastName,
				Email = custBll.Email,
				Call1 = custBll.Call1,
				Call2 = custBll.Call2,
				DtIn = custBll.DtIn,
				AddByUser = custBll.AddByUser
			};
		}

   
	}
}