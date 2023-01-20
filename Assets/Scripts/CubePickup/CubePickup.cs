using UnityEngine;

public class CubePickup : MonoBehaviour
{
    // Serialize
    [SerializeField] private string _tagToCompare = "Obstacle";
    [SerializeField] private float _timeBeforeDestroy = 2.0f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals(_tagToCompare))
        {
            CinemachineShake.Instance.ShakeCamera(7.0f, 0.3f);

            transform.parent = null;

            Destroy(gameObject, _timeBeforeDestroy);
        }
    }
}
