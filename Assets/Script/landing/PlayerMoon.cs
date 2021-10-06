using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class PlayerMoon : MonoBehaviour {

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
				if (target == "SEV")
				{
					title.text = "SEV";
					content.text = "The Space Exploration Vehicle (SEV) concept is designed to be flexible depending on the destination; the pressurized cabin can be used both for in-space missions and for surface exploration of planetary bodies, including near-Earth asteroids and Mars. The surface exploration version of the SEV has the cabin mounted on a chassis, with wheels that can pivot 360 degrees and drive about 10 kilometers per hour in any direction. It's about the size of a pickup truck (with 12 wheels) and can house two astronauts for up to 14 days with sleeping and sanitary facilities. Likewise, the in-space version of the SEV would have the same pressurized cabin on a flying platform; it too would allow two astronauts to stay on-site for 14 days.";
				}
				if (target == "LM")
				{
					title.text = "The Apollo Lunar Module";
					content.text = "The Apollo Lunar Module, or simply Lunar Module (LM), originally designated the Lunar Excursion Module (LEM), was the Lunar lander spacecraft that was flown between lunar orbit and the Moon's surface during the United States' Apollo program. It was the first crewed spacecraft to operate exclusively in the airless vacuum of space, and remains the only crewed vehicle to land anywhere beyond Earth.";
				}
				if (target == "MoonStone")
				{
					title.text = "MoonStone";
					content.text = "Moon rocks fall into two main categories: those found in the lunar highlands (terrae), and those in the maria. The terrae consist dominantly of mafic plutonic rocks. Regolith breccias with similar protoliths are also common. Mare basalts come in three distinct series in direct relation to their titanium content: high-Ti basalts, low-Ti basalts, and Very Low-Ti (VLT) basalts.";
					
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
