using System.Collections;
using System.Collections.Generic;
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
	        _rSlap.SetActive(false);
	        Cursor.lockState = CursorLockMode.Locked;
	        Cursor.visible = true;
	        _spriteRenderer = GetComponent<SpriteRenderer>();
        }

    
        void Update()
        {
	        _countDown+=Time.deltaTime;
	        
		        
	        if (Input.GetMouseButtonDown(0))
	        {
		        if (_countDown >= _animationWaiter)
		        {
		        StartCoroutine(SlapFood());
		        _countDown=0;
		        }
	        }
	        
	        
        }

        private IEnumerator SlapFood()
        {
	        yield return new WaitForSeconds(0.1f);
	        _rSlap.SetActive(true);
	        _spriteRenderer.sprite = _handBack;
	        yield return new WaitForSeconds(0.1f);
	        _rSlap.SetActive(false);
	        _spriteRenderer.sprite = _handFront;
	        
        }
    #endregion
	
    #region Utils
	
    #endregion
	
    #region private

    [SerializeField] private Sprite _handFront;
    [SerializeField] private Sprite _handBack;
    private SpriteRenderer _spriteRenderer;
    private float _countDown;
    private float _animationWaiter=0.25f;
    [SerializeField] private GameObject _rSlap;

    #endregion
    }
}
