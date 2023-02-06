using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Animator animator;

    private bool isMove = false;
    [SerializeField] private float speed = 10.0f;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            return;
        }

        if (Input.GetKey(KeyCode.W))
        {
            isMove = true;
            animator.SetBool("IsMove", true);
        }
        else if(Input.GetKeyUp(KeyCode.W))
        {
            isMove = false;
            animator.SetBool("IsMove", false);

        }

        if (isMove)
        {
            Move();
        }
    }

    private void Move()
    {
        transform.position += transform.forward.normalized * speed * Time.deltaTime;
    }
}
