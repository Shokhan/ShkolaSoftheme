using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeHW
{
    class ShapeDescriptor
    {
        private enum Shapes { Point = 1, Line, Triangle, Square };
        private List<Point> points = new List<Point>();
 
        public string ShapeType
        {
            get
            {
                string s = string.Empty;
                switch((Shapes)points.Count)
                {
                    case Shapes.Point:
                        s = "Point";
                        break;
                    case Shapes.Triangle:
                        s = "Triangle";
                        break;
                    case Shapes.Line:
                        s = "Line";
                        break;
                    case Shapes.Square:
                        s = "Square";
                        break;
                    default:
                        s = "Unknown";
                        break;
                }

                return s;
            }
        }

        public ShapeDescriptor(Point p)
        {
            points.Add(p);
        }
        public ShapeDescriptor(Point p1, Point p2)
        {
            points.Add(p1);
            points.Add(p2);
        }

        public ShapeDescriptor(Point p1, Point p2, Point p3)
        {
            points.Add(p1);
            points.Add(p2);
            points.Add(p3);
        }

        public ShapeDescriptor(Point p1, Point p2, Point p3, Point p4)
        {
            points.Add(p1);
            points.Add(p2);
            points.Add(p3);
            points.Add(p4);
        }
    }
}
