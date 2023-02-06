using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    private Transform trans = null;

    [SerializeField] private Vector3 cameraOffset = new Vector3(-5, 5, 0);
    [SerializeField] private GameObject target = null;
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private float rotSpeed = 10.0f;

    void Start()
    {
        trans = this.transform;
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            FixMode();
        } else {
            if (Input.GetMouseButton(0) || Input.GetMouseButton(1))
            {
                if (Input.GetMouseButton(0))
                {
                    Move();
                }

                if (Input.GetMouseButton(1))
                {
                    Rotate();
                }

            }
        }


        

        if (Input.GetKeyDown(KeyCode.P))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }else if(Input.GetKeyUp(KeyCode.P)) {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        
    }

    private void FixMode() 
    {
        if (target != null)
        {
            trans.position = target.transform.position + cameraOffset.x * target.transform.forward + cameraOffset.y * target.transform.up;
            trans.rotation = target.transform.rotation;
            trans.Rotate(45, 0f, 0f);
        }
    }


    private void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            trans.position = trans.transform.position + trans.forward * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            trans.position = trans.transform.position - trans.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            trans.position = trans.transform.position - trans.right * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            trans.position = trans.transform.position + trans.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            trans.position = trans.transform.position - trans.up * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            trans.position = trans.transform.position + trans.up * speed * Time.deltaTime;
        }
    }

    private void Rotate()
    {
        float mouseX = 0.0f;
        float mouseY = 0.0f;

        mouseX += Input.GetAxis("Mouse X") * rotSpeed;
        mouseY += Input.GetAxis("Mouse Y") * rotSpeed;

        trans.Rotate(0f, mouseX, 0f, Space.World);
        trans.Rotate(-mouseY, 0f, 0f);

    }
}
