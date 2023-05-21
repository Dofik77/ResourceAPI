using System;
using System.Collections.Generic;
using System.Text;

namespace EnergoStatApi.Domain.Entity
{
    public class RateGraphModel
    {
        public RateGraphModel(int AxisX, double AxisY)
        {
            this.AxisX = AxisX;
            this.AxisY = AxisY;
        }

        public int AxisX { get; set; }

        public double AxisY { get; set; }
    }
}
