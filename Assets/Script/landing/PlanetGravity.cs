using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class PlanetGravity : MonoBehaviour
{
    //The gravity of the planet
    public float gravity = 10;
    private float GM = 10000f;
    private Transform m_transform;
    private float v0;
    private Vector3 move;
    private string sceneName;

    void Awake()
    {
        m_transform = transform;
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }

    public void addOBJ(Transform targetObject) {
        if (sceneName == "LandingMoon")
        {
            float r = Vector3.Distance(targetObject.position, transform.position);
            v0 = Mathf.Sqrt(GM / r);
            Debug.Log(v0);
            Debug.Log(r);
            move = new Vector3(v0, 0, 0) * 1.35f;
            targetObject.GetComponent<Rigidbody>().AddForce(move, ForceMode.VelocityChange);
        }
    }

    public void AddGravity(Transform targetObject)
    {
        float distance = Vector3.Distance(targetObject.position, transform.position);
        //The gravity direction of the planet
        Vector3 gravityDirection = (targetObject.position - m_transform.position).normalized;
        
        
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
       
        if (sceneName == "Rocket1")
        {
            distance += 640;
        }
        gravity = GM / (distance * distance);

        //targetObject.GetComponent<Rigidbody>().AddForce(move * Time.deltaTime, ForceMode.VelocityChange);
        //move.x -= gravity * gravityDirection.x;
        //targetObject.GetComponent<Rigidbody>().AddForce(move * Time.deltaTime, ForceMode.Impulse);
        /* Debug.Log("move");
         Debug.Log(move);
         Debug.Log("gravityDirection");
         Debug.Log(gravityDirection);*/

        //Add the gravity to the target object
        targetObject.GetComponent<Rigidbody>().AddForce(-gravity * gravityDirection);
        //targetObject.GetComponent<Rigidbody>().AddForce(targetObject.transform.up * v0);
        //y -= gravity * gravityDirection;

    }
}