using UnityEngine;

public class CollectCubeTextSpawner : MonoBehaviour
{
    // Serialize
    [SerializeField] private GameObject _collectCubetextPrefab;
    [SerializeField] private Transform _parentObjectTransform;

    private void Awake()
    {
        CubeStacker.OnCubeStack.AddListener(SpawnCollectCubetext);
    }

    private void SpawnCollectCubetext()
    {
        GameObject obj = Instantiate(_collectCubetextPrefab, transform.position, Quaternion.identity);
        obj.transform.SetParent(_parentObjectTransform, true);
    }
}
