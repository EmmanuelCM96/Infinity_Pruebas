[System.Serializable]

public class PlayerData
{
    public float vidas;
    public int monedas;
    public float[] position_player = new float[3];
    public float[] position_rooms = new float[3];
    
    public PlayerData(CombateP scoress)
    {
        vidas = scoress.vida;
        monedas = scoress.moneda;
        position_player[0] = scoress.transform.position.x;
        position_player[1] = scoress.transform.position.y;
        position_player[2] = scoress.transform.position.z;



    }
}
