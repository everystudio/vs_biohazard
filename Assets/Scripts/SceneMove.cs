using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		//Debug.Log(collision.name);
		SceneManager.LoadScene("GameScene");
	}
}
