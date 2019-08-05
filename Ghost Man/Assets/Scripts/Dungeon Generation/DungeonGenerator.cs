using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class will be used to generate new floors of the dungeon, randomly populating the floor with rooms, hallways, and more
/// </summary>
public class DungeonGenerator : MonoBehaviour
{
    public Sprite wallprefab;
    public Sprite floorprefab;

    public List<Area> areas;
    [HideInInspector]
    public Sprite[] tiles;

    [Header("Generation Variables")]
    public int mapSize;
    [Space(10)]
    public int minRoomsCount;
    public int maxRoomsCount;
    [Space(10)]
    public int minRoomsSize;
    public int maxRoomsSize;
    [Space(10)]
    public int minHallwayLength;
    public int maxHallwayLength;


    void Start()
    {
        
    }

    // Ideally will not need to update
    void Update()
    {
        
    }
    
    /// <summary>
    /// Called once for each floor, past that, the interactions with the floor should be self automating
    /// </summary>
    /// <param name="size">size to be used for dungeon width and height</param>
    public void GenerateNewDungeon(int size)
    {
        tiles = new Sprite[size * size];
    }

    void AddRoom(int xPos, int yPos, int width, int height)
    {

    }

    void AddHallway(int xStart, int yStary, int length)
    {

    }
}
