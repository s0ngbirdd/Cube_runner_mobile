using UnityEngine;

public class TrackGroundSpawner : MonoBehaviour
{
    // Serialize
    [SerializeField] private GameObject _trackGroundStartPrefab;
    [SerializeField] private GameObject _trackGroundPrefab;
    [SerializeField] private Transform _parentObjectTransform;
    [SerializeField] private int _numberToSpawn = 3;

    // Private
    private Vector3 _nextSpawnPoint;

    private void Start()
    {
        SpawnStartTrack();

        for (int i = 0; i < _numberToSpawn; i++)
        {
            SpawnTrack();
        }
    }

    public void SpawnTrack()
    {
        GameObject obj = Instantiate(_trackGroundPrefab, _nextSpawnPoint, Quaternion.identity);
        obj.transform.SetParent(_parentObjectTransform, true);
        _nextSpawnPoint = obj.transform.GetChild(1).transform.position;
    }

    private void SpawnStartTrack()
    {
        GameObject obj = Instantiate(_trackGroundStartPrefab, _nextSpawnPoint, Quaternion.identity);
        obj.transform.SetParent(_parentObjectTransform, true);
        _nextSpawnPoint = obj.transform.GetChild(1).transform.position;
    }
}
