using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public static InputController Instance = null;

    public delegate void InputEvent(string userAction);
    public event InputEvent OnUserInput();

    public delegate void InputSpecificEvent();
    public event InputSpecificEvent OnUserPause();

    // Start is called before the first frame update
    void Start()
    {
        if(InputController.Instance == null)
            InputController.Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            this.OnUserPause.Invoke("pause");
            this.OnUserPause.Invoke();
            // if (GameController.Instance)
            //     GameController.Instance.Pause();
        }
    }
}
