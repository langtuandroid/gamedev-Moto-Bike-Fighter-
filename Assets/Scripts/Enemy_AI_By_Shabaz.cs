using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class EnemyAIBA : MonoBehaviour {
	[SerializeField] private Transform target;
	[SerializeField] private float moveSpeed = 3;
	private Rigidbody _rb;
	private Animator _ani;
	public float engineSpeed;
	[SerializeField] private float turnSpeed;
	[SerializeField] private float EnemyHealth;
	[SerializeField] private GameObject player;
	[SerializeField] private Transform bikerR;
	[SerializeField] private bool enemyHit;
	
	private void Start () {
		_rb = GetComponent<Rigidbody> ();
		_ani = GetComponent<Animator> ();
		EnemyHealth = 100;
		enemyHit = false;
	}

	private void Update () {
		
		_rb.AddForce (Vector3.back * engineSpeed);
	}
	
	public void LegHit()
	{
		_ani.SetBool("yes4",true);
		print ("Leg hit");
	}
	public void LegHit1()
	{
		_ani.SetBool("yes4",false);
	}
	public void Punch()
	{
		_ani.SetBool ("yes3", true);
	}
	public void Punch1()
	{
		_ani.SetBool ("yes3", false);
	
	}
	
	private void OnCollisionStay(Collision col)
	{
		{
			if (col.collider.tag == "Player") {

				player.GetComponent<Animator> ().SetBool ("hit1", true);
		
			}
		}
	}

	private void OnCollisionExit(Collision col)
	{
		{
			if (col.collider.tag == "Player") {

				player.GetComponent<Animator> ().SetBool ("hit1", false);
	
			}
		}
	}
}


