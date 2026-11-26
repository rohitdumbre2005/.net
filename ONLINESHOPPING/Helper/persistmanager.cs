namespace Helpers;
using Entities;
using System.Collections.Generic;
using System.Text.Json;

public class PersistManager
{
    public static List<Order> Load(string filePath)
    {
        List<Order> orders = new List<Order>();
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            orders = JsonSerializer.Deserialize<List<Order>>(json);
        }
        return orders;
    }

    public static bool Dump(string filePath, List<Order> orders)
    {
        Boolean status = false;
        try
        {
            string json = JsonSerializer.Serialize( orders, JsonSerializerOptions.Default);
            File.WriteAllText(filePath, json);
            status = true;
        }
        catch (Exception exp)
        {

        }
        finally
        {

        }
        return status;
    }
}
