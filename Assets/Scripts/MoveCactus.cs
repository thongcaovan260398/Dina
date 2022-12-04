using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCactus : MonoBehaviour
{

    public Cactus cactus;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * cactus.currentSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NextLine"))
        {
            cactus.CreateCactus();
        }    
    }
}
