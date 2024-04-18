using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.Serialization;

public class LevelSelection : MonoBehaviour {
	[SerializeField] private GameObject l2;
	[SerializeField] private GameObject l3;
	[SerializeField] private GameObject l4;
	[SerializeField] private GameObject l5;
	[SerializeField] private GameObject l6;
	[SerializeField] private GameObject l7;
	[SerializeField] private GameObject l8;
	[SerializeField] private GameObject l9;
	[SerializeField] private GameObject l10;
	[FormerlySerializedAs("Loading")] [SerializeField] private GameObject loading;
	private bool _adbool;

	private void Awake()
	{
		if (PlayerPrefs.GetInt ("sound") == 1) {
			AudioListener.pause = false;

		} if(PlayerPrefs.GetInt ("sound") == 2) {
			AudioListener.pause = true;

		}
	}
	
	private void Start () {
		 
		_adbool=true;
		loading.SetActive(false);
		
		
		
	}

	public void UnlockAllLevels()
	{
		PlayerPrefs.SetInt("level1", 1);
		PlayerPrefs.SetInt("level2", 1);
		PlayerPrefs.SetInt("level3", 1);
		PlayerPrefs.SetInt("level4", 1);
		PlayerPrefs.SetInt("level5", 1);
		PlayerPrefs.SetInt("level6", 1);
		PlayerPrefs.SetInt("level7", 1);
		PlayerPrefs.SetInt("level8", 1);
		PlayerPrefs.SetInt("level9", 1);
	}
	
	private void Update () {

		if (PlayerPrefs.GetInt ("level1") == 1) {
			l2.SetActive (false);
		} else {
			l2.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("level2") == 1) {
			l3.SetActive (false);
		} else {
			l3.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("level3") == 1) {
			l4.SetActive (false);
		} else {
			l4.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("level4") == 1) {
			l5.SetActive (false);
		} else {
			l5.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("level5") == 1) {
			l6.SetActive (false);
		} else {
			l6.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("level6") == 1) {
			l7.SetActive (false);
		} else {
			l7.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("level7") == 1) {
			l8.SetActive (false);
		} else {
			l8.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("level8") == 1) {
			l9.SetActive (false);
		} else {
			l9.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("level9") == 1) {
			l10.SetActive (false);
		} else {
			l10.SetActive (true);
		}
		
	}

	public void LoadTime()
	{
		SceneManager.LoadScene (3);
 	}
	public void Level1()
	{
		Invoke(nameof(LoadTime),3f);
 		loading.SetActive (true);
		 
	}

	public void LoadTime1()
	{
		SceneManager.LoadScene (4);
		 
	}

	public void Level2()
	{
		Invoke(nameof(LoadTime1),3f);
 		loading.SetActive (true);
		 
	}

	public void LoadTime2()
	{
		SceneManager.LoadScene (5);
 	}
	
	public void Level3()
	{
		Invoke(nameof(LoadTime2),3f);
 		loading.SetActive (true);
		 
	}

	public void LoadTime3()
	{
		SceneManager.LoadScene (6);
 	}
	
	public void Level4()
	{
		Invoke(nameof(LoadTime3),3f);
		loading.SetActive (true);
		 
	}

	public void LoadTime4()
	{
		SceneManager.LoadScene (7);
 	}
	
	public void Level5()
	{
		Invoke(nameof(LoadTime4),3f);
 		loading.SetActive (true);
	}

	public void LoadTime5()
	{
		SceneManager.LoadScene (8);
 	}

	public void Level6()
	{
		Invoke(nameof(LoadTime5),3f);
 		loading.SetActive (true);
	}

	public void LoadTime6()
	{
		SceneManager.LoadScene (9);
 	}

	public void Level7()
	{
		Invoke(nameof(LoadTime6),3f);
 		loading.SetActive (true);
		 
	}

	public void LoadTime7()
	{
		SceneManager.LoadScene (10);
 	}
	public void Level8()
	{
		Invoke(nameof(LoadTime7),3f);
 		loading.SetActive (true);
		 
	}

	public void LoadTime8()
	{
		SceneManager.LoadScene (11);
 	}
	public void Level9()
	{
		Invoke(nameof(LoadTime8),3f);
 		loading.SetActive (true);
	}

	public void LoadTime9()
	{
		SceneManager.LoadScene (12);
 	}
	
	public void Level10()
	{
		Invoke(nameof(LoadTime9),3f);
 		loading.SetActive (true);
		 
	}

	public void Back()
	{
 		SceneManager.LoadScene (1);
	}
}
