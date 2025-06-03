using UnityEngine;
using UnityEngine.SceneManagement;

public class FromStartToGame : MonoBehaviour
{
    public void LoadDevTestScene()
    {
        SceneManager.LoadScene("TutoScene");
    }
}