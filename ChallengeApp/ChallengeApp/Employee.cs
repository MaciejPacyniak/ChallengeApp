namespace ChallengeApp
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public List<int> Points = new List<int>();

        public void AddPoint(int point)
        {
            Points.Add(point);
        }

        public int Sum()
        {
            return Points.Sum();
        }
    }
}