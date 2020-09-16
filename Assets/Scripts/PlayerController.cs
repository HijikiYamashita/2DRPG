using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Vector3 moveX = new Vector3(1, 0, 0);
    Vector3 moveY = new Vector3(0, 1, 0);

    public float speed = 2f;
    Vector3 target;
    Vector3 prevPos;

    public Rigidbody rb;

    void Start()
    {
        target = transform.position;
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    void Update()
    {
        if (transform.position == target)
        {
            SetTargetPosition();
        }
        Move();
    }

    void SetTargetPosition()
    {
        prevPos = target;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            target = transform.position + moveX;
            return;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            target = transform.position - moveX;
            return;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            target = transform.position + moveY;
            return;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            target = transform.position - moveY;
            return;
        }
    }

    void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
