using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeGenerator : MonoBehaviour
{
    public GameObject spike;
    public float MinSpeed;
    public float MaxSpeed;
    public float currentSpeed;
    // Start is called before the first frame update
    private void Awake()
    {
        currentSpeed = MinSpeed;
        generateSpike();
    }

    void generateSpike()
    {
       GameObject SpikeIns =  Instantiate(spike, transform.position, Quaternion.identity);

    }    

    // Update is called once per frame
    void Update()
    {
        
    }
}
