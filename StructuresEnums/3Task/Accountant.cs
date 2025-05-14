namespace _3Task
{
    internal class Accountant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            int requiredHours = (int)worker;

            if (hours > requiredHours)
            {
                return true;
            }
            else return false;
        }
    }
}
