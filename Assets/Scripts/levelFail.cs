using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class LevelFail : MonoBehaviour {
	private Animator _ani;
	[FormerlySerializedAs("Player")] [SerializeField] private GameObject player;
	[FormerlySerializedAs("Fail")] [SerializeField] private GameObject fail;
	public static bool stop;
	private bool _adBool1;
	
	public void FailYes()
	{
		fail.SetActive (true);
		Time.timeScale = 0f;
		 
	}
	
	private void OnCollisionEnter(Collision col)
	{
		if (col.collider.tag == "Player") {
			player.GetComponent<Animator>().SetBool ("yes7", true);
			player.GetComponent<BikeControls> ().engineSpeed = 0f;
			player.GetComponent<BikeControls> ().healthBar.fillAmount = 0;
			Invoke (nameof(FailYes), 1.5f);
		
		}
	}
}
