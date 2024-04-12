using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class StayTrigger1 : MonoBehaviour {
	[FormerlySerializedAs("Player")] [SerializeField] private GameObject player;
	private static readonly int Right2 = Animator.StringToHash("right2");
	private static readonly int Right3 = Animator.StringToHash("right3");

	private void OnTriggerStay(Collider other)
	{
		if (other.tag == "Player") {
			player.GetComponent<Animator> ().SetBool (Right2, true);
			player.GetComponent<Animator> ().SetBool (Right3, true);
			player.GetComponent<EnemyAIBA> ().engineSpeed= 0f;

		}

	}
	
	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player") {
			player.GetComponent<Animator> ().SetBool (Right2, false);		
			Time.timeScale = 1f;
		}
	}
}
