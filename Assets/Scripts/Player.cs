using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //y = (0.5 * -10 * t* t) + (5 * t);
    public float JumpForce;

    [SerializeField]
    bool isGrounded = false;
    Rigidbody2D m_rb;
    // Start is called before the first frame update

    private void Awake()
    {
        m_rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded == true)
            {
                m_rb.AddForce(Vector2.up * JumpForce);
                isGrounded = false;
            }    
        }    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            if (isGrounded == false)
            {
                isGrounded = true;
            }    
        }    
    }
}
