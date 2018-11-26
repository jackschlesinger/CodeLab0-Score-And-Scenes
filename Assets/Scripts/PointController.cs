using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PointController : MonoBehaviour
{
	private int pointTotal = 0;
	public Text pointText;
	private int totalScoredBalls = 0;
	
	void Update ()
	{
		pointText.text = "Points: " + pointTotal;

		if (pointTotal >= 100)
		{
			SceneManager.LoadScene("Winning Screen");
		}

		if (totalScoredBalls >= 10)
		{
			SceneManager.LoadScene("Losing Screen");
		}
	}
	
	public void IncreaseScore(int amount)
	{
		pointTotal += amount;
		totalScoredBalls++;
	}
}
