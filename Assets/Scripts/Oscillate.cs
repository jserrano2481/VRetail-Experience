using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillate : MonoBehaviour
{
    public float speed = 1f;   // The speed of the oscillation
    public float amplitude = 0.5f;   // The amplitude of the oscillation

    // Update is called once per frame
    void Update()
    {
        float scale = Mathf.Sin(Time.time * speed) * amplitude + 1f;
        transform.localScale = new Vector3(scale, scale, scale);
    }
}



