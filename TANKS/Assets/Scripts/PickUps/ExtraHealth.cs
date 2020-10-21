using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraHealth : MonoBehaviour
{
    public float vidaExtra = 100;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<TankHealth>().SumarVida(vidaExtra);
            other.GetComponent<TankMovement>().ActivarParticula2();
            PickUpGenerator.instance.count--;
            Destroy(gameObject);
        }
    }
}
