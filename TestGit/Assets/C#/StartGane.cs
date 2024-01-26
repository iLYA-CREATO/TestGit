using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGane : MonoBehaviour
{
    public float sing = 1;
    void Update()
    {
        Mathf.Sin(sing);
        transform.position += new Vector3(sing, sing, 0);
    }
}
