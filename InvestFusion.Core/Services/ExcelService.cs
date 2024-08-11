using ClosedXML.Excel;
using InvestFusion.Core.Entities;
using InvestFusion.Core.Entities.Enums;
using InvestFusion.Core.Interfaces;

namespace InvestFusion.Core.Services
{
    public class ExcelService : IExcelService
    {
        public List<Transactions> ReadExcelFile(SupportedBroker supportedBroker, byte[] fileData)
        {
            if (supportedBroker == SupportedBroker.Swissquote)
                return ReadSwissquoteFile(fileData);

            throw new NotSupportedException("This broker is not supported");
        }

        private List<Transactions> ReadSwissquoteFile(byte[] fileData)
        {
            using (var stream = new MemoryStream(fileData))
            using (var workbook = new XLWorkbook(stream))
            {
                var worksheet = workbook.Worksheets.FirstOrDefault();
                var result = new List<Transactions>();
                if (worksheet != null)
                {
                    int id = 1;
                    for (int row = 2; row <= worksheet.LastRowUsed().RowNumber(); row++)
                    {
                        var stock = new Transactions
                        {
                            Id = id++,
                            Stock = new Stock()
                            {
                                Name = worksheet.Cell(row, 1).GetString(),
                                ISIN = worksheet.Cell(row, 2).GetString(),
                            },
                            OrderType = Enum.Parse<OrderType>(worksheet.Cell(row, 3).GetString(), true),
                            Count = int.Parse(worksheet.Cell(row, 4).GetString()),
                            Price = decimal.Parse(worksheet.Cell(row, 5).GetString()),
                            OrderDate = DateTime.Parse(worksheet.Cell(row, 6).GetString())
                        };
                        result.Add(stock);
                    }
                }
                return result;
            }
        }
    }
}
