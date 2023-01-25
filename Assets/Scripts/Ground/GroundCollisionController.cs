using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollisionController : MonoBehaviour
{
    [SerializeField] private GroundDataTransmitter groundDataTransmitter;
    private void OnCollisionExit(Collision other) // exit dedik ��nk� k�p ayr�ld�ktan sonra i�lem ger�ekle�sin istiyoruz.
    {
        if (other.gameObject.CompareTag("Ball")) // y�k�lacak objeye �arpan BALL ise i�lem yap�l�r
        {
            groundDataTransmitter.SetGroundRigidbodyValues();
        }
    }

}
