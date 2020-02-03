using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScripts : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Speed;
    public float MaxX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        if (x > 0)
        {

            MoveRight();
        }


        if (x < 0)
        {
            MoveLeft();

        }


        if (x == 0)
        {
            stop();

        }

        Vector3 Pos = transform.position;
        Pos.x= Mathf.Clamp(Pos.x, -MaxX, MaxX);
        transform.position = Pos;
    }
    void MoveLeft()
    {

        rb.velocity = new Vector2(-Speed, 0);
    }

    void MoveRight()
    {
        rb.velocity = new Vector2(Speed, 0);
    }

    void stop()
    {
        rb.velocity = Vector2.zero;

    }
   


}
