using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class TriggerStay : MonoBehaviour {
	[FormerlySerializedAs("Player")] public GameObject player;
	[FormerlySerializedAs("Enemy")] public GameObject enemy;
	private static readonly int Hit1 = Animator.StringToHash("hit1");
	private static readonly int Hit3 = Animator.StringToHash("hit3");

	private void OnTriggerStay(Collider col)
	{
		if (col.tag == "Player") {
		    player.GetComponent<Animator> ().SetBool (Hit1, true);
			player.GetComponent<Animator> ().SetBool (Hit3, true);
			enemy.GetComponent<EnemyAIBA> ().engineSpeed = 0f;
		}

	}

	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player") {
			player.GetComponent<Animator> ().SetBool (Hit1, false);
			Time.timeScale = 1f;
		}

	}
}
