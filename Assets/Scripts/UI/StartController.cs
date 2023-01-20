using UnityEngine;

public class StartController : MonoBehaviour
{
    // Serialize
    [SerializeField] private GameObject _startUI;

    private void Awake()
    {
        ObjectMover.OnEnableMoveSpeed.AddListener(HideStartUI);
    }

    private void HideStartUI()
    {
        _startUI.SetActive(false);
    }
}
