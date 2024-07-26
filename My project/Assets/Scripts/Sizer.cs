using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sizer : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Transform _transform;

    public void Awake()
    {
        _transform = transform;
    }

    public void Update()
    {
        ChangeScale(Time.deltaTime);
    }

    private void ChangeScale(float time)
    {
        _transform.localScale += Vector3.one * _speed * time;
    }
}
