using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public KeyCode Up;
    public KeyCode Down;

    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(Up))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * Speed;
        }
        else if (Input.GetKey(Down))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.down * Speed;
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
}
