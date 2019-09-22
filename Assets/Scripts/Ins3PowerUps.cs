using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ins3PowerUps : MonoBehaviour
{
    public GameObject PickedupEffect;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup();
        }
    }
    void Pickup()
    {
        Instantiate(PickedupEffect, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
