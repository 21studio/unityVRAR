﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLookAt : MonoBehaviour
{
    private CharacterController cc;
    private Transform camTr;
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        camTr = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        cc.SimpleMove(camTr.forward * speed);
    }
}
