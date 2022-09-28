using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public delegate void SpeedEvent(float newSpeed);
    public event SpeedEvent OnSpeedChanged;

    private static GameController _instance;
    public static GameController Instance
    {
        get {
            if(_instance == null)
                _instance = FindObjectOfType<GameController>();
            return _instance;
        }
        private set {
            _instance = value;
        }
    }

    private float _speed = 1;
    public float Speed { get => _speed; 
    set 
    {
        if(this.OnSpeedChanged != null) {
            this.OnSpeedChanged.Invoke(value);
        }
        this._speed = value;
    }
    }

    private float _previousSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        if(Instance == null)
            Instance = this;
        
        if(InputController.Instance)
            InputController.Instance.OnUserPause += Pause;
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
