using System;
using System.Data.SqlClient;
using System.IO;

namespace ExportTest.Controllers;

class Caht
{
    public static void CreateTables(IEnumerable<ExportDataViewModel> exportData)
    {
        const string fileName = "ProjectName_Tables.sql";

        var tables = exportData.GroupBy(table => table.TableName).ToList();
        // Write SQL script to file
        using var writer = new StreamWriter(fileName);
        foreach (var table in tables)
        {
            writer.WriteLine($"-- Create table {table.Key}");
            writer.WriteLine($"CREATE TABLE \"{table.Key}\" (");


            foreach (var column in table)
            {
                var line = $"  \"{column.ColumnName}\" {column.DataType}";
                if (column != table.Last())
                    line += ",";
                writer.WriteLine(line);
            }

            writer.WriteLine(");");
        }
    }

    public static void InsertData(TableData exportData)
        {
            if (exportData.Data == null) return;
            
            var fileName = $"ProjectName_Insert_{exportData.TableName}.sql";
            
            // Write SQL script to file
            using var writer = new StreamWriter(fileName);
            
            writer.WriteLine($"-- Insert data into table {exportData.TableName}");
            foreach (var row in exportData.Data)
            {
                var columns = "";
                var data = "";

                foreach (var column in row)
                {
                    columns += column.Key + ", ";
                    data += column.Value + ", ";
                }

                writer.WriteLine($"INSERT INTO {exportData.TableName} ({columns}) VALUES ({data});");
            }
        }
}




















