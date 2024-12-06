using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animals;
    public float spawnRangeX, spawnRangeZ;
    public float initialSpawnDelay, spawnDelay;

    private void Start()
    {
        InvokeRepeating("spawnRandomAnimals", initialSpawnDelay, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        


        //Get Key Events
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //spawnRandomAnimals();
        }
            //returns true for one frame when you push down the button 

        if (Input.GetKey(KeyCode.Space))
            //returns true while a button is pushed down 

        if (Input.GetKeyUp(KeyCode.Space))
            //returns true for one frame after the user lets go of a button

                { }
    }

    private void spawnRandomAnimals()
    {
        int randomIndex = Random.Range(0, animals.Length);
        
        Instantiate(animals[randomIndex], randomSpawnPos(), Quaternion.Euler(0, Random.Range(0, 360), 0));
    }

    private Vector3 randomSpawnPos()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 22, Random.Range(-spawnRangeZ, spawnRangeZ));

        return randomSpawnPosition;
    }
}
