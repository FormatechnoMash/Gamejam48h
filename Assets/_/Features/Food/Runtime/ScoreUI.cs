using TMPro;
using UnityEngine;

namespace Food.Runtime
{
    public class ScoreUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI scoreText;
        private EatingScript eating;

        void Start()
        {
            eating = FindObjectOfType<EatingScript>();
        }

        void Update()
        {
            if (eating != null)
            {
                scoreText.text = "Score: " + eating._score.ToString();
            }
        }
    }

    
}