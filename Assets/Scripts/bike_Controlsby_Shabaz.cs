using System;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class BikeControlsBA : MonoBehaviour {
	private Rigidbody _rb;
	private Animator _ani;
	[SerializeField] private TextMeshProUGUI speedText;
	[FormerlySerializedAs("EngineSpeed")] public float engineSpeed;
	[SerializeField] private float turnSpeed;
	[SerializeField] private int speed;
    private bool _left, _right;
    public Image healthBar;
	[SerializeField] private GameObject player;
	public GameObject fail,EnemyBike;
	private Vector3 _pos;
	[SerializeField] private bool speedyY;
	[SerializeField] private bool speedReleaseE;
	[SerializeField] private bool brakeE;
	[SerializeField] private float timerR =0.01f;
	[SerializeField] private AudioSource raceSound;
	[FormerlySerializedAs("leghit")] public bool legHit;
	[SerializeField] public bool punch;
	private bool _adBool1;
	private void Start () {
		legHit = false;
		punch = false;
		_pos.z = EnemyBike.transform.position.z;
	    _rb = GetComponent<Rigidbody> ();
	    _ani = GetComponent<Animator> ();
		healthBar.fillAmount = 1f;
		_left = false;
		_right = false;
		speedyY = false;
		brakeE = false;
		speedReleaseE = false;
	}
	
	
	private void Update () {
		speedText.text = (_rb.velocity.magnitude * 7.5f).ToString ("f0") + " Km/h";

		if (healthBar.fillAmount <= 0) {
				player.GetComponent<Animator> ().SetBool ("yes7", true);
				Invoke (nameof(ForFail), 2f);
		
		}
	}

	private void FixedUpdate()
	{
		if (engineSpeed >= 50f) {
			engineSpeed = 50f;
		}
		if (speedyY) {
			engineSpeed += 15f * Time.deltaTime;
		}
		if (speedReleaseE) {
			engineSpeed -= 20f * Time.deltaTime;
		}
		if (brakeE) {
			engineSpeed -= 20f * Time.deltaTime;
		}
		if (engineSpeed <= 15f) {
			engineSpeed = 15f;
		}
		
		float leftright = Input.GetAxis ("Horizontal");
		_rb.AddForce (Vector3.back * engineSpeed);
		if(_left)
		{
			_rb.AddForce (Vector3.right* turnSpeed,ForceMode.Acceleration);

		}
		if(_right)
		{
			_rb.AddForce (Vector3.left* turnSpeed,ForceMode.Acceleration);
		}
	}

	public void ForFail()
	{
		fail.SetActive (true);
		Time.timeScale = 0.00f;
		 
	}

	public void LeftPressed()
	{
		_ani.SetBool ("yes5", true);
		_left = true;
	}
	public void LeftReleased()
	{
		_ani.SetBool ("yes5", false);
		_left = false;
	}

	public void RightPressed()
	{
		_ani.SetBool ("yes6", true);
		_right = true;
	}
	public void RightReleased()
	{
		_ani.SetBool ("yes6", false);
		_right = false;
	}
	public void LegHit()
	{
		_ani.SetBool("yes4",true);
		legHit = true;

	}
	public void LegHit1()
	{
		_ani.SetBool("yes4",false);
		legHit = false;

	}
	public void Punch()
	{
		_ani.SetBool ("yes3", true);
		punch = true;
	}
	public void Punch1()
	{
		_ani.SetBool ("yes3", false);
		punch = false;
	}
	public void OneWheel()
	{
		_ani.SetBool ("yes9", true);
		speedyY = true;
		speedReleaseE = false;
		brakeE = false;
	}
	public void OneWheel1()
	{
		_ani.SetBool ("yes9", false);
		speedyY = false;
		speedReleaseE = true;
		brakeE = true;
	}

	public void Speed()
	{
		speedyY = true;
		speedReleaseE = false;
		brakeE = false;
		raceSound.Play();
	}

	public void Speed1()
	{
		speedyY = false;
	}

	public void ReleaseSpeed()
	{
		speedReleaseE = true;
		speedyY = false;
		raceSound.Pause ();

	}
	public void ReleaseSpeed1()
	{
		speedReleaseE = false;

	}
	public void Stop()
	{
		brakeE = true;
		print ("stoppp");
	}
	public void Stop1()
	{
		brakeE = false;
		print ("stoppp1");
	}
	
	private void OnCollisionEnter(Collision other)
	{
		if (other.collider.tag == "Enemy") {
			timerR -= Time.deltaTime;
			if (timerR <= 0) {
				player.GetComponent<Animator> ().SetBool ("yes8", true);
			}

		}
	}
	
	private void OnCollisionExit(Collision other)
	{
		if (other.collider.tag == "Enemy") 
		{
			
			player.GetComponent<Animator> ().SetBool ("yes8", false);

		}
	}



}
