using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class ChaseBA : MonoBehaviour {

	[SerializeField] private Transform targetT;
	[SerializeField] private float moveSpeedD = 3;
	
	private void Update () {
		ChaseE();
	}

	private void ChaseE () {
		Vector3 vectorToTarget = targetT.position - transform.position;
		float moveDistance = moveSpeedD * Time.deltaTime;
		if (vectorToTarget.magnitude > moveDistance ) {
			transform.position += vectorToTarget.normalized * moveDistance;
		}
		else {
			transform.position = targetT.position;
		}
	}
}
