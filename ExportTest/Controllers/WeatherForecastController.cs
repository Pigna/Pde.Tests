using System.Dynamic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
namespace ExportTest.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet(Name = "GetWeatherForecast")]
    public OkResult Get()
    {
        var tables = new List<ExportDataViewModel>();
        tables.Add(new ExportDataViewModel()
        {
            TableName = "ColumnName123",
            ColumnName = "columnName123",
            DataType = FakeDataType.Account
        });
        tables.Add(new ExportDataViewModel()
        {
            TableName = "2",
            ColumnName = "qwe",
            DataType = FakeDataType.Account
        });
        tables.Add(new ExportDataViewModel()
        {
            TableName = "3",
            ColumnName = "asd",
            DataType = FakeDataType.Account
        });
        tables.Add(new ExportDataViewModel()
        {
            TableName = "3",
            ColumnName = "wergfdgfgd",
            DataType = FakeDataType.Account
        });
        tables.Add(new ExportDataViewModel()
        {
            TableName = "3",
            ColumnName = "te3ff",
            DataType = FakeDataType.Account
        });
        tables.Add(new ExportDataViewModel()
        {
            TableName = "4",
            ColumnName = "fgd",
            DataType = FakeDataType.Account
        });
        
        tables.Add(new ExportDataViewModel()
        {
            TableName = "4",
            ColumnName = "rwrreg",
            DataType = FakeDataType.Account
        });
        
        Caht.CreateTables(tables);
       // Caht.InsertData();
        return Ok();
        
    }
}