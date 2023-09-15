
namespace BLL.Models
{
    public class CustomerSummaryBll
    {
        public int IdCustomer { get; set; }
        public IEnumerable<AdrBllLight>? adrLights { get; set; }
        public IEnumerable<OdpBllLight>? odpLights { get; set; }
        public IEnumerable<CmdBllLight>? cmdLights { get; set; }
        public IEnumerable<FctBllLight>? fctLights { get; set; }
        public IEnumerable<RprBllLight>? rprLights { get; set; }
        public IEnumerable<DlcBllLight>? dlcLights { get; set; }
    }
}
