﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rawimg1 : MonoBehaviour {

    public RawImage rawImage;
    // Use this for initialization
    void Start()
    {
        WebCamDevice[] webc= WebCamTexture.devices;
        WebCamTexture webcamTexture = new WebCamTexture(webc[0].name);

        rawImage.texture = webcamTexture;
        rawImage.material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}