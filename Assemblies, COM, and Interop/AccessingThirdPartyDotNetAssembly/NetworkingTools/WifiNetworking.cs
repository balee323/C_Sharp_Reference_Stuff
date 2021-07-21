namespace NetworkingTools
{
    public class WifiNetworking
    {

        private readonly string _ipAddress;

        public WifiNetworking(string ipAddress)
        {
            _ipAddress = ipAddress;
        }


        public string GetPhysicalAddress()
        {
            string phyiscalAddress = string.Empty;

            switch (_ipAddress)
            {
                case "40.167.112.90":
                    phyiscalAddress = "GamingPC";
                    break;
                case "192.168.1.1":
                    phyiscalAddress = "Router1";
                    break;
                default:
                    phyiscalAddress = "Unknown :)";
                    break;
            }

            return phyiscalAddress;
        }
    }
}
