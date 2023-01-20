using UnityEngine;
using UnityEngine.Events;

public class ObjectMover : MonoBehaviour
{
    // Public
    public static UnityEvent OnEnableMoveSpeed = new UnityEvent();

    // Serialize
    [SerializeField] private float _objectSpeed = 10.0f;
    [SerializeField] private Joystick _joystick;

    // Private
    private bool _isMoveSpeedEnabled;

    private void Awake()
    {
        GameEnder.OnGameOver.AddListener(DisableMoveSpeed);
    }

    private void Start()
    {
        DisableMoveSpeed();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !_isMoveSpeedEnabled)
        {
            EnableMoveSpeed();
        }

        GetMobileMoveInput();
    }

    private void GetMobileMoveInput()
    {
        Vector3 forwardMove = transform.forward * _objectSpeed * Time.deltaTime;
        Vector3 horizontalMove = Vector3.zero;

        if (transform.position.x >= 1.99f)
        {
            horizontalMove = transform.right * -1 * _objectSpeed * Time.deltaTime;
        }
        else if (transform.position.x <= -1.99f)
        {
            horizontalMove = transform.right * 1 * _objectSpeed * Time.deltaTime;
        }
        else
        {
            horizontalMove = transform.right * _joystick.Horizontal * _objectSpeed * Time.deltaTime;
        }

        transform.Translate(forwardMove + horizontalMove);
    }

    private void EnableMoveSpeed()
    {
        _objectSpeed = 10.0f;
        _isMoveSpeedEnabled = true;
        OnEnableMoveSpeed?.Invoke();
    }

    private void DisableMoveSpeed()
    {
        _objectSpeed = 0.0f;
    }
}
