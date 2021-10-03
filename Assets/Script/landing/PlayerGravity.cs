using UnityEngine;
using System.Collections;

public class PlayerGravity : MonoBehaviour
{
    public PlanetGravity planetGravity;
    
    private Transform m_transform;
    public static bool effect = false;

    void Awake()
    {
        m_transform = transform;
    }

    void Start()
    {
        //planetGravity.addOBJ(m_transform);
    }

    public void startgravity()
    {
        planetGravity.addOBJ(m_transform);
    }

    void Update()
    {
        if(effect)
            planetGravity.AddGravity(m_transform);
    }
}