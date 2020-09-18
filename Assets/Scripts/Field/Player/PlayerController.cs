using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Vector3 moveX = new Vector3(1, 0, 0);
    Vector3 moveY = new Vector3(0, 1, 0);

    [SerializeField] private float speed = 5f;
    Vector3 target;

    Rigidbody2D rb;

    [SerializeField] private GameObject eventCol;

    bool rightMove = true;
    bool leftMove = true;
    bool upMove = true;
    bool downMove = true;

    void Start()
    {
        target = transform.position;
        rb = GetComponent<Rigidbody2D>();
        eventCol.gameObject.transform.localPosition = new Vector3(0, 1, 0);
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
        if (Input.GetKey(KeyCode.RightArrow))
        {
            eventCol.gameObject.transform.localPosition = new Vector3(1, 0, 0);
            if (rightMove == true)
            {
                target = transform.position + moveX;
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            eventCol.gameObject.transform.localPosition = new Vector3(-1, 0, 0);
            if (leftMove == true)
            {
                target = transform.position - moveX;
            }
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            eventCol.gameObject.transform.localPosition = new Vector3(0, 1, 0);
            if (upMove == true)
            {
                target = transform.position + moveY;
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            eventCol.gameObject.transform.localPosition = new Vector3(0, -1, 0);
            if (downMove == true)
            {
                target = transform.position - moveY;
            }
        }
    }

    void Move()
    {
        rb.MovePosition(Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime));
    }

    public void colTrigger(int colNum)
    {
        if (colNum == 0)
        {
            rightMove = true;
            leftMove = true;
            upMove = true;
            downMove = true;
        }
        if (colNum == 99)
        {
            rightMove = false;
            leftMove = false;
            upMove = false;
            downMove = false;
        }
        if (colNum == 1)
        {
            rightMove = false;
        }
        if (colNum == 2)
        {
            leftMove = false;
        }
        if (colNum == 3)
        {
            upMove = false;
        }
        if (colNum == 4)
        {
            downMove = false;
        }
    }
}
