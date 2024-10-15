using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public class DashboardDataFetcher
{
    private readonly Dbcon db;

    public DashboardDataFetcher(Dbcon dbConnection)
    {
        db = dbConnection;
    }

    public async Task<DashboardData> FetchDashboardDataAsync()
    {
        DashboardData data = new DashboardData();

        try
        {
            await db.Connect();

            data.TotalVehicleCount = await GetCountAsync("SELECT COUNT(*) FROM vehicles");
            data.IncidentVehicleCount = await GetCountAsync("SELECT COUNT(DISTINCT VehicleID) FROM incidentreports");
            data.AssignedVehiclesCount = await GetCountAsync("SELECT COUNT(DISTINCT VehicleID) FROM vehicleassignments WHERE ReturnDate IS NULL");
            data.UnassignedVehiclesCount = data.TotalVehicleCount - data.AssignedVehiclesCount;
            data.MaintenanceAvailableVehiclesCount = await GetCountAsync("SELECT COUNT(*) FROM vehicles v LEFT JOIN vehicleassignments va ON v.VehicleID = va.VehicleID WHERE va.VehicleID IS NULL OR va.ReturnDate IS NOT NULL");

            data.TotalDriverCount = await GetCountAsync("SELECT COUNT(*) FROM drivers");
            data.ActiveDriverCount = await GetCountAsync("SELECT COUNT(*) FROM drivers WHERE Status = 'Active'");
            data.InactiveDriverCount = data.TotalDriverCount - data.ActiveDriverCount;
            data.AssignedDriverCount = await GetCountAsync("SELECT COUNT(DISTINCT DriverID) FROM vehicleassignments WHERE ReturnDate IS NULL");
            
            data.YearlyIncidentCount = await GetCountAsync("SELECT COUNT(*) FROM incidentreports WHERE YEAR(IncidentDate) = YEAR(CURDATE())");
            data.MonthlyIncidentCount = await GetCountAsync("SELECT COUNT(*) FROM incidentreports WHERE YEAR(IncidentDate) = YEAR(CURDATE()) AND MONTH(IncidentDate) = MONTH(CURDATE())");
            data.DailyIncidentCount = await GetCountAsync("SELECT COUNT(*) FROM incidentreports WHERE DATE(IncidentDate) = CURDATE()");
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("MySQL Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
        finally
        {
            db.Disconnect();
        }

        return data;
    }

    private async Task<int> GetCountAsync(string query)
    {
        using (MySqlDataReader reader = await db.ExecuteQuery(query))
        {
            if (await reader.ReadAsync())
            {
                return reader.GetInt32(0);
            }
        }
        return 0;
    }
}

public class DashboardData
{
    public int TotalVehicleCount { get; set; }
    public int IncidentVehicleCount { get; set; }
    public int AssignedVehiclesCount { get; set; }
    public int UnassignedVehiclesCount { get; set; }
    public int MaintenanceAvailableVehiclesCount { get; set; }
    public int TotalDriverCount { get; set; }
    public int ActiveDriverCount { get; set; }
    public int InactiveDriverCount { get; set; }
    public int AssignedDriverCount { get; set; }
    public int YearlyIncidentCount { get; set; }
    public int MonthlyIncidentCount { get; set; }
    public int DailyIncidentCount { get; set; }
    
}