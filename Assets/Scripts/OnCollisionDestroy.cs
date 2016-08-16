using UnityEngine;
using System.Collections;

public class OnCollisionDestroy : MonoBehaviour {

	[SerializeField]
	private float time;

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.name == "KinematicCube") Destroy (col.gameObject);
		StartCoroutine (DestroyTime ());
	}

	IEnumerator DestroyTime()
	{
		yield return new WaitForSeconds (time);
		Destroy (gameObject);
	}
}