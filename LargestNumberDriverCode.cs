class __Driver__ {
  static void Main(string[] args) {
  using (StreamWriter file = new StreamWriter("user.out")) {
    file.AutoFlush = true;
    string line;
    while ((line = Console.ReadLine()) != null) {
      string[] input = line.Split();
      //int x = int.Parse(input[0]);
      int[] num = input.Select(y => int.Parse(y))
                       .ToArray();
      file.WriteLine(__Serializer__.serialize(new Solution().LargestNumber(num)));
    }
  }
  }
}
