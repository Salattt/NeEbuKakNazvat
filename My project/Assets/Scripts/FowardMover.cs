using UnityEngine;

public class FowardMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Transform _transform;

    public void Awake()
    {
        _transform = transform;
    }

    public void Update()
    {
        Move();
    }

    private void Move()
    {
        _transform.position += _transform.forward.normalized * _speed * Time.deltaTime;
    }
}
