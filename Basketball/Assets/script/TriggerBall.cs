using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TriggerBall : MonoBehaviour
    
{
    [SerializeField] float _numderBall;
    [SerializeField] TextMeshProUGUI _textMeshPro;
    private void OnTriggerEnter(Collider other)
    {
        _numderBall += 1;
        _textMeshPro.text = _numderBall.ToString();
    }
}
