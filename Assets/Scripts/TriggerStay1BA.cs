using UnityEngine;

public class TriggerStay1BA : MonoBehaviour {
	[SerializeField] private GameObject player;
	[SerializeField] private bool gotYou1;
	[SerializeField] private bool hit1;
	private static readonly int Right1 = Animator.StringToHash("right1");
	private static readonly int Yes8 = Animator.StringToHash("yes8");
	private static readonly int Right3 = Animator.StringToHash("right3");

	private void Update () {
		if (gotYou1 && FindObjectOfType<BikeControlsBA> ().punch) 
		{
			player.GetComponent<Animator> ().SetBool (Right3, true);
			player.GetComponent<EnemyAIBA> ().engineSpeed= 0f;
			gotYou1 = false;
		}
		if (hit1) {
			player.GetComponent<Animator> ().SetBool (Right1,true);
			FindObjectOfType<BikeControlsBA> ().healthBar.fillAmount = FindObjectOfType<BikeControlsBA> ().healthBar.fillAmount - 0.25f;
			FindObjectOfType<BikeControlsBA> ().gameObject.GetComponent<Animator> ().SetBool (Yes8, true);
			hit1 = false;

		}
	
	}
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			gotYou1 = true;
			hit1 = true;
		}

	}

	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player") {
			gotYou1 = false;
			player.GetComponent<Animator> ().SetBool (Right1, false);
			FindObjectOfType<BikeControlsBA> ().gameObject.GetComponent<Animator> ().SetBool (Yes8, false);
			hit1 = false;

		}
	}
}
