using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 5f; // �̵� �ӵ�

    void Update()
    {
        // Ű���� �Է� �ޱ�
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // �̵� ���� ����
        Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0).normalized;

        // ������Ʈ �̵�
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}
