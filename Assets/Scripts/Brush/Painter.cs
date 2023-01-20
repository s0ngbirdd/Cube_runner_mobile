using System.Collections;
using UnityEngine;

public class Painter : MonoBehaviour
{
    // Serialize
    [SerializeField] private GameObject _brushPrefab;
    [SerializeField] private Transform _parentObjectTransform;
    [SerializeField] private float _brushSize = 0.1f;
    [SerializeField] private LayerMask _layerMask;
    [SerializeField] private float _timeBetweenPaints = 1.0f;
    [SerializeField] private float _timeBeforeDestroy = 1.0f;

    // Private
    private bool _isCoroutineEnd = true;

    private void Update()
    {
        if (_isCoroutineEnd)
        {
            StartCoroutine(Paint());
            _isCoroutineEnd = false;
        }
    }

    private IEnumerator Paint()
    {
        yield return new WaitForSeconds(_timeBetweenPaints);

        if (Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit, 10.0f, _layerMask))
        {
            GameObject obj = Instantiate(_brushPrefab, hit.point + Vector3.up * 0.1f, Quaternion.identity);
            obj.transform.localScale = Vector3.one * _brushSize;
            obj.transform.SetParent(_parentObjectTransform, true);
            Destroy(obj, _timeBeforeDestroy);
        }

        _isCoroutineEnd = true;
    }
}
