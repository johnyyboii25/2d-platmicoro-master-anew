using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript2 : MonoBehaviour
{
	public Text myText;

	// Update is called once per frame
	void Update()
	{
		myText.text = $"Lives:  + {GameManager.Instance.lives}";
	}
}
