using UnityEngine;

namespace Food.Runtime
{
    public class EatingScript : MonoBehaviour
    {
    #region public
	

    #endregion


    #region unity API

    
        void Start()
        {
        _score = 0;
        _healthPoints = 5;
        
        }

    
        void Update()
        {
	        
        if(_healthPoints<=0)
        {
	        gameObject.SetActive(false);
        }
        
        }

        void OnTriggerEnter2D(Collider2D other)
        {
	        if (other.CompareTag("GoodFood"))
	        {
		        _score += 100;
		        Destroy(other.gameObject);
	        }

	        if (other.CompareTag("BadFood"))
	        {
		        _healthPoints -= 1;
		        Destroy(other.gameObject);
	        }
        }
    #endregion
	
    
    #region Utils
	
    
    #endregion
	
    
    #region private
	private int _score;
    [SerializeField] private int _healthPoints;
    

    #endregion
    }
}
