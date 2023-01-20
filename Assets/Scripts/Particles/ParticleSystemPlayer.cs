using UnityEngine;

public class ParticleSystemPlayer : MonoBehaviour
{
    // Serialize
    [SerializeField] private ParticleSystem _warpParticles;
    [SerializeField] private ParticleSystem _stackParticles;

    private void Awake()
    {
        CubeStacker.OnCubeStack.AddListener(PlayStackParticles);
    }

    private void Update()
    {
        PlayWarpParticles();
    }

    private void PlayWarpParticles()
    {
        if (!_warpParticles.isPlaying)
        {
            _warpParticles.Play();
        }
    }

    private void PlayStackParticles()
    {
        _stackParticles.Play();
    }
}
