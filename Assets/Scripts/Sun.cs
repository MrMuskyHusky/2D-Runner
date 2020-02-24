using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public float sunSpeed;
    void Update()
    {
        transform.Rotate(Vector3.right * sunSpeed * Time.deltaTime);
    }
}
