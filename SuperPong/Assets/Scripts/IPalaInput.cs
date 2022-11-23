using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPalaInput
{
    float Vertical { get; }

    void GetInput();
}