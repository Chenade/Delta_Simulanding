using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class flyinSpace : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float speed;
    public string scene;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

    public void OnCollisionEnter(Collision collision)
    {
        
        SceneManager.LoadScene(scene);
    }
}
