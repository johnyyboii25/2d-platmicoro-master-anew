using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myplayercontroller : MonoBehaviour
{
    public float Speed;
    public Rigidbody2D Rigidbody;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite1;
    public Sprite newSprite2;
    public int CoinCount;
	// Start is called before the first frame update
	void Start()
    {
        Speed = 3;
        Rigidbody.mass = 0.6f;
    }

    // Update is called once per frame
    void Update()
    {
        float FrameTime = Time.deltaTime;
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y);
        if (Input.GetKey(KeyCode.D))
        {
            float DistanceTravelled = FrameTime * Speed;
            newPosition.x += DistanceTravelled;
        }
        if (Input.GetKey(KeyCode.A))
        {
            float DistanceTravelled = FrameTime * -Speed;
            newPosition.x += DistanceTravelled;
        }

        if (Rigidbody.velocity.y == 0)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                Vector2 force = new Vector2(0, 350);
                Rigidbody.AddForce(force);
            }
            if (Input.GetKey(KeyCode.W))
            {
                ChangeSpriteJump();
            }
            else if (!Input.GetKey(KeyCode.W))
            {
                ChangeSpriteDown();
            }

            
        }
        
        transform.position = newPosition;
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
        Debug.Log("dotek s " +  collision.gameObject.name);
		if (collision.gameObject.tag == "bod")
        {
            Destroy(collision.gameObject);
            CoinCount++;
        }
	}

  

    public void Death()
    {
        GameManager.Instance.ResetLevel(0f);
    }

	void ChangeSpriteJump()
    {
        spriteRenderer.sprite = newSprite1;
    }
    void ChangeSpriteDown()
    { 
        spriteRenderer.sprite = newSprite2;
    }
}
