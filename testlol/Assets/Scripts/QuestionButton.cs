﻿using UnityEngine;
using System.Collections;

public class QuestionButton : MonoBehaviour
{
    AudioSource audio;
	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void PlaySOund()
    {
        audio.Play();
    }
}
