namespace AzureComputeWindows.DataAccess
{
    public class Helper
    {

        public static string GetConVal() =>System.Configuration.ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString;
    }
}
