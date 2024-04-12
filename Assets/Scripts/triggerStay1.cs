using UnityEngine;
using System.Collections;

public class triggerStay1 : MonoBehaviour {
	public GameObject Player;
	public bool Gotyou1;
	public bool hit1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Gotyou1 && FindObjectOfType<BikeControls> ().punch) 
		{
			Player.GetComponent<Animator> ().SetBool ("right3", true);
			Player.GetComponent<EnemyAIBA> ().engineSpeed= 0f;
			Gotyou1 = false;
		}
		if (hit1) {
			Player.GetComponent<Animator> ().SetBool ("right1",true);
			FindObjectOfType<BikeControls> ().healthBar.fillAmount = FindObjectOfType<BikeControls> ().healthBar.fillAmount - 0.25f;
			FindObjectOfType<BikeControls> ().gameObject.GetComponent<Animator> ().SetBool ("yes8", true);
			hit1 = false;

		}
	
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			Gotyou1 = true;
			hit1 = true;
		}

	}

	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player") {
			Gotyou1 = false;
			Player.GetComponent<Animator> ().SetBool ("right1", false);
			FindObjectOfType<BikeControls> ().gameObject.GetComponent<Animator> ().SetBool ("yes8", false);
			hit1 = false;

		}
	}
}
