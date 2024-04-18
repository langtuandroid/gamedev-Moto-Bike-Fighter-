using UnityEngine;
using System.Collections;

public class VideoMenu : MonoBehaviour {
	private Rigidbody _rb;
	private static float _engineSpeed;
	public GameObject player;

	private static readonly int Yes9 = Animator.StringToHash("yes9");
	private static readonly int Stunt1 = Animator.StringToHash("stunt1");

	// Use this for initialization
	private void Start () {
		_engineSpeed = 15;
	}
	

	private void OnCollisionEnter(Collision other)
	{
		
			player.GetComponent<Animator> ().SetBool (Stunt1, true);

		}

	private void OnTriggerEnter(Collider other)
	{
		player.GetComponent<Animator> ().SetBool (Yes9, true);

	}
}
