using System.Collections;
using System.Collections.Generic;
using UnityEngine;




//list of inputs
public enum InputAction
{
    None
    ,Up
    ,Down
    ,Left
    ,Right
    ,Crouch
    ,Jump
    ,Dash
    ,Block
    ,Attack
    ,HeavyAttack
    ,Special
}



//data stored about each input
public class InputData
{
    public InputAction type;
    public bool isDown;
    public bool isHeld;
    public bool isNew;//if given this frame

    public bool inputLocked;

    public InputData()
    {
        type = InputAction.None;
        isDown = false;
        isHeld = false;
        inputLocked = false;
        isNew = false;
    }
    public InputData(InputAction typ)
    {
        type = typ;
        isDown = false;
        isHeld = false;
        inputLocked = false;
        isNew = false;
    }
    public InputData(InputAction type, bool isDown, bool isHeld, bool isNew, bool inputLocked)
    {
        this.type = type;
        this.isDown = isDown;
        this.isHeld = isHeld;
        this.isNew = isNew;
        this.inputLocked = inputLocked;
    }
}



