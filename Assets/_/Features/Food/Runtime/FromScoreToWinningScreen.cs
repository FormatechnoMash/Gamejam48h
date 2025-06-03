using UnityEngine;
using UnityEngine.SceneManagement;

namespace Food.Runtime
{
    public class FromScoreToWinningScreen : MonoBehaviour
    {
	    #region public


	    #endregion


	    #region unity API

	    void Awake()
	    {
		    DontDestroyOnLoad(gameObject);
	    
		    SceneManager.sceneLoaded += OnSceneLoaded;
	    }
	    void Start()
	    {
        
	    }

    
	    void Update()
	    {
		    if (Input.GetMouseButtonDown(0))
		    {
			    SceneManager.LoadScene("WinningScene");
		    }
	    }
	
	    #endregion
	
	    #region Utils
	
	    
	    
	    void OnDestroy()
	    {
		    SceneManager.sceneLoaded -= OnSceneLoaded;
	    }

	    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	    {
		    if (scene.name == "DevTestScene") 
		    {
			    _audioSource.Stop(); 
			    Destroy(gameObject); 
		    }
	    }
	    
	    
	    #endregion
	
	    #region private
		[SerializeField]private AudioSource _audioSource;
	    #endregion
    }
}
