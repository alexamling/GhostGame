using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class will be used to generate new floors of the dungeon, randomly populating the floor with rooms, hallways, and more
/// </summary>
public class DungeonGenerator : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject wallprefab;
    public GameObject floorprefab;
    [Space(5)]
    public GameObject spawnPrefab;
    public GameObject roomPrefab;
    public GameObject hallwayPrefab;
    public GameObject exitPrefab;
    [Space(10)]

    public List<Area> areas;
    [HideInInspector]
    public GameObject[] tiles;

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
        GenerateNewDungeon(mapSize);
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
        // make the blank map
        tiles = new GameObject[size * size];
        for (int i = 0; i < size * size; i++)
        {
            tiles[i] = Instantiate(wallprefab, transform);
            tiles[i].transform.position = new Vector3(i % size, i / size, 0);
        }

        // generate spawn

        // generate rooms -> hallways

        // generate the exit

    }

    void AddSpawn(int xPos, int yPos, int width, int height)
    {
        
    }

    void AddRoom(int xPos, int yPos, int width, int height)
    {

    }

    void AddHallway(int xStart, int yStary, int length)
    {

    }

    void AddExit(int xPos, int yPos, int width, int height)
    {

    }
}
