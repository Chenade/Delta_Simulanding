using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    // gravity = G* M*m/r^2

    public GameObject mainCanvas;
    public GameObject operateCanvas;

    public float speed = 10f;
    public float Vt;
    private float distance;
    private float fixedDeltaTime;
    private bool landed = false;

    public TextMeshProUGUI speedText;
    public TextMeshProUGUI distText;
    public Rigidbody player;
    public Transform target;
    public Slider fuel;
    public GameObject outOfFuel;

    public GameObject dashboard;
    public GameObject result;
    public TextMeshProUGUI title;
    public TextMeshProUGUI finalSpeed;
    public TextMeshProUGUI finalAngle;
    public TextMeshProUGUI finalFuel;
    public GameObject nextStage;
    public GameObject tryAgain;

    void Start()
    {
        fuel.value = 100;
     }

    // Update is called once per frame
    void Update()
    {
        if (operateCanvas.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.Space))  //Space
            {
                operateCanvas.SetActive(false);
                mainCanvas.SetActive(true);
                PlayerGravity.effect = true;
                PlayerGravity sn = gameObject.GetComponent<PlayerGravity>();
                sn.startgravity();
            }
        }
        else
        {
            float Horizontal = Input.GetAxis("Horizontal") * 10f;
            float Vertical = Input.GetAxis("Vertical") * 35f;
            transform.Rotate(new Vector3(0, 0, Vertical) * Time.deltaTime);

            if (!landed)
            {
                Vt = player.velocity.magnitude;
                //Debug.Log(speed);
                speedText.text = Vt.ToString("0.00");

                float tmp = Vector3.Distance(transform.position, target.position) - 87;
                distance = (int)tmp;
                distText.text = distance.ToString();
            }
        

            if (Input.GetKeyDown(KeyCode.Space))  //Space
            {
                if (fuel.value > 0)
                {
                    fuel.value -= 1;
                    player.AddForce(transform.up * -speed , ForceMode.VelocityChange);
                }
                else
                {
                    Debug.Log("Out of Fuel");
                    outOfFuel.SetActive(true);
                }
            }
        }
        
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        landed = true;
        Vector3 start = transform.position;
        Vector3 end = target.position;
        Vector3 rocket_v = transform.up;
        float angle = Vector3.Dot((end - start).normalized, (rocket_v).normalized);
        angle *= 90;

        //Debug.Log(angle);
        //Debug.Log(Vt);
        //Debug.Log(distance);
        dashboard.SetActive(false);
        result.SetActive(true);
        finalAngle.text = angle.ToString("0.00");
        finalFuel.text = fuel.value.ToString() + "%";
        finalSpeed.text = Vt.ToString("0.00");
        PlayerGravity.effect = false;
        if (angle >= 89.55 && Vt <= 2)
        {
            nextStage.SetActive(true);
            title.text = "Congratulations";
            Debug.Log("pass");

        }
        else
        {
            tryAgain.SetActive(true);
            title.text = "Mission Failed";
            Debug.Log("failed");
        }
        //Debug.Log(Vector3.Dot((end - start).normalized, (rocket_v).normalized));
        //bool passed = Vector3.Dot((end - start).normalized, (rocket_v).normalized) > 0;
    }
}