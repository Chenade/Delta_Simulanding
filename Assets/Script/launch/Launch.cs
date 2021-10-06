using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using RemptyTool.ES_MessageSystem;

public class Launch : MonoBehaviour
{

    public Transform mainCamera;
    public GameObject canvas;
    public GameObject Launchcanvas;
    public Rigidbody Rocket;
    public float Thrust;
    float Times = 0.0f;
    public static string Scene = "ToMoon";
    public GameObject ms;
    Vector3 targetPosition = new Vector3(-18.1f, 32.8f, -200.7f);
    Vector3 currentVelocity = Vector3.zero;
    float maxSpeed = 40f;
    float smoothTime = 3f;
    private bool clicked = false;
    private float height;

    
    public void cameraTO()
    {
        dropTank sn = gameObject.GetComponent<dropTank>();
        sn.lightFire();

        ms.GetComponent<UsageCase>().enabled = true;
        canvas.SetActive(false);
        Launchcanvas.SetActive(true);
        clicked = true;
        Debug.Log(clicked);
        Times = 0f;
    }

    private void Start()
    {
        Rocket = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(clicked);
        if (clicked)
        {
            Thrust *= 1.001f;
            mainCamera.position = Vector3.SmoothDamp(mainCamera.position, targetPosition, ref currentVelocity, smoothTime, maxSpeed);
            if(Thrust >= 15f)
            {
                Rocket.AddForce(Rocket.transform.up * Thrust);
                mainCamera.GetComponent<CameraFollow>().enabled = true;
                Rocket.constraints = RigidbodyConstraints.None;
                Rocket.freezeRotation = true;
                height = transform.position.y;
                if (height > 5200)
                {
                    SceneManager.LoadScene(Scene);
                }
            }
        }
    }
}
