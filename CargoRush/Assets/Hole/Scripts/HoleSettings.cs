using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Character/Hole Settings")]
public class HoleSettings : ScriptableObject
{
    [SerializeField] private float[] HoleRadius;
    public float[] _holeRadius { get { return HoleRadius; } }
}
