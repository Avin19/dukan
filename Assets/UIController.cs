using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private Transform _mainScreen;
    [SerializeField] private Transform _logoScreen;
    [SerializeField] private Transform _targetPosition;
    [SerializeField] private float _moveSpeed = 20f;

    void Update()
    {
        if (Vector2.Distance(_logoScreen.position, _targetPosition.position) >= 0.1f)
        {

            MovingPlane();
        }
    }

    private void MovingPlane()
    {
        _mainScreen.Translate(Vector2.up * Time.deltaTime * _moveSpeed / 4);
        _logoScreen.Translate(Vector2.down * Time.deltaTime * _moveSpeed);

    }
}
