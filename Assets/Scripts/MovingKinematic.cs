using UnityEngine;
using System.Collections;

public class MovingKinematic : MonoBehaviour {

	[SerializeField]
	private float movementSpeed;

	void FixedUpdate ()
	{
		transform.Translate (Vector3.right * movementSpeed * Time.deltaTime);
	}
}