namespace Maze
{
    public sealed partial class PlayerController : Player
    {
        private void FixedUpdate()
        {
            TimerSpeedGoodBonus();
            TimerSpeedBadBonus();
            Move();
        }

    }
}
