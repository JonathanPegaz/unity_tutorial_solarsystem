using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class PlanetOrbitPreset : ScriptableObject
{
    [Range(-100, 100)]
    [Tooltip("Speed of rotation of the orbit in degrees per second")]
    public float OrbitalSpeed;

    [Range(0, 100000)]
    [Tooltip("Distance of the planet in Units")]
    public float OrbitRadius;
}
