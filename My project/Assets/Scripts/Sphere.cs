using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] private float _loopTime;
    [SerializeField] private float _distance;
    private float _time = 0f;
    private float _startPosition;
    private Transform _transform;

    public void Awake()
    {
        _transform = transform;
        _startPosition = _transform.position.z;
    }

    public void Update()
    {
        _time += Time.deltaTime;   
        
        ChangePosition( _time );
    }

    private void ChangePosition(float time)
    {
        float currentLoopTime = time % _loopTime;

        if (currentLoopTime < _loopTime / 2)
        {
            _transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Lerp(_startPosition,_startPosition + _distance, currentLoopTime  / (_loopTime / 2)));
        }
        else
        {
            _transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Lerp(_startPosition + _distance,_startPosition , currentLoopTime % ((_loopTime / 2)) / (_loopTime / 2)));
        }
    }
}
