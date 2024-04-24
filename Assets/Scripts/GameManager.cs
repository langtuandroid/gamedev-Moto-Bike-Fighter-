using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour {
	[SerializeField] private GameObject completeE;
	[SerializeField] private GameObject player;
	[SerializeField] private GameObject pausePanel;
	private bool _completeBool;
	[SerializeField] private Texture[] bikeTextures;
	[SerializeField] private SkinnedMeshRenderer bikeBody;
	[SerializeField] private SkinnedMeshRenderer playerBody;
	
	public static bool showLoading;
	private bool _adbool1;
	private bool _adBool;
	
	private void Awake()
	{
		if (PlayerPrefs.GetInt ("sound") == 1) {
			AudioListener.pause = false;

		} if(PlayerPrefs.GetInt ("sound") == 2) {
			AudioListener.pause = true;

		}
	}
	private void Start () {

		showLoading = false;
		_adbool1 = true;
		_adBool = true;
		_completeBool = false;
//		PlayerPrefs.DeleteAll ();
		pausePanel.SetActive(false);
		if (PlayerPrefs.GetInt ("Player") == 0) {
			bikeBody.material.mainTexture = bikeTextures [0];
			playerBody.material.mainTexture = bikeTextures [1];

		}
		if (PlayerPrefs.GetInt ("Player") == 1) {
			bikeBody.material.mainTexture = bikeTextures [2];
			playerBody.material.mainTexture = bikeTextures [3];
		}
		if (PlayerPrefs.GetInt ("Player") == 2) {
			bikeBody.material.mainTexture = bikeTextures [4];
			playerBody.material.mainTexture = bikeTextures [5];
			
		}
		 

			
	}
	
	private void Update () {
		if (_completeBool) {
			if (Application.loadedLevelName == "level1") {
				PlayerPrefs.SetInt ("level1", 1);
			}
			if (Application.loadedLevelName == "level2") {
				PlayerPrefs.SetInt ("level2", 1);
			}
			if (Application.loadedLevelName == "level3") {
				PlayerPrefs.SetInt ("level3", 1);
			}
			if (Application.loadedLevelName == "level4") { 
				PlayerPrefs.SetInt ("level4", 1);
			}
			if (Application.loadedLevelName == "level5") { 
				PlayerPrefs.SetInt ("level5", 1);
			}
			if (Application.loadedLevelName == "level6") { 
				PlayerPrefs.SetInt ("level6", 1);
			}
			if (Application.loadedLevelName == "level7") { 
				PlayerPrefs.SetInt ("level7", 1);
			}
			if (Application.loadedLevelName == "level8") { 
				PlayerPrefs.SetInt ("level8", 1);
			}
			if (Application.loadedLevelName == "level9") { 
				PlayerPrefs.SetInt ("level9", 1);
			}
			if (Application.loadedLevelName == "level10") { 
				PlayerPrefs.SetInt ("level10", 1);
			}
			_completeBool = false;
		}
	}


	private void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player") {
			player.GetComponent<Animator> ().SetBool("yes10", true);
			StartCoroutine (CompleteYes ());
		}
	}
	public IEnumerator CompleteYes()
	{
		Debug.Log ("started");
		_completeBool = true;
		yield return new WaitForSeconds(2f);
		completeE.SetActive (true);
		Time.timeScale = 0f;
		 

	}
	public void Restart()
	{
		Application.LoadLevel (Application.loadedLevel);
		Time.timeScale = 1f;
		AudioListener.pause = false;
	}

	public void OnPause()
	{
		pausePanel.SetActive (true);
		Time.timeScale = 0f;
		AudioListener.pause = true;
		 
	}

	public void Resume()
	{
 		pausePanel.SetActive (false);
		Time.timeScale = 1f;
		AudioListener.pause = false;

	}

	public void Home()
	{
		 
		SceneManager.LoadScene (0);
		Time.timeScale = 1f;
		AudioListener.pause = false;
	}

	public void Next()
	{
 		SceneManager.LoadScene (2);
		Time.timeScale = 1f;
		AudioListener.pause = false;
	}
}
