using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void Quit()
    {
        
        Application.Quit();

        
        Debug.Log("Quit Game (fonctionne uniquement dans le build)");
    }
}