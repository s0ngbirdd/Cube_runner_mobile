using UnityEngine;

public class CubePickupSpawner : MonoBehaviour
{
    // Serialize
    [SerializeField] private GameObject _cubePickupPrefab;
    [SerializeField] private Transform _parentObjectTransform;

    private void Start()
    {
        SpawnCubeAtRandomPosition();
    }

    private void SpawnCubeAtRandomPosition()
    {
        int index = Random.Range(0, 3);

        if (index == 0)
        {
            GameObject obj = Instantiate(_cubePickupPrefab, new Vector3(transform.position.x - 1.5f, transform.position.y, transform.position.z), Quaternion.identity);
            obj.transform.SetParent(_parentObjectTransform, true);
        }
        else if (index == 1)
        {
            GameObject obj = Instantiate(_cubePickupPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            obj.transform.SetParent(_parentObjectTransform, true);
        }
        else if (index == 2)
        {
            GameObject obj = Instantiate(_cubePickupPrefab, new Vector3(transform.position.x + 1.5f, transform.position.y, transform.position.z), Quaternion.identity);
            obj.transform.SetParent(_parentObjectTransform, true);
        }
    }
}
