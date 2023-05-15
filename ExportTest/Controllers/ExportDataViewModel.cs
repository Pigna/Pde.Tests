namespace ExportTest.Controllers;

public class ExportDataViewModel
{
    public string TableName { get; set; } = null!;
    public string ColumnName { get; set; } = null!;
    public FakeDataType DataType { get; set; }


}

public enum FakeDataType
{
    Null,
    Account
}