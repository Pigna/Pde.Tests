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
        
        Exporter.CreateTables(tables);

        var data = new TableData();
        data.TableName = "tabel";
        var rows = new List<IDictionary<string, object>>();
        var columns = new Dictionary<string, object>();
        rows.Add(columns);
        columns.Add("column1", "Data enzo");
        columns.Add("column2", "Data enz2o");
        columns.Add("column3", "Data enzo3");
        columns.Add("column4", "Data en9zo");
        columns.Add("column5", "Data 4enzo");
        columns.Add("column6", "Data e5nzo");
        columns.Add("column7", "Data en6zo");
        columns.Add("column8", "Data enz7o");
        var columns2 = new Dictionary<string, object>();
        rows.Add(columns2);
        columns2.Add("column1", "Data enzo");
        columns2.Add("column2", "Data enz2o");
        columns2.Add("column3", "Data enzo3");
        columns2.Add("column4", "Data en9zo");
        columns2.Add("column5", "Data 4enzo");
        columns2.Add("column6", "Data e5nzo");
        columns2.Add("column7", "Data en6zo");
        columns2.Add("column8", "Data enz7o");

        data.Data = rows;
        
       Exporter.InsertData(data);
        return Ok();
        
    }
}