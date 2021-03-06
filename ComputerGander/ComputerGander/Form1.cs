using System;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace ComputerGander
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateMAC(object sender, EventArgs e)
        {
            // Find and display the MAC Address of the host machine.
            if (macButton.Text == "Show MAC Address")
            {
                // Get MAC address from Network Interfaces
                var macAddr =
                (
                    from nic in NetworkInterface.GetAllNetworkInterfaces()
                    where nic.OperationalStatus == OperationalStatus.Up
                    select nic.GetPhysicalAddress().ToString()
                ).FirstOrDefault();

                // Update the button and text labels
                macLabel.Text = $"MAC: {macAddr}";
                macButton.Text = "Hide MAC Address";
            }

            // Hide the MAC address
            else
            {
                macLabel.Text = "MAC Address Hidden";
                macButton.Text = "Show MAC Address";
            }

        }

        private void GenerateIP(object sender, EventArgs e)
        {
            // Find and display the IP Address of the host machine.
            if(ipButton.Text == "Show IP Address")
            {
                string hostName = Dns.GetHostName();
                string localIP = Dns.GetHostEntry(hostName).AddressList[0].ToString();
                ipAddressLabel.Text = $"IP: {localIP}";
                ipButton.Text = "Hide IP Address";
            }

            // Hide the IP Address
            else
            {
                ipButton.Text = "Show IP Address";
                ipAddressLabel.Text = "IP address hidden";
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GeneratePing(object sender, EventArgs e)
        {
            try
            {
                // Initialize variables to send pings
                string[] args = { ipTextBox.Text };
                Ping pingSender = new Ping();
                PingOptions options = new PingOptions();

                // Use the default Ttl value which is 128,
                // but change the fragmentation behavior.
                options.DontFragment = true;

                // Create a buffer of 32 bytes of data to be transmitted.
                string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                int timeout = 120;
                PingReply reply = pingSender.Send(args[0], timeout, buffer, options);

                // Update label to show information.
                if (reply.Status == IPStatus.Success)
                {
                    pingDataLabel.Text = $"Address: {reply.Address.ToString()}\n" +
                        $"RoundTrip time: {reply.RoundtripTime}\n" +
                        $"Time to Live: {reply.Options.Ttl}\n" +
                        $"Buffer size: {reply.Buffer.Length}";
                }
            }

            // Catch invalid inputs
            catch (PingException)
            {
                pingDataLabel.Text = "Not a valid IP";
            }
            catch (ArgumentNullException)
            {
                pingDataLabel.Text = "Cannot enter null or empty value";
            }
            catch(Exception)
            {
                pingDataLabel.Text = "Not a valid IP";
            }
        }

        private void primaryTimer_Tick(object sender, EventArgs e)
        {
            // Initialize packet variables
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            IPGlobalStatistics ipstats = properties.GetIPv6GlobalStatistics();

            // Packet counts to find the amount of packets
            // recieved since the last packet polling
            Program.packetCount2 = ipstats.ReceivedPackets;
            packetsListBox.Items.Add(Program.packetCount2 - Program.packetCount1);

            // Update the old packet count to the newer one.
            Program.packetCount1 = Program.packetCount2;
        }
    }
}