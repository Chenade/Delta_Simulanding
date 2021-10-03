using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeDescription : MonoBehaviour
{
    public GameObject desCanvas;
    public GameObject mainCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            desCanvas.SetActive(false);
            mainCanvas.SetActive(true);

        }
    }
}
