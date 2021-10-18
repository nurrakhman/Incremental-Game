﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapText : MonoBehaviour
{
    public float SpawnTime = 0.5f;
    public Text text;

    private float _spawnTime;

    private void OnEnable()
    {
        _spawnTime = SpawnTime;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _spawnTime -= Time.unscaledDeltaTime;
        if(_spawnTime <= 0f)
        {
            gameObject.SetActive(false);
        }
        else
        {
            text.CrossFadeAlpha(0f, 0.5f, false);
            if(text.color.a == 0f)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
