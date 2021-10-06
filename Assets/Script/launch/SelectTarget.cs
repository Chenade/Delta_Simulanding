using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SelectTarget : MonoBehaviour
{
    public Text target;
    public Text fuel;
    public Slider slider;
    public GameObject rangeMoon;
    public GameObject rangeMars;
    public GameObject lunchGO;
    public Text tips;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(slider.value.ToString());
            float val = slider.value;
            bool valid = false;
            Debug.Log(val.ToString());
            if (Launch.Scene == "ToMoon" && val > 3335 && val < 4604)   valid = true;
            if (Launch.Scene == "Mars" && val > 7620 && val < 8737)   valid = true;


            if (valid)
            {
                Launch sn = lunchGO.GetComponent<Launch>();
                sn.cameraTO();
            }
            else
                tips.text = ("Fuel Setup Fail !!!!!!!!!!!");
        }
    }

    public void SelectMars()
    {
        target.text = "Mars";
        rangeMars.SetActive(true);
        rangeMoon.SetActive(false);
        Launch.Scene = "Mars";
    }

    public void SelectMoon()
    {
        target.text = "Moon";
        rangeMoon.SetActive(true);
        rangeMars.SetActive(false);
        Launch.Scene = "ToMoon";
    }
}
