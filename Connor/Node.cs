/*
 * Each node contains its x and y coordinates and a "marker" field which
 * marks a way-point along a path (if set)
 */
namespace Euler.Connor
{
    public class Node
    {
        private int xId, yId;
        private bool marker;


        public Node(int xId, int yId)
        {
            //super();
            this.xId = xId;
            this.yId = yId;
            marker = false;
        }


        public int getxId()
        {
            return xId;
        }


        public int getyId()
        {
            return yId;
        }



        public bool isMarker()
        {
            return marker;
        }




        public void setMarker(bool hasMarker)
        {
            this.marker = hasMarker;
        }



        public override int GetHashCode()
        {
            int prime = 31;
            int result = 1;
            result = prime * result + (marker ? 1231 : 1237);
            result = prime * result + xId;
            result = prime * result + yId;
            return result;
        }


        public static bool operator ==(Node x, Node y)
        {
            if (ReferenceEquals(x, y)) return true;
            if ((object)x == null || (object)y == null) return false;
            return (x.xId == y.xId) && (x.yId == y.yId) && (x.marker == y.marker);
        }

        public static bool operator !=(Node x, Node y)
        {
            return !(x == y);
        }

        public override bool Equals(object obj)
        {
            var y = obj as Node;
            if (y == null) return false;
            return (xId == y.xId) && (yId == y.yId) && (marker == y.marker);
        }


        public override string ToString()
        {
            return "Node [xId=" + xId + ", yId=" + yId + "]";
        }

    }
}