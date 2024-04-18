using System;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class MainMenuBA : MonoBehaviour {
	[SerializeField] private GameObject settingsPanelL;
	[SerializeField] private GameObject audioSource;
	[SerializeField] private GameObject soundOnnN;
	[SerializeField] private GameObject soundOffF;
	[SerializeField] private GameObject loading;
	private float _timer;
	private bool _temp;
	private bool _once;
	private bool _menu;

	private void Awake()
	{
		Application.targetFrameRate = 60;
	}

	private void Start () {
		_temp = true;
		_once = true;
		_timer = 3f;
		settingsPanelL.SetActive (false);
	
		if (PlayerPrefs.GetInt ("sound") == 1) {
			AudioListener.pause = false;
			soundOnnN.SetActive (true);
			soundOffF.SetActive (false);
		} if (PlayerPrefs.GetInt ("sound") == 2) {
			AudioListener.pause = true;
			soundOnnN.SetActive (false);
			soundOffF.SetActive (true);
		}

		 

	}
	
	private void Update () {
		if (PlayerPrefs.GetInt ("sound") == 1) {
			AudioListener.pause = false;

		} if(PlayerPrefs.GetInt ("sound") == 2) {
			AudioListener.pause = true;

		}

		_timer -= Time.deltaTime;
		if (_timer > 0) {
			loading.SetActive (true);
			if (GameManager.showLoading && PlayerPrefs.GetInt("ADSUNLOCK")!=1) {
				
				GameManager.showLoading = false;
			}
		}

		if (_timer <= 0 && _temp) {
			loading.SetActive (false);
			 
			_temp = false;
		}
	}


	public void Play()
	{
 		SceneManager.LoadScene (1);

	}

	public void RateUs()
	{
 		Application.OpenURL ("");

	}

	public void MoreGames()
	{
 		Application.OpenURL("");
	}

	public void Settings()
	{
 		settingsPanelL.SetActive (true);
	}
	 
	public void Close()
	{
		settingsPanelL.SetActive (false);
	}
	public void Privacy()
	{
 		Application.OpenURL ("");
	}
		
	public void SoundOn()
	{
		PlayerPrefs.SetInt ("sound", 2);
		AudioListener.pause = false;
		soundOnnN.SetActive (false);
		soundOffF.SetActive (true);

	}

	public void SoundOff()
	{
		PlayerPrefs.SetInt ("sound", 1);
		AudioListener.pause = true;
		soundOnnN.SetActive (true);
		soundOffF.SetActive (false);
	}

}
