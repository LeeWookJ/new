using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 5f; // 이동 속도

    void Update()
    {
        // 키보드 입력 받기
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // 이동 방향 설정
        Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0).normalized;

        // 오브젝트 이동
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}
