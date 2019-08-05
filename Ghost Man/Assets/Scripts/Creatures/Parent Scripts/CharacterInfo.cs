using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInfo : MonoBehaviour
{
    // Variables

    // Primary and secondary abilities which will be set in child classes
    protected delegate void Ability1(Vector3 point);
    protected delegate void Ability2(Vector3 point);


    // Public properties that could be effected by attacks or status effects
    public Vector3 MaxSpeed
    {
        get;set;
    }
    public Vector3 Acceleration
    {
        get;set;
    }
    public Vector3 Deceleration
    {
        get;set;
    }
    public float MaxHealth
    {
        get;set;
    }
    public float Health
    {
        get;set;
    }
    public bool Possessable
    {
        get
        {
            return (Health / MaxHealth < .05f);
        }
    }
    public bool Floating
    {
        get;set;
    }



    // Default Methods
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    // Non-Default Methods
    public void TakeDamage(float damage)
    {
        Health -= damage;
    }
}
