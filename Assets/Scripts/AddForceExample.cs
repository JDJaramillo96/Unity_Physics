using UnityEngine;
using System.Collections;

public class AddForceExample : MonoBehaviour {

	[SerializeField]
	private float force;

	void OnMouseDown()
	{
		gameObject.GetComponent<Rigidbody> ().AddForce (transform.forward * force, ForceMode.Force);
	}
}