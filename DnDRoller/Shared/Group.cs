namespace DnDRoller.Shared
{
    public class Group
    {

        public Action<Group> Destroyer;

        public Group(Action<Group> destroyer)
        {
            Destroyer = destroyer;
        }

        public void Destroy()
        {
            Destroyer.Invoke(this);
        }
        private int count = 1;
        public int Count
        {
            get => count;
            set => count = Math.Max(1, value);
        }

        private int nd = 1;
        public int Nd
        {
            get => nd;
            set => nd = Math.Max(1, value);
        }

        public int AC = 10;

        public int HitPlus = 0;
        public int DamagePlus = 0;


        public Dice D = Dice.d8;
        public List<ThrowResult> Results = new List<ThrowResult>();
    }
}
