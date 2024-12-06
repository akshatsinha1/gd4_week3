using UnityEngine;

public class AnimalMovement : MonoBehaviour
{
    public float moveSpeed;
    public float xRange, zRange;

    int animalCount;

    // Update is called once per frame
    void Update()
    {
        

        if (transform.position.x > xRange || transform.position.x < -xRange || transform.position.z > zRange || transform.position.z < -zRange)
        {
            //either of the four contitions need to be true for the code tobe executed
            Destroy(gameObject);
        }
        animalCount = transform.childCount;

        if (transform.position.x > xRange && transform.position.x < -xRange)
        {
            //both the conditions need to be true for this code to execute
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Projectile")
        {
            //Destroy the Projectile
            Destroy(other.gameObject);

            //Update the score
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().score++;

            Debug.Log(GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().score);

            //Destroy ourselves
            Destroy(gameObject);
        }

        if(other.tag == "animal")
        {
            other.transform.parent = transform;
        }

       
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.transform.tag == "Ground")
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }



}
