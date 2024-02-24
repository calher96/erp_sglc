using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Security.Principal;
using Newtonsoft.Json.Linq;

namespace CEN.Helpers
{
    public class BasicVariable
    {
        public static readonly String cadena_conexion  = "Data Source=localhost,1433;Initial Catalog=ERP_SGLC;User ID=sa;Password=carlos561996;";
        public static readonly String nombre_sistema = "ERP_SGLC";



        public static readonly String webapi = "http://localhost/";
        //public static readonly String webapi = "http://192.168.101.14:5093/";
        //public static readonly String webapi = "http://192.168.101.7:5093/";
        public static readonly String HostName = Dns.GetHostName();
        public static readonly String HostUser = WindowsIdentity.GetCurrent().Name;
        public static readonly String Ip = GetLocalNetworkIPAddress();
        public static readonly String Mac = GetMacAddress();
        public static String GetMacAddress()
        {
            string macAddress = string.Empty;
            try
            {
                NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface netInterface in networkInterfaces)
                {
                    if (netInterface.OperationalStatus == OperationalStatus.Up)
                    {
                        macAddress = netInterface.GetPhysicalAddress().ToString();
                        break; // Si encontramos una dirección MAC, salimos del bucle
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la dirección MAC: " + ex.Message);
            }
            return macAddress;
        }

        public static String GetLocalNetworkIPAddress()
        {
            string localNetworkIp = string.Empty;
            try
            {
                NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface netInterface in networkInterfaces)
                {
                    if (netInterface.NetworkInterfaceType != NetworkInterfaceType.Loopback &&
                        netInterface.OperationalStatus == OperationalStatus.Up)
                    {
                        foreach (UnicastIPAddressInformation ipAddressInfo in netInterface.GetIPProperties().UnicastAddresses)
                        {
                            if (ipAddressInfo.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            {
                                localNetworkIp = ipAddressInfo.Address.ToString();
                                break; // Si encontramos una dirección IPv4, salimos del bucle
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la dirección IP pública: " + ex.Message);
            }
            return localNetworkIp;
        }
    }
}
