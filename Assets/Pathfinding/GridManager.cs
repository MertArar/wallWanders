using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] Vector2Int gridSize; 
    Dictionary<Vector2Int, Node> grid = new Dictionary<Vector2Int, Node>();
    
    void Awake()
    {
        CreateGrid();
    }
    
    void CreateGrid()
    {
        for(int x = 0; x < gridSize.x; x++)
        {
            for(int y=0; y < gridSize.y; y++)
            {
                Vector2Int coordinates = new Vector2Int(x,y);
                grid.Add(coordinates, new Node(coordinates, true));
                Debug.Log(grid[coordinates].coordinates + " = " + grid[coordinates].isWalkable);
            }
        }
    }
}
