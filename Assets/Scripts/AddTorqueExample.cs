using UnityEngine;
using System.Collections;

public class AddTorqueExample : MonoBehaviour {

	private Rigidbody rb;

	void Awake()
	{
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate()
	{
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		rb.AddTorque (transform.forward * horizontal, ForceMode.VelocityChange);
		rb.AddTorque (transform.right * vertical, ForceMode.VelocityChange);
	}
}