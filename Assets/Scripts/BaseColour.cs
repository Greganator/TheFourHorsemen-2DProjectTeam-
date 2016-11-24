﻿using UnityEngine;
using System.Collections;

public class BaseColour : MonoBehaviour {

    public float offsetY = 0f;
    public Transform darknessplane;
    public string lightSource;
    public Transform target;

    public void start()
    {
    }

    public void GreyScale(float offsetY)
    {
        Vector3 origin = new Vector3(0, offsetY, 0);
        origin += target.position;

        darknessplane.GetComponent<Renderer>().material.SetVector(lightSource, origin);
    }
}
