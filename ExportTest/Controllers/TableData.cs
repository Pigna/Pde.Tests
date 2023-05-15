namespace ExportTest.Controllers;

public class TableData
{
    public string TableName { get; set; } = null!;
    public IList<IDictionary<string, object>>? Data { get; set; }
}