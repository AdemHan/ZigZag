using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollisionController : MonoBehaviour
{
    [SerializeField] private GroundDataTransmitter groundDataTransmitter;
    private void OnCollisionExit(Collision other) // exit dedik çünkü küp ayrýldýktan sonra iþlem gerçekleþsin istiyoruz.
    {
        if (other.gameObject.CompareTag("Ball")) // yýkýlacak objeye çarpan BALL ise iþlem yapýlýr
        {
            groundDataTransmitter.SetGroundRigidbodyValues();
        }
    }

}
