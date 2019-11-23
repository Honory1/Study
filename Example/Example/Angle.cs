using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class Angle
    {
        private double _ax;
        private double _ay;
        private double _bx;
        private double _by;
        private double _cx;
        private double _cy;

        //вычисление координат векторов
        private double _abx => _bx - _ax;
        private double _aby => _by - _ay;
        private double _bcx => _cx - _bx;
        private double _bcy => _cy - _by;

        private double _angle //формула для вычисления угла между векторами
        {
            get => Math.Acos((_abx * _bcx + _aby * _bcy) / Math.Sqrt(_abx * _abx + _aby * _aby) * Math.Sqrt(_bcx * _bcx + _bcy * _bcy));
        }

        public Angle(double Ax, double Ay, double Bx, double By, double Cx, double Cy)
        {
            _ax = Ax;
            _ay = Ay;
            _bx = Bx;
            _by = By;
            _cx = Cx;
            _cy = Cy;
        }

        public static bool operator >(Angle angle1, Angle angle2)
        {
            return angle1._angle > angle2._angle;
        }

        public static bool operator <(Angle angle1, Angle angle2)
        {
            return angle1._angle < angle2._angle;
        }

        public static bool operator ==(Angle angle1, Angle angle2)
        {
            return angle1._angle == angle2._angle;
        }

        public static bool operator !=(Angle angle1, Angle angle2) => throw new Exception("This operation cannot be performed.");

        public static double operator +(Angle angle1, Angle angle2)
        {
            return angle1._angle + angle2._angle;
        }

        public static bool operator -(Angle angle1, Angle angle2) => throw new Exception("This operation cannot be performed.");

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
