using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tropoline : MonoBehaviour
{
    public float jumpStrengthe=6;
    
        void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = jumpStrengthe;
    }
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = 2f;
    }
    
    
}
