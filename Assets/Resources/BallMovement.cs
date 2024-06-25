using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-1f, 1f);
        float y = Random.Range(-1f, 1f);
        Vector2 direction = new(x, y);

        GetComponent<Rigidbody2D>().velocity = direction.normalized * Speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
