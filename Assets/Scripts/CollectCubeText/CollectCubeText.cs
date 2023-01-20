using UnityEngine;

public class CollectCubeText : MonoBehaviour
{
    // Serialize
    [SerializeField] private float _objectSpeed = 2.0f;
    [SerializeField] private float _timeBeforeDestroy = 4.0f;

    private void Start()
    {
        Destroy(gameObject, _timeBeforeDestroy);
    }

    private void Update()
    {
        MoveUp();
    }

    private void MoveUp()
    {
        transform.Translate(Vector3.up * _objectSpeed * Time.deltaTime);
    }
}
