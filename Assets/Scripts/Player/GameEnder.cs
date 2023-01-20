using UnityEngine;
using UnityEngine.Events;

public class GameEnder : MonoBehaviour
{
    // Public
    public static UnityEvent OnGameOver = new UnityEvent();

    // Serialize
    [SerializeField] private string _tagToCompare = "Obstacle";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals(_tagToCompare))
        {
            CinemachineShake.Instance.ShakeCamera(7.0f, 0.3f);

            OnGameOver?.Invoke();
        }
    }
}
