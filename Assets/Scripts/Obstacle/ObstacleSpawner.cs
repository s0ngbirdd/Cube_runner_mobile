using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    // Serialize
    [SerializeField] private List<GameObject> _obstacles;
    [SerializeField] private Transform _parentObjectTransform;

    private void Start()
    {
        SpawnRandomObstacle();
    }

    private void SpawnRandomObstacle()
    {
        int index = Random.Range(0, _obstacles.Count);
        GameObject obj = Instantiate(_obstacles[index], transform.position, Quaternion.identity);
        obj.transform.SetParent(_parentObjectTransform, true);
    }
}
