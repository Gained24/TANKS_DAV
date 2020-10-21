using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraSpeed : MonoBehaviour
{
    public float velocidadExtra = 20;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<TankMovement>().SumarVelocidad(velocidadExtra);
            other.GetComponent<TankMovement>().ActivarParticula();
            PickUpGenerator.instance.count--;
            Destroy(gameObject);
        }
    }
}
