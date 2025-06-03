using TMPro;
using UnityEngine;

namespace Food.Runtime
{
	public class ScoreDisplay : MonoBehaviour
	{
		public TextMeshProUGUI scoreText;

		void Start()
		{
			int currentScore = PlayerPrefs.GetInt("CurrentScore", 0);
			scoreText.text = ": " + currentScore;
		}
	}
}
