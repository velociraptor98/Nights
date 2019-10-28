using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rg;
    private bool isGrounded;
    void Start()
    {
         rg = this.GetComponent<Rigidbody2D>();
         isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal");
        rg.velocity = new Vector2(Horizontal, 0.0f);
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
    }
}
