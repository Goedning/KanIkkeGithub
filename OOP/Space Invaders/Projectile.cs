using System.Drawing;
using System.Security;

namespace SpaceInvaders { 
    class Projectile
{
    private int type; 
    private bool vis;
    private int xPos, yPos;

    public Projectile(int t)
    {
        type = t;
    }

    public bool SetVisibility(bool b)
    {
        vis = b;
        return vis;
    }

    public int GetPos(char dim)
    { 
        if (dim == 'x')
            return (xPos);
        else
            return (yPos);
    }

    public void SetPos(int pos, char dim)
    { 
        if (dim == 'x')
            xPos = pos;
        else
            yPos = pos;
    }
}
}
