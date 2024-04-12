using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class BikeRunBA : MonoBehaviour {
	private Vector3 _tempPost;
	public Animator start,leghit;

	[FormerlySerializedAs("Muka")] public Animator muka;

	[FormerlySerializedAs("bikeleft")] public Animator bikeLeft;

	[FormerlySerializedAs("bikeright")] public Animator bikeRight;

	[FormerlySerializedAs("fall")] public Animator fallL;

	[FormerlySerializedAs("movingB")] public Animator movingBb;

	public Animator wheelO;


	public void Boost()
	{
      
	}

	public void Moving()
	{
		movingBb.SetBool ("yes8", true);
	}

	public void Moving1()
	{
		movingBb.SetBool ("yes8", false);
	}

	public void RiderFall()
	{
		fallL.SetBool ("yes7", true);

	}

	public void RiderFall1()
	{
		fallL.SetBool ("yes7", false);

	}

	public void Right()
	{
		bikeRight.SetBool ("yes6", true);
	}

	public void Right1()
	{
		bikeRight.SetBool ("yes6", false);
	}

	public void Left()
	{
		bikeLeft.SetBool ("yes5", true);

	}
	public void Left1()
	{
		bikeLeft.SetBool ("yes5", false);

	}

	public void LegHit()
	{
		leghit.SetBool("yes4",true);
	
	}
	public void LegHit1()
	{
		leghit.SetBool("yes4",false);

	}

	public void Punch()
	{
		muka.SetBool ("yes3", true);
	

	}
	public void Punch1()
	{
		muka.SetBool ("yes3", false);
	}
}
