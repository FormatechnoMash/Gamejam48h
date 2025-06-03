using UnityEngine;
using UnityEngine.SceneManagement;

namespace Food.Runtime
{
    public class FromScoreToWinningScreen : MonoBehaviour
    {
	    #region public


	    #endregion


	    #region unity API

    
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
	
	    #endregion
	
	    #region private
	
	    #endregion
    }
}
