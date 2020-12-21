using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject _projectile;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private int _numberSecondsBetweenOutliersondsfor;

    private float _time = 0;

    private void Update()
    {
        _time += Time.deltaTime;
        if (_time >= _numberSecondsBetweenOutliersondsfor)
        {
            Instantiate(_projectile, _spawnPoint);
            _time = 0;
        }
    }
}
