using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using Warehouse.Common;
using System.IO;
using System.IO.Ports;

namespace Warehouse.Win
{
	public class AlarmHelper
	{
		private static SoundPlayer soundPlayer;
		private static SerialPort serialPort;

		public static void StartAlarm()
		{
			try {
				serialPort = new SerialPort(ConfigHelper.SerialPortName);
				serialPort.BaudRate = 9600;
				serialPort.DataBits = 8;
				serialPort.StopBits = StopBits.One;
                serialPort.Parity = Parity.None;
				serialPort.Open();
                serialPort.WriteLine("@01FF\r");            
             
			} catch (Exception) {
			}


			//if (soundPlayer == null) {
			//    var alarmFile = Path.Combine(SystemInfo.SystemBaseDir, ConfigHelper.AlarmFileName);
			//    soundPlayer = new SoundPlayer(alarmFile);
			//}

			//soundPlayer.PlayLooping();
		}

		public static void StopAlarm()
		{
			try {
                serialPort.WriteLine("@0100\r");
                serialPort.Close();
			} catch (Exception) {
			}

			//if (soundPlayer != null) {
			//    soundPlayer.Stop();
			//}
		}

		private static string Get16Str(string str)
		{
			var bytes = Encoding.Unicode.GetBytes(str);
            var resultStr = Convert.ToBase64String(bytes);
			return resultStr;
		}
	}
    


}
