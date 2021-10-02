using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class PlayerMoon : MonoBehaviour {

		private Animator anim;
		private CharacterController controller;

		public float speed = 600.0f;
		public float turnSpeed = 400.0f;
		private Vector3 moveDirection = Vector3.zero;
		public float gravity = 20.0f;

		public GameObject mainCanvas;
		public GameObject detailCanvas;
		public TextMeshProUGUI title;
		public TextMeshProUGUI content;

	void Start () {
			controller = GetComponent <CharacterController>();
			anim = gameObject.GetComponentInChildren<Animator>();
		}

		void Update (){
			if (Input.GetKey ("w")) {
				anim.SetInteger ("AnimationPar", 1);
			}  else {
				anim.SetInteger ("AnimationPar", 0);
			}

			if(controller.isGrounded){
				moveDirection = transform.forward * Input.GetAxis("Vertical") * speed;
			}

			float turn = Input.GetAxis("Horizontal");
			transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);
			controller.Move(moveDirection * Time.deltaTime);
			moveDirection.y -= gravity * Time.deltaTime;

			if (Input.GetKeyDown(KeyCode.Space))
			{
				RaycastHit hit;
				Vector3 fwd = transform.TransformDirection(Vector3.forward);
				if (Physics.Raycast(transform.position, fwd, out hit, 15f))
				{
					Debug.Log(hit.transform.name);
					if (hit.transform.name == "MMSEV")
					{
						title.text = "MMSEV";
						content.text = "The Space Exploration Vehicle (SEV) concept is designed to be flexible depending on the destination; the pressurized cabin can be used both for in-space missions and for surface exploration of planetary bodies, including near-Earth asteroids and Mars. The surface exploration version of the SEV has the cabin mounted on a chassis, with wheels that can pivot 360 degrees and drive about 10 kilometers per hour in any direction. It's about the size of a pickup truck (with 12 wheels) and can house two astronauts for up to 14 days with sleeping and sanitary facilities. Likewise, the in-space version of the SEV would have the same pressurized cabin on a flying platform; it too would allow two astronauts to stay on-site for 14 days.";
						detailCanvas.SetActive(true);
						mainCanvas.SetActive(false);
					}
					if (hit.transform.name == "LM")
					{
						title.text = "The Apollo Lunar Module";
						content.text = "The Apollo Lunar Module, or simply Lunar Module (LM), originally designated the Lunar Excursion Module (LEM), was the Lunar lander spacecraft that was flown between lunar orbit and the Moon's surface during the United States' Apollo program. It was the first crewed spacecraft to operate exclusively in the airless vacuum of space, and remains the only crewed vehicle to land anywhere beyond Earth.";
						detailCanvas.SetActive(true);
						mainCanvas.SetActive(false);
					}
					if (hit.transform.name == "MoonStone")
					{
						title.text = "MoonStone";
						content.text = "Moon rocks fall into two main categories: those found in the lunar highlands (terrae), and those in the maria. The terrae consist dominantly of mafic plutonic rocks. Regolith breccias with similar protoliths are also common. Mare basalts come in three distinct series in direct relation to their titanium content: high-Ti basalts, low-Ti basalts, and Very Low-Ti (VLT) basalts.";
						detailCanvas.SetActive(true);
						mainCanvas.SetActive(false);
					}
			}
				
			}
		}
}
