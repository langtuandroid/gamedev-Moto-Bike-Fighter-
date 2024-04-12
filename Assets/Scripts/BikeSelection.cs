using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BikeSelection : MonoBehaviour {
	[SerializeField] private GameObject yellowW;
	[SerializeField] private  GameObject redD;
	[SerializeField] private  GameObject blueE;
	[SerializeField] private  GameObject redTextT;
	[SerializeField] private  GameObject blueTextT;
	[SerializeField] private  Text totalScoreE;
	[SerializeField] private  GameObject buyBtnN;
	[SerializeField] private  GameObject buyBtn1N;
	[SerializeField] private  GameObject selectT;
	[SerializeField] private  GameObject coinImageE;
	public int a, b;
	private Animator _ani;

	// Use this for initialization
	private void Awake()
	{
		if (PlayerPrefs.GetInt ("sound") == 1) {
			AudioListener.pause = false;

		} if(PlayerPrefs.GetInt ("sound") == 2) {
			AudioListener.pause = true;

		}
	}
	private void Start () {
		redD.SetActive (false);
		blueE.SetActive (false);
		buyBtnN.SetActive (false);
		buyBtn1N.SetActive (false);
		redTextT.SetActive (false);
		blueTextT.SetActive(false);
		selectT.SetActive (true);
		coinImageE.SetActive (false);
		PlayerPrefs.SetInt ("Player", 0);
		 
	}
	
	// Update is called once per frame
	private void Update () {
		
		if (PlayerPrefs.GetInt ("Buy") == 2) {
			buyBtnN.SetActive (false);
			redTextT.SetActive (false);
		}  if (PlayerPrefs.GetInt ("Buy1") == 3) {
			buyBtn1N.SetActive (false);
			blueTextT.SetActive (false);
		}

		GetScore ();
	
	}

	public void Right()
	{
		if (a == 0) 
		{
			PlayerPrefs.SetInt ("Player",1);
			redD.SetActive (true);
			yellowW.SetActive (false);
			blueE.SetActive (false);
			selectT.SetActive (true);
			redTextT.SetActive (true);
			blueTextT.SetActive (false);
			buyBtnN.SetActive (true);
			buyBtn1N.SetActive (false);
			coinImageE.SetActive (true);
			a = 1;
			b = 2;
			Debug.Log (a + "right of a==0");
			Debug.Log (b + "right of a==0");
		}
		else if (a == 1) 
		{
			PlayerPrefs.SetInt ("Player",2 );
			yellowW.SetActive (false);
			redD.SetActive (false);
			blueE.SetActive (true);
			redTextT.SetActive (false);
			selectT.SetActive (true);
			blueTextT.SetActive (true);
			buyBtn1N.SetActive (true);
			buyBtnN.SetActive (false);
			coinImageE.SetActive (true);
			a = 2;
			b = 1;
			Debug.Log (a + "right of a==1");
			Debug.Log (b + "right of a==1");
		}
	}
	public void Left()
	{
		if (b == 1) 
		{
			PlayerPrefs.SetInt ("Player",1);
			redD.SetActive (true);
			blueE.SetActive (false);
			yellowW.SetActive (false);
			selectT.SetActive (true);
			redTextT.SetActive (true);
			blueTextT.SetActive (false);
			buyBtnN.SetActive (true);
			buyBtn1N.SetActive (false);
			coinImageE.SetActive (true);
			a = 1;
			b = 2;
			Debug.Log (a + "right of b==1");
			Debug.Log (b + "right of b==1");
		}
		else if (b == 2) 
		{
			PlayerPrefs.SetInt ("Player",3);
			yellowW.SetActive (true);
			redD.SetActive (false);
			blueE.SetActive (false);
			selectT.SetActive (true);
			redTextT.SetActive (false);
			blueTextT.SetActive (false);
			buyBtnN.SetActive (false);
			buyBtn1N.SetActive (false);
			coinImageE.SetActive (false);
			b = 0;
			a = 0;
			Debug.Log (a + "right of b==2");
			Debug.Log (b + "right of b==2");
		}
	}
	
	public void SelectFwrd(){
 		SceneManager.LoadScene (2);
	}


	public void GetScore(){

		totalScoreE.text = "" + PlayerPrefs.GetInt("score");
	}

	public void BuyBike()
	{
		if (PlayerPrefs.GetInt ("score") >= 500) {
			selectT.SetActive (true);
			coinImageE.SetActive (false);
			PlayerPrefs.SetInt ("score", PlayerPrefs.GetInt ("score") - 500);
			Debug.Log ("score");
			PlayerPrefs.SetInt ("Buy", 2);
		}
	}

	public void BuyBike1()
	{
		if (PlayerPrefs.GetInt ("score") >= 1000) 
		{
			selectT.SetActive (true);
			coinImageE.SetActive (false);
			PlayerPrefs.SetInt ("score", PlayerPrefs.GetInt ("score") - 1000);
			Debug.Log ("score");
			PlayerPrefs.SetInt ("Buy1", 3);
		}

	}


	public void Back(){
 		SceneManager.LoadScene (0);
	}
}

