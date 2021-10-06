using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI dialog_Text;
    public Text slider_Text;
    public Slider slider;
    private float delta = 100;
    public GameObject secCanvas;
    public Text tips;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value == 10000) delta *= -1;
        if (slider.value == 1) delta *= -1;
        slider.value = slider.value + delta;

        //slider.value = value;

        if (Input.GetMouseButtonDown(0))
        {
            Destroy(dialog_Text);
            secCanvas.SetActive(true);
            tips.text = "Choose the destintation! Press Space To Launch!";
        }

        slider_Text.text = slider.value.ToString();
    }
}
