
using System;

namespace PatternMatching
{
    public class TollCalculator
    {
        public decimal CalculateToll(object vehicle) =>
            vehicle switch
            {
                Car c => c.Passengers switch
                {
                    0 => 2.00m + 0.5m,
                    1 => 2.0m,
                    2 => 2.0m - 0.5m,
                    _ => 2.00m - 1.0m
                },

                Taxi t => t.Fares switch
                {
                    0 => 3.50m + 1.00m,
                    1 => 3.50m,
                    2 => 3.50m - 0.50m,
                    _ => 3.50m - 1.00m
                },

                Bus b when ((double)b.Riders / (double)b.Capacity) < 0.50 => 5.00m + 2.00m,
                Bus b when ((double)b.Riders / (double)b.Capacity) > 0.90 => 5.00m - 1.00m,
                Bus b => 5.00m,

                DeliveryTruck t => t.GrossWeightClass switch
                {
                    < 3000 => 10.00m - 2.00m,
                    >= 3000 and <= 5000 => 10.00m,
                    > 5000 => 10.00m + 5.00m,
                },

                not null => throw new ArgumentException($"Not a known vehicle type: {vehicle}", nameof(vehicle)),
                null => throw new ArgumentNullException(nameof(vehicle))
            };
    }
}