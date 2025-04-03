using UnityEngine;

[CreateAssetMenu]
public class IntSO : ScriptableObject
{
    [SerializeField]
    public int _value;
    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }



}
