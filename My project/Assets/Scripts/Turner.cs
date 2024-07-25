using UnityEngine;

public class Turner : MonoBehaviour
{
    [SerializeField] private float _fullTurningTime;
    private Transform _transform;
    private float _startAngle;
    private float _time;

    public void Awake()
    {
        _transform = transform;
        _startAngle = transform.eulerAngles.y;
    }

    public void Update()
    {
        _time += Time.deltaTime;

        Turn(_time);
    }

    private void Turn(float time)
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, (_startAngle + Mathf.Lerp(0, 360, time % _fullTurningTime / _fullTurningTime)) % 360, transform.eulerAngles.z);
    }
}
