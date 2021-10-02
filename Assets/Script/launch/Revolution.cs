using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Revolution : MonoBehaviour
{

    public Transform oringin;
    public float spead;
    public float rAngle;
    float m_rAngle;
    double radians;
    float y;
    
    // Start is called before the first frame update
    void Start()
    {
        m_rAngle = 90 - rAngle;
        radians = m_rAngle * Math.PI / 180;
        y = (float)Math.Tan(radians) * 1;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Axis = new Vector3(0, y, 1);
        this.transform.RotateAround(oringin.position, Axis, spead * Time.deltaTime);
    }
}
