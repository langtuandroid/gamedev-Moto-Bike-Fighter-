using UnityEngine;

public class EnemyTrigger : MonoBehaviour {
	private static bool _speedBool;
	[SerializeField] private GameObject script;

	private void Start () {
		_speedBool = false;

	
	}
	private void OnTriggerEnter(Collider col)
	{
			
		if (col.tag == "Player") {
	           _speedBool = true;
			   script.GetComponent<ChaseBA> ().enabled = true;
			    print ("Sohail");
			 
		}
	}
}
