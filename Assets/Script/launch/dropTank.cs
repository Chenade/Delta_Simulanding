using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropTank : MonoBehaviour
{
    public GameObject tk1;
    public GameObject tk2;
    public GameObject tk3;
    public GameObject tk4;
    public GameObject tk5;
    public string rocket;
    private float height;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        height = transform.position.y;
        if(rocket == "Falcon_Heavy")
        {
            if (height > 2000 && tk1)
            {
                Rigidbody rb1 = tk1.AddComponent<Rigidbody>();
                rb1.AddForce(tk1.transform.forward * -100f);
                rb1.AddForce(Physics.gravity, ForceMode.Acceleration);
                tk1 = null;
            }

            if (height > 2000 && tk2)
            {
                Rigidbody rb2 = tk2.AddComponent<Rigidbody>();
                rb2.AddForce(tk2.transform.forward * 100f);
                rb2.AddForce(Physics.gravity, ForceMode.Acceleration);
                tk2 = null;
            }

            if (height > 4000 && tk3)
            {
                Rigidbody rb3 = tk3.AddComponent<Rigidbody>();
                rb3.AddForce(Physics.gravity, ForceMode.Acceleration);
                tk3 = null;
            }
        }
        
    }
}
