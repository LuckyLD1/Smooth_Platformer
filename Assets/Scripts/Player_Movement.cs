using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    Rigidbody2D rb;
    float playerMovementSpeed = 5f;
    float playerJumpForce = 5f;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += new Vector3(playerMovementSpeed*Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position += new Vector3(playerMovementSpeed * Time.deltaTime * -1, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0,playerJumpForce,0),ForceMode2D.Impulse);
        }
    }
}
