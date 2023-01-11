using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowController : MonoBehaviour
{
    [SerializeField] private Transform ballTransform;

    //aradaki mesafeyi tutacak
    private Vector3 offset;

    private Vector3 newPosition;

    [SerializeField][Range(0, 3)] private float lerpValue;
    void Start()
    {
        //kamera ve top arasindaki mesafeyi offset degiskenine atadik
        offset = transform.position - ballTransform.position;
    }

    //kamera takibinde lateupdate daha iyidir
    void LateUpdate()
    {
        SetCameraSmoothFollow();
    }

    //kamera takip fonksiyonu
    private void SetCameraSmoothFollow()
    {
        //kameranýn pozistonu 1. paramatre, 2. paramatre gitmesini istedigimiz yer, 3. paramatre kamera hizi
        newPosition = Vector3.Lerp(transform.position, ballTransform.position + offset, lerpValue * Time.deltaTime);

        //yeni pozisyon artýk ana pozisyonumuz oldu
        transform.position = newPosition;
    }


}
