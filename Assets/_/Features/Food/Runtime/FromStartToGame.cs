// using UnityEngine;
// using UnityEngine.SceneManagement;
//
// public class FromStartToGame : MonoBehaviour
// {
//     public void LoadDevTestScene()
//     {
//         DontDestroyOnLoad(gameObject);
//         SceneManager.LoadScene("TutoScene");
//         SceneManager.sceneLoaded += OnSceneLoaded;
//     }
//     void OnDestroy()
//     {
//         SceneManager.sceneLoaded -= OnSceneLoaded;
//     }
//     private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
//     {
//         if (scene.name == "DevtestScene") 
//         {
//             _audioSource.Stop(); 
//             Destroy(gameObject); 
//         }
//     }
//
//     [SerializeField]private AudioSource _audioSource;
//}
using UnityEngine;
using UnityEngine.SceneManagement;

public class FromStartToGame : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (_audioSource == null)
        {
            _audioSource = GetComponent<AudioSource>();
        }

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    public void LoadDevTestScene()
    {
        SceneManager.LoadScene("TutoScene");  // Charger la scène "DevtestScene"
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "DevtestScene")
        {
            if (_audioSource != null && _audioSource.isPlaying)
            {
                _audioSource.Stop();
            }
            Destroy(gameObject); // Détruire ce GameObject pour ne plus jouer le son
        }
    }
}

