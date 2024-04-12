using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class TriggerStay : MonoBehaviour {
	[FormerlySerializedAs("Player")] public GameObject player;
	[FormerlySerializedAs("Enemy")] public GameObject enemy;
	
	private void OnTriggerStay(Collider col)
	{
		if (col.tag == "Player") {
		    player.GetComponent<Animator> ().SetBool ("hit1", true);
			player.GetComponent<Animator> ().SetBool ("hit3", true);
			enemy.GetComponent<EnemyAIBA> ().engineSpeed = 0f;
			print("shahbazzzz");
		}

	}

	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player") {
			player.GetComponent<Animator> ().SetBool ("hit1", false);
			Time.timeScale = 1f;
		}

	}
}
