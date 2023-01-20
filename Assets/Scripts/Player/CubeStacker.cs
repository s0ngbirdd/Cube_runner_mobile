using UnityEngine;
using UnityEngine.Events;

public class CubeStacker : MonoBehaviour
{
    // Public
    public static UnityEvent OnCubeStack = new UnityEvent();

    // Serialize
    [SerializeField] private string _tagToCompare = "Cube";
    [SerializeField] private Transform _parentObjectTransform;
    [SerializeField] private Transform _upperCubeTransform;
    [SerializeField] private Transform _nextStackPoint;

    // Private
    private int _cubeCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals(_tagToCompare))
        {
            OnCubeStack?.Invoke();

            GameObject obj = other.gameObject;
            obj.name = "CubeObject" + _cubeCount++;
            obj.tag = "Untagged";
            obj.transform.SetParent(_parentObjectTransform, true);
            obj.transform.position = _nextStackPoint.position;
            _nextStackPoint = _upperCubeTransform.transform;

            _upperCubeTransform.position = _upperCubeTransform.GetChild(1).transform.position;
        }
    }
}
