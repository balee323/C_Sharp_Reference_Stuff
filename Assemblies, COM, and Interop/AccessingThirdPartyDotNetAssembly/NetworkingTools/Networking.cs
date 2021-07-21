namespace NetworkingTools
{
    public static class Networking
    {

        static string GetPhysicalAddress(string ipAddress)
        {
            string phyiscalAddress = string.Empty;

            switch (ipAddress)
            {
                case "40.167.112.90":
                    phyiscalAddress = "GamingPC";
                    break;
                case "192.168.1.1":
                    phyiscalAddress = "Router1";
                    break;
                default:
                    phyiscalAddress = "Unknown";
                    break;
            }

            return phyiscalAddress;
        }
    }
}
