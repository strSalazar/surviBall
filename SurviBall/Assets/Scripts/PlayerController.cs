using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocity = 5f;
    private int live = 3;
    public GameObject projectilePrefab;
    public Transform firePoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        Move();
        Shoot();
    }

    void Move()
    {
        float velocidadH = Input.GetAxis("Horizontal");
        float velocidadV = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(velocidadH,0f,velocidadV);
        transform.Translate(movement * velocity * Time.deltaTime);
    }

    void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(projectilePrefab,firePoint.position, firePoint.rotation);
        }
    }

    public void TakeDamage()
    {
        live--;
        Debug.Log("Vida restante: " +live);
        if (live <= 0)
        {
            Debug.Log("GAME OVER");
            Destroy(gameObject);
        }
    } 
}
