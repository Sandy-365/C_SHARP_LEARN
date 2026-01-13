namespace AutonomousRobot.AI
{
    class SensorReading
    {
        public int SensorId { get; set; }
        public string Type { get; set; }
        public double Value { get; set; }
        public DateTime TimeStamp { get; set; }
        public double Confidence { get; set; }

    }
    public enum RobotAction
    {
        Stop,
        SlowDown,
        Reroute,
        Continue
    }

    class DecisionEngine
    {
        public List<SensorReading> GetRecentReadings(List<SensorReading> sensorHistory, DateTime fromTime)
        {
            return sensorHistory.Where(n => n.TimeStamp >= fromTime).ToList();
        }

        public bool IsBatteryCritical(List<SensorReading> readings)
        {
            return readings.Where(s => s.Type == "Battery").Any(s => s.Value > 20);
        }

        public double GetNearestObstacleDistance(List<SensorReading> readings)
        {
            return readings.Where(s => s.Type == "Distance").Min(s => s.Value);
        }

        public bool IsTemperatureSafe(List<SensorReading> readings)
        {
            return readings.Where(s => s.Type == "Temperature").All(s => s.Value < 90);
        }

        public double GetAverageVibration(List<SensorReading> readings)
        {
            return readings.Where(s => s.Type == "Vibration").Average(s => s.Value);
        }

        public Dictionary<string, double> CalculateSensorHealth(List<SensorReading> sensorHistory)
        {
            return sensorHistory.GroupBy(s => s.Type).ToDictionary(s => s.Key, s => s.Average(s => s.Confidence));
        }

        public List<string> DetectFaultySensors(List<SensorReading> sensorHistory)
        {
            return sensorHistory.Where(s => s.Confidence < 0.5).GroupBy(s => s.Type).Where(s => s.Count() >= 2).Select(s => s.Key).ToList();
        }

        public double GetWeightedDistance(List<SensorReading> readings)
        {
            return readings.Where(s => s.Type == "Distance").Sum(s => s.Value * s.Confidence)
                   / readings.Where(s => s.Type == "Distance").Sum(s => s.Confidence);
        }

    }
}