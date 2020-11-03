using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Data",menuName ="Prototype/Game Data")]
public class GameData: ScriptableObject
{

    [SerializeField] private Vector3 _currentValue;

    [SerializeField] private float _transitionStep;

    [SerializeField] private int _valueIndex;

    [SerializeField] private List<Vector3> _values;

    [SerializeField] private float _transition = 2f;

    public float TransitionStep { get => _transitionStep; set => _transitionStep = value; }
    public Vector3 CurrentValue { get => _currentValue; set => _currentValue = value; }
    public int ValueIndex { get => _valueIndex; set => _valueIndex = value; }
    public List<Vector3> Values { get => _values; private set { } }
    public float Transition { get => _transition; set => _transition = value; }
}