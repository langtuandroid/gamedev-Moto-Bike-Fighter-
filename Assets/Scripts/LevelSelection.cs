using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.Serialization;

public class LevelSelection : MonoBehaviour {
	[SerializeField] private Level l2;
	[SerializeField] private Level l3;
	[SerializeField] private Level l4;
	[SerializeField] private Level l5;
	[SerializeField] private Level l6;
	[SerializeField] private Level l7;
	[SerializeField] private Level l8;
	[SerializeField] private Level l9;
	[SerializeField] private Level l10;
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
			l2.Unlock();
		} else {
			l2.Lock();
		}
		if (PlayerPrefs.GetInt ("level2") == 1) {
			l3.Unlock();
		} else {
			l3.Lock();
		}
		if (PlayerPrefs.GetInt ("level3") == 1) {
			l4.Unlock();
		} else {
			l4.Lock();
		}
		if (PlayerPrefs.GetInt ("level4") == 1) {
			l5.Unlock();
		} else {
			l5.Lock();
		}
		if (PlayerPrefs.GetInt ("level5") == 1) {
			l6.Unlock();
		} else {
			l6.Lock();
		}
		if (PlayerPrefs.GetInt ("level6") == 1) {
			l7.Unlock();
		} else {
			l7.Lock();
		}
		if (PlayerPrefs.GetInt ("level7") == 1) {
			l8.Unlock();
		} else {
			l8.Lock();
		}
		if (PlayerPrefs.GetInt ("level8") == 1) {
			l9.Unlock();
		} else {
			l9.Lock();
		}
		if (PlayerPrefs.GetInt ("level9") == 1) {
			l10.Unlock();
		} else {
			l10.Lock();
		}
		
	}

	public void LoadTime()
	{
		LoadingScreenManager.instance.LoadScene(3);
 	}
	
	public void Level1()
	{
		Invoke(nameof(LoadTime),3f);
 		loading.SetActive (true);
		 
	}

	public void LoadTime1()
	{
		LoadingScreenManager.instance.LoadScene(4);
	}
	
	public void Level2()
	{
		Invoke(nameof(LoadTime1),0f);
 		loading.SetActive (true);
		 
	}

	public void LoadTime2()
	{
		LoadingScreenManager.instance.LoadScene(5);
 	}
	
	public void Level3()
	{
		Invoke(nameof(LoadTime2),3f);
 		loading.SetActive (true);
		 
	}

	public void LoadTime3()
	{
		LoadingScreenManager.instance.LoadScene(6);
 	}
	
	public void Level4()
	{
		Invoke(nameof(LoadTime3),3f);
		loading.SetActive (true);
		 
	}

	public void LoadTime4()
	{
		LoadingScreenManager.instance.LoadScene(7);
 	}
	
	public void Level5()
	{
		Invoke(nameof(LoadTime4),3f);
 		loading.SetActive (true);
	}

	public void LoadTime5()
	{
		LoadingScreenManager.instance.LoadScene(8);
 	}

	public void Level6()
	{
		Invoke(nameof(LoadTime5),3f);
 		loading.SetActive (true);
	}

	public void LoadTime6()
	{
		LoadingScreenManager.instance.LoadScene(9);
 	}

	public void Level7()
	{
		Invoke(nameof(LoadTime6),3f);
 		loading.SetActive (true);
		 
	}

	public void LoadTime7()
	{
		LoadingScreenManager.instance.LoadScene(10);
 	}
	public void Level8()
	{
		Invoke(nameof(LoadTime7),3f);
 		loading.SetActive (true);
		 
	}

	public void LoadTime8()
	{
		LoadingScreenManager.instance.LoadScene(11);
 	}
	public void Level9()
	{
		Invoke(nameof(LoadTime8),3f);
 		loading.SetActive (true);
	}

	public void LoadTime9()
	{
		LoadingScreenManager.instance.LoadScene(12);
 	}
	
	public void Level10()
	{
		Invoke(nameof(LoadTime9),3f);
 		loading.SetActive (true);
		 
	}

	public void Back()
	{
		loading.SetActive (true);
		LoadingScreenManager.instance.LoadScene(1);
	}
}
