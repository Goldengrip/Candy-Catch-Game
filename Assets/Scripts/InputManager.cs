using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public static class InputManager
{
    private static Gamecontrols _gamecontrols;

    public static void Init(Player myPlayer)

    {
        _gamecontrols = new Gamecontrols();


        // Connects input action to code
        _gamecontrols.Game.Movement.performed += jeff =>
        {

            myPlayer.SetMovmentDirection(jeff.ReadValue<Vector2>());
        };
        }
    public static void SetGameControls()
    {
            _gamecontrols.Game.Enable();
            _gamecontrols.UI.Disable();
    }
    public static void SetUIControls()
    {
            _gamecontrols.Game.Disable();
            _gamecontrols.UI.Enable();
    

    }

}

