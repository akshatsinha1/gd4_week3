using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float moveSpeed = 15;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
