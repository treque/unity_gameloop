using System;
using UnityEngine;

public class MenuButtonController : MonoBehaviour
{
    public int SelectedIndex;
    [SerializeField] uint NumberOfButtons;
    private bool _keyDown;

    void Update()
    {
        if (Input.GetAxis("Vertical") != 0)
        {
            if (!_keyDown)
            {
                if (Input.GetAxis("Vertical") < 0) ++SelectedIndex;
                else --SelectedIndex;
                SelectedIndex = (int)Math.Min(SelectedIndex, NumberOfButtons - 1);
                SelectedIndex = (int)Math.Max(SelectedIndex, 0);
            }
            _keyDown = true;
        }
        else _keyDown = false;
    }
}
