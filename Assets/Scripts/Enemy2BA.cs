using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class Enemy2BA : MonoBehaviour {
	[SerializeField] private GameObject player;
	private static readonly int Hit2 = Animator.StringToHash("hit2");

	private void OnCollisionStay(Collision col)
	{
		{
			if (col.collider.tag == "Player") {

				player.GetComponent<Animator> ().SetBool (Hit2, true);
			}
		}
}
	private void OnCollisionExit(Collision col)
	{
		{
			if (col.collider.tag == "Player")
			{	
				player.GetComponent<Animator> ().SetBool (Hit2, false);
			}

        }
	}
}