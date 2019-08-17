using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PathGrid
{
    private PathNode[,] NodeArray;

    private List<PathNode> finalPath;


    public PathGrid(Tilemap ground, Tilemap obstacles, Vector3 current, Vector3 target)
    {
       
        NodeArray = new PathNode[ground.size.x, ground.size.y];

        bool isWall = false;
        Vector3 position = new Vector3();

        GridLayout groundGrid = ground.GetComponent<GridLayout>();
        GridLayout obstaclesGrid = obstacles.GetComponent<GridLayout>();

        for (int x = 0; x < ground.size.x; x++)
        {
            for (int y = 0; y < ground.size.y; y++)
            {
                isWall = false;
                Vector3Int cell = groundGrid.WorldToCell(new Vector2(x, y));
                Vector3Int obstcl = obstaclesGrid.WorldToCell(new Vector2(cell.x, cell.y));

                TileBase grountTile = ground.GetTile(cell);
                TileBase tile = obstacles.GetTile(obstcl);

                if (tile != null)
                {
                    isWall = true;
                }
                NodeArray[x, y] = new PathNode(isWall, new Vector2(x, y), x, y);

            }
        }



                //    Vector3Int cellPosition = gridLayout.WorldToCell(current);       
                //    Vector3Int cellPosition2 = gridLayout2.WorldToCell(current);

                //    TileBase tile = obstacles.GetTile(cellPosition2);
                //     TileBase _tile = ground.GetTile(cellPosition);

                TilemapCollider2D tpmcollide = ground.GetComponent<TilemapCollider2D>();
        TilemapCollider2D tpmcollide2 = obstacles.GetComponent<TilemapCollider2D>();



        /* Vector3 bottomLeft = transform.position - Vector3.right * vGridWorldSize.x / 2 - Vector3.forward * vGridWorldSize.y / 2;
         //Get the real world position of the bottom left of the grid.

         for (int x = 0; x < iGridSizeX; x++)//Loop through the array of nodes.
         {
             for (int y = 0; y < iGridSizeY; y++)//Loop through the array of nodes
             {
                 Vector3 worldPoint = bottomLeft + Vector3.right * (x * fNodeDiameter + fNodeRadius) + Vector3.forward * (y * fNodeDiameter + fNodeRadius);//Get the world co ordinates of the bottom left of the graph
                 bool Wall = true;//Make the node a wall

                 //If the node is not being obstructed
                 //Quick collision check against the current node and anything in the world at its position. If it is colliding with an object with a WallMask,
                 //The if statement will return false.
                 if (Physics.CheckSphere(worldPoint, fNodeRadius, WallMask))
                 {
                     Wall = false;//Object is not a wall
                 }

                 NodeArray[x, y] = new Node(Wall, worldPoint, x, y);//Create a new node in the array.
             }
         }*/

    }


}

