using UnityEngine;

namespace Food.Runtime
{
    public class BadFood : MonoBehaviour
    {
	    #region public
	    

	    #endregion


	    #region unity API

    
	    void Start()
	    {
		    _rigidbody2D = GetComponent<Rigidbody2D>();
		    _eating = FindObjectOfType<EatingScript>();
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
			    if (gameObject.layer == LayerMask.NameToLayer("Steak"))
			    {
				    _eating._score += 200;
			    }
			    if (gameObject.layer == LayerMask.NameToLayer("Pepper"))
			    {
				    _eating._score += 150;
			    }
            
			    if (gameObject.layer == LayerMask.NameToLayer("Candy"))
			    {
				    _eating._score += 100;
			    }
			    _audioSource.Play();
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
	    private EatingScript _eating;
	    [SerializeField]private AudioSource _audioSource;
	    #endregion
    }
}
