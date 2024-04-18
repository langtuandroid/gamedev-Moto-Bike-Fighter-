using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class StayTrigger : MonoBehaviour {
	[SerializeField] private GameObject player;
	[SerializeField] private bool gotYou;
	[SerializeField] private bool hit;
	
	private void Update () {
		if (gotYou && FindObjectOfType<BikeControlsBA> ().legHit) 
		{
			player.GetComponent<Animator> ().SetBool ("hit3", true);
			player.GetComponent<EnemyAIBA> ().engineSpeed= 0f;
			gotYou = false;
		}
		if (hit) 
		{
			player.GetComponent<Animator> ().SetBool ("hit1",true);
			FindObjectOfType<BikeControlsBA> ().healthBar.fillAmount = FindObjectOfType<BikeControlsBA> ().healthBar.fillAmount - 0.15f;
			FindObjectOfType<BikeControlsBA> ().gameObject.GetComponent<Animator> ().SetBool ("yes8", true);
			hit = false;

		}
	
	}
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			gotYou = true;
			hit = true;

		}

	}
	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player") {
			gotYou = false;
			player.GetComponent<Animator> ().SetBool ("hit1",false);
			FindObjectOfType<BikeControlsBA> ().gameObject.GetComponent<Animator> ().SetBool ("yes8", false);
			hit = false;
		}
}
}
