using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawnController : MonoBehaviour
{
    public GameObject lastGroundObject;
    [SerializeField] private GameObject groundPrefab;
    private GameObject newGroundObject;
    private int groundDirection;

    void Start()
    {
        GenerateRandomNewGrounds();
    }

    public void GenerateRandomNewGrounds()  // s�rekli zemin yaratma i�lemi
    {
        for (int i = 0; i < 75; i++)
        {
            CreateNewGround();
        }
    }



    private void CreateNewGround()  // zemin yaratma i�lemi
    {
        groundDirection = Random.Range(0, 2);  // burada 0 dahildir ama 2 dahil de�ildir. Yani 0 ve 1 d�ner d�nen say�y� groundDirection'a atar

        if (groundDirection == 0)
        {
            //groundDirection 0'a a�itse sola blok ekler
            newGroundObject = Instantiate(groundPrefab, new Vector3(lastGroundObject.transform.position.x - 1f, lastGroundObject.transform.position.y, lastGroundObject.transform.position.z), Quaternion.identity);
            lastGroundObject = newGroundObject;
        }
        else
        {
            //ileri blok ekler
            newGroundObject = Instantiate(groundPrefab, new Vector3(lastGroundObject.transform.position.x , lastGroundObject.transform.position.y, lastGroundObject.transform.position.z + 1f), Quaternion.identity);
            lastGroundObject = newGroundObject;
        }
    }
}
