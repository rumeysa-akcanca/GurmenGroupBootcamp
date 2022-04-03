// See https://aka.ms/new-console-template for more information
public class Goalkeeper : Player, IKeepTheBall
{
    public override void KickTheBall()
    {
        // Ball was kicked by Goalkeeper !
    }

    public void KeepTheBall()
    {
        // Ball was kept by Goalkeeper !
    }
}