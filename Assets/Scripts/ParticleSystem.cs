using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Material particleMaterial = new Material(Shader.Find("Particles/Standard Unlit"));

        var go = new GameObject("Particle System");
        go.transform.Rotate(-90, 0, 0); // Rotate so the system emits upwards.
        system = go.AddComponent<ParticleSystem>();
        go.GetComponent<ParticleSystemRenderer>().material = particleMaterial;
        var mainModule = system.main;
        mainModule.startColor = Color.green;
        mainModule.startSize = 0.5f;

        InvokeRepeating("DoEmit", 2.0f, 2.0f);
    }
    public void Emit(ParticleSystem.EmitParams emitParams, int count);
    void DoEmit()
    {
        var emitParams = new ParticleSystem.EmitParams();
        emitParams.startColor = Color.red;
        emitParams.startSize = 0.2f;
        system.Emit(emitParams, 10);
        system.Play(); // Continue normal emissions
    }
}
