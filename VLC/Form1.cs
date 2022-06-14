using DirectShowLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //Get capture devices
            var devices = new List<DsDevice>(DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice));
            var cameraNames = new List<string>();
            foreach (var device in devices)
            {
                cameraNames.Add(device.Name);
            }

            //Use the same VLC options
            var mediaOptions = new[]
                 {
                    ":dshow-vdev=HD User Facing",
                    ":dshow-adev=Microphone Array (Realtek(R) Audio)",
                    ":live-caching=500",
                    ":sout-keep"
                };

            VLCPlayer.SetMedia("dshow://", mediaOptions);

            VLCPlayer.Play();

            Console.WriteLine("Streaming on rtsp://127.0.0.1:554/");
            Console.WriteLine("Press any key to exit");

            //VLCPlayer.Play(new Uri("http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ElephantsDream.mp4"));
        }
    }
}
