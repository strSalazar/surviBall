using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 20f;
    int damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity=transform.forward * bulletSpeed;
        Destroy(gameObject,3f);
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<Enemy>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }

}
