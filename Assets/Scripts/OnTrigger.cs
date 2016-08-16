using UnityEngine;
using System.Collections;

public class OnTrigger : MonoBehaviour {

	[SerializeField]
	private float hoveForce;

	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("On trigger enter");
	}

	void OnTriggerStay(Collider other)
	{
		Debug.Log ("On trigger stay");

		Rigidbody otherRigidbody = other.gameObject.GetComponent<Rigidbody> ();
		otherRigidbody.AddForce (Vector3.up * hoveForce, ForceMode.Force);
	}

	void OnTriggerExit(Collider other)
	{
		Debug.Log ("On trigger exit");
	}
}