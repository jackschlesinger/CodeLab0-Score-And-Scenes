using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointHoleController : MonoBehaviour
{
	public PointController pointController;
	public int myValue;
	
	private void OnTriggerEnter2D(Collider2D other)
	{
		pointController.IncreaseScore(myValue);
	}
}
