using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed = 2.0f;
    private Transform _playerTransform;

    private void Awake()
    {
        enabled = false;
    }

    public void EnableChase(Transform player)
    {
        enabled = true;
        _playerTransform = player;
    }

    public void DisableChase()
    {
        enabled = false;
        _playerTransform = null;
    }

    private void Update()
    {
        if (_playerTransform == null) return;

        transform.position = Vector3.MoveTowards(
            transform.position,
            _playerTransform.position,
            _speed * Time.deltaTime
        );
    }
}
