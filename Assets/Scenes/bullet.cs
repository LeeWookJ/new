using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject bulletPrefab; // 총알 프리팹
    public Transform firePoint; // 발사 위치
    public float bulletSpeed = 10f; // 총알 속도

    void Update()
    {
        // 스페이스바를 누르면 총알 발사
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // 총알을 발사 위치에서 생성
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // 총알을 발사 방향으로 이동
        bullet.GetComponent<Rigidbody>().velocity = firePoint.forward * bulletSpeed;
    }
}
