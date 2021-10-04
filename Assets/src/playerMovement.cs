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

    }

    private void FixedUpdate() 
    {
        float vy = Input.GetAxis("Vertical") * moveSpeed;
        float vx = Input.GetAxis("Horizontal") * moveSpeed;
        if (rb)
            rb.AddForce(new Vector2(vx, vy));

        if (vx != 0 || vy != 0) {
            float angle = Mathf.Atan2(-Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
}
