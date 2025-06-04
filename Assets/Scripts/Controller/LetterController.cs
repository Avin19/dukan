
using System;
using UnityEngine;
using UnityEngine.UI;

public class LetterController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform _oLetter;
    [SerializeField] private Transform _lLetter;
    [SerializeField] private Transform _cLetter;
    [SerializeField] private Transform _eLetter;
    [SerializeField] private Transform _sLetter;
    [SerializeField] private Button _button;
    private Animator _animator;
    private bool _shopStatus = false;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }
    void OnEnable()
    {
        _button.onClick.AddListener(OnButtonClick);
    }
    void OnDisable()
    {
        _button.onClick.RemoveListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        if (_shopStatus)
        {
            _shopStatus = false;
            _animator.SetTrigger("opening");


        }
        else
        {
            _shopStatus = true;
            _animator.SetTrigger("closing");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
