using UnityEngine;
using System.Collections;

public class CoinTrigger : MonoBehaviour {
	[SerializeField] private int score;
	
	private void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	private void Update () {
		transform.Rotate (Vector3.up * (Time.deltaTime * 200));
	}

	private void OnTriggerEnter(Collider col)
	{
		GetComponent<AudioSource> ().Play ();
		PlayerPrefs.SetInt ("score", PlayerPrefs.GetInt ("score")+10);
		Destroy (gameObject,0.15f);

	}
}
