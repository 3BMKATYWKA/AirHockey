using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject puck;

    void Start()
    {

    }

    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Puck"))
        {
            Instantiate(puck);
        }
    }
}
