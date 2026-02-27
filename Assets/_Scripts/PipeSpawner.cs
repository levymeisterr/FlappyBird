using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    private float spawnRate = 4f;
    private float lastPipeY = 1;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        if (pipePrefab == null)
        {
            Debug.LogError("Pipe prefab is not assigned in the inspector.");
            return;
        }
        StartCoroutine(SpawnPipeRoutine());
    }

    private void SpawnPipe()
    {
        GameObject newPipe;
        transform.position = new Vector3(transform.position.x,Random.Range(-2f, 2f), transform.position.z);
        newPipe = Instantiate(pipePrefab, transform.position, Quaternion.identity);
        lastPipeY = newPipe.transform.position.y;
        Debug.Log("Spawned pipe at y: " + lastPipeY);
    }

    IEnumerator SpawnPipeRoutine()
    {
        while (true)
        {
            SpawnPipe();
            yield return new WaitForSeconds(spawnRate);
        }
    }
}
