using UnityEngine;
using UnityEngine.Serialization;

namespace Food.Runtime
{
    public class FoodSpawn : MonoBehaviour
    {
    #region public
    
	public GameObject[] m_foodPrefab;
	public int[] m_changingLevels;
    #endregion


    #region unity API

    
        void Start()
        {
        
        }
	
    
        void Update()
        {
	        _difficultyTimer += Time.deltaTime;
	        _countDown+=Time.deltaTime;
	        if (_difficultyLevel == 1)
	        {
		        
                        if (_countDown >= _timeBetweenSpawnsLevelOne)
                        {
                	        _randomNumber=Random.Range(0,2);
                	        Instantiate(m_foodPrefab[_randomNumber], transform.position, Quaternion.identity);
                	        _countDown=0;
                        }
                      
      
			}

	        if (_difficultyLevel == 2)
	        {
		        
		        if (_countDown >= _timeBetweenSpawnsLevelTwo)
		        {
			        _randomNumber=Random.Range(0,2);
			        Instantiate(m_foodPrefab[_randomNumber], transform.position, Quaternion.identity);
			        _countDown=0;
		        }
		       
		        
	        }
	        if (_difficultyLevel == 3)
	        {
		        if (_countDown >= _randomTimeSpawn)
		        {
			        _randomTimeSpawn=Random.Range(_timeBetweenSpawnsLevelThreeMin,_timeBetweenSpawnsLevelThreeMax);
			        _randomNumber=Random.Range(0,2);
			        Instantiate(m_foodPrefab[_randomNumber], transform.position, Quaternion.identity);
			        _countDown=0;
		        }
		        
		        
	        }
	        if (_difficultyLevel == 4)
	        {
		        if (_countDown >= _randomTimeSpawn)
		        {
			        _randomTimeSpawn=Random.Range(_timeBetweenSpawnsLevelFourMin,_timeBetweenSpawnsLevelFourMax);
			        _randomNumber=Random.Range(0,2);
			        
			        Instantiate(m_foodPrefab[_randomNumber], transform.position, Quaternion.identity);
			        _countDown=0;
		        }
		        
	        }

	        if (_difficultyLevel == 5)
	        {
		        
	        }
	        
	        if (_difficultyTimer >= 20)
	        {
		        
		        _difficultyLevel=m_changingLevels[i];
		        i++;
		        _difficultyTimer=0;
	        }
	        
			
        }
	
    #endregion
	
    
    #region Utils
	
    #endregion
	
    
    #region private
	[FormerlySerializedAs("_timeBetweenSpawns")] [SerializeField] private float _timeBetweenSpawnsLevelOne;
	[SerializeField] private float _timeBetweenSpawnsLevelTwo;
	[SerializeField] private float _timeBetweenSpawnsLevelThreeMin= 1.25f;
	[FormerlySerializedAs("_timeBetweenSpawnsLevelThree")] [SerializeField] private float _timeBetweenSpawnsLevelThreeMax= 1.5f;
	[SerializeField] private float _timeBetweenSpawnsLevelFourMin;
	[FormerlySerializedAs("_timeBetweenSpawnsLevelFour")] [SerializeField] private float _timeBetweenSpawnsLevelFourMax;
	private float _randomTimeSpawn=1.5f;
	private float _countDown;
	private int _randomNumber;
	private int _timeBeforeDispawn;
	private int _difficultyLevel=1;
	private float _difficultyTimer;
	private int i=0;
	
	#endregion
    }
}
