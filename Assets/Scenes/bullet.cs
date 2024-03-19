using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject bulletPrefab; // �Ѿ� ������
    public Transform firePoint; // �߻� ��ġ
    public float bulletSpeed = 10f; // �Ѿ� �ӵ�

    void Update()
    {
        // �����̽��ٸ� ������ �Ѿ� �߻�
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // �Ѿ��� �߻� ��ġ���� ����
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // �Ѿ��� �߻� �������� �̵�
        bullet.GetComponent<Rigidbody>().velocity = firePoint.forward * bulletSpeed;
    }
}
