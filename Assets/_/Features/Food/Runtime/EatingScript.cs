using System.Collections;
using System.Collections.Generic;
using Codice.Client.Common.EventTracking;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

namespace Food.Runtime
{
    public class EatingScript : MonoBehaviour
    {
    #region public
	
    public int _score;
    #endregion


    #region unity API

    
        void Start()
        {
	      
        _score = 0;
        _healthPoints = 5;
        _spriteRenderer = transform.Find("Sprite").GetComponent<SpriteRenderer>();
		
        }

    
        void Update()
        {
	        
        if(_healthPoints<=0)
        {
	        _spriteRenderer.sprite = _dead;
        }
        
        }

        void OnTriggerEnter2D(Collider2D other)
        {
	        
	        if (other.CompareTag("GoodFood"))
	        {
		        StartCoroutine(EatFood(other.gameObject, true));
	        }
	        else if (other.CompareTag("BadFood" ))
	        {
		        StartCoroutine(EatFood(other.gameObject, false));
	        }
        }
        
        private IEnumerator EatFood(GameObject food, bool isGood)
        {
	          if (isGood)
	          {
            		        if (food.layer == LayerMask.NameToLayer("Apple"))
            		        {
            			        _score += 200;
            		        }
            		        if (food.layer == LayerMask.NameToLayer("Cherries"))
            		        {
            			        _score += 150;
            		        }
            
            		        if (food.layer == LayerMask.NameToLayer("Strawberry"))
            		        {
            			        _score += 100;
            		        }
	          }
	          else
	          {
            		        _score -= 1500;
            		        _healthPoints -= 1;
	          }
	        Destroy(food);
	        _spriteRenderer.sprite = _mouthOpen;
	        yield return new WaitForSeconds(0.1f);

	        _spriteRenderer.sprite = _mouthClose;

	      
	        yield return new WaitForSeconds(0.1f);
	        _spriteRenderer.sprite = _mouthOpen;
	        
        }
    #endregion
	
    
    #region Utils
	
    
    #endregion
	
    
    #region private

    
    [SerializeField] private int _healthPoints=5;
    private float _timeAnimation;
	[SerializeField] private Sprite _mouthOpen;
	[SerializeField]private Sprite _mouthClose;
	[SerializeField]private Sprite _dead;
	[SerializeField]private SpriteRenderer _spriteRenderer;
	private GameObject _object;

	#endregion
    }
}
