using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Score : MonoBehaviour {

	[SerializeField] private Text score;
	
	private void Update () {
		SetScoreTextT ();
	}
	
	private void SetScoreTextT ()
	{
		score.text = "" + PlayerPrefs.GetInt("score");
	}
}
