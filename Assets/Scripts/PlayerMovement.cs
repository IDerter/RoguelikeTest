using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private float axeleration;
    public float GetSpeed => speed;

    private Vector2 direction;

    private void Update()
    {
        TakeInput();

        Move();
    }

    private void TakeInput()
    {
        direction = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;
            if (Input.GetKey(KeyCode.Space))
            {
                SpaceMove();
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
            if (Input.GetKey(KeyCode.Space))
            {
                SpaceMove();
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
            if (Input.GetKey(KeyCode.Space))
            {
                SpaceMove();
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
            if (Input.GetKey(KeyCode.Space))
            {
                SpaceMove();
            }
        }

       
    }

    private void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void SpaceMove()
    {
        transform.Translate(direction * axeleration * Time.deltaTime);
    }
}
