using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumnsNumberByCoordinates
{
    class GetCoordinates
    {
        private readonly double XCoord;
        private readonly double YCoord;
        private readonly double ZCoord;

        public GetCoordinates(FamilyInstance fi)
        {
            FamilyInstance Col = fi;
            LocationPoint colLocPoint = (LocationPoint)Col.Location;

            XCoord = colLocPoint.Point.X;
            YCoord = colLocPoint.Point.Y;
            ZCoord = colLocPoint.Point.Z;
        }

        public double X
        { get { return XCoord; } }

        public double Y
        { get { return YCoord; } }

        public double Z
        { get { return ZCoord; } }
    }
}

