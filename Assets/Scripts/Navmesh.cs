using UnityEngine;
using System.Collections;

public class Navmesh : MonoBehaviour {
	private UnityEngine.AI.NavMeshAgent _agentT;
	private Transform _playerR;
 
	// Use this for initialization
	private void Start () {
		_agentT = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		_playerR = FindObjectOfType<PlayerPosition> ().gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	private void Update () {
	
		_agentT.SetDestination (_playerR.position);
	}
}
