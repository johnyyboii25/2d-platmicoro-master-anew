using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
	public float Speed;
	public Rigidbody2D Rigidbody;
	public Sprite flatEnemy;
	public int crushedShrooms;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		float FrameTime = Time.deltaTime;
		Vector3 newPosition = new Vector3(transform.position.x, transform.position.y);
		float DistanceTravelled = FrameTime * -Speed;
		newPosition.x += DistanceTravelled;
		transform.position = newPosition;

		
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			myplayercontroller player = collision.gameObject.GetComponent<myplayercontroller>();
			if (collision.transform.DotTest(transform, Vector2.down))
			{
				Flatten();
			}
			else
			{
				player.Death();
			}
		}
	}
	private void Flatten()
	{
		GetComponent<SpriteRenderer>().sprite = flatEnemy;
		Destroy(gameObject, 0.25f);
		GameManager.Instance.crushedShrooms++;
	}

}
