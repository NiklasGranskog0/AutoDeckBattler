using UnityEngine;

public class SpawnPoint_test : MonoBehaviour
{
    public GameObject prefabToSpawn;

    public void Start()
    {
        Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
    }
}
