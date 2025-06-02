using UnityEngine;

namespace Food.Runtime
{
    public class MouseHandler : MonoBehaviour
    {
    #region public


    #endregion


    #region unity API

    
        void Start()
        {
	        Cursor.lockState = CursorLockMode.Locked;
	        Cursor.visible = true;
        }

    
        void Update()
        {
        
        }
	
    #endregion
	
    #region Utils
	
    #endregion
	
    #region private
	
    #endregion
    }
}
