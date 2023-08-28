

using DAL.Models;

namespace BLL.Models

{
    public class FctBll
	{
        public int Id { get; set; }
        public int IdOdp { get; set; } = 0;
        public int AddByUser { get; set; }
        public int IdCustomer { get; set; }
        public DateTime DtIn{ get; set; }
        public List<ItemDal> Basket { get; set; }
    }
    public class FctLightDal
    {
        public int Id { get; set; }
        public DateTime DtIn { get; set; }

    }
}