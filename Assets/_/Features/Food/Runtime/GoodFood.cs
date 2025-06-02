using System;
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
		        _rigidbody2D.AddForce(Vector2.left * 1000f);
	        }
        }

        #endregion
	
    	#region Utils
	
    	#endregion
	
    	#region private
		private Rigidbody2D _rigidbody2D;
		private int _timeToDispawn=3;
		private float _countDown;

		#endregion
    }
}
