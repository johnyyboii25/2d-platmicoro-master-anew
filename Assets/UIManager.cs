using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public string text;
    public Text textfield;
    public Color ColorField;
    public float color;
    public int a;

    // Start is called before the first frame update
    void Start()
    {
        textfield.text = a.ToString();
    }

    // Update is called once per frame
    void Update()
    {
		
	}

	public void IncreaseCount()
	{
		a++;
		textfield.text = a.ToString();
	}

    public void DecreaseCount()
    {
        a--;
		textfield.text = a.ToString();
	}


}
