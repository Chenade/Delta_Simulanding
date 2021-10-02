using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ignition : MonoBehaviour
{

    public GameObject rocket;
    public Rigidbody Rocket;
    public float Thrust;
    float Times = 0.0f;
    public string Scene;

    private bool clicked = false;


    public void Ignition()
    {
        Debug.Log("TEST");
        clicked = true;
    }

    private void Start()
    {
        Rocket = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (clicked)
        {
            //Thrust *= 1.01f;
            Rocket.AddForce(Rocket.transform.forward * -Thrust);
            //Rocket.velocity = Vector3.right*100f;
            rocket.GetComponent<Revolution>().enabled = false;
        }
    }
    /*
    private void LateUpdate()
    {
        if (clicked)
        {
            Times += Time.deltaTime;
            Debug.Log(Times);
            if (Times >= 6.0f)
            {
               // SceneManager.LoadScene(Scene);
               
            }
        }
    }*/
}
