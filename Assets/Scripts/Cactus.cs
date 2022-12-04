using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactus : MonoBehaviour
{
    public GameObject cactus;
    public float speed;
    // Update is called once per frame

    private void Awake()
    {
        
        CreateCactus();
    }


    public void CreateCactus()
    {
        GameObject Cactus = Instantiate(cactus, transform.position, Quaternion.identity);
        Cactus.GetComponent<MoveCactus>().cactus = this;
    }    
    void Update()
    {
        
    }

}
