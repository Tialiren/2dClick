using UnityEngine;

public class PathNode 
{
    public int X;
    public int Y;

    public bool IsWall;
    public Vector3 Position;


    public PathNode(bool isWall, Vector3 position, int x, int y)
    {
        IsWall = isWall;
        Position = position;
        X = x;
        Y = y;
    }

}

