using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpGenerator : MonoBehaviour
{
    public GameObject vida;
    public GameObject velocidad;
    public GameObject potencia;
    public GameObject invencible;
    public int xPos;
    public int zPos;
    public int count;
    int i;
    public static PickUpGenerator instance;
    

    private void Awake()
    {
        PickUpGenerator.instance = this;
    }
    void Start()
    {
        StartCoroutine(Drop());
    }

    IEnumerator Drop()
    {
        while (count < 10)
        {
            i = Random.Range(0, 4);

            if(i == 0)
            {
                xPos = Random.Range(-42, 38);
                zPos = Random.Range(-44, 32);
                Instantiate(vida, new Vector3(xPos, 1, zPos), Quaternion.identity);
            }
            if (i == 1)
            {
                xPos = Random.Range(-42, 38);
                zPos = Random.Range(-44, 32);
                Instantiate(velocidad, new Vector3(xPos, 1, zPos), Quaternion.identity);
            }
            if (i == 2)
            {
                xPos = Random.Range(-42, 38);
                zPos = Random.Range(-44, 32);
                Instantiate(potencia, new Vector3(xPos, 1, zPos), Quaternion.identity);
            }
            if (i == 3)
            {
                xPos = Random.Range(-42, 38);
                zPos = Random.Range(-44, 32);
                Instantiate(invencible, new Vector3(xPos, 1, zPos), Quaternion.identity);
            }

            yield return new WaitForSeconds(5.0f);
            count += 1;
        }
    }

}
