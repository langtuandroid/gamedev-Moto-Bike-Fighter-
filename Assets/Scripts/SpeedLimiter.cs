using UnityEngine;
using System.Collections;

public class SpeedLimiter : MonoBehaviour {
	
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Enemy") {
//			FindObjectOfType<Enemy_AI_By_Shabaz>().EngineSpeed = 500f;

		}
	}
}
