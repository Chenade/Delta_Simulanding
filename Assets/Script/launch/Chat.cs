using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chat : MonoBehaviour
{
    public GameObject character;
    public GameObject rocket1_Text;
    public GameObject rocket2_Text;
    public GameObject rocket3_Text;
    public GameObject rocket4_Text;
    public GameObject rocket5_Text;
    public GameObject rocket6_Text;
    public GameObject rocket7_Text;
    public GameObject rocket8_Text;
    public GameObject pressTip;
    private GameObject canvas;
    private string target;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(target);
            if (target != null)
            {
                if (target == "Rocket1") canvas = rocket1_Text;
                if (target == "Rocket2") canvas = rocket2_Text;
                if (target == "Rocket3") canvas = rocket3_Text;
                if (target == "Rocket4") canvas = rocket4_Text;
                if (target == "Rocket5") canvas = rocket5_Text;
                if (target == "Rocket6") canvas = rocket6_Text;
                if (target == "Rocket7") canvas = rocket7_Text;
                if (target == "Rocket8") canvas = rocket8_Text;
                if(canvas) canvas.SetActive(!canvas.activeInHierarchy);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        pressTip.SetActive(true);
        target = (other.transform.tag);
        //Debug.Log(target);
    }

    private void OnTriggerExit(Collider other)
    {
        pressTip.SetActive(false);
        target = null;
        //Debug.Log(target);
    }
}


