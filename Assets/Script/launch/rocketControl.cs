using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketControl : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject earth;
    
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(transform.forward * 2f, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {

         
    }
}
