using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesktopSpawner : MonoBehaviour
{
    [SerializeField] private Transform _position1;
    [SerializeField] private Transform _position2;
    [SerializeField] private Transform _position3;
    [SerializeField] private GameObject _pfBottle;
    [SerializeField] private GameObject _pfToffee;
    void Start()
    {
        GameObject b1 = Instantiate(_pfBottle, _position1);
        GameObject b2 = Instantiate(_pfBottle, _position2);
        GameObject b3 = Instantiate(_pfBottle, _position3);

        for (int i = 0; i <= 5; i++)
        {
            Instantiate(_pfToffee, b1.transform.position, Quaternion.identity, transform);
            Instantiate(_pfToffee, b2.transform.position, Quaternion.identity, transform);
            Instantiate(_pfToffee, b3.transform.position, Quaternion.identity, transform);
        }
    }


}
