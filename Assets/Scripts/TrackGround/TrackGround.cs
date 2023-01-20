using UnityEngine;

public class TrackGround : MonoBehaviour
{
    // Serialize
    [SerializeField] private string _tagToCompare = "Player";
    [SerializeField] private float _timeBeforeDestroy = 2.0f;

    // Private
    private TrackGroundSpawner _trackGroundSpawner;
    private bool _isTrackSpawned;

    private void Start()
    {
        _trackGroundSpawner = FindObjectOfType<TrackGroundSpawner>();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals(_tagToCompare) && !_isTrackSpawned)
        {
            _trackGroundSpawner.SpawnTrack();
            Destroy(gameObject, _timeBeforeDestroy);
            _isTrackSpawned = true;
        }
    }
}
