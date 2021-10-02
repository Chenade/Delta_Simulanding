using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    public Text dialog_Text;
    public Text slider_Text;
    public Slider slider;
    public GameObject launch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Destroy(dialog_Text);
            slider.gameObject.SetActive(true); 
            slider_Text.gameObject.SetActive(true);
            launch.SetActive(true);
        }
        
        slider_Text.text = slider.value.ToString();
    }
}
