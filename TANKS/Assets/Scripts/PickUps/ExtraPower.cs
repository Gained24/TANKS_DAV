using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraPower : MonoBehaviour
{
    public float m_NewMinDamage = 50f;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<TankShooting>().masPoder = true;
            other.GetComponent<TankMovement>().ActivarParticula();
            PickUpGenerator.instance.count--;
            Destroy(gameObject);
        }
    }
}
