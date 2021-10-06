using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropTank : MonoBehaviour
{
    public GameObject[] tk;
    public GameObject[] fires;
    public Slider heightSlider;
    public string rocket;
    private float height;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        height = transform.position.y;
        heightSlider.value = height / 5000;
        if (rocket == "Falcon_Heavy" || rocket == "Delta_IV")
        {
            if (height > 2000 && tk[0])
            {
                Rigidbody rb1 = tk[0].AddComponent<Rigidbody>();
                rb1.AddForce(tk[0].transform.right * -10000f);
                rb1.AddForce(Physics.gravity, ForceMode.Acceleration);
                tk[0] = null;
            }

            if (height > 2000 && tk[1])
            {
                Rigidbody rb2 = tk[1].AddComponent<Rigidbody>();
                rb2.AddForce(tk[1].transform.right * 10000f);
                rb2.AddForce(Physics.gravity, ForceMode.Acceleration);
                tk[1] = null;
            }

            if (height > 4000 && tk[2])
            {
                Rigidbody rb3 = tk[2].AddComponent<Rigidbody>();
                rb3.AddForce(Physics.gravity, ForceMode.Acceleration);
                tk[2] = null;
                fires[3].SetActive(true);
            }
        }

        if (rocket == "Saturn_V")
        {
            if (height > 1500 && tk[0])
            {
                Rigidbody rb1 = tk[0].AddComponent<Rigidbody>();
                rb1.AddForce(Physics.gravity, ForceMode.Acceleration);
                tk[0] = null;
                fires[5].SetActive(true);
                fires[6].SetActive(true);
                fires[7].SetActive(true);
                fires[8].SetActive(true);
                fires[9].SetActive(true);
            }

            if (height > 3000 && tk[1])
            {
                Rigidbody rb2 = tk[1].AddComponent<Rigidbody>();
                rb2.AddForce(Physics.gravity, ForceMode.Acceleration);
                tk[1] = null;
                Rigidbody rb21 = tk[2].AddComponent<Rigidbody>();
                rb21.AddForce(Physics.gravity, ForceMode.Acceleration);
                tk[2] = null;
                fires[10].SetActive(true);
            }

            if (height > 4500 && tk[3])
            {
                Rigidbody rb3 = tk[3].AddComponent<Rigidbody>();
                rb3.AddForce(Physics.gravity, ForceMode.Acceleration);
                tk[3] = null;
                fires[11].SetActive(true);
            }
        }

        if (rocket == "SLS Block 1B Cargo" || rocket == "SLS Block 1B Crew" || rocket == "SLS Block 2 Cargo")
        {
            if (height > 1500 && tk[0])
            {
                Rigidbody rb1 = tk[0].AddComponent<Rigidbody>();
                rb1.AddForce(tk[0].transform.right * 10000f);
                rb1.AddForce(Physics.gravity, ForceMode.Acceleration);
                tk[0] = null;
            }

            if (height > 1500 && tk[1])
            {
                Rigidbody rb2 = tk[1].AddComponent<Rigidbody>();
                rb2.AddForce(tk[1].transform.right * -10000f);
                rb2.AddForce(Physics.gravity, ForceMode.Acceleration);
                tk[1] = null;
            }

            if (height > 3000 && tk[2])
            {
                Rigidbody rb3 = tk[2].AddComponent<Rigidbody>();
                rb3.AddForce(Physics.gravity, ForceMode.Acceleration);
                tk[2] = null;
                fires[6].SetActive(true);
                fires[7].SetActive(true);
                fires[8].SetActive(true);
                fires[9].SetActive(true);
            }
        }

        if (rocket == "Star_ship")
        {
            if (height > 2000 && tk[0])
            {
                Rigidbody rb2 = tk[0].AddComponent<Rigidbody>();
                rb2.AddForce(Physics.gravity, ForceMode.Acceleration);
                tk[0] = null;
                fires[1].SetActive(true);
            }
        }

    }


    public void lightFire()
    {
        
        if (rocket == "Falcon_Heavy" || rocket == "Delta_IV")
        {
            foreach (GameObject fire in fires)
            {
                fire.SetActive(true);
            }
            fires[3].SetActive(false);
        }
        if (rocket == "Saturn_V")
        {
            fires[0].SetActive(true);
            fires[1].SetActive(true);
            fires[2].SetActive(true);
            fires[3].SetActive(true);
            fires[4].SetActive(true);
        }
        if (rocket == "SLS Block 1B Cargo" || rocket == "SLS Block 1B Crew" || rocket == "SLS Block 2 Cargo")
        {
            fires[0].SetActive(true);
            fires[1].SetActive(true);
            fires[2].SetActive(true);
            fires[3].SetActive(true);
            fires[4].SetActive(true);
            fires[5].SetActive(true);
        }
        if (rocket == "Star_ship")
        {
            fires[0].SetActive(true);
        }

    }
}
