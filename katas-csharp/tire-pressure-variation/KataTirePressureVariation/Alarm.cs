using System;

namespace KataTirePressureVariation
{
	public class Alarm
	{
		private const double LowPressureThreshold = 17;
		private const double HighPressureThreshold = 21;
		
		private readonly Sensor sensor = new Sensor();
		
		private bool alarmOn = false;
		
		public void Check() {
			double psiPressureValue = sensor.PopNextPressurePsiValue();

			if (psiPressureValue < LowPressureThreshold || HighPressureThreshold < psiPressureValue) {
				if(!IsAlarmOn()) {
					alarmOn = true;
					Console.WriteLine("Alarm activated!");
				}
			} else {
				if(IsAlarmOn()) {
					alarmOn = false;
					Console.WriteLine("Alarm deactivated!");
				}
			}
		}
		
		private bool IsAlarmOn() {
			return alarmOn;
		}
		
	}
}