using InvestFusion.Core.Entities;
using InvestFusion.Core.Entities.Enums;

namespace InvestFusion.Core.Interfaces
{
    public interface IExcelService
    {
        List<Transactions> ReadExcelFile(SupportedBroker supportedBroker, byte[] fileData);
    }
}