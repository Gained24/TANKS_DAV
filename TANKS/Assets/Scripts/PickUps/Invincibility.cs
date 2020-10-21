using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincibility : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<TankHealth>().m_Invencible=true;
            other.GetComponent<TankMovement>().ActivarParticula();
            PickUpGenerator.instance.count--;
            Destroy(gameObject);
        }
    }
}
