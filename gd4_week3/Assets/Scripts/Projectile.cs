using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float moveSpeed = 15;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if(transform.position.z > 20)
        {
            Destroy(gameObject);
        }
    }
}
