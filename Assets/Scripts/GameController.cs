using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance = null;

    [Range(-2000, 2000)]
    public float Speed = 100;

    private float _previousSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        if(Instance == null)
            Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause() {
        if(this.Speed != 0) {
            this._previousSpeed = this.Speed;
            this.Speed = 0;
        } else {
            if(this._previousSpeed == 0)
                this.Speed = 1;
            else
                this.Speed = this._previousSpeed;
        }
    }
}
