using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public Text myText;

    // Update is called once per frame
    void Update()
    {
		myText.text = $"Score:  + {(GameManager.Instance.coins + GameManager.Instance.crushedShrooms) * 100}";
	}
}
