using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class PlayerMars : MonoBehaviour {

	public GameObject mainCanvas;
	public GameObject detailCanvas;
	public TextMeshProUGUI title;
	public TextMeshProUGUI content;
	private string target;

	void Start () {
	
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Debug.Log(target);
			if (target != null)
			{
				if (target == "MarsRover")
				{
					title.text = "Mars Rover";
					content.text = "Opportunity is a robotic rover that was active on Mars from 2004 until mid-2018. Opportunity was operational on Mars for 5110 sols (14 years&136 days). Launched on July 7, 2003, as part of NASA's Mars Exploration Rover program, it landed in Meridiani Planum on January 25, 2004, three weeks after its twin Spirit touched down on the other side of the planet. Mission highlights included the initial 90-sol mission, finding meteorites such as Heat Shield Rock (Meridiani Planum meteorite), and over two years of exploring and studying Victoria crater. The rover survived moderate dust storms and in 2011 reached Endeavour crater, which has been described as a 'second landing site.' The Opportunity mission is considered one of NASA's most successful ventures.";
				}
				
				detailCanvas.SetActive(true);
				mainCanvas.SetActive(false);
			}
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		target = (other.transform.name);
		//Debug.Log(target);
	}

	private void OnTriggerExit(Collider other)
	{
		target = null;
		//Debug.Log(target);
	}
}
