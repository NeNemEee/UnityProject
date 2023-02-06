using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSceneRotate : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;
    void Update()
    {
         this.transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
