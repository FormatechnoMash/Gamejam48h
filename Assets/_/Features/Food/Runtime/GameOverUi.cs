using UnityEngine;
using TMPro;
namespace Food.Runtime
{
    public class GameOverUi : MonoBehaviour
    {
	    public TextMeshProUGUI[] scoreTexts;
	    private int maxHighScores = 10;

	    private void Start()
	    {
		    DisplayHighScores();
	    }

	    private void DisplayHighScores()
	    {
		    int[] highScores = LoadHighScores();

		    for (int i = 0; i < scoreTexts.Length; i++)
		    {
			    if (i < highScores.Length)
			    {
				    scoreTexts[i].text = $"#{i + 1}: {highScores[i]}"; 
			    }
			    else
			    {
				    scoreTexts[i].text = $"#{i + 1}: ---";
			    }
		    }
	    }

	    private int[] LoadHighScores()
	    {
		    int[] highScores = new int[maxHighScores];
		    for (int i = 0; i < maxHighScores; i++)
		    {
			    highScores[i] = PlayerPrefs.GetInt("HighScore" + i, 0);
		    }
		    return highScores;
	    }
    }
}
