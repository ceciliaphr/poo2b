using UnityEngine;

public class Personagem1 : MonoBehaviour
{
    [SerializeField] private int vidas;
    [SerializeField] private int energia;

    public void setVidas(int vidas)
    {
        this.vidas = vidas;
    }

    public int getVidas()
    {
        return vidas;
    }

    public void setEnergia(int energia)
    {
        this.energia = energia;
    }

    public int getEnergia()
    {
        return energia;
    }
}
