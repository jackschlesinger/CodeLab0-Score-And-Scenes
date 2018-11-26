using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropZoneController : MonoBehaviour {

	GameObject ballPrefab;

	void Start()
	{
		ballPrefab = Resources.Load("Prefabs/DropBall") as GameObject;
	}
	
	void OnMouseDown()
	{
		Debug.Log("Clicked.");

		var ball = Instantiate(ballPrefab);
		var ballPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		ballPosition.z = 0.0f;
		ball.transform.position = ballPosition;
	}
}
