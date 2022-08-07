using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinglePlayerBoard : Board
{

    private Vector2Int intCoords;
    public override void SelectedPieceMoved(Vector2 coords)
    {
        GetIntCoords(coords);
        OnSelectedPieceMoved(intCoords);
    }

    public override void SetSelectedPiece(Vector2 coords)
    {
        GetIntCoords(coords);
        OnSetSelectedPiece(intCoords);
    }
    
    private void GetIntCoords(Vector2 coords)
    {
        intCoords = new Vector2Int(Mathf.RoundToInt(coords.x), Mathf.RoundToInt(coords.y));
    }
}
