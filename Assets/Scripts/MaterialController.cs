using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialController : MonoBehaviour
{
    public float Bloat = 0;
    MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        print("Kill yourself");
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    { 
        meshRenderer.material.SetFloat("_Bloat",Bloat);
    }
}
