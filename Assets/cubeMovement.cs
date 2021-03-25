using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMovement : MonoBehaviour
{
    private ThinkGear thinkGear;
    private float scalar = 0;
    private const float SPEED_TO_ADD = 40f;

    private void Start()
    {
        thinkGear = GameObject.Find("ThinkGear").GetComponent<ThinkGear>();
        thinkGear.UpdateConnectedStateEvent += OnConnect;
        thinkGear.UpdateBlinkEvent += OnBlink;
    }

    private void Update()
    {
        transform.Rotate(new Vector3(1f, 1f, 1f) * scalar * Time.deltaTime);
    }

    private void OnConnect()
    {
        thinkGear.StartMonitoring();
        Debug.Log("Sensor on");
    }

    private void OnBlink(int i)
    {
        IncreaseRotate();
    }

    private void IncreaseRotate()
    {
        scalar += SPEED_TO_ADD;
    }
}

