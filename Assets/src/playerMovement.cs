using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
 
    // Update is called once per frame
    void Update()
    {
        float vy = Input.GetAxis("Vertical") * moveSpeed;
        float vx = Input.GetAxis("Horizontal") * moveSpeed;
        if (rb)
            rb.AddForce(new Vector2(vx, vy));
    }
}
