using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
                if (target == "Falcon_Heavy") canvas = rocket1_Text;
                if (target == "Delta_IV") canvas = rocket2_Text;
                if (target == "Saturn_V") canvas = rocket3_Text;
                if (target == "SLS Block 1B Cargo") canvas = rocket4_Text;
                if (target == "SLS Block 1B Crew") canvas = rocket5_Text;
                if (target == "SLS Block 2 Cargo") canvas = rocket6_Text;
                if (target == "SLS Block1") canvas = rocket7_Text;
                if (target == "Star_ship") canvas = rocket8_Text;
                if(canvas) canvas.SetActive(!canvas.activeInHierarchy);
            }
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log(target);
            if (target != null)
            {
                SceneManager.LoadScene(target);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        pressTip.SetActive(true);
        target = (other.transform.name);
        //Debug.Log(target);
    }

    private void OnTriggerExit(Collider other)
    {
        pressTip.SetActive(false);
        target = null;
        //Debug.Log(target);
    }
}


