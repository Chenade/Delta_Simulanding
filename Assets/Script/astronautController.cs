using UnityEngine;
using System.Collections;

public class astronautController : MonoBehaviour
{

	private Animator anim;
	private CharacterController controller;

	//private string target;
	public float speed = 600.0f;
	public float turnSpeed = 400.0f;
	private Vector3 playerVelocity;
	public float gravity = 9.8f;
	public float JumpHeight = 20f;

	void Start()
	{
		controller = GetComponent<CharacterController>();
		anim = gameObject.GetComponentInChildren<Animator>();
	}

	void Update()
	{
		if (Input.GetKey("w") || Input.GetKey("s") || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow)){
			anim.SetInteger("AnimationPar", 1);
		}else{
			anim.SetInteger("AnimationPar", 0);
		}

		if (controller.isGrounded)
		{
			playerVelocity = transform.forward * Input.GetAxis("Vertical") * speed;
		}

		if (Input.GetKeyDown(KeyCode.F) && controller.isGrounded)
		{
			playerVelocity.y += Mathf.Sqrt(JumpHeight * -3.0f * -gravity);
		}


		float turn = Input.GetAxis("Horizontal");
		transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);
		controller.Move(playerVelocity * Time.deltaTime);
		playerVelocity.y -= gravity * Time.deltaTime;
		/*
		bool groundedPlayer = controller.isGrounded;
		if (groundedPlayer && playerVelocity.y < 0)
		{
			playerVelocity.y = 0f;
		}

		Vector3 move = new Vector3(Input.GetAxis("Vertical"), 0, 0);
		playerVelocity = transform.forward * Input.GetAxis("Vertical") * speed;
		controller.Move(playerVelocity * Time.deltaTime);

		if (move != Vector3.zero)
		{
			gameObject.transform.forward = move;
		}

		if (Input.GetKeyDown(KeyCode.F) && groundedPlayer)
		{
			playerVelocity.y += Mathf.Sqrt(JumpHeight * -3.0f * -gravity);
		}

		float turn = Input.GetAxis("Horizontal");
		transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);
		controller.Move(playerVelocity * Time.deltaTime);
		playerVelocity.y -= gravity * Time.deltaTime;

		/*

		float turn = Input.GetAxis("Horizontal");
		transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);
		controller.Move(moveDirection * Time.deltaTime);
		moveDirection.y -= gravity * Time.deltaTime;*/
	}

}