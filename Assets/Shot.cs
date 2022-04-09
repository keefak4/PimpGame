using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    [SerializeField]
    private float Power;
    [SerializeField]
    private GameObject bulletPrefab;
    private Camera mainCamera;
    private void Start()
    {
        mainCamera = Camera.main;
    }
    private void Update()
    {
        float enter;
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        new Plane(-Vector3.right, transform.position).Raycast(ray, out enter);
        Vector3 mousWord = ray.GetPoint(enter);

        Vector3 speed = (mousWord - transform.position) * Power;
        transform.rotation = Quaternion.LookRotation(speed);

        if(Input.GetMouseButtonDown(0))
        {
            Rigidbody2D bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>();
            bullet.AddForce(speed, ForceMode2D.Impulse);
        }
    }
}
