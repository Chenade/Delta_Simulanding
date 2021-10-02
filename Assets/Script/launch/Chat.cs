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

    //Ray main_ray;
    //RaycastHit hit;
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(character.transform.position, character.transform.up * -1, out hit, 150f))
        {
            //Debug.Log(hit.collider.gameObject.tag);
            if (hit.collider.gameObject.tag == "Rocket1")
            {
                if (rocket1_Text.activeInHierarchy)
                    pressTip.SetActive(true);

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (!rocket1_Text.activeInHierarchy)
                    {
                        rocket1_Text.SetActive(true);
                        pressTip.SetActive(false);
                    }
                    else
                    {
                        rocket1_Text.SetActive(false);
                        pressTip.SetActive(true);
                    }
                }
            }
            else if (hit.collider.gameObject.tag == "Rocket2")
            {
                if (rocket2_Text.activeInHierarchy)
                    pressTip.SetActive(true);
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (!rocket2_Text.activeInHierarchy)
                    {
                        rocket2_Text.SetActive(true);
                        pressTip.SetActive(false);
                    }
                    else
                    {
                        rocket2_Text.SetActive(false);
                        pressTip.SetActive(true);
                    }
                }
            }
            else if (hit.collider.gameObject.tag == "Rocket3")
            {
                if (rocket3_Text.activeInHierarchy)
                    pressTip.SetActive(true);
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (!rocket3_Text.activeInHierarchy)
                    {
                        rocket3_Text.SetActive(true);
                        pressTip.SetActive(false);
                    }
                    else
                    {
                        rocket3_Text.SetActive(false);
                        pressTip.SetActive(true);
                    }
                }
            }
            else if (hit.collider.gameObject.tag == "Rocket4")
            {
                if (rocket4_Text.activeInHierarchy)
                    pressTip.SetActive(true);
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (!rocket4_Text.activeInHierarchy)
                    {
                        rocket4_Text.SetActive(true);
                        pressTip.SetActive(false);
                    }
                    else
                    {
                        rocket4_Text.SetActive(false);
                        pressTip.SetActive(true);
                    }
                }
            }
            else if (hit.collider.gameObject.tag == "Rocket5")
            {
                if (rocket5_Text.activeInHierarchy)
                    pressTip.SetActive(true);
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (!rocket5_Text.activeInHierarchy)
                    {
                        rocket5_Text.SetActive(true);
                        pressTip.SetActive(false);
                    }
                    else
                    {
                        rocket5_Text.SetActive(false);
                        pressTip.SetActive(true);
                    }
                }
            }
            else if (hit.collider.gameObject.tag == "Rocket6")
            {
                if (rocket6_Text.activeInHierarchy)
                    pressTip.SetActive(true);
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (!rocket6_Text.activeInHierarchy)
                    {
                        rocket6_Text.SetActive(true);
                        pressTip.SetActive(false);
                    }
                    else
                    {
                        rocket6_Text.SetActive(false);
                        pressTip.SetActive(true);
                    }
                }
            }
            else if (hit.collider.gameObject.tag == "Rocket7")
            {
                if (rocket7_Text.activeInHierarchy)
                    pressTip.SetActive(true);
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (!rocket7_Text.activeInHierarchy)
                    {
                        rocket7_Text.SetActive(true);
                        pressTip.SetActive(false);
                    }
                    else
                    {
                        rocket7_Text.SetActive(false);
                        pressTip.SetActive(true);
                    }
                }
            }
            else if (hit.collider.gameObject.tag == "Rocket8")
            {
                if (rocket8_Text.activeInHierarchy)
                    pressTip.SetActive(true);
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (!rocket8_Text.activeInHierarchy)
                    {
                        rocket8_Text.SetActive(true);
                        pressTip.SetActive(false);
                    }
                    else
                    {
                        rocket8_Text.SetActive(false);
                        pressTip.SetActive(true);
                    }
                }
            }
            else
                pressTip.SetActive(false);
         }
         else
                pressTip.SetActive(false);
        }
    }


