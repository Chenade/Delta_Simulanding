using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;
    public Vector3 rotation;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(rotation.x, rotation.y, rotation.z);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position);
        transform.position = new Vector3(player.position.x+offset.x, player.position.y+ offset.y, player.position.z+offset.z);
        

    }
}
