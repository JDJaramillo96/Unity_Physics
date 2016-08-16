using UnityEngine;
using System.Collections;

public class OnCollision : MonoBehaviour {

	void OnCollisionEnter(Collision other)
	{
		Debug.Log ("On collision enter");
	}

	void OnCollisionStay(Collision other)
	{
		Debug.Log ("On collision stay");
	}

	void OnCollisionExit(Collision other)
	{
		Debug.Log ("On collision exit");
	}
}