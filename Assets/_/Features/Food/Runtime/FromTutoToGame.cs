using UnityEngine;
using UnityEngine.SceneManagement;

namespace Food.Runtime
{
    public class FromTutoToGame : MonoBehaviour
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
		        SceneManager.LoadScene("DevTestScene");
	        }
        }
	
    	#endregion
	
    	#region Utils
	
    	#endregion
	
    	#region private
	
    	#endregion
    }
}
