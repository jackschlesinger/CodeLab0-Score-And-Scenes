using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PointController : MonoBehaviour
{
	public int pointTotal = 0;
	public Text pointText;
	
	void Update ()
	{
		pointText.text = "Points: " + pointTotal;

		if (pointTotal >= 100)
		{
			SceneManager.LoadScene("Game Over Screen");
		}
	}
}
