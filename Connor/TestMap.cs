// Conversion output is limited to 2048 chars
// Share Varycode on Facebook and tweet on Twitter
// to double the limits.

/**
 * Here we use a HashMap to store marked nodes and a reference to the 
 * previous marked node we encountered. Thus, we can build a path using this.
 * The convention is that the path is left-to-right and top-to-bottom
 * 
 *     0   1   2   3   4   5
 *   -------------------------
 * 0 | * |   |   |   |   |   |
 *   -------------------------
 * 1 |   |   |   |   |   |   |
 *   -------------------------
 * 2 |   | * |   | * |   |   |
 *   -------------------------
 * 3 |   |   |   |   | * |   |
 *   -------------------------
 * 4 |   |   |   |   |   | * |
 *   -------------------------
 *   
 * In the example above, the "path" would be :
 * (0,0) -> (2,1) -> (2,3) -> (3,4) -> (4,5) 
 * @author dermot.hegarty
 *
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace Euler.Connor
{
    public class TestMap
    {

        public void Main()
        {
            //"key" is a marked node; "value" is the parent node (i.e. the
            //last marked node we encountered)
            IDictionary<Node, Node> path = new Dictionary<Node, Node>();

            GridMap map = new GridMap();
            map.makeTestMap();

            Node lastMarkedNode = map.getStartNode();

            //The first entry has no parent
            path.Add(map.getStartNode(), null);
            Console.Write("(0, 0)");

            //Now populate the path by looking for marked nodes and 
            //associating them with their parent (the previous marked node
            //we encountered)

            //COMPLETE...
            //PSEUDO-CODE
            //Process each Node in the Map (nested loops)
            //If the Node is a marker node (and it's not the start node)
            //Add it to our path (along with parent info)
            //Remember to keep track of parent (using lastMarkedNode)
            for (int i = 0; i < map.getHeight(); i++)
            {
                for (int j = 0; j < map.getWidth(); j++)
                {
                    var currentNode = map.getNode(i, j);
                    if (currentNode.isMarker() && currentNode != map.getStartNode())
                    {
                        path.Add(currentNode, lastMarkedNode);
                        lastMarkedNode = currentNode;
                        Console.Write(" -> ({0}, {1}) ", i,j);
                    }
                }
            }

            //Now we print the path (but it's BACKWARDS). Note that each time
            //the parent node (value) will then be the key for
            //the subsequent invocation
    Node key = lastMarkedNode;

    Console.WriteLine();
    Console.WriteLine("Output from Dictionry");
    Console.WriteLine(key);
    //COMPLETE...
    while (key != null)
    {
        Node value = path[key];
        key = value;
        Console.WriteLine(key); // Write to output
    }
            

            //Now you should instead try to use a Stack data structure (java.util.Stack)
            //to get the path in the right order

            //COMPLETE...
            
    // Reset key
    key = lastMarkedNode;

    Console.WriteLine("Using stack ....");
    Stack<Node> stack = new Stack<Node>();
    stack.Push(key);
    while (key != null)
    {
        //   Node value = path[key];
        stack.Push(path[key]);
        key = path[key];
    }

    while (stack.Count > 0)
    {
        Console.WriteLine(stack.Pop());
    }

            
        }
    }
}