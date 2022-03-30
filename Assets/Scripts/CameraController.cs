using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] GameObject driver;

    void LateUpdate()
    {
        transform.position = driver.transform.position + new Vector3(0, 0, -10);
    }
}
