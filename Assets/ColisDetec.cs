using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisDetec : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Bullet bullet = collision.gameObject.GetComponent<Bullet>();
        if(bullet != null)
        {
            Destroy(gameObject);
        }
    }
}
