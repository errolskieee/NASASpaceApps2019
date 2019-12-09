using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotate : MonoBehaviour
{
    private int speed = 10;

    void Update () {
        transform.Rotate (0, (360f / 5400f) * Time.deltaTime * speed, 0);
    }
}
