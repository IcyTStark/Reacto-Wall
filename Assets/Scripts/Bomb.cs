using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] GameObject bomb;
    
    [SerializeField]public float explosionForce = 10f;
    [SerializeField]public float explosionRadius = 5f;
    [SerializeField] float upForce = 1f;


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Ball")
        {
            DetonateBomb();
            Destroy(gameObject, 2f);
        }
    }
    public void DetonateBomb()
    {
        Vector3 explosionPosition = bomb.transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPosition, explosionRadius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            { 
                rb.AddExplosionForce(explosionForce, explosionPosition, explosionRadius, upForce, ForceMode.Impulse);
                Destroy(gameObject);
            }
        }
    }
}
