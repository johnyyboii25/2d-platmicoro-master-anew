using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathWall : MonoBehaviour
{
	private void OnCollisionEnter2D(Collision2D collision)
	{
		myplayercontroller player = collision.gameObject.GetComponent<myplayercontroller>();
		if (collision.gameObject.CompareTag("bum"))
		{
			Destroy(collision.gameObject);
		}
		if (collision.gameObject.CompareTag("Player"))
		{
			player.Death();
		}
	}
}
