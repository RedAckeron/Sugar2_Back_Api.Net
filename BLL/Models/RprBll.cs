

namespace BLL.Models

{
    public class RprBll
    {
        public int Id { get; set; }
        public int AddByUser { get; set; }
        public int IdCustomer { get; set; }
        public DateTime DtIn{ get; set; }
    }
    public class RprDalLight
    {
        public int Id { get; set; }
        public DateTime DtIn { get; set; }

    }
}