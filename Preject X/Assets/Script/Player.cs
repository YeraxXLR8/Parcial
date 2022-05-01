using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody rb;
    public float speed;
    
    [SerializeField]
    Controller controller;

    public void Update()
    {
        Move();
    }

    public void Move()
    {
        rb.velocity = controller.MoveDir() * speed;
    }
}
