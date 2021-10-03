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
    public GameObject[] fires;
    public Rigidbody Rocket;
    public float Thrust;
    float Times = 0.0f;
    public string Scene;
    public GameObject ms;
    Vector3 targetPosition = new Vector3(-18.1f, 32.8f, -200.7f);
    Vector3 currentVelocity = Vector3.zero;
    float maxSpeed = 40f;
    float smoothTime = 3f;
    private bool clicked = false;
    private float height;

    
    public void cameraTO()
    {
        ms.GetComponent<UsageCase>().enabled = false;

        foreach (GameObject fire in fires)
        {
            fire.SetActive(true);
        }
        fires[3].SetActive(false);
        canvas.SetActive(false);
        Launchcanvas.SetActive(true);
        clicked = true;
        Times = 0f;
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
            Times += Time.deltaTime;
            Thrust *= 1.001f;
            mainCamera.position = Vector3.SmoothDamp(mainCamera.position, targetPosition, ref currentVelocity, smoothTime, maxSpeed);
            if(Times >= 3f)
            {
                Rocket.AddForce(Rocket.transform.forward * -Thrust);
                mainCamera.GetComponent<CameraFollow>().enabled = true;
                Rocket.constraints = RigidbodyConstraints.None;
                Rocket.freezeRotation = true;
                height = transform.position.y;
                if (height > 4500)
                {
                    SceneManager.LoadScene(Scene);
                }
            }
        }
    }
}
