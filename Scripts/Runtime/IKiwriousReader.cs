using Assets.Kiwrious.Scripts;
using System.Collections.Generic;
using static Assets.Kiwrious.Scripts.Constants;

namespace kiwrious {
	public interface IKiwriousReader
	{

		byte[] GetRawData();

		SensorData GetConductivity();


		SensorData GetVOC();


		SensorData GetUVLux();


		SensorData GetHumidityTemperature();


		SensorData GetColor();


		SensorData GetHeartRate();


		SensorData GetBodyTemperature();


		SensorData GetBodyTemperature2();

	}
}
