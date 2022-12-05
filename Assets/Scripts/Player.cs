using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //y = (0.5 * -10 * t* t) + (5 * t);
    public float Jump;

    [SerializeField]
    bool isJump = false;
    Rigidbody2D m_rb;
    public Text scoreText;
    public float score;
    // Start is called before the first frame update

    private void Awake()
    {
        m_rb = GetComponent<Rigidbody2D>();
        scoreText = gameObject.AddComponent<Text>();
        scoreText.transform.localPosition = new Vector3(1.0f, 1.0f, 15.0f);

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isJump == true)
            {
                m_rb.AddForce(Vector2.up * Jump);
             
                isJump = false;
            }    
        }
        score += Time.deltaTime;
        scoreText.text = ((int)score).ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Line"))
        {
            if (isJump == false)
            {
                isJump = true;
            }    
        }
        if (collision.gameObject.CompareTag("Cactus"))
        {
            
            Time.timeScale = 0;
        }    
      
    }
}
