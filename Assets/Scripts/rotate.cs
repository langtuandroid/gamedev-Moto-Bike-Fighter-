using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	
	private void Update () {
	
		transform.Rotate (Vector3.up, Time.deltaTime * 20);
	}
}
