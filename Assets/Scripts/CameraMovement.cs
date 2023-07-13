using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float camSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(camSpeed * Time.deltaTime, 0, 0);
    }
}
