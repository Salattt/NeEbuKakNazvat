using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sizer : MonoBehaviour
{
    [SerializeField] private float _loopTime;
    [SerializeField] private float _maxScale;
    private float _time = 0f;
    private float _startScale;
    private Transform _transform;

    public void Awake()
    {
        _transform = transform;
        _startScale = _transform.localScale.x;
    }

    public void Update()
    {
        _time += Time.deltaTime;

        ChangeScale(_time);
    }

    private void ChangeScale(float time)
    {
        float currentLoopTime = time % _loopTime;
        float newScale;

        if (currentLoopTime < _loopTime / 2)
        {
            newScale = Mathf.Lerp(_startScale, _maxScale, currentLoopTime / (_loopTime / 2));
        }
        else
        {
            newScale = Mathf.Lerp(_maxScale, _startScale, currentLoopTime % ((_loopTime / 2)) / (_loopTime / 2));
        }

        _transform.localScale = new Vector3(newScale, newScale, newScale);
    }
}
