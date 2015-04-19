/**
 * Maintains a 2D grid-map of nodes
 * @author dermot.hegarty
 *
 */

namespace Euler.Connor
{
    public class GridMap
    {
        private readonly int GRID_HEIGHT = 10;
        private readonly int GRID_WIDTH = 10;

        Node[][] map;

        public GridMap()
	{
		map = new Node[GRID_HEIGHT][];
		
		for(int i = 0; i < GRID_HEIGHT; i++)
		{
            map[i] = new Node[GRID_WIDTH];
			for (int j = 0; j < GRID_HEIGHT; j++)
			{
				map[i][j] = new Node(i,j);
			}
		}
	}

        public Node getNode(int x, int y)
        {
            return map[x][y];
        }


        public void setNodeMarker(int x, int y)
        {
            map[x][y].setMarker(true);
        }


        /*
         * Check if a node has a marker attached.
         */
        public bool isNodeMarker(int x, int y)
        {
            return map[x][y].isMarker();
        }

        /*
         * This will populate the grid with some way-points indicating markers
         * laid along a path
         */
        public void makeTestMap()
        {

            map[0][0].setMarker(true);
            map[2][3].setMarker(true);
            map[5][3].setMarker(true);
            map[GRID_HEIGHT - 1][GRID_WIDTH - 1].setMarker(true);

        }

        public int getHeight()
        {
            return GRID_HEIGHT;
        }

        public int getWidth()
        {
            return GRID_WIDTH;
        }

        public Node getStartNode()
        {
            return map[0][0];
        }
    }
}