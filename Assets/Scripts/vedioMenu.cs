using UnityEngine;
using System.Collections;

public class vedioMenu : MonoBehaviour {
	private Rigidbody rb;
	public  static float EngineSpeed;
	public GameObject player;
	// Use this for initialization
	void Start () {
	//	rb = GetComponent<Rigidbody> ();
		EngineSpeed = 15;
	}
	
	// Update is called once per frame
	void Update () {
//		rb.AddForce (Vector3.back* EngineSpeed,ForceMode.Impulse);
	}

	void OnCollisionEnter(Collision other)
	{
		
			player.GetComponent<Animator> ().SetBool ("stunt1", true);

		}

	void OnTriggerEnter(Collider other)
	{
		player.GetComponent<Animator> ().SetBool ("yes9", true);

	}
}
