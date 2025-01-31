using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TriggerBall : MonoBehaviour
{

    [SerializeField] int _numderBall;
    [SerializeField] TextMeshProUGUI _textMeshPro;
    [SerializeField] GameObject _textNO;
    [SerializeField] GameObject _textYES;
    [SerializeField] GameObject _textNO3;
    [SerializeField] GameObject _textYES3;
    [SerializeField] GameObject _ice;
    private void OnTriggerEnter(Collider other)
    {
        _numderBall += 1;
        _textMeshPro.text = _numderBall.ToString();
        Instantiate(_ice, transform.position, transform.rotation);
        if (_numderBall == 1)
        {
            _textNO.SetActive(false);
            _textYES.SetActive(true);
        }

        if (_numderBall == 3)
        {
            _textNO3.SetActive(false);
            _textYES3.SetActive(true);
        }
    }
}
