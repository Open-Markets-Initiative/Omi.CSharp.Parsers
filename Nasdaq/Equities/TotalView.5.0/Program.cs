using SharpPcap;
using PacketDotNet;

namespace Nasdaq.TotalView
{
    class Program
    {
        public unsafe static void Main(string[] args) {
            string pcap = @"";
            
            var device = new SharpPcap.LibPcap.CaptureFileReaderDevice(pcap);
            device.Open();

            while (device.GetNextPacket(out var packet) == GetPacketStatus.PacketRead) 
            {
                Process(packet);
            }

            device.Close();
        }

        /// <summary>
        ///  Process 
        /// </summary>
        public unsafe static void Process(PacketCapture capture)
        {
            var current = capture.GetPacket();

            fixed (byte* buffer = &current.Data[0]) 
            {
                var packet = *(PacketHeader *)(buffer + 46);
                var session = packet.Session;
                var count = packet.Sequence;
            }
        }
    }
}
