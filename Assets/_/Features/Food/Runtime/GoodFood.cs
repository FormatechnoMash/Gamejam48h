
using UnityEngine;

namespace Food.Runtime
{
    public class GoodFood : MonoBehaviour
    {
    #region public

    #endregion


    #region unity API

    
        void Start()
        {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _eating = FindObjectOfType<EatingScript>();
        }

    
        void Update()
        {
        _countDown += Time.deltaTime;

        if (_countDown >= _timeToDispawn)
        {
	     Destroy(this.gameObject);   
	     _countDown = 0;
        }
        
        }

        private void OnMouseOver()
        {
	        if (Input.GetMouseButtonDown(0))
	        { 
		        if (gameObject.layer == LayerMask.NameToLayer("Apple"))
		        {
			        _eating._score -= 200;
		        }
		        if (gameObject.layer == LayerMask.NameToLayer("Cherries"))
		        {
			        _eating._score -= 150;
		        }
            
		        if (gameObject.layer == LayerMask.NameToLayer("Strawberry"))
		        {
			        _eating._score -= 100;
		        }
		        _audioSource.Play();
		        _rigidbody2D.AddForce(Vector2.left * 1000f);
		        if (_eating._score < 0)
		        {																
			        _eating._score = 0;
		        }
	        }
        }

        #endregion
	
    	#region Utils
	
    	#endregion
	
    	#region private
		private Rigidbody2D _rigidbody2D;
		private int _timeToDispawn=3;
		private float _countDown;
		private EatingScript _eating;
		[SerializeField]private AudioSource _audioSource;
		#endregion
    }
}
