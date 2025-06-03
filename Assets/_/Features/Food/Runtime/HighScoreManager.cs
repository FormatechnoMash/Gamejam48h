using UnityEngine;

namespace Food.Runtime
{

	public class HighScoreManager : MonoBehaviour
	{
		public int maxHighScores = 10;

		public void CheckAndAddHighScore(int playerScore)
		{
			int[] highScores = LoadHighScores();

			for (int i = 0; i < maxHighScores; i++)
			{
				if (playerScore > highScores[i])
				{
					for (int j = maxHighScores - 1; j > i; j--)
					{
						highScores[j] = highScores[j - 1];
					}

					highScores[i] = playerScore;
					SaveHighScores(highScores);
					return;
				}
			}
		}

		public int[] LoadHighScores()
		{
			int[] highScores = new int[maxHighScores];
			for (int i = 0; i < maxHighScores; i++)
			{
				highScores[i] = PlayerPrefs.GetInt("HighScore" + i, 0);
			}

			return highScores;
		}

		private void SaveHighScores(int[] highScores)
		{
			for (int i = 0; i < maxHighScores; i++)
			{
				PlayerPrefs.SetInt("HighScore" + i, highScores[i]);
			}

			PlayerPrefs.Save();
		}
	}
}