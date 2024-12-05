using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animals;
    public float spawnRangeX, spawnRangeZ;
    int randomInt;


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomIndex = Random.Range(0, animals.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-spawnRangeX,spawnRangeX), 0, Random.Range(-spawnRangeZ,spawnRangeZ));
            Instantiate(animals[randomIndex], randomSpawnPosition, Quaternion.Euler(0, Random.Range(0, 360), 0));
        }

        //Get Key Events
        if (Input.GetKeyDown(KeyCode.Space))
            //returns true for one frame when you push down the button 

        if (Input.GetKey(KeyCode.Space))
            //returns true while a button is pushed down 

        if (Input.GetKeyUp(KeyCode.Space))
            //returns true for one frame after the user lets go of a button





                { }
    }
}
