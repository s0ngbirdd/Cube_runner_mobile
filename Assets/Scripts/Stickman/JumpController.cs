using UnityEngine;

public class JumpController : MonoBehaviour
{
    // Private
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();

        CubeStacker.OnCubeStack.AddListener(PlayJumpAnimation);
    }

    private void PlayJumpAnimation()
    {
        _animator.Play("Jumping");
    }
}
