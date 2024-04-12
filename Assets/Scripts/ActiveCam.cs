using UnityEngine;
using System.Collections;

public class ActiveCam : MonoBehaviour {
	private Camera camM;
	public bool temp;
	private Transform playerR;
	private bool temp2L;


	// Use this for initialization
	private void Start () {
		camM = GetComponentInChildren<Camera> ();
		camM.enabled = false;
		temp2L = true;
	}

	// Update is called once per frame
	private void Update () {
		if (temp) 
		{
			camM.GetComponent<Transform> ().LookAt (playerR);

		}

	}
	private void OnTriggerEnter(Collider other)
	{
	//	if (temp2 && other.tag == "Player") {
			playerR = other.GetComponent<Transform> ();
			Time.timeScale = .2f;
			temp = true;
			camM.enabled = true;
			StartCoroutine (ActionN ());
			temp2L = false;
	//	}

	}
	public IEnumerator ActionN()
	{
		yield return new WaitForSeconds (0.4f);
		Time.timeScale = 1;
//		Destroy (gameObject);
	}
}
