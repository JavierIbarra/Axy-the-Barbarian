using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public void update(Player player)
    {
        InputMov(player);
    }

    void InputMov(Player player)
    {
        player.Movimiento = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"),0);
        player.Movimiento = player.Movimiento.normalized;
    }
}
