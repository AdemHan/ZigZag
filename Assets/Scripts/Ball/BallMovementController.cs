using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementController : MonoBehaviour
{
    [SerializeField] private BallDataTransmiter ballDataTransmiter;

    [SerializeField] private float ballMoveSpeed;


    private void Update()
    {
        SetBallMovement();
    }

    //topun hizini burada belirledik
    private void SetBallMovement()
    {
        transform.position += ballDataTransmiter.GetBallDirection() * ballMoveSpeed * Time.deltaTime;
    }



}
