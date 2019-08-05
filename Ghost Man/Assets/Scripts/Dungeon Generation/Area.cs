using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AreaType { spawn, room, hallway };

public class Area : MonoBehaviour
{
    public Sprite[][] tiles;

    public AreaType areaType;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /// <summary>
    /// This will be tied to a trigger collider on the area that 
    /// will activate whatever should happen when the player enters that room
    /// such as: 
    ///  - assign enemy navmesh targets
    ///  - spawn a boss
    /// </summary>
    /// <param name="collision"></param>
    public void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
