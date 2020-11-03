using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsMovement : MonoBehaviour
{
    #region PUBLIC VARIABLES
    public int Loops { get; private set; }

    #endregion

    #region PRIVATE VARIABLES

    [SerializeField] private GameData _gameData;

    [SerializeField] private Transform _myTransform;

    #endregion



    private void Awake()
    {
        _myTransform = transform;
    } 

    private void Start()
    {
        StartCoroutine(MoveSphere(_gameData));
    }

    void Update()
    {
        
    }  

    private IEnumerator MoveSphere(GameData data)
    {
        
        if (_myTransform == null || _gameData == null) yield break;

        while (true){

            if (data.Transition > data.TransitionStep)
            {
                data.TransitionStep += Time.deltaTime;

                float step = data.TransitionStep / data.Transition;

                _myTransform.position = Vector3.Lerp(_myTransform.position, data.Values[data.ValueIndex], step);
            }
            else
            {
                data.TransitionStep = 0;

                _myTransform.position = data.Values[data.ValueIndex];

                data.ValueIndex = (data.ValueIndex + 1) % data.Values.Count;

                Loops++;
            }
            yield return null;
        }
        
    } 
}
